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
