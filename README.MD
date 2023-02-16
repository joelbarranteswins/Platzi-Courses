
# Platzi Course Resources

<img src="https://static.platzi.com/static/images/footer/logo.png">

## `Overview`

All the courses which appear here is what I have taken in [**platzi.com**](platzi.com) and I own all the files except the files inside folders named **shared**, with much pleasure Fork and download all my sources if you like it and if you want to improve this repo just make a Pull request 😀.

## `Architecture`

* `Each School and Course` has a `Pattern`
* `All courses from each school are sorted` as they appear in Platzi.



~~~mermaid
stateDiagram-v2
    state Platzi-courses {
        state School {
            [*] --> Course 
            state Course {
                [*] --> exam : (folder)
                [*] --> exercise: (folder)
                exercise --> scripts
                [*] --> imgs: (folder)
                [*] --> shared: (folder)
                shared --> slides: (presentation file)
                [*] --> README:(summary file)
            }
        }
        [*] --> Certificates
        state Certificates{
            [*] --> certificate: (file)
        }
    } 
~~~

## `Bases de Datos`

* [x] Fundamentos de Bases de Datos
* [ ] Curso de MySQL y MariaDB
* [ ] Curso Práctico de SQL y MySQL
* [ ] Curso de PostgreSQL
* [ ] Curso Práctico de SQL
* [ ] Curso de Optimización de Bases de Datos en SQL Server
* [ ] Nuevo Curso de Introducción a MongoDB
* [ ] Curso de Modelamiento de Datos en MongoDB
* [ ] Curso de Introducción a Elasticsearch


## `Data Science`

* [x] DataAcademy
* [x] Cómo y Por Qué Aprender Data Science e Inteligencia Artificial
* [x] Analisis de negocios para ciencia de datos
* [x] Básico de Python
* [x] Excel Básico
* [x] Entorno Trabajo Ciencia de Datos
* [x] Curso Practico de Regresion Lineal Simple
* [x] Curso Profesional de Python
* [x] Business Intelligence - Utilidad y Areas de oportunidad
* [ ] Visualización de Datos para Business Intelligence
* [x] Manipulación y Análisis de Datos con Pandas y Python
* [x] Manipulación y Transformación de Datos con Pandas y NumPy
* [x] Visualización de Datos con Matplotlib y Seaborn
* [x] Funciones Matemáticas para Data Science e Inteligencia Artificial
* [x] Matemáticas para Data Science - Estadística Descriptiva
* [x] Matemáticas para Data Science - Probabilidad
* [x] Ética y Manejo de Datos para Data Science e Inteligencia Artificial

## `Backend`

* [ ] Curso de Introducción al Desarrollo Backend
* [ ] Curso Práctico de Arquitectura Backend

## `Desarrollo Backend con C# y .NET`

* [x] Curso de Introducción a C#
* [x] Curso de C# con .Net Core
* [ ] ~~Curso de C# con .Net Core 2~~ `(Deprecated)`
* [ ] Buenas Prácticas y Código Limpio en C# `(New)`
* [ ] Fundamentos de .NET `(New)`
* [x] Fundamentos de Entity Framework
* [x] APIs con .NET
* [ ] Manejo de Datos con LINQ `(New)`
* [ ] Curso de Principios SOLID en C# y .NET `(New)`
* [ ] ASP.NET Core `(New)`
* [ ] Desarrollo Web con Blazor y .Net 
* [ ] Azure DevOps: Flujos de CI/CD
* [ ] Curso Práctico de Arquitectura Backend

## `Desarrollo Backend con Python` :white_check_mark: (completed)

* [x] Fundamentos de Python
* [x] Comprehensions, Funciones y Manejo de Errores
* [x] Introducción al Pensamiento Computacional con Python
* [ ] ~~Introducción al Pensamiento Probabilístico~~ `(Deprecated)`
* [x] PIP y Entornos Virtuales
* [x] Estructuras de Datos Lineales con Python
* [x] Estadística Computacional con Python
* [x] POO y Algoritmos con Python
* [x] Introducción al Desarrollo Backend
* [x] Curso Práctico de Python: Creación de un CRUD
* [ ] ~~Introducción a Selenium con Python~~ `(Deprecated)`
* [x] Curso de FastAPI: Fundamentos, Path Operations y Validaciones
* [x] Curso de FastAPI: Modularización, Datos Avanzados y Errores
* [ ] ~~Curso de FastAPI: Path Operations, Validaciones y Autenticación~~ `(Deprecated)`
* [x] Curso de FastAPI: Base de Datos, Modularización y Deploy a Producción
* [x] Curso Django Básico 
* [x] Curso de Django Intermedio: Testing, Static Files, Django Admin


## `Desarrollo de Software`

* [x] Curso Básico de Programación
* [ ] Fundamentos de Ingeniería de Software
* [ ] Curso de Expresiones Regulares
* [x] Curso Profesional de Git y GitHub
* [x] Introducción a la Terminal y Línea de Comandos
* [x] Programación Orientada a Objetos POO
* [ ] Curso de Buenas Prácticas para Escritura de Código
* [ ] Fundamentos de Arquitectura de Software
* [ ] Curso Profesional de Arquitectura de Software
* [ ] Fundamentos de Arquitectura de Alta Concurrencia

## `Desarrollo Web`

* [x] Curso Definitivo de HTML y CSS

## `English`

* [x] Ruta de Beginner A1-A2
* [x] Intermediate B1

</br>

## Comments:
* If a course doesn't have a check it's because I didn't take it but I will soon
* I will be a backend engineer and machine learning enginer, so it's probably I won't take all the courses from web developer
* Platzi create and updates courses, roads and schools, so I will use my knowledge to sort courses as you saw above. 
    * set of courses -> roads
    * set of roads -> Schools
* I'm not sure if my certificates have to be in this repository, but they are till someone makes a complaint. however, it's not a crime to show certificates but they use space in this repo. maybe it will be removed

</br>

<div align="center">
<img src="https://pbs.twimg.com/media/DsD-ttxWsAAye1s.png" width="200">

</br>

<p style="color:green; font-size:130%;">
Made with ♥ by 
<a href="https://www.dropbox.com/s/8u1sw03d4y001dc/JOel%20barrantes%20palacios.pdf?dl=0" download="acero.pdf" >Joel Barrantes</a>
</p>
</div>


