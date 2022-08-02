
# Platzi Course Resources

<img src="https://static.platzi.com/static/images/footer/logo.png">

## Overview

All the courses which appear here is what I have taken in [**platzi.com**](platzi.com) and I own all the files except the files inside folders named **shared**, with much pleasure Fork and download all my sources if you like it and if you want to improve this repo just make a Pull request 😀.

## Architecture

Each School and Course has a Pattern

~~~mermaid
stateDiagram-v2
    state Home {
        [*] --> School
        state School {
            [*] --> Course 
            state Course {
                [*] --> exam : (folder)
                [*] --> exercise: (folder)
                exercise --> scripts
                [*] --> imgs: (folder)
                [*] --> shared: (folder)
                [*] --> README:(summary file)
            }
        }
    }
~~~

## Base de Datos

* [Fundamentos de Bases de Datos](https://github.com/joelbarranteswins/Platzi-Courses/tree/main/Base%20de%20datos/1%20Fundamento%20de%20bases%20de%20datos)
* [x] Curso de PostgreSQL

## Data Science

* DataAcademy
* Cómo y Por Qué Aprender Data Science e Inteligencia Artificial
* Analisis de negocios para ciencia de datos
* Básico de Python
* Excel Básico
* Entorno Trabajo Ciencia de Datos
* Curso Practico de Regresion Lineal Simple
* Curso Profesional de Python
* Business Intelligence - Utilidad y Areas de oportunidad
* Manipulación y Análisis de Datos con Pandas y Python
* Manipulación y Transformación de Datos con Pandas y NumPy
* Visualización de Datos con Matplotlib y Seaborn
* Funciones Matemáticas para Data Science e Inteligencia Artificial
* Matemáticas para Data Science - Estadística Descriptiva
* Matemáticas para Data Science - Probabilidad

## Desarrollo Backend con C# y .NET

* Curso de Introducción a C#
* Curso de C# con .Net Core
* [x] Curso de C# con .Net Core 2
* Fundamentos de Entity Framework
* [x] API con .NET
* [x] ASP.NET Core
* [x] Desarrollo Web con Blazor y .Net
* [x] Curso de Xamarin.Forms

## Desarrollo Backend con Python y Django

* Introducción al Pensamiento Computacional con Python
* Introducción al Desarrollo Backend
* [x] Django Básico
* [x] POO y Algoritmos con Python

## Desarrollo de Software

* [x] Fundamentos de Ingeniería de Software
* Curso Profesional de Git y GitHub
* Introducción a la Terminal y Línea de Comandos
* Programación Orientada a Objetos POO
* [x] Curso de Buenas Prácticas para Escritura de Código
* [x] Curso Profesional de Arquitectura de Software
* [x] Fundamentos de Arquitectura de Software

## Desarrollo Web

* Curso Definitivo de HTML y CSS
* [x] JavaScript Básico

<img src="https://media4.giphy.com/media/YnS7j9pwnECXLMrI4t/giphy.gif?cid=790b7611bcac33f8180fa033a644a3a80b8c473654503079&rid=giphy.gif&ct=s">