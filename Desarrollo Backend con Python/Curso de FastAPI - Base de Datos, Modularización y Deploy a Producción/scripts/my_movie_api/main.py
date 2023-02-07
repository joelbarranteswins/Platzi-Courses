import fastapi
from config.database import engine, Base
from middlewares.error_handler import ErrorHandle
from routers.movie import movie_router
from routers.user import user_router

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

app.add_middleware(ErrorHandle)
app.include_router(user_router)
app.include_router(movie_router)


Base.metadata.create_all(bind=engine)
