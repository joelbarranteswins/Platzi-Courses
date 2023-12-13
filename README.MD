
# Platzi Course Resources

<img src="https://static.platzi.com/static/images/footer/logo.png">

## `Overview`

This repository contains all the courses I have taken on [**platzi.com**](https://platzi.com), and I own all the files, except for those inside the "shared" folders. If you find this repository helpful, please give it a star. If you'd like to contribute, feel free to fork the repository and make a pull request. I welcome any improvements you might have. Thank you! 😀


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

## `Bases de Datos` :sunglasses: (Studying)

- [x] Fundamentos de Bases de Datos
- [ ] Curso de MySQL y MariaDB
- [ ] Curso Práctico de SQL y MySQL
- [ ] Curso de PostgreSQL
- [ ] Curso Práctico de SQL
- [ ] Curso de Optimización de Bases de Datos en SQL Server
- [ ] Nuevo Curso de Introducción a MongoDB
- [ ] Curso de Modelamiento de Datos en MongoDB
- [ ] Curso de Introducción a Elasticsearch


## `Data Science`

- [x] DataAcademy
- [x] Cómo y Por Qué Aprender Data Science e Inteligencia Artificial
- [x] Analisis de negocios para ciencia de datos
- [x] Python Básico
- [x] Excel Básico
- [x] Entorno Trabajo Ciencia de Datos
- [x] Curso Practico de Regresion Lineal Simple
- [x] Curso Profesional de Python
- [x] Business Intelligence - Utilidad y Areas de oportunidad
- [x] Manipulación y Análisis de Datos con Pandas y Python
- [x] Manipulación y Transformación de Datos con Pandas y NumPy
- [x] Visualización de Datos con Matplotlib y Seaborn
- [x] Funciones Matemáticas para Data Science e Inteligencia Artificial
- [x] Matemáticas para Data Science - Estadística Descriptiva
- [x] Matemáticas para Data Science - Probabilidad
- [x] Ética y Manejo de Datos para Data Science e Inteligencia Artificial


## `Desarrollo Backend`

- [x] Curso de Introducción al Desarrollo Backend
- [x] Curso Práctico de Arquitectura Backend


## `Desarrollo Backend con C# y .NET` :white_check_mark: (Completed)

- [x] Curso de Introducción a C#
- [x] Curso Básico de Programación con C#
- [x] Curso de Programación Orientada a Objetos con C#
- [x] Curso de Fundamentos de .NET
- [x] Curso de C# con .Net Core
- [x] Curso de Buenas Prácticas y Código Limpio en C#
- [x] Curso de Principios SOLID en C# y .NET
- [x] Fundamentos de Entity Framework
- [x] APIs con .NET
- [x] Manejo de Datos con LINQ
- [x] Curso de Unit Testing con C# y .NET
- [x] Curso de Aplicaciones Web con Blazor WebAssembly y .NET
- [x] Curso de Azure DevOps: Flujos de CI y CD
*
    ### Extras ASP.NET
    - [ ] Curso de ASP.NET Core
    - [ ] Curso de Desarrollo Web con Blazor y .Net Core 3 
    - [ ] Curso de Web Apps y Logic Apps en Azure
*
    ### Extras Multiplataforma
    - [ ] Curso de .NET MAUI: Fundamentos de Interfaces Gráficas
    - [ ] Curso de .NET MAUI: Manejo del XAML
    - [ ] Laboratorio de .NET MAUI: Interfaz de una App de Reservas


## `Desarrollo Backend con GO`

- [x] Curso Básico de Programación en Go
- [ ] Curso Práctico de Go: Creación de un Servidor Web


## `Desarrollo backend con Java`
- [x] Curso de Introducción a Java SE
- [ ] Curso de Java SE Orientado a Objetos
- [ ] Curso de Java SE Persistencia de Datos
- [ ] Curso Básico de Testing en Java
- [ ] Curso de Programación Funcional con Java SE
- [ ] Curso de Java Spring
- [ ] Curso de Java - Backend con Spring Boot
- [ ] Curso Avanzado de Java SE


## `Desarrollo backend con JavaScript`



## `Desarrollo Backend con Python` :white_check_mark: (Completed)

- [x] Fundamentos de Python
- [x] Comprehensions, Funciones y Manejo de Errores
- [x] Introducción al Pensamiento Computacional con Python
- [x] PIP y Entornos Virtuales
- [x] Estructuras de Datos Lineales con Python
- [x] Estadística Computacional con Python
- [x] POO y Algoritmos con Python
- [x] Introducción al Desarrollo Backend
- [x] Curso Práctico de Python: Creación de un CRUD
- [x] Curso de FastAPI: Fundamentos, Path Operations y Validaciones
- [x] Curso de FastAPI: Modularización, Datos Avanzados y Errores
- [x] Curso de FastAPI: Base de Datos, Modularización y Deploy a Producción
- [x] Curso Django Básico 
- [x] Curso de Django Intermedio: Testing, Static Files, Django Admin


## `Desarrollo de Software` :sunglasses: (Studying)

- [x] Curso Básico de Programación
- [ ] Fundamentos de Ingeniería de Software
- [ ] Curso de Expresiones Regulares
- [x] Curso Profesional de Git y GitHub
- [x] Introducción a la Terminal y Línea de Comandos
- [x] Programación Orientada a Objetos POO
- [ ] Curso de Buenas Prácticas para Escritura de Código
- [ ] Fundamentos de Arquitectura de Software
- [ ] Curso Profesional de Arquitectura de Software
- [ ] Fundamentos de Arquitectura de Alta Concurrencia


## `Desarrollo Web`


## `Desarrollo con JavaScript`

- [x] Curso Básico de JavaScript
- [x] Curso Práctico de JavaScript
- [x] Curso de ECMAScript: Historia y Versiones de JavaScript
- [x] Curso de Asincronismo con JavaScript
- [x] Curso de NPM: Gestión de Paquetes y Dependencias en JavaScript
*
    ### Librerías y Dependencias de JavaScript con NPM

## `Desarrollo Frontend`


## `Desarrollo Frontend con HTML y CSS`

- [x] Curso de Frontend Developer
- [x] Curso Práctico de Frontend Developer
- [x] Curso Definitivo de HTML y CSS

## `Desarrollo Frontend con React.js`

- [x] Curso de React.js

## `Herramientas de IA`

- [x] Curso de Inglés para el Uso de Herramientas de Inteligencia Artificial
- [x] Curso de Inteligencia Artificial - ChatGPT, DALL-E y Hugging Face
- [ ] Curso de Generación de Imágenes con IA - Dall-E, Midjourney y Stable Diffusion
- [ ] Taller de Creación de Contenido con Inteligencia Artificial
- [ ] Desafío IA - Crea videos y animaciones con herramientas avanzadas de IA
- [ ] Curso de Experimentación en Machine Learning con Hugging Face
- [ ] Curso de Transfer Learning con Hugging Face
- [ ] Curso de Inteligencia Artificial aplicada a Product Design


## `Ingles`
- [x] Ruta de Beginner A1-A2
- [x] Intermediate B1


## `Metodologías Ágiles`
- [x] Curso Profesional de Scrum
- [ ] Curso de Scrum Master
- [x] Curso de Historias de Usuario en Scrum
- [ ] Curso de Fundamentos de Product Owner
- [ ] Curso de Herramientas y Frameworks Intermedias para Product Owners


## `Perfil Profesional`
- [x] Creación de Portafolio y CV
- [x] Curso de Creación de CV
- [x] Optimización del Perfil de LinkedIn
- [x] Curso de Networking Efectivo
- [x] Optimización del Perfil Profesional
- [ ] Curso para ser Freelance Profesional
- [ ] Diseño y Desarrollo de Plan de Carrera


## `Productividad y Bienestar`

- [ ] Audiocurso - Duerme Mejor y Logra un Sueño Reparador


## `Technical Writing`

- [x] Curso de Introducción al Technical Writing y Documentación de Código

</br>

## Important Considerations:
- If a course doesn't have a checkmark, it's because I haven't taken it yet, but I plan to soon.
- Although my focus is on becoming a backend and machine learning engineer, I may not take all of the web development courses.
- Platzi frequently creates and updates courses, paths, and schools, and I will use my knowledge to organize the courses as shown below:
    - Sets of courses -> Paths
    - Sets of paths -> Schools
- Please note that if you fork this repository, it is recommended that you do so for the purpose of making a pull request. If you fork for any other reason, you may not have access to new commits. To receive updates, please star this repository.


</br>

<div align="center">
<img src="https://pbs.twimg.com/media/DsD-ttxWsAAye1s.png" width="200">

</br>

<p style="color:green; font-size:130%;">
Made with ♥ by <a href="https://github.com/joelbarranteswins"><b>Joel Barrantes</b></a>
</p>
</div>


