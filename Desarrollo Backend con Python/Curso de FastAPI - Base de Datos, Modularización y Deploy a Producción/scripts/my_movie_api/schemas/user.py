from pydantic import BaseModel, Field


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
