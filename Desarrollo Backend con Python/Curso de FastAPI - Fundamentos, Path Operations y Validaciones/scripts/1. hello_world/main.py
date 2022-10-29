from doctest import Example
from typing import Optional
from enum import Enum
from unittest import result
from pydantic import BaseModel, Field
from fastapi import FastAPI, Path, Query
from fastapi import Body

app = FastAPI()


class HairColor(str, Enum):
    white = "white"
    brown = "brown"
    black = "black"
    blonde = "blonde"
    red = "red"


class Location(BaseModel):
    city: str
    state: str
    country: str


class Person(BaseModel):
    first_name: str = Field(..., example="joel", min_length=1, max_length=50)
    last_name: str = Field(..., example="barrantes",
                           min_length=1, max_length=50)
    age: int = Field(..., example=25, gt=0, lt=115)
    hair_color: Optional[HairColor] = Field(
        default=None, example=HairColor.brown)
    is_married: Optional[bool] = Field(default=None, example=False)

    # class Config:
    #     schema_extra = {
    #         "example": {
    #             "first_name": "John",
    #             "last_name": "Doe",
    #             "age": 30,
    #             "hair_color": "brown",
    #             "is_married": True
    #         }
    #     }


@app.get("/")
def home():
    return {"Hello": "World"}


# Request and Response
@app.post("/person/new")
def create_person(person: Person = Body(...)):
    return person


# Validaciones: query parameters
@app.get("/person/detail")
def show_person_detail(
    name: Optional[str] = Query(
        default=None,
        example="John Doe",
        min_length=1,
        max_length=50,
        title="Person Name",
        description="This is the person name. It's between 1 and 50 characters long"),
    age: int = Query(
        ...,
        example=25,
        title="Person Age",
        description="This is the person age. It's required",)
):
    return {"name": name, "age": age}


# Validaciones: path parameters
@app.get("/person/detail/{person_id}")
def show_person(
    person_id: int = Path(
        ...,
        example=12,
        title="The ID of the person to get",
        ge=0,
        le=100)
):
    return {"person_id": person_id}


# Validaciones: Request body
@app.put("/person/{person_id}")
def update_person(
    person_id: int = Path(
        ...,
        title="The ID of the person to get",
        ge=0,
        le=100),
    person: Person = Body(
        ...,
        title="The person data to update"),
    location: Location = Body(...)

):
    results = person.dict()
    results.update(location.dict())
    return results  # {"person_id": person_id, **person.dict()}
