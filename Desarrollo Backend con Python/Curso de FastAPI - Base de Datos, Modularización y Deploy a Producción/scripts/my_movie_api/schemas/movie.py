from typing import Optional
from pydantic import BaseModel, Field


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
