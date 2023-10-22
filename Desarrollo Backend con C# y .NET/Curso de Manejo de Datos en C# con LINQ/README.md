
# Curso de Manejo de Datos en C# con LINQ


## ¿Qué es LINQ?

Es una librería creada en el 2017 que se utiliza en el desarrollo con varios lenguajes. En este caso se va abordar su uso en el framework .NET.

* Las siglas de LINQ significan Language Integrated Query. Como sus siglas lo dicen, es una librería para trabajar con consultas a colecciones.
* Existen dos formas de utilizar link, la primera es query expression, esta modalidad permite usar sentencias sql dentro del lenguaje de programación. La segunda forma de trabajar con LINQ es con métodos de extensión, estos proveen de un conjunto de funciones que permiten realizar consultas a través de ellas en lugar de usar sintaxis de SQL.

¿Qué no es LINQ?

* No es un lenguaje de programación
* No es un componente de SQL
* No es un componente de base de datos
* No es una librería de terceros.


~~~csharp
var unTomate = from t in ArraydeStrings
                       where t == "Tomate"
                       select t;
ArraydeStrings.Where(t=> t == "Tomate")
~~~


## Programación declarativa vs. imperativa

### Comparativa

**Programacion Declarativa**

* Paradigama de programacion
* instruciones donde especifico lo que quiero y no como lo quiero
* contraciposion de a la programacion impertariva
* fiable y simple

Nota : La programación declarativa utiliza funciones predefinidas para acciones específicas y puede ayudar a reducir el código. Es importante comprender el propósito de cada función para usarlas eficientemente. El uso excesivo de métodos puede complicar la comprensión del código. Personalmente, prefiero evitar la complejidad que genera utilizar múltiples métodos simultáneamente.

**Programacion Imperativa**
* Paradigama de programacion
* Secuencia de paso a paso de intrucciones
* Contraposicion a la programacion declarativa
* Codigo mas extenso mas facil de interpretar

Nota : la programacion imperativa debemos programar paso a paso lo que queremos hacer, tiene sus ventajas es mas facil de compreder al mometo debuguearlo, pero puede se mucho extenso.

Ejemplos:

Ejemplo JavaScript

~~~javascript
//Declarativo
const array1 = [1,2,3,4,5];
array1.forEach(element => console.log(element))

//Imperativo
const array1 = [1,2,3,4,5];
for (let i = 0; i < array1.length; i++)
{
    console.log(array1[i])
}
~~~

Ejemplo C#

~~~csharp
//Declarativo
var listOfNumbers = new int[] {1,2,3,4,5};
var item1 = listOfNumbers.FirstOrDefault(p => p == 1)
Console.Writeline(item1)

//Imperativo
var listOfNumbers = new int[] {1,2,3,4,5};
for (int i = 0; i < listOfNumbers.length; i++)
{
    if(listOfNumbers[i] == 1) 
        Console.WriteLine(listOfNumbers[i]);
} 
~~~



## Creando el proyecto base

Una de forma de agregar archivos externos como el "books.json" al proyecto es agregando lo siguiente en el csproj.

~~~cs
<ItemGroup>
    <Content Include="books.json" />
</ItemGroup>
~~~



## Configurando clases

En el archivo .csproj es posible que tengan la siguiente configuración:

~~~cs
<Nullable>enable</Nullable>
~~~


En algunas propiedades de la clase Book.cs aparecerá este warning:

* CS8618 - Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.

Puedes deshabilitar esa configuración haciendo lo siguiente en el csproj:

~~~cs
<Nullable>disable</Nullable>
~~~


## Links Adicionales

* https://www.tutorialsteacher.com/linq