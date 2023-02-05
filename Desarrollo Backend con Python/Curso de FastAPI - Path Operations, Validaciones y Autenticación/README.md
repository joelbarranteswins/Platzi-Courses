# Curso de Introducción a FastAPI: Path Operations, Validaciones y Autenticación

## 1. ¿Qué es FastAPI?
Es un framework moderno y de alto rendimiento para creación de API con Python, se puede utilizar desde la version de python 3.6

### Características
* Rápido
* Menos errores
* Fácil e intuitivo
* Robusto
* Basado en estándares

### Marco utilizado por FastAPI
* Starlette: Framework asíncrono para la construcción de servicios y es uno de los más rápidos de Python
* Pydantic: Encargado de la validación de datos.
* Uvicorn: ejecuta el codigo con FastAPI


## 2. Instalación de FastAPI y creación de tu primera aplicación
* Creamos entorno virtual
    ~~~shell
    py -m venv venv
    ~~~

* Activamos entorno virtual
    ~~~shell
    .\venv\Scripts\activate
    ~~~
* Instalamos módulos
    ~~~shell
    pip install fastapi uvicorn
    ~~~
* Creamos nuestra primer app con FastAPI
    ~~~python
    from fastapi import FastAPI

    app = FastAPI()

    @app.get("/")
    def read_root():
        return {"Hello": "World"}
    ~~~
* Corremos la app en un server que se ejecute cuando realizamos un guardado 

    En nuestra consola escribimos: 
        
    ~~~shell
    uvicorn main:app —reload
    ~~~

    ~~~shell
    uvicorn main:app --reload --port 5000
    ~~~

    ~~~shell
    uvicorn main:app --reload --port 5000 --host 127.0.0.10
    ~~~

## 3. Documentación automática con Swagger

Swagger es una especificación abierta para definir las API REST.

El documento Swagger especifica la lista de recursos que están disponibles en la API REST y las operaciones que se pueden llamar en esos recursos. El documento también especifica la lista de parámetros de una operación, incluido el nombre y el tipo de los parámetros, si los parámetros son necesarios u opcionales, e información sobre los valores aceptables para dichos parámetros.

Además, el documento Swagger puede incluir el esquema JSON que describe la estructura del cuerpo de solicitud que se envía a una operación en una API REST, y el esquema JSON describe la estructura de los cuerpos de respuesta que se devuelven de una operación.


~~~python
import fastapi

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
~~~

## 4. Métodos HTTP en FastAPI

### Métodos HTTP
El protocolo HTTP es aquel que define un conjunto de métodos de petición que indican la acción que se desea realizar para un recurso determinado del servidor.

### Los principales métodos soportados por HTTP y por ello usados por una API REST son:

* POST: crear un recurso nuevo.
* PUT: modificar un recurso existente.
* GET: consultar información de un recurso.
* DELETE: eliminar un recurso.

Como te diste cuenta con estos métodos podemos empezar a crear un CRUD en nuestra aplicación.

### ¿De qué tratará nuestra API?
El proyecto que estaremos construyendo a lo largo del curso será una API que nos brindará información relacionada con películas, por lo que tendremos lo siguiente:

* Consulta de todas las películas

    Para lograrlo utilizaremos el método GET y solicitaremos todos los datos de nuestras películas.

* Filtrado de películas

    También solicitaremos información de películas por su id y por la categoría a la que pertenecen, para ello utilizaremos el método GET y nos ayudaremos de los parámetros de ruta y los parámetros query.

* Registro de peliculas

    Usaremos el método POST para registrar los datos de nuestras películas y también nos ayudaremos de los esquemas de la librería pydantic para el manejo de los datos.

* Modificación y eliminación

    Finalmente para completar nuestro CRUD realizaremos la modificación y eliminación de datos en nuestra aplicación, para lo cual usaremos los métodos PUT y DELETE respectivamente.

Y lo mejor es que todo esto lo estarás construyendo mientras aprendes FastAPI, te veo en la siguiente clase donde te enseñaré cómo puedes utilizar el método GET.


### Ademas:

* HTTP: Hypertext Transfer ** P**rotocol.
* CRUD: Create, Read, Update, Delete.
* API: Application Programming Interface.
* API REST: API hecho con el diseño o arquitectura REST(ful), que permite el desarrollo desde distintos lenguajes de programación mientras se ajuste a los siguientes principios:

    1.- Uniformidad de la interfaz; 

    2.- Separación de cliente y servidor; 

    3.- Ser sin estado (que cada solicitud incluya toda la información requerida para ser procesada); 

    4.- Capacidad de almacenamiento en memoria caché; 

    5.- Arquitectura en sistema de capas; 

    6.- Ejecución de código ejectuable bajo demanda.


### 5. Método GET
consultar información de un recurso.

~~~python
movies = [
    {
        'id': 1,
        'title': 'Avatar',
        'overview': "En un exuberante planeta llamado Pandora viven los Na'vi, seres que ...",
        'year': '2009',
        'rating': 7.8,
        'category': 'Acción'
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
~~~


## 5. Parámetros de ruta
el parametro se agrega en el end point y en el navegador se introduce de esta manera:

> http://127.0.0.10:5000/movies/2


~~~python
@app.get("/movies/{id}", tags=["movies"])
def get_movie(id: int):
    for item in movies:
        if item['id'] == id:
            return item
~~~

## 6. Parámetros Query
Un query parameter es un conjunto de parámetros opcionales los cuales son añadidos al finalizar la ruta, con el objetivo de definir contenido o acciones en la url, estos elementos se añaden después de un ?, para agregar más query parameters utilizamos &.

Con un parametro:
> http://127.0.0.10:5000/movies/?category=wefwef

Con dos parametros:
> http://127.0.0.10:5000/movies/?category=sedfse&year=123123

~~~python
@app.get("/movies/", tags=["movies"])
def get_movies_by_category(category: str):
    return [item for item in movies if item['category'] == category]
~~~


## 7. Método POST

crear un recurso nuevo.

~~~python
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

~~~


## 8. Métodos PUT y DELETE
### PUT: modificar un recurso existente.

~~~python
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
~~~

### DELETE: eliminar un recurso.

~~~python
@app.delete("/movies", tags=["movies"])
def delete_movie(id: int):
    for item in movies:
        if item['id'] == id:
            movies.remove(item)
    return movies
~~~


## 9. Creación de esquemas
para crear esquedas se usará la libreria pydantic para crear un esquema de la siguiente forma:

~~~python
from pydantic import BaseModel

class Movie(BaseModel):
    id: Optional[int] = None
    title: str
    overview: str
    year: int
    rating: float
    category: str
~~~

### se modificara los endpoint de post y put de la siguiente manera:

~~~python

@app.post("/movies", tags=["movies"])
def create_movie(movie: Movie):
    movies.append(movie)
    return movies


@app.put("/movies", tags=["movies"])
def update_movie(
        id: int, movie: Movie):
    for item in movies:
        if item['id'] == id:
            item['title'] = movie.title
            item['overview'] = movie.overview
            item['year'] = movie.year
            item['rating'] = movie.rating
            item['category'] = movie.category
    return movies
~~~


## 10. Validaciones de tipos de datos
validaremos el tipo de dato usando pydantic de la siguiente manera:

~~~python
from pydantic import BaseModel, Field

class Movie(BaseModel):
    id: Optional[int] = None
    title: str = Field(min_length=5, max_length=15)
    overview: str = Field(
        min_length=15, max_length=50)
    year: int = Field(ge=1900, le=2021)
    rating: float = Field(ge=0.0, le=10.0)
    category: str = Field(min_length=5, max_length=15)

    class Config:
        schema_extra = {
            "example": {
                "title": "Mi pelicula",
                "overview": "Descripcion de mi pelicula ...",
                "year": 2000,
                "rating": 5.0,
                "category": "Acción"
            }
        }
~~~


## 11. Validaciones de parámetros

### Validar parametros de ruta

~~~python
from fastapi import Body, Path

@app.get("/movies/{id}", tags=["movies"])
def get_movie(id: int = Path(ge=1, le=2000)):
    for item in movies:
        if item['id'] == id:
            return item
~~~

### Validar parametros Query

~~~python
from fastapi import Body, Path, Query


@app.get("/movies/", tags=["movies"])
def get_movies_by_category(category: str = Query(min_length=5, max_length=15)):
    return [item for item in movies if item['category'] == category]
~~~


### Parameters of validation
    min_length
    max_length
    max_digits
    regex
    ge (greater or equal than)
    le (less or equal than)
    gt (greater tha)
    lt (less than)
    Title
    Description

### Documentación
    https://fastapi.tiangolo.com/tutorial/query-params-str-validations/


## 12. Tipos de respuestas

HTTP response status codes
HTTP response status codes indicate whether a specific HTTP request has been successfully completed. Responses are grouped in five classes:

    Informational responses (100 – 199)
    Successful responses (200 – 299)
    Redirection messages (300 – 399)
    Client error responses (400 – 499)
    Server error responses (500 – 599)



## 13. Códigos de estado

~~~python
@app.get("/movies", tags=["movies"], response_model=List[Movie])
def get_movies() -> List[Movie]:
    return JSONResponse(content=movies, status_code=200)

@app.get("/movies/", tags=["movies"], response_model=List[Movie])
def get_movies_by_category(
    category: str = Query(min_length=5, max_length=15,
                          title="Categoria Movie",
                          description="This is the movie category")) -> List[Movie]:
    data = [item for item in movies if item['category'] == category]
    return JSONResponse(content=data, status_code=200)


@app.post("/movies", tags=["movies"], response_model=dict, status_code=201)
def create_movie(movie: Movie) -> dict:
    movies.append(movie)
    return JSONResponse(content={"message": "se ha registrado la pelicula"}, status_code=201)


@app.put("/movies", tags=["movies"], response_model=dict, status_code=200)
def update_movie(
        id: int, movie: Movie) -> dict:
    for item in movies:
        if item['id'] == id:
            item['title'] = movie.title
            item['overview'] = movie.overview
            item['year'] = movie.year
            item['rating'] = movie.rating
            item['category'] = movie.category
    return JSONResponse(content={"message": "se ha actualizado la pelicula"}, status_code=200)


@app.delete("/movies", tags=["movies"], response_model=dict, status_code=200)
def delete_movie(id: int) -> dict:
    for item in movies:
        if item['id'] == id:
            movies.remove(item)
    return JSONResponse(content={"message": "se ha eliminado la pelicula"}, status_code=200)


~~~


### implementando reponse = 404

~~~python
@app.get("/movies/{id}", tags=["movies"], response_model=Movie)
def get_movie(id: int = Path(ge=1, le=2000)) -> Movie:
    for item in movies:
        if item['id'] == id:
            return JSONResponse(content=item, status_code=200)

    return JSONResponse(content={"message": "no se ha encontrado la pelicula"}, status_code=404)
~~~

## 14. Flujo de autenticación

### Flujo de autenticación
Ahora empezaremos con el módulo de autenticaciones pero antes quiero explicarte un poco acerca de lo que estaremos realizando en nuestra aplicación y cómo será el proceso de autenticación y autorización.

### Ruta para iniciar sesión
Lo que obtendremos como resultado al final de este módulo es la protección de determinadas rutas de nuestra aplicación para las cuales solo se podrá acceder mediante el inicio de sesión del usuario. Para esto crearemos una ruta que utilice el método POST donde se solicitarán los datos como email y contraseña.

### Creación y envío de token
Luego de que el usuario ingrese sus datos de sesión correctos este obtendrá un token que le servirá para enviarlo al momento de hacer una petición a una ruta protegida.

### Validación de token
Al momento de que nuestra API reciba la petición del usuario, comprobará que este le haya enviado el token y validará si es correcto y le pertenece. Finalmente se le dará acceso a la ruta que está solicitando.

En la siguiente clase empezaremos con la creación de una función que nos va a permitir generar tokens usando la librería pyjwt.


### PyJWT (Python JSON Web Token) 
es una biblioteca de Python que se utiliza para codificar y decodificar tokens JWT (JSON Web Token). Un token JWT es un objeto de seguridad que se utiliza para autenticar a los usuarios en aplicaciones web y móviles. Los tokens JWT se emiten por un servidor de autenticación y luego se envían al cliente, que los utiliza para demostrar su identidad al acceder a recursos protegidos en el servidor


## 15. Generando tokens con pyjwt

* instalar la libreria jason web token
> pip install pyjwt

* el siguiente codigo nos ayuda a crear token, se debe tener ne cuenta que el key permite crear el token con una clave y esta clave lo va a decodificar.

    ~~~python
    from jwt import encode

    def create_token(data: dict):
        token = encode(payload=data, key="my_secret_key", algorithm="HS256")
        return token
    ~~~




## Validando tokens
decode ayuda a decodificar el token creada con una clave.

* el siguiente ejemplo nos ayuda decodificar usando el metodo decode
    ~~~python
    from jwt import decode

    def validate_token(token: str) -> dict:
        data = decode(token, key="my_secret_key", algorithms=["HS256"])
        return data
    ~~~


* realizando la validación en el endpoint login

    ~~~python

    class User(BaseModel):
        email: str = Field(min_length=5, max_length=100,
                        title="Email",
                        description="This is the email")
        password: str = Field(min_length=5, max_length=15,
                            title="Password",
                            description="This is the password")

    @app.post("/login", tags=["auth"], response_model=dict, status_code=200)
    def login(user: User):
        if user.email == "admin@gmail.com" and user.password == "admin":
            token: str = create_token(user.dict())
            return JSONResponse(content=token, status_code=200)
        return JSONResponse(content={"message": "usuario o contraseña incorrectos"}, status_code=401)
    ~~~


## Middlewares de autenticación

realizar la autentificación en cada endpoint

* primero se debe crear una clase con el metodo __call__ asincrono para que se realice la validación cuando usamos un metodo HTTP

    ~~~python
    from fastapi import Body, Depends, HTTPException, Path, Query, status, Request
    from pydantic import BaseModel, Field
    from typing import List
    from jwt_manager import create_token, validate_token
    from fastapi.security import HTTPBearer


    class JWTBearer(HTTPBearer):
        async def __call__(self, request: Request):
            auth = await super().__call__(request)
            data = validate_token(auth.credentials)
            if data['email'] != "admin@gmail.com":
                return HTTPException(status_code=403, detail="Credenciales no son validas")
    ~~~


* se usa el argumento dependencies=[Depends()] para hacer que se ejecute nuestra clase y asi realizar la validación del token, por lo que ya no se requiere hacer las validaciones dentro de cada metodo HTTP.

    ~~~python
    @app.get(
        "/movies", tags=["movies"], response_model=List[Movie],
        status_code=status.HTTP_200_OK, dependencies=[Depends(JWTBearer())])
    def get_movies() -> List[Movie]:
        return JSONResponse(content=movies, status_code=status.HTTP_200_OK)
    ~~~