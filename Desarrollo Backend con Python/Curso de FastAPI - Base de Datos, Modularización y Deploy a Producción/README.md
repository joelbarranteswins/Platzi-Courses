# Curso de FastAPI: Base de Datos, Modularización y Deploy a Producción

## SQLAlchemy: el ORM de FastAPI

* Que es un ORM?

    ORM significa Object-Relational Mapping. Es una técnica de programación que permite trabajar con bases de datos relacionales como si fueran objetos en lugar de utilizar un lenguaje de consulta (SQL) para interactuar con la base de datos.

    Esto significa que con un ORM, se pueden utilizar clases y objetos en el código para crear, consultar, actualizar y eliminar datos en la base de datos, en lugar de escribir consultas SQL manualmente.

* Que es SQLAlchemy?

    SQLAlchemy es un ORM (Object-Relational Mapping) de Python que permite trabajar con bases de datos relacionales como si fueran objetos en lugar de utilizar un lenguaje de consulta (SQL) para interactuar con la base de datos.


* Ademas:

    Tiangolo, el creador de FastAPI, también ha desarrollado un ORM, llamado SQLModel, el cual está basado en SQLAlchemy.

    Dado que FastAPI y SQLModel son proyectos iniciados por la misma persona, es muy facil adaptarlos.

    SQLModel is designed to simplify interacting with SQL databases in FastAPI applications, it was created by the same author.

    It combines SQLAlchemy and Pydantic and tries to simplify the code you write as much as possible, allowing you to reduce the code duplication to a minimum, but while getting the best developer experience possible.

    SQLModel is, in fact, a thin layer on top of Pydantic and SQLAlchemy, carefully designed to be compatible with both.


## Instalación y configuración de SQLAlchemy

1. instalar sqlite viewer en vscode
    

2. install SQLAlchemy con pip

    > pip install sqlalchemy

3. crear un archiv con la carpeta config y un archivo database.py y se realizara lo siguiente:

    * Se guardara el nombre de la base de datos

        ~~~python
        sqlite_file_name = "database.sqlite"      
        ~~~

    * Se lera el directorio actual del archivo database

        ~~~python
        base_dir = os.path.dirname(os.path.realpath(__file__))   
        ~~~

    * sqlite:/// es la forma en la que se conecta a una base de datos, se usa el metodo join para unir las urls

        ~~~python
        database_url = f"sqlite:///{os.path.join(base_dir, sqlite_file_name)}" 
        ~~~

    * representa el motor de la base de datos, con el comando “echo=True” para que al momento de realizar la base de datos,
    me muestre por consola lo que esta realizando, que seria el codigo

        ~~~python
        engine = create_engine(database_url, echo=True)      
        ~~~  

    * Se crea session para conectarse a la base de datos, se enlaza con el comando “bind” y se iguala a engine
        ~~~python
        Session = sessionmaker(bind=engine) 
        ~~~     

    * Sirve para manipular todas las tablas de la base de datos

        ~~~python
        Base = declarative_base()                 
        ~~~

## Creación de modelos

1. Creamos la carpeta models y dentro de ella los archivos __init__.py y init.py.

    ~~~python
    from config.database import Base
    from sqlalchemy import Column, Integer, String, Float

    class Movie(Base):
        ___tablename__ = 'movies'
        id = Column(Integer, primary_key=True)
        title = Column(String)
        overview = Column(String)
        year = Column(Integer)
        rating = Column(Float)
        category = Column(String)
    ~~~

2. En main.py añadimos las configuraciones para que se cree la base de datos.

    ~~~python
    from config.database import Session, engine, Base
    from models.movie import Movie

    app = FastAPI()
    app.title = "Mi aplicación con  FastAPI"
    app.version = "0.0.1"

    Base.metadata.create_all(bind=engine)
    ~~~

## Registro de datos

1. Iniciamos una sesión
2. Añadimos los datos al modelo MovieModel(). Podemos hacerlo de dos formas:
    * Añadiendo dato por dato:
    ~~~python
    new_movie = MovieModel(title=movie.title, overview=movie.overview, ...)
    ~~~

    * Descomprimiendo el diccionario de peliculas.
    ~~~python
    new_movie = MovieModel(**movie.dict())
    ~~~
    * Añadir el nuevo registro a la base de datos
    * Actualizar y guardar los cambios.
    ~~~python
    @app.post('/movies', tags=['movies'], response_model=dict, status_code=201)
    def create_movie(movie: Movie) -> dict:
    # Paso 1
        db = Session()
    # Paso 2
        new_movie = MovieModel(**movie.dict())
    # Paso 3
        db.add(new_movie)
    # Paso 4
        db.commit()
        return JSONResponse(status_code=201, content={"message": "Se ha registrado la película"})
    ~~~


## Consulta de datos

queries de las bases de datos:

* filter() (visto en clase): filtra por condiciones.
* where(): es un sinonimo de filter().
* first() (visto en clase): devuelve el primer resultado de la query.
* all(): devuelve todos los registros.
* orderby(): ordena los resultados por columnas.
* count(): cuenta el numero de filas.
Pueden ver más sobre esto en la documentación. Hay varios métodos que se parecen a las funciones de SQL.

## Modificación y eliminación de datos

### Modificacar datos

1. Iniciar una Session().

2. Si la pelicula existe, reescribir los datos

    ~~~python
    @app.put('/movies/{id}', tags=['movies'], response_model=dict, status_code=200)
    def update_movie(id: int, movie: Movie)-> dict:

        db = Session()
        result = db.query(MovieModel).where(MovieModel.id == id).first()

        if result: 
            result.title = movie.title
            result.category = movie.overview
            result.overview = movie.overview
            result.rating = movie.rating
            result.year = movie.year  
            db.commit()
            return JSONResponse(status_code=201, content={"message": "Updated done"})

        
        if not result:
            return JSONResponse(status_code=404, content={'message': 'ID No found'})
    ~~~

### Eliminar datos

1. Iniciar una Session().

2. Si la pelicula existe, eliminar ese registro
    ~~~python
    @app.delete('/movies/{id}', tags=['movies'], response_model=dict, status_code=200)
    def delete_movie(id: int)-> dict:

        db = Session()
        result = db.query(MovieModel).where(MovieModel.id == id).first()

        if result: 
            db.delete(result)
            db.commit()
            return JSONResponse(status_code=200, content={"message": "Record deleted"})

        if not result:
            return JSONResponse(status_code=404, content={'message': 'ID No found'})
    ~~~


## SQLModel: el futuro ORM de FastAPI

* otra libreria que nos permite hacer ORM con la base de datos
https://sqlmodel.tiangolo.com/


## Manejo de errores y middlewares

* Los middlewares en la creación de APIs son funciones que se ejecutan en un punto intermedio de la solicitud-respuesta en una aplicación web. Se ejecutan en orden antes de llegar al controlador (el lugar donde se define la lógica para manejar la solicitud) y después de la ejecución del controlador.

    Los middlewares pueden realizar tareas como autenticación, validación de datos, registro de solicitudes, manipulación de encabezados, entre otras. Estos son utilizados para agregar funcionalidades a la API sin tener que modificar la lógica del controlador y permiten una mayor separación de responsabilidades en la aplicación.

1. se crea una carpeta con el nombre de middleware
2. se crear un archivo con el nombre wrror_handler y se tendra el siguiente codigo:

    ~~~python
    from starlette.middleware.base import BaseHTTPMiddleware
    from fastapi import FastAPI, Request, Response
    from fastapi.responses import JSONResponse

    class ErrorHandle(BaseHTTPMiddleware):
        def __init__(self, app: FastAPI) -> None:
            super().__init__(app)

        async def dispatch(
            self, request: Request, call_next
        ) -> Response | JSONResponse:
            try:
                return await call_next(request)
            except Exception as e:
                return JSONResponse(status_code=500, content={"message": str(e)})
    ~~~

3. se crear un archivo con el nombre jwt_bearer y se digita el siguiente codigo:

    ~~~python
    from fastapi.security import HTTPBearer
    from fastapi import Request, HTTPException
    from jwt_manager import validate_token


    class JWTBearer(HTTPBearer):
        async def __call__(self, request: Request):
            auth = await super().__call__(request)
            data = validate_token(auth.credentials)
            if data['email'] != "admin@gmail.com":
                return HTTPException(status_code=403, detail="Credenciales no son validas")
    ~~~


## Creación de routers

* Los routers se crean en la creación de APIs para gestionar y enrutar las solicitudes HTTP a los controladores apropiados. Un router actúa como un intermediario entre las solicitudes entrantes y los controladores que manejan estas solicitudes.

    El router determina qué controlador debe manejar una solicitud en función de la URL y el método HTTP (por ejemplo, GET, POST, PUT, DELETE) en la solicitud. Esto permite una mayor modularidad y escalabilidad en la aplicación, ya que los controladores pueden estar organizados de manera lógica y las solicitudes se pueden enrutar a los controladores correctos sin necesidad de una gran cantidad de código repetitivo.

    Además, los routers también pueden utilizarse para agregar funcionalidades adicionales como la autenticación y la autorización en la API, lo que mejora la seguridad y la gestión de la API.

1. crear la carpeta llamada routers y dos archivos con el nombre movie.py y user.py

* movie.py
    ~~~python
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

        db.delete(result)
        db.commit()
        return JSONResponse(content={"message": "se ha eliminado la pelicula"}, status_code=200)

    ~~~

* user.py
    ~~~python
    from fastapi import APIRouter
    from fastapi.responses import HTMLResponse, JSONResponse
    from jwt_manager import create_token
    from schemas.user import User

    user_router = APIRouter()


    @user_router.get("/", tags=["home"])
    def message():
        return HTMLResponse(
            content="""
            <h1>hello world</h1>
            <p>my first api with a content</p>
            """,
            status_code=200)


    @user_router.post("/login", tags=["auth"], response_model=dict, status_code=200)
    def login(user: User):
        if user.email == "admin@gmail.com" and user.password == "admin":
            token: str = create_token(user.dict())
            return JSONResponse(content=token, status_code=200)
        return JSONResponse(content={"message": "usuario o contraseña incorrectos"}, status_code=401)

    ~~~


## Servicios para consultar datos, registrar y modificar datos
1. crear carpeta con el nombre schemas y introducir el siguiente codigo de la siguiente manera:
* movie.py

    ~~~python
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
    ~~~


* user.py

    ~~~python
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
    ~~~


2. crearemos una carpeta llamada services y dos archivos con el nombre movie.py y user.py

3. usar el siguiente codigo en movie.py

    * los metodos para cada endpoint los tendremos en routers y desde alli realizaremos las transacciones

    ~~~python
    from models.movie import Movie as MovieModel
    from schemas.movie import Movie


    class MovieService():
        def __init__(self, db):
            self.db = db

        def get_movies(self):
            result = self.db.query(MovieModel).all()
            return result

        def get_movie(self, id: int):
            result = self.db.query(MovieModel).filter(MovieModel.id == id).first()
            return result

        def get_movies_by_category(self, category: str):
            result = self.db.query(MovieModel).filter(
                MovieModel.category == category).all()
            return result

        def create_movie(self, movie: Movie):
            new_movie = MovieModel(**movie.dict())
            self.db.add(new_movie)
            self.db.commit()

        def update_movie(self, id: int, movie: Movie):
            result = self.db.query(MovieModel).filter(MovieModel.id == id).first()
            result.title = movie.title
            result.overview = movie.overview
            result.year = movie.year
            result.rating = movie.rating
            result.category = movie.category
            self.db.commit()
    ~~~

4. usar el siguiente en user.py

~~~python
from fastapi import APIRouter
from fastapi.responses import HTMLResponse, JSONResponse
from jwt_manager import create_token
from schemas.user import User

user_router = APIRouter()

@user_router.get("/", tags=["home"])
def message():
    return HTMLResponse(
        content="""
        <h1>hello world</h1>
        <p>my first api with a content</p>
        """,
        status_code=200)


@user_router.post("/login", tags=["auth"], response_model=dict, status_code=200)
def login(user: User):
    if user.email == "admin@gmail.com" and user.password == "admin":
        token: str = create_token(user.dict())
        return JSONResponse(content=token, status_code=200)
    return JSONResponse(content={"message": "usuario o contraseña incorrectos"}, status_code=401)
~~~



## Preparando el proyecto para desplegar a producción

* agregar el gitignore en el root y se puede obtener contenido que debe ser ignorado desde el repositorio de gitignore enel siguiente path:

    https://www.toptal.com/developers/gitignore/api/windows,linux,macos,python

* pueden visitar la pagina de https://www.toptal.com/developers/gitignore para obtener codigo de gitignore.

## Creando el repositorio en GitLab
Gitlab Inc. es una compañía de núcleo abierto y es la principal proveedora del software GitLab, un servicio web de forja, control de versiones y DevOps basado en Git.


~~~shell

# inicializa el repositorio
git init --initial-branch=main

# agrega el repositorio remoto
git remote add origin <url-del-repositorio>

* lleva el codigo del working directory al staging area
git add .

* lleva el codigo del staging area al repositorio local
git commit -m "deploy"

* lleva el codigo del repositorio local al repositorio remoto
git push
~~~

## Instalación de herramientas para el servidor

~~~shell
# Pasos para hacer el 
apt update

apt -y upgrade

#instalar python y git
python3 -V

git --version


# instalar ngnex
apt install nginx

# ejecutar la app con el servidor
nodejs --version

apt install nodejs

# Instalar para ejecutar la aplicaciooon
apt install npm

#instalar globalmente 
npm install pm2@latest -g

# Aqui debe salir la aplicación de python.
pm2 list

# instalar el entorno virtual 
apt install python3-venv

#Crear y activar el intorno virtual
python3 -m venv venv
source venv/vim/activate

pip install -r requirements.txt
~~~



## Ejecutando FastAPI con NGINX

~~~shell
pm2 start "uvicorn main:app --port 5000 --host 0.0.0.0" --name my-movie-api

deactivate out of venv

nano /etc/nginx/sites-enabled/my-movie-api

server {
        listen 80;
        server_name 104.248.228.181;
        location / {
                proxy_pass http://127.0.0.1:5000;
        }
}

save and exit 

systemctl status nginx

systemctl restart nginx
~~~