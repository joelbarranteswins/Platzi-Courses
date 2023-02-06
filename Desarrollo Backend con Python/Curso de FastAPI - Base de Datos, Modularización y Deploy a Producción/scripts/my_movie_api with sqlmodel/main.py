from typing import Optional
from fastapi.responses import HTMLResponse, JSONResponse
import fastapi
from fastapi import Body, Depends, HTTPException, Path, Query, status, Request
from pydantic import BaseModel, Field
from typing import List
from jwt_manager import create_token, validate_token
from fastapi.security import HTTPBearer
from config.database import engine
from models.movie import Movie as MovieModel
from fastapi.encoders import jsonable_encoder
from sqlmodel import SQLModel, Session, select

app = fastapi.FastAPI(
    title="My app with FastAPI",
    description="Aprove using api",
    version="0.1.0",
    terms_of_service="http://example.com/terms/",
    contact={
        "name": "joel barrantes",
        "url": "https://github.com/joelbarranteswins/Platzi-Courses",
        "email": "joelbarrantespalacios@gmail.com"
    },
    license_info={
        "name": "Apache 2.0",
        "url": "https://www.apache.org/licenses/LICENSE-2.0.html"}
)

SQLModel.metadata.create_all(engine, checkfirst=True)


class User(BaseModel):
    email: str = Field(min_length=5, max_length=100,
                       title="Email",
                       description="This is the email")
    password: str = Field(min_length=5, max_length=15,
                          title="Password",
                          description="This is the password")

    class Config:
        schema_extra = {
            "example": {
                "email": "admin@gmail.com",
                "password": "password"
            }
        }


class JWTBearer(HTTPBearer):
    async def __call__(self, request: Request):
        auth = await super().__call__(request)
        data = validate_token(auth.credentials)
        if data['email'] != "admin@gmail.com":
            return HTTPException(status_code=403, detail="Credenciales no son validas")


class Movie(BaseModel):
    id: Optional[int] = None
    title: str = Field(min_length=5, max_length=15,
                       title="Movie ID", description="This is the movie")
    overview: str = Field(
        min_length=15, max_length=50, title="Movie Overview",
        description="This is the movie overview")
    year: int = Field(ge=1900, le=2021)
    rating: float = Field(ge=0.0, le=10.0)
    category: str = Field(min_length=5, max_length=15)

    class Config:
        schema_extra = {
            "example": {
                "id": 1,
                "title": "Mi pelicula",
                "overview": "Descripcion de mi pelicula ...",
                "year": 2000,
                "rating": 5.0,
                "category": "Acción"
            }
        }


movies = [
    {
        'id': 1,
        'title': 'Avatar',
        'overview': "En un exuberante planeta llamado Pandora viven los Na'vi, seres que ...",
        'year': '2009',
        'rating': 7.8,
        'category': 'Acción'
    },
    {
        'id': 2,
        'title': 'Avatar',
        'overview': "En un exuberante planeta llamado Pandora viven los Na'vi, seres que ...",
        'year': '2010',
        'rating': 7.8,
        'category': 'Terror'
    }
]


@app.get("/", tags=["home"])
def message():
    return HTMLResponse(
        content="""
        <h1>hello world</h1>
        <p>my first api with a content</p>
        """,
        status_code=200)


@app.post("/login", tags=["auth"], response_model=dict, status_code=200)
def login(user: User):
    if user.email == "admin@gmail.com" and user.password == "admin":
        token: str = create_token(user.dict())
        return JSONResponse(content=token, status_code=200)
    return JSONResponse(content={"message": "usuario o contraseña incorrectos"}, status_code=401)


@app.get(
    "/movies", tags=["movies"], response_model=List[Movie],
    status_code=status.HTTP_200_OK, dependencies=[Depends(JWTBearer())])
def get_movies() -> List[Movie]:
    db = Session(bind=engine)
    result = db.query(MovieModel).all()
    return JSONResponse(content=jsonable_encoder(result), status_code=status.HTTP_200_OK)


@ app.get("/movies/{id}", tags=["movies"], response_model=Movie)
def get_movie(id: int = Path(ge=1, le=2000)) -> Movie:
    db = Session(bind=engine)
    result = db.query(MovieModel).filter(MovieModel.id == id).first()
    if not result:
        return JSONResponse(content={"message": "no se ha encontrado la pelicula"}, status_code=status.HTTP_404_NOT_FOUND)

    return JSONResponse(content=jsonable_encoder(result), status_code=status.HTTP_200_OK)


@ app.get("/movies/", tags=["movies"], response_model=List[Movie])
def get_movies_by_category(
    category: str = Query(min_length=5, max_length=15,
                          title="Categoria Movie",
                          description="This is the movie category")) -> List[Movie]:
    db = Session(bind=engine)
    result = db.query(MovieModel).filter(MovieModel.category == category).all()
    if not result:
        return JSONResponse(content={"message": "no se ha encontrado la peliculas con la categoria"}, status_code=404)
    return JSONResponse(content=jsonable_encoder(result), status_code=200)


@ app.post("/movies", tags=["movies"], response_model=dict, status_code=201)
def create_movie(movie: Movie) -> dict:
    db = Session(bind=engine)
    new_movie = MovieModel(**movie.dict())
    db.add(new_movie)
    db.commit()
    return JSONResponse(content={"message": "se ha registrado la pelicula"}, status_code=201)


@ app.put("/movies", tags=["movies"], response_model=dict, status_code=200)
def update_movie(
        id: int, movie: Movie) -> dict:
    db = Session(bind=engine)
    result = db.query(MovieModel).filter(MovieModel.id == id).first()
    if not result:
        return JSONResponse(content={"message": "no se ha encontrado la pelicula"}, status_code=404)

    result.title = movie.title
    result.overview = movie.overview
    result.year = movie.year
    result.rating = movie.rating
    result.category = movie.category
    db.commit()
    return JSONResponse(content={"message": "Se a actualizado la pelicula"}, status_code=200)


@ app.delete("/movies", tags=["movies"], response_model=dict, status_code=200)
def delete_movie(id: int) -> dict:
    db = Session(bind=engine)
    result = db.query(MovieModel).filter(MovieModel.id == id).first()
    if not result:
        return JSONResponse(content={"message": "no se ha encontrado la pelicula"}, status_code=404)

    db.delete(result)
    db.commit()
    return JSONResponse(content={"message": "se ha eliminado la pelicula"}, status_code=200)
