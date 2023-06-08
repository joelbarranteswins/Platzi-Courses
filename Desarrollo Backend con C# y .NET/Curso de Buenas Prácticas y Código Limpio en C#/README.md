
# Curso de Buenas Prácticas y Código Limpio en C#


## 1. PreRequisitos 

* Conocimiento en C# y .NET

* Conocimiento de Git

* Visual Code o Visual Studio

* .NET 6 o superior


## 2. Terminologia

- Buenas practicas

    Conjunto de estandares comprobados y verificados que brindan guias faciles de aprender y comprender , permitiendo tener una estructura similar para multiples proyesctos.

- Codigo Limpio

    Es un codigo que sigue buenas practicas, es facil de entender, analizar, mantener, actualizar y escalar.

    ¿Como se logra?
        Utilizar una sintaxis simple y moderna.
        Mantener bajo acoplamiento.
        Evitar el uso de muchas librerias de terceros.
        Distribuir las responsabilidades.
        Crear componentes pequeños.

- Deuda tecnica

    Son problemas tecnicos que ocurren durante la fase de desarrollo del software, dichos problemas deben ser arreglados si o si en el futuro.

    Ejemplos:
        Mejorar la seguridad
        Mejorar el rendimiento

- Refactoring

    Proceso que se realiza al codigo para mejorar cualquier aspecto ya sea de seguridad, rendimiento, legibilidad, soporte, etc…

    * Los cambios que se realizen deben ser recurrentes disminuyendo la deuda tecnica, ademas, no deben afectar al cliente/negocio, puesto que el objetivo de esto no es hacer un cambio radical en el software.



## 3. Nombramientos

Variables:
~~~
//Mal:
int d;

//Bien:
int daySinceModification;
~~~

Método
~~~
//Mal:
public List<Users> getUsers( )

//Bien:
public List<Users> GetActiveUsers( )
~~~

Clases

~~~
//Mal:
public class ClassUser2

//Bien:
public class User
~~~

## 4. Code smell

Sensación de que algo va mal con el código al percibir algunos indicadores de posibles errores. A veces estos errores pueden ser indicaciones de mala calidad del código, pero, esto que a simple vista se ve como “mal, feo, o raro”, en muchas ocasiones puede ser causante de problemas más profundos de funcionamiento en el código del programa o aplicación, lo que conllevaría una refactorización o incluso una reescritura del código para lograr un código limpio y su mejor funcionamiento.
Algunos ejemplos de code smell:

    Variables, métodos o clases con nombres poco descriptivos.
    Métodos y clases de muchísimas líneas que se vuelven difíciles o tediosos de entender. Esto es un indicativo de que las funcionalidades que contienen se pueden separar en pequeñas partes y así poder dividir las responsabilidades en clases y metodos mas pequeños y entendibles.
    Métodos o funciones que reciben demasiados parámetros, lo que indica que hay mucha lógica dentro de esa función.
    Utilización de “Números mágicos” o “quemados”, esto se refiere a números fijos que utilizamos dentro de la lógica de nuestro código y que puede causar que a primera vista no se entienda cuál es su función dentro del mismo y se requiera de más tiempo para comprender lo que hacen.

### Tipos de code smell:

Para considerar los diferentes code smells, hay que distinguir entre los niveles de abstracción del código:

* Code smells de forma general
* Code smells a nivel de función
* Code smells a nivel de clase
* Code smells a nivel de la aplicación

Para complementar la información sobre los tipos de code smell les recomiendo la lectura de este artículo: Code smell explicado de forma sencilla


## 5. Principio DRY

DRY: Don’t Repeat Yourself (No te repitas) .

El objetivo de este principio es evitar la duplicación de partes de código en nuestro código. Andy Hunt y Dave Thomas formularon en su libro «The Pragmatic Programmer: From Journeyman to Master» el siguiente principio:

    «Every piece of knowledge must have a single, unambiguous, authoritative representation within a system»

Que en español se traduciría como:

    «Cada pieza de conocimiento debe tener una única representación autorizada, sin ambigüedades, dentro de un sistema».

El código duplicado no siempre es fácil de reconocer o para poder eliminarlo puede que resulte más compleja la solución. una regla de oro en el refactoring es la Regla de tres: repetir una vez el mismo código puede ser aceptable, pero la tercera vez que utilizamos el mismo código, es señal inequívoca de que hay que refactorizar y solucionar la duplicación.


## 6. KISS

KISS: es un acrónimo de Keep It Simple Stupid o Keep It Short and Simple y a rasgos generales se puede traducir como Mantenlo simple!.

Este principio establece que la mayoría de sistemas funcionan mejor si se mantienen simples o sencillos a diferencia de aquellos que se hacen complejos de manera innecesaria. Es decir, que desde el incio del proyecto la sencillez tiene que ser una meta en el desarrollo y que la complejidad innecesaria debe ser eliminada cada vez que sea detectada. Muchas veces esta complejidad ocurre cuando se diseñan grandes soluciones para objetivos simples.

    Tratemos de utilizar la mejor solución dependiendo de la complejidad de lo que estemos trabajando. Cuando algo es muy complejo o muy grande, es recomendable buscar soluciones más complejas o avanzadas que se ajusten, pero si algo es más simple, pequeño o sencillo, lo ideal es darle una solución acorde a sus características.

Es bueno tener presente que:

    Si ya no comprendes tu propio código después de un breve período de tiempo, las campanas de alarma deberían sonar. Porque cuanto más complicado es o se presenta, más difícil es para todos los involucrados trabajar con él.

Algunos ejemplos de complejidad innecesaria son:

    Incluir bibliotecas enormes en el proyecto cuando solo se necesitan un par de funciones de ellas.
    Abstracción excesiva en el código.
    Funciones que resultan enormes por por la lógica que contienen.
    Anidación de condicionales que solo cumplen una función.


## 7. Evolución de C#

* https://dev.to/mteheran/c-evolution-3o9o
* https://learn.microsoft.com/es-es/dotnet/csharp/whats-new/csharp-version-history

## 8. Interpolación de cadenas, inicializador de propiedades y operador condicional null

* Interpolación de cadenas: La interpolación de cadenas es una forma conveniente de combinar variables y cadenas de texto en un solo valor. En lugar de concatenar manualmente las cadenas, puedes incluir variables dentro de una cadena utilizando llaves {} y el símbolo de dólar $ al principio. Al evaluar la cadena, el valor de la variable se insertará en su lugar. Aquí tienes un ejemplo de cómo se vería en código:

~~~csharp
string nombre = "Juan";
int edad = 25;
string saludo = $"Hola, mi nombre es {nombre} y tengo {edad} años.";
Console.WriteLine(saludo);

//La salida sería: Hola, mi nombre es Juan y tengo 25 años.
~~~

* Inicializador de propiedades: En algunos lenguajes de programación, como C#, puedes inicializar las propiedades de una clase directamente en la declaración de la propiedad, en lugar de hacerlo en el constructor. Esto permite establecer un valor predeterminado para la propiedad sin la necesidad de escribir un constructor personalizado. Aquí tienes un ejemplo en código:

~~~csharp

public class Persona
{
    public string Nombre { get; set; } = "Juan";
    public int Edad { get; set; } = 25;
}

// Uso de la clase Persona
Persona persona = new Persona();
Console.WriteLine(persona.Nombre); // Imprime "Juan"
Console.WriteLine(persona.Edad);   // Imprime 25
~~~

* Operador condicional null: El operador condicional null, también conocido como el operador de fusión null, es utilizado en algunos lenguajes de programación, como C#, para proporcionar un valor predeterminado en caso de que una expresión sea nula. Permite simplificar la verificación de nulos y proporcionar una sintaxis más concisa. Aquí tienes un ejemplo en código:

~~~csharp

void ShowMenuTaskList()
{
    if (TaskList?.Count > 0)
    {
        ShowTaskList();
    } 
    else
    {
        Console.WriteLine("No hay tareas por realizar");
    }
}
~~~


## 9. Implementando minimalismo

* se puede agregar lo siguiente para no tener que impotar librerias y nos permita usar codigo top-level-statement
~~~xml
  <PropertyGroup>
    <TargetFramework>net7.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>
~~~


## 10. Uso de comentarios

