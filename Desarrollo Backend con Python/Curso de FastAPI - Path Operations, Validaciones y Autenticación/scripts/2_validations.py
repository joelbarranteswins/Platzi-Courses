from typing import Optional
from fastapi.responses import HTMLResponse, JSONResponse
import fastapi
from fastapi import Body, Path, Query, status
from pydantic import BaseModel, Field
from typing import List

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


@app.get("/movies", tags=["movies"], response_model=List[Movie], status_code=status.HTTP_200_OK)
def get_movies() -> List[Movie]:
    return JSONResponse(content=movies, status_code=status.HTTP_200_OK)


@app.get("/movies/{id}", tags=["movies"], response_model=Movie)
def get_movie(id: int = Path(ge=1, le=2000)) -> Movie:
    for item in movies:
        if item['id'] == id:
            return JSONResponse(content=item, status_code=200)

    return JSONResponse(content={"message": "no se ha encontrado la pelicula"}, status_code=404)


@app.get("/movies/", tags=["movies"], response_model=List[Movie])
def get_movies_by_category(
    category: str = Query(min_length=5, max_length=15,
                          title="Categoria Movie",
                          description="This is the movie category")) -> List[Movie]:
    data = [item for item in movies if item['category'] == category]
    return JSONResponse(content=data, status_code=200)


@app.post("/movies", tags=["movies"], response_model=dict, status_code=201)
def create_movie(movie: Movie) -> dict:
    movies.append(movie)
    return JSONResponse(content={"message": "se ha registrado la pelicula"}, status_code=201)


@app.put("/movies", tags=["movies"], response_model=dict, status_code=200)
def update_movie(
        id: int, movie: Movie) -> dict:
    for item in movies:
        if item['id'] == id:
            item['title'] = movie.title
            item['overview'] = movie.overview
            item['year'] = movie.year
            item['rating'] = movie.rating
            item['category'] = movie.category
    return JSONResponse(content={"message": "se ha actualizado la pelicula"}, status_code=200)


@app.delete("/movies", tags=["movies"], response_model=dict, status_code=200)
def delete_movie(id: int) -> dict:
    for item in movies:
        if item['id'] == id:
            movies.remove(item)
    return JSONResponse(content={"message": "se ha eliminado la pelicula"}, status_code=200)
