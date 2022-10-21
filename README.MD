
# Platzi Course Resources

<img src="https://static.platzi.com/static/images/footer/logo.png">

## Overview

All the courses which appear here is what I have taken in [**platzi.com**](platzi.com) and I own all the files except the files inside folders named **shared**, with much pleasure Fork and download all my sources if you like it and if you want to improve this repo just make a Pull request 😀.

## Architecture

Each School and Course has a Pattern

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

## Base de Datos

* [x] Fundamentos de Bases de Datos
* [ ] Curso de PostgreSQL

## Data Science

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

## Desarrollo Backend con C# y .NET

* [x] Curso de Introducción a C#
* [x] Curso de C# con .Net Core
* [ ] Curso de C# con .Net Core 2
* [x] Fundamentos de Entity Framework
* [x] API con .NET
* [ ] ASP.NET Core
* [ ] Desarrollo Web con Blazor y .Net
* [ ] Curso de Xamarin.Forms
* [ ] Web Apps y Logic Apps en Azure
* [ ] Azure DevOps: Flujos de CI/CD

## Desarrollo Backend con Python y Django

* [x] Comprehensions, Funciones y Manejo de Errores (just exam)
* [x] Introducción al Pensamiento Computacional con Python
* [x] Introducción al Desarrollo Backend
* [ ] Django Básico
* [ ] POO y Algoritmos con Python

## Desarrollo de Software

* [x] Curso Básico de Programación
* [ ] Fundamentos de Ingeniería de Software
* [x] Curso Profesional de Git y GitHub
* [x] Introducción a la Terminal y Línea de Comandos
* [x] Programación Orientada a Objetos POO
* [ ] Curso de Buenas Prácticas para Escritura de Código
* [ ] Curso Profesional de Arquitectura de Software
* [ ] Fundamentos de Arquitectura de Software

## Desarrollo Web

* [x] Curso Definitivo de HTML y CSS
* [ ] JavaScript Básico

<img src="https://media4.giphy.com/media/YnS7j9pwnECXLMrI4t/giphy.gif?cid=790b7611bcac33f8180fa033a644a3a80b8c473654503079&rid=giphy.gif&ct=s">