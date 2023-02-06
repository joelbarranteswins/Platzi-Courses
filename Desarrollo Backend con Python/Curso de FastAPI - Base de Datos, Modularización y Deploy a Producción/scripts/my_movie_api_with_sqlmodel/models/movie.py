from sqlmodel import Field, SQLModel


class Movie(SQLModel, table=True):
    id: int = Field(primary_key=True, index=True)
    title: str = Field(max_length=100)
    overview: str
    year: str
    rating: float
    category: str
