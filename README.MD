
# Platzi Course Resources

<img src="https://static.platzi.com/static/images/footer/logo.png"/>

## Overview

All the courses which appear here is what I have taken in [**platzi.com**](platzi.com) and I own all the files except the files inside folders named **shared**, with much pleasure Fork and download all my sources if you like it and if you want to improve this repo just make a Pull request 😀.

## architecture

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
                [*] --> imgs: (folder)
                [*] --> shared: (folder)
                [*] --> README.MD:(file Abstract)
            }
        }
    }
~~~


## Base de Datos

1. [Fundamentos de Bases de Datos](https://github.com/joelbarranteswins/Platzi-Courses/tree/main/Base%20de%20datos/1%20Fundamento%20de%20bases%20de%20datos)

## Data Science

## Desarrollo Backend con C# y .NET

## Desarrollo Backend con Python y Django

## Desarrollo Backend con Python y Django

## Desarrollo de Software

## Desarrollo Web