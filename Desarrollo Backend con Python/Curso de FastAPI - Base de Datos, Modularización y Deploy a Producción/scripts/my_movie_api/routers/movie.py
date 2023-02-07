from fastapi import APIRouter
from fastapi.responses import JSONResponse
from fastapi import Path, Query, status
from typing import List
from config.database import Session
from fastapi.encoders import jsonable_encoder
from services.movie import MovieService
from schemas.movie import Movie
from models.movie import Movie as MovieModel

movie_router = APIRouter()


@movie_router.get(
    "/movies", tags=["movies"], response_model=List[Movie],
    status_code=status.HTTP_200_OK)  # dependencies=[Depends(JWTBearer())])
def get_movies() -> List[Movie]:
    db = Session()
    result = MovieService(db).get_movies()
    return JSONResponse(content=jsonable_encoder(result), status_code=status.HTTP_200_OK)


@ movie_router.get("/movies/{id}", tags=["movies"], response_model=Movie)
def get_movie(id: int = Path(ge=1, le=2000)) -> Movie:
    db = Session()
    result = MovieService(db).get_movie(id)
    if not result:
        return JSONResponse(content={"message": "no se ha encontrado la pelicula"}, status_code=status.HTTP_404_NOT_FOUND)

    return JSONResponse(content=jsonable_encoder(result), status_code=status.HTTP_200_OK)


@ movie_router.get("/movies/", tags=["movies"], response_model=List[Movie])
def get_movies_by_category(
    category: str = Query(min_length=5, max_length=15,
                          title="Categoria Movie",
                          description="This is the movie category")) -> List[Movie]:
    db = Session()
    result = MovieService(db).get_movies_by_category(category)
    if not result:
        return JSONResponse(content={"message": "no se ha encontrado la peliculas con la categoria"}, status_code=404)
    return JSONResponse(content=jsonable_encoder(result), status_code=200)


@ movie_router.post("/movies", tags=["movies"], response_model=dict, status_code=201)
def create_movie(movie: Movie) -> dict:
    db = Session()
    MovieService(db).create_movie(movie)
    return JSONResponse(content={"message": "se ha registrado la pelicula"}, status_code=201)


@ movie_router.put("/movies", tags=["movies"], response_model=dict, status_code=200)
def update_movie(
        id: int, movie: Movie) -> dict:
    db = Session()
    result = MovieService(db).get_movie(id)

    if not result:
        return JSONResponse(content={"message": "no se ha encontrado la pelicula"}, status_code=404)

    MovieService(db).update_movie(id, movie)
    return JSONResponse(content={"message": "Se a actualizado la pelicula"}, status_code=200)


@ movie_router.delete("/movies", tags=["movies"], response_model=dict, status_code=200)
def delete_movie(id: int) -> dict:
    db = Session()
    result = db.query(MovieModel).filter(MovieModel.id == id).first()
    if not result:
        return JSONResponse(content={"message": "no se ha encontrado la pelicula"}, status_code=404)

    MovieService(db).delete_movie(id)
    return JSONResponse(content={"message": "se ha eliminado la pelicula"}, status_code=200)
