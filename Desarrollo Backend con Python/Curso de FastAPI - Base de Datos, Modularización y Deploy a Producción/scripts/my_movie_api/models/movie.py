from config.database import Base
from sqlalchemy import Column, Integer, String


class Movie(Base):
    __tablename__ = "movies"
    id = Column(Integer, primary_key=True, index=True)
    title = Column(String)
    overview = Column(String)
    year = Column(Integer)
    rating = Column(Integer)
    category = Column(String)
