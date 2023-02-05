from typing import Optional
from fastapi.responses import HTMLResponse
import fastapi
from fastapi import Body

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


@app.get("/movies", tags=["movies"])
def get_movies():
    return movies


@app.get("/movies/{id}", tags=["movies"])
def get_movie(id: int):
    for item in movies:
        if item['id'] == id:
            return item


@app.get("/movies/", tags=["movies"])
def get_movies_by_category(category: str):
    return [item for item in movies if item['category'] == category]


@app.post("/movies", tags=["movies"])
def create_movie(
        id: int = Body(), title: str = Body(), overview: str = Body(),
        year: str = Body(), rating: int = Body(), category: str = Body()):
    movie = {
        'id': id,
        'title': title,
        'overview': overview,
        'year': year,
        'rating': rating,
        'category': category
    }
    movies.append(movie)
    return movies


@app.put("/movies", tags=["movies"])
def update_movie(
        id: int, title: str = Body(), overview: str = Body(),
        year: str = Body(), rating: int = Body(), category: str = Body()):
    for item in movies:
        if item['id'] == id:
            item['title'] = title
            item['overview'] = overview
            item['year'] = year
            item['rating'] = rating
            item['category'] = category
    return movies


@app.delete("/movies", tags=["movies"])
def delete_movie(id: int):
    for item in movies:
        if item['id'] == id:
            movies.remove(item)
    return movies
