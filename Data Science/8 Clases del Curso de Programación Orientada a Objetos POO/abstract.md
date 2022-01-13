# Clases del Curso de Programación Orientada a Objetos: POO

- Indice

# Bienvenida e Introducción

## ¿Por qué aprender Programación Orientada a Objetos?

- **Vas a programar más rápido**. Tener un análisis previo de lo que estás realizando te ayudará a generar código mucho más veloz

- **Dejas de ser Programador Jr**. Podrás responder preguntas como ¿Qué es encapsulamiento?, ¿Qué es Abstracción?, ¿Qué es Herencia?, ¿Qué es Polimorfismo? en futuras entrevistas de trabajo

- **Dejar de Copiar y Pegar Código**.

**La programación orientada a objetos tiene cuatro características principales:**

**Encapsulamiento**

Quiere decir que oculta datos mediante código.

**Abstracción**

Es como se pueden representar los objetos en modo de código.

**Herencia.**

Es donde una clase nueva se crea a partir de una clase existente.

**Polimorfismo**

.Se refiere a la propiedad por la que es posible enviar mensajes sintácticamente iguales a objetos de tipos distintos.

**En este curso, los pasos a seguir será.**

Análisis

- observación
- entendimiento
- lectura

Plasmar

- Diagramar

Programar

- lenguajes de programación

## ¿Qué resuelve la Programación Orientada a Objetos?

> Huecos que la programación estructurada no resuelve, por lo que la estructuración por objetos surgió como una solución.
> 

La programación Orientada a Objetos nace de los problemas creados por la programación estructurada y nos ayuda a resolver cierto problemas como:

- Código muy largo: A medida que un sistema va creciendo y se hace más robusta el código generado se vuelve muy extenso haciéndose difícil de leer, depurar, mantener.

- Si algo falla, todo se rompe: Ya que con la programación estructurada el código se ejecuta secuencialmente al momento de que una de esas líneas fallara todo lo demás deja de funcionar.

- Difícil de mantener.

## Paradigma Orientado a Objetos

La **Programación Orientada a Objetos** viene de una filosofía o forma de pensar que es la **Orientación a Objetos** y esto surge a partir de los problemas que necesitamos plasmar en código. Es analizar un problema en forma de objetos para después llevarlo a código, eso es la **Orientación a Objetos**.

Un **paradigma** es una teoría que suministra la base y modelo para resolver problemas. La paradigma de Programación Orientada a Objetos se compone de 4 elementos:

- Clases

- Propiedades

- Métodos

- Objetos

Y 4 Pilares:

- Encapsulamiento

- Abstracción

- Herencia

- Polimorfismo

## Lenguajes Orientados a Objetos

Algunos de los lenguajes de programación Orientados a Objetos son:

- **Java**:–
    
    Orientado a Objetos naturalmente
    
    Es muy útilizado en Android
    
    Y es usado del lado del servidor o Server Side
    

- **PHP**
    
    Lenguaje interpretado
    
    Pensado para la Web
    

- **Python**
    
    Diseñado para ser fácil de usar
    
    Múltiples usos: Web, Server Side, Análisis de 
    
    Datos, Machine Learning, etc
    

- **Javascript**–
    
    Lenguaje interpretado
    
    Orientado a Objetos pero basado en prototipos
    
    Pensado para la Web
    

- C#

- Ruby
- Kotlin

## Diagramas de Modelado

Nos permiten plasmar de forma gráfica a través de diagramas nuestro análisis. Servirá de intermediario para poder entender el problema y la solución con la orientación a objetos.

- Existen dos herramientas de diagramación:

**OMT** (Object Modeling Techniques)
Es una metodología para el análisis orientado a objetos., sus métodos, sus atributos y cuales son las relaciones que tienen. Pero ya está descontinuada.

**UML** (Unified Modeling Languaje)
Tomó las bases y técnicas de OMT unificándolas. Tenemos más opciones de diagramas como lo son Clases, Casos de Uso, Objetos, Actividades, Iteración, Estados, Implementación

**Un buen desarrollador** debe manejar y dominar con fluidez, conceptos de UML ya que es lo que nos van a entregar cuando empecemos a trabajar en un proyecto que se haya construido bajo la arquitectura POO.

[Object-Oriented Thought Process, The (Developer's Library)](http://amazon.es/Object-Oriented-Thought-Process-Developers-Library/dp/0321861272)

[Online Diagram Software & Visual Solution | Lucidchart](https://www.lucidchart.com/pages/)

[Aprendiendo uml en 24 horas](https://es.slideshare.net/still01/aprendiendo-uml-en-24-horas-16815956)

[StarUML](https://staruml.io/download)

## UML

Es un lenguaje estándar de modelado de sistemas orientados a objetos.

Esto significa que tendremos una manera gráfica de representar una situación, justo como hemos venido viendo. A continuación te voy a presentar los elementos que puedes utilizar para hacer estas representaciones.

## C**lases**

En la parte superior se colocan los atributos o propiedades, y debajo las operaciones de la clase. Notarás que el primer carácter con el que empiezan es un símbolo. Este denotará la visibilidad del atributo o método, esto es un término que tiene que ver con Encapsulamiento y veremos más adelante a detalle.

![https://static.platzi.com/media/user_upload/clase-1897e6cf-84b3-4432-926b-aff4fc4db122.jpg](https://static.platzi.com/media/user_upload/clase-1897e6cf-84b3-4432-926b-aff4fc4db122.jpg)

Estos son los niveles de **visibilidad** que puedes tener:

- **** private**+** public**#** protected**~** default

Una forma de representar las relaciones que tendrá un elemento con otro es a través de las flechas en UML, y aquí tenemos varios tipos, estos son los más comunes:

## Asociación

Como su nombre lo dice, notarás que cada vez que esté referenciada este tipo de flecha significará que ese elemento contiene al otro en su definición. La flecha apuntará hacia la dependencia.

![https://static.platzi.com/media/user_upload/associacion-d2e1b691-b6e9-4854-85e2-d3ffdf0a9049.jpg](https://static.platzi.com/media/user_upload/associacion-d2e1b691-b6e9-4854-85e2-d3ffdf0a9049.jpg)

![https://static.platzi.com/media/user_upload/uml-relacion-asociacion-99b916c6-1f80-4b61-889a-ebf6e74f4f23.jpg](https://static.platzi.com/media/user_upload/uml-relacion-asociacion-99b916c6-1f80-4b61-889a-ebf6e74f4f23.jpg)

Con esto vemos que la ClaseA está asociada y depende de la ClaseB.

## Herencia

Siempre que veamos este tipo de flecha se estará expresando la herencia.La dirección de la flecha irá desde el hijo hasta el padre.

![https://static.platzi.com/media/user_upload/herencia-2eb98d5e-bcad-4162-b236-aa87eba20e76.jpg](https://static.platzi.com/media/user_upload/herencia-2eb98d5e-bcad-4162-b236-aa87eba20e76.jpg)

![https://static.platzi.com/media/user_upload/herencia-clases-53cb3117-def7-433f-adc5-4ad183d6b5e7.jpg](https://static.platzi.com/media/user_upload/herencia-clases-53cb3117-def7-433f-adc5-4ad183d6b5e7.jpg)

Con esto vemos que la ClaseB hereda de la ClaseA

## Agregación

Este se parece a la asociación en que un elemento dependerá del otro, pero en este caso será: Un elemento dependerá de muchos otros. Aquí tomamos como referencia la multiplicidad del elemento. Lo que comúnmente conocerías en Bases de Datos como Relaciones uno a muchos.

![https://static.platzi.com/media/user_upload/agregacion-6489d946-cc06-4e3c-a976-f6435531b4f2.jpg](https://static.platzi.com/media/user_upload/agregacion-6489d946-cc06-4e3c-a976-f6435531b4f2.jpg)

![https://static.platzi.com/media/user_upload/uml-relacion-agregacion-adb20be8-d6c2-41d1-b002-2cfa37639240.jpg](https://static.platzi.com/media/user_upload/uml-relacion-agregacion-adb20be8-d6c2-41d1-b002-2cfa37639240.jpg)

Con esto decimos que la ClaseA contiene varios elementos de la ClaseB. Estos últimos son comúnmente representados con listas o colecciones de datos.

## Composición

Este es similar al anterior solo que su relación es totalmente compenetrada de tal modo que conceptualmente una de estas clases no podría vivir si no existiera la otra.

![https://static.platzi.com/media/user_upload/composicion-1da1dd19-6925-42d9-9727-7fd8cb031b0c.jpg](https://static.platzi.com/media/user_upload/composicion-1da1dd19-6925-42d9-9727-7fd8cb031b0c.jpg)

![https://static.platzi.com/media/user_upload/uml-relacion-composicion-2d4cb1fa-5422-44e3-849b-3a3e2d276733.jpg](https://static.platzi.com/media/user_upload/uml-relacion-composicion-2d4cb1fa-5422-44e3-849b-3a3e2d276733.jpg)

Con esto terminamos nuestro primer módulo. Vamos al siguiente para entender cómo podemos hacer un análisis y utilizar estos elementos para construir nuestro diagrama de clases de Uber.

![src/Untitled.png](src/Untitled.png)

En la **composición**, el elemento ***Tree*** depende completamente del elemento ***Leaf*** , siendo el caso de que si el elemento ***Leaf*** desapareciera también lo haría el elemento ***Tree***.

Mientras que en la **agregación** si el elemento ***Book*** desaparece, o se vuelve 0, el elemento ***Book** **Shop*** no lo haría.

# Orientación a Objetos

## Objetos

Los Objetos son aquellos que tienen propiedades y comportamientos, también serán sustantivos. Pueden ser:

Físicos 

o

Conceptuales

Las **Propiedades** también pueden llamarse atributos y estos también serán sustantivos. Algunos atributos o propiedades son nombre, tamaño, forma, estado, etc. Son todas las características del objeto.

Los **Comportamientos** serán todas las operaciones que el objeto puede hacer, suelen ser verbos o sustantivos y verbo. Algunos ejemplos pueden ser que el usuario pueda hacer login y logout.

## Abstracción y Clases

Una **Clase** es el modelo por el cual nuestros objetos se van a construir y nos van a permitir generar más objetos.

Analizamos Objetos para crear **Clases**. Las **Clases** son los modelos sobres los cuales construiremos nuestros objetos.

> **Abstracción** es cuando separamos los datos de un objeto para generar un molde.
> 

## Modularidad

La **modularidad** va muy relacionada con las clases y es un principio de la Programación Orientado a Objetos y va de la mano con el Diseño Modular que significa dividir un sistema en partes pequeñas y estas serán nuestros módulos pudiendo funcionar de manera independiente.

La **modularidad** de nuestro código nos va a permitir

- Reutilizar
- Evitar colapsos
- Hacer nuestro código más mantenible
- Legibilidad
- Resolución rápida de problemas

Una buena práctica es separando las clases en archivos diferentes.

## Analizando Uber en Objetos

**ANÁLISIS DE LA SITUACIÓN**

Cuando un usuario solicita un servicio de Uber, se da un proceso dividido en 4 momentos o pasos:

**1.** El usuario con su celular solicita el servicio, ya que tiene la necesidad de trasladarse de un punto a otro.

**2.** El usuario solicita el automóvil, especificando qué ruta es la que necesita recorrer.

![src/Untitled%201.png](src/Untitled%201.png)

**3.** La aplicación le muestra al usuario un catálogo de automóviles, de los cuales el usuario puede elegir según su necesidad. Aquí también se muestra al conductor que maneja dicho automóvil.

**4.** El usuario aborda el automóvil y realiza el viaje a la ruta definida en un principio. Al terminar el recorrido el usuario realiza el pago por el viaje realizado.

**OBJETOS QUE SE IDENTIFICAN DESPUÉS DEL ANÁLISIS**

USER: 

El usuario, persona, cliente.

ROUTE: 

Ruta de un punto A al B, tu ruta de traslado.

CONDUCTOR: 

Quien conduce el automóvil Uber.

AUTOMÓVILES:

Uber X

Uber Pool

Uber Black

Uber Van

MÉTODO DE PAGO:

Card

PayPal

Cash

TRIP:

Contiene los datos, como la ruta, automóvil escogido, usuario que solicita el servicio, etc.

## Reto 1: identificando objetos

Ya estás listo para resolver tu primer reto y poner en práctica todo lo que aprendiste para identificar objetos en un problema.

Toma como referencia nuestro Sistema de Adopciones e identifica todos los objetos.

Compártenos tu análisis en la sección de discusiones.

![https://static.platzi.com/media/user_upload/0-40823920-f03b-4276-898b-95385f096cad.jpg](https://static.platzi.com/media/user_upload/0-40823920-f03b-4276-898b-95385f096cad.jpg)

### Abstractas

Animal

Persona

### Clases Concreta

Perro : Animal

Adopción (esta seria conceptual)

Usuario: Persona

Titular: Persona

# Programación Orientada a Objetos. Análisis

## **Clases en UML y su sintaxis en código**

**Clases en UML y su sintaxis en código**

**Recuerda que el proceso es:**

- Identificar el problema, y objetos
- Definir las clases
- Plasmarlas en un diagrama

**Se lo puede plasmar en UML :**

- **Identidad:** que será el nombre de la clase.
- **Estado:** que serán los atributos de la clase.
- **Comportamiento:** que serán las operaciones de la clase.

.

![src/Untitled%202.png](src/Untitled%202.png)

![src/Untitled%203.png](src/Untitled%203.png)

## Modelando nuestros objetos Uber

![src/Untitled%204.png](src/Untitled%204.png)

![src/Untitled%205.png](src/Untitled%205.png)

## ¿Qué es la herencia?

> Cuando detecto características y comportamientos iguales, entonces significa que debo realizar una abstracción.
> 

**Don’t repeat yourself** es una filosofía que promueve la reducción de duplicación en programación, esto nos va a inculcar que no tengamos líneas de código duplicadas.

Toda pieza de información nunca debería ser duplicada debido a que incrementa la dificultad en los cambios y evolución

La **herencia** nos permite crear nuevas clases a partir de otras, se basa en modelos y conceptos de la vida real. También tenemos una jerarquía de **padre e hijo**.

![src/Untitled%206.png](src/Untitled%206.png)

![src/Untitled%207.png](src/Untitled%207.png)

![src/Untitled%208.png](src/Untitled%208.png)

## Aplicando Herencia a nuestro proyecto Uber

![src/Untitled%209.png](src/Untitled%209.png)

![src/Untitled%2010.png](src/Untitled%2010.png)

![src/Untitled%2011.png](src/Untitled%2011.png)

![src/Untitled%2012.png](src/Untitled%2012.png)

## Reto 2: analicemos un problema

![src/Untitled%2013.png](src/Untitled%2013.png)

# Clases, Objetos y Método Constructor

## Definiendo clases en Java y Python

### Java

```java
class Account {
    Integer id;
    String name;
    String document;
    String email;
    String password;
}
```

```java
class Car {
    Integer id;
    String  license;
    String  driver;
    Integer passenger;
}
```

```java
class Main {
    public static void main(String[] args) {
        System.out.println("Hola mundo");
    }
}
```

```java
class Payment {
    Integer id;
}
```

```java
import java.util.ArrayList;

class Route {
    Integer id;
    ArrayList<Double> start;
    ArrayList<Double> end;    
}
```

### Python

```python
class Account:
    id          = int
    name        = str
    document    = str
    email       = str
    password    = str
```

```python
class Car:
    id = int
    license = str
    driver = str
    passegenger = int
```

```python
if __name__ == "__main__":
    print('Hola Mundo')
```

```python
class Payment:
    id = int
```

```python
class Route:
    id      = int
    start   = []
    end     = []
```

## Definiendo Clases en JavaScript

Si estás interesado en aprender JavaScript desde ahora debes saber que el concepto de clases no existía como tal hasta el nuevo estándar EcmaScript 6. El reto de encontrar sistemas construidos con este estándar es alto por esa razón te explicaré cuál fue por mucho tiempo su equivalente.

Los Prototipos fue la forma de crear clases en JavaScript y las representaremos partiendo de la declaración de una función.

Creemos nuestras clases:

- Account
- Car
- Payment
- Route

Para esto crearemos el siguiente sistema de archivos dentro de la carpeta JS de nuestro proyecto:

- Account.js
- Car.js
- Payment.js
- Route.js
- index.js

El archivo index.js será el lugar equivalente al punto de entrada de la aplicación donde estaremos declarando nuestros objetos basado en las clases. Para esta clase lo dejaremos en blanco.

Ahora veamos el código archivo por archivo:

### Account.js

```jsx
function Account () {
    this,id;
    this.name;
    this.document;
    this.email;
    this.password;
}
```

### Car.js

```jsx
function Car () {
    this,id;
    this.license;
    this.driver;
    this.passenger;
}
```

### Payment.js

```jsx
function Payment () {
    this.id;
}
```

### Route.js

```jsx
function Route () {
    this.id;
    this.init;
    this.end;
}
```

Este es el enlace del código del proyecto: [https://github.com/anncode1/Curso-POO-Platzi/tree/f5725787165b36cae579f94e428068039b554b0b/JS](https://github.com/anncode1/Curso-POO-Platzi/tree/f5725787165b36cae579f94e428068039b554b0b/JS)

En este código notarás el uso de la palabra reservada **this**. Normalmente cuando usamos la sintaxis punto siempre lo haremos a partir de un objeto instanciado, en este caso con this, se hace una simulación al objeto en cuestión, a pesar de que en ese momento visualmente sigue siendo una clase.

Digamos que se adelanta un poco al momento de ejecución y visualiza al objeto con sus atributos, más adelante verás la forma en que podemos asignar datos a un atributo del objeto en otros lenguajes y verás que es exactamente la misma sintaxis.

Si intentaramos poner this. en el momento de ejecución nos traería un listado de todos los componentes de la clase que en este caso son solo estos tres: id, init y end.

This hace referencia al objeto instanciado. Para comprender del todo esta última frase mira la siguiente clase donde hablamos de objetos.

## Reto.

En la carpeta de nuestro proyecto PHP declara estas mismas clases: Puedes utilizar esta clase de apoyo: [https://platzi.com/clases/1338-php/12929-programacion-orientada-a-objetos1172/](https://platzi.com/clases/1338-php/12929-programacion-orientada-a-objetos1172/)Inténtalo y compártenos tus resultados, compáralos con tus compañeros.

```php
		<?php
class Account {
public $id;
public $name;
public $document;
public $email;
public $password;
}
?>
```

```php
<?php
class Car {
public $id;
public $license;
public $driver;
public $passenger;
}
?>
```

```php
<?php
class Payment {
public $id;
}
?>

```

```php
<?php
class Route {
public $id;
public $start = [];
public $end = [];
}
?>
```

## Objetos, método constructor y su sintaxis en código

Los **objetos** nos ayudan a crear instancia de una clase, el objeto es el resultado de lo que modelamos, de los parámetros declarados y usaremos los objetos para que nuestras clases cobren vida.

Los **métodos constructores** dan un estado inicial al objeto y podemos añadirle algunos datos al objeto mediante estos métodos. Los atributos o elementos que pasemos a través del constructor serán los datos mínimos que necesita el objeto para que pueda vivir.

## Objetos. Dando vida a nuestras clases en Java y Python

```java
class Main {
    public static void main(String[] args) {
        System.out.println("Hola mundo");
        Car car = new Car();
        car.license = "AA 036 AU";
        car.driver = "Carlos Mazzaroli";
        car.passenger = 4;
        car.printDatacar();

        Car car2 = new Car ();
        car2.license = "1EASD1";
        car2.driver = "Juanito locardo";
        car2.passenger = 3;
        car2.printDatacar();
    }
}
```

```java
class Car {
    Integer id;
    String  license;
    String  driver;
    Integer passenger;

    void printDatacar() {
        System.out.println("License: " + license + "Driver: " + driver);
    }
}
```

```python
from car import Car 

if __name__ == "__main__":
    print('Hola Mundo')
    car = Car()
    car.license = 'AMDASDM2'
    car.driver = 'Carlos'
    print(vars(car))

    car2 = Car()
    car2.license = 'AMDASDaaaaaaaaaaM2'
    car2.driver = 'aaaaaaaaCarlos'
    print(vars(car2))
```

## Declarando un Método Constructor en Java y JavaScript

### Java

```java
class Account {
    Integer id;
    String name;
    String document;
    String email;
    String password;

    public Account(String name, String document){
        this.name = name;
        this.document = document;
    }
}
```

```java
class Car {
    Integer id;
    String license;
    Account driver;
    Integer passegenger;

    public Car(String license, Account driver){
        this.license = license;
        this.driver = driver;
    }

    void printDataCar() {
        System.out.println("License: " + license + " Name Driver: " + driver.name);
    }

}
```

```java
class Main {
    public static void main(String[] args) {
        System.out.println("Hola mundo");
        Car car = new Car("AA 036 AU", new Account("Carlos Bolonegsa", "And123"));
        car.passegenger = 4;
        car.printDataCar();

        Car car2 = new Car("1EASD1", new Account("Juanito locardo", "42987105"));
        car2.passegenger = 3;
        car2.printDataCar();
    }
}
```

### JavaScript

```jsx
function Car(license, driver) {
    this.id;
    this.license = license;
    this.driver = driver;
    this.passenger;
}

Car.prototype.printDataCar = function () {
    console.log(this.driver)
    console.log(this.driver.name)
    console.log(this.driver.document)
}
```

```jsx
var car = new Car("AW456", new Account("Andres Herrera", "QWE234"))
car.passenger = 4;
car.printDataCar();
```

```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Programacion Orientada A Objetos en JavaScript</h1>
</body>
<script src="Account.js"></script>
<script src="Car.js"></script>
<script src="Index.js"></script>
</html>
```

```jsx
var car = new Car("AW123", new Account("Carlos", "42987105"));
car.passenger = 4;
car.printDataCar();
```

## JavaScript orientado a objetos, lo más nuevo

A partir de las nuevas especificaciones del EcmaScript 6 ya podemos declarar una clase con la palabra reservada *class*, aunque es importante aclarar que estos no dejan de ser prototipos, sino todo lo contrario.

Además tendremos una palabra clave para definir un constructor, y dentro de este estarán las propiedades de nuestra clase definidas listas para inicializarse.

Transcribamos el código JavaScript que generamos en la clase anterior a este nuevo estándar.

La clase **Car** quedaría así:

![https://static.platzi.com/media/user_upload/1-66a6be76-e42f-479c-be67-3adc45ccd7db.jpg](https://static.platzi.com/media/user_upload/1-66a6be76-e42f-479c-be67-3adc45ccd7db.jpg)

Si quisiéramos declarar un método, en esta nueva sintaxis dejaremos de utilizar la palabra clave *function*.

Ahora veamos a la clase **Account**:

![https://static.platzi.com/media/user_upload/2-2ccbff18-3961-4b42-89ad-3c232a8f1af4.jpg](https://static.platzi.com/media/user_upload/2-2ccbff18-3961-4b42-89ad-3c232a8f1af4.jpg)

Y para finalizar aquí puedes ver las clases **Route** y **Payment**:

![https://static.platzi.com/media/user_upload/3-e0aac592-7edb-41cf-840f-63628c815201.jpg](https://static.platzi.com/media/user_upload/3-e0aac592-7edb-41cf-840f-63628c815201.jpg)

![https://static.platzi.com/media/user_upload/4-431f9596-35af-4b45-8021-7f0d15258259.jpg](https://static.platzi.com/media/user_upload/4-431f9596-35af-4b45-8021-7f0d15258259.jpg)

Notarás que para instanciar un objeto seguiremos usando la palabra clave *new*.

![https://static.platzi.com/media/user_upload/5-0a9e302c-9376-495e-a2e2-171a1f17f988.jpg](https://static.platzi.com/media/user_upload/5-0a9e302c-9376-495e-a2e2-171a1f17f988.jpg)

Y los resultados serán los mismos:

![https://static.platzi.com/media/user_upload/6-26a92034-dd3b-42a2-94ea-ceaeaf5e1d9f.jpg](https://static.platzi.com/media/user_upload/6-26a92034-dd3b-42a2-94ea-ceaeaf5e1d9f.jpg)

Aquí encuentras el código de este ejercicio: [https://github.com/anncode1/Curso-POO-Platzi/tree/3.1.POOJS](https://github.com/anncode1/Curso-POO-Platzi/tree/3.1.POOJS)

## Declarando un Método Constructor en Python

En Python encontrarás un concepto denominado **Métodos Mágicos**, estos métodos son llamados automática y estrictamente bajo ciertas reglas. El método constructor en Python forma parte de esta familia de métodos y como aprendimos en la clase anterior lo declaramos usando `__init__`, aunque si nos ponemos estrictos este método no construye el objeto en sí. El encargado de hacer esto es `__new__` y el método `__init__` se encargará de personalizar la instanciación de la clase, esto significa que lo que esté dentro de `__init__` será lo primero que se ejecute cuando se cree un objeto de esta clase.

Para nuestro proyecto tenemos la necesidad de que algunas variables se inicialicen obligatoriamente cuando ocurra la instanciación. Así que declaremos el método `__init__` en las clases de nuestro proyecto con las propiedades obligatorias.

Para la clase Account quedaría algo así, notarás que usamos la palabra clave **self**, esta es muy parecida a lo que venimos trabajando a otros lenguajes con **this**. Y como su nombre lo dice hace referencia a los datos que componen la clase, en este caso `self.name` está llamando al atributo name que se encuentra en la línea 3 de la clase y, le está asignando el dato que se pasa en el método `__init__` de la línea 8.

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%201.16.43-c55250b1-a09b-4025-b263-c09ae7364008.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%201.16.43-c55250b1-a09b-4025-b263-c09ae7364008.jpg)

Ahora veamos la clase Car:

![https://static.platzi.com/media/user_upload/imagen-f683eb2d-6a0a-44c7-a32c-92a0cbce962b.jpg](https://static.platzi.com/media/user_upload/imagen-f683eb2d-6a0a-44c7-a32c-92a0cbce962b.jpg)

Lo que notarás de diferente es que cambiamos el tipo de dato de **driver**, ahora es de tipo Account y como ves está solicitando los dos datos obligatorios para instanciar un objeto de este tipo. Esto lo verás más en acción en el próximo fragmento de código del archivo [main.py](http://main.py/). Además, mucho ojo, en la primera línea observamos que es importante importar la clase para poderla usar.

Nuestro archivo [main.py](http://main.py/) ahora se verá así:

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%201.17.11-72be8450-fa7f-4030-9987-ffb098c4d46c.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%201.17.11-72be8450-fa7f-4030-9987-ffb098c4d46c.jpg)

Observa que estamos importando las dos clases que usaremos y las estamos instanciando en los métodos constructores.

Los resultados serán los siguientes:

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%201.14.06-613a190d-a678-490c-a010-81150b4b883f.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%201.14.06-613a190d-a678-490c-a010-81150b4b883f.jpg)

El código de este ejemplo lo encuentras en este enlace:[https://github.com/anncode1/Curso-POO-Platzi/tree/3.2.ConstructorPython](https://github.com/anncode1/Curso-POO-Platzi/tree/3.2.ConstructorPython)

Reto 3.

Ahora que ya viste cómo creamos un método constructor en Python, mira esta clase [https://platzi.com/clases/2034-php-poo/32133-polimorfismo/](https://platzi.com/clases/2034-php-poo/32133-polimorfismo/) y **hazlo también para PHP**. Compártenos tus resultados en la sección de discusiones.

```php
<?php

class Account {
  public $id;
  public $name;
  public $document;
  public $email;
  public $password;

  public function __construct($name, $document) {
    $this->name = $name;
    $this->document = $document;
  }
}
```

```php
<?php

class Car {
  public $id;
  public $license;
  public $driver;
  public $passengers;

  public function __construct($license, $driver) {
    $this->license = $license;
    $this->driver = $driver;
  }

  public function PrintDataCar(){
    echo "license: $this->license, conductor: {$this->driver->name}, document: {$this->driver->document}";
  }
}
```

```php
<?php

require_once('Car.php');
require_once('Account.php');

$car = new Car("AW456", new Account("Andres Herrera", "AMS123"));
$car->printDataCar();
```

# Herencia

## Aplicando herencia en lenguaje Java y PHP

### Java

```java
import java.util.ArrayList;
import java.util.Map;

class UberBlack extends Car {
    Map<String, Map<String,Integer>> typeCarAccepted;
    ArrayList<String> seatsMaterial;

    public UberBlack(String license, Account driver, 
    Map<String, Map<String,Integer>> typeCarAccepted,
    ArrayList<String> seatsMaterial){
        super(license, driver);
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;
    }
}
```

```java
class UberPool extends Car {
    String brand;
    String model;

    public UberPool(String license, Account driver, String brand, String model){
        super(license, driver);
        this.brand = brand;
        this.model = model;

    }
}
```

```java
import java.util.ArrayList;
import java.util.Map;

class UberVan extends Car {
    Map<String, Map<String,Integer>> typeCarAccepted;
    ArrayList<String> seatsMaterial;

    public UberVan(String license, Account driver, 
    Map<String, Map<String,Integer>> typeCarAccepted,
    ArrayList<String> seatsMaterial){
        super(license, driver);
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;
    }
}
```

```java
class UberX extends Car {
    String brand;
    String model;

    public UberX(String license, Account driver, String brand, String model){
        super(license, driver);
        this.brand = brand;
        this.model = model;

    }
}
```

### PHP

```php
<?php
require_once('car.php');
class UberBlack extends Car {
    public $typeCarAccepted;
    public $seatsMaterial;

    public function __construct($license, $driver, $typeCarAccepted, $seatsMaterial){
        parent::__construct($license,$driver);
        $this->typeCarAccepted = $typeCarAccepted;
        $this->seatsMaterial = $seatsMaterial;
    }

}
?>
```

```php
<?php
require_once('car.php');
class UberBlack extends Car {
    public $typeCarAccepted;
    public $seatsMaterial;

    public function __construct($license, $driver, $typeCarAccepted, $seatsMaterial){
        parent::__construct($license,$driver);
        $this->typeCarAccepted = $typeCarAccepted;
        $this->seatsMaterial = $seatsMaterial;
    }

}
?>
```

```php
<?php
require_once('car.php');
class UberX extends Car {
    public $brand;
    public $model;

    public function __construct($license, $driver, $brand, $model){
        parent::__construct($license,$driver);
        $this->brand = $brand;
        $this->model = $model;
    }

}
?>
```

```php
<?php
require_once('car.php');
class UberPool extends Car {
    public $brand;
    public $model;

    public function __construct($license, $driver, $brand, $model){
        parent::__construct($license,$driver);
        $this->brand = $brand;
        $this->model = $model;
    }

}
?>
```

## Solución del reto de herencia en PHP

Si tienes problemas para usar PHP en Visual Studio Code:

1. Instalar Xampp
2. Configurar las variables de entorno:
    - Dentro de la variable Path agregar la ruta C:\xampp\php
3. En visual Studio ir a file->preferences->Settings y buscar “editar desde settings.json” y en este archivo adicionar las siguientes lineas:

```
"php.executablePath": 
"C:/xampp/php/php.exe",
"php.validate.executablePath": 
"C:/xampp/php/php.exe"
```

Aplicando herencia en lenguaje Python y JavaScript

## Python

Recuerdas que en Python la herencia se expresa de manera muy similar a un método constructor de otros lenguajes. Apliquemos herencia para nuestra familia Car, para esto crearemos las siguientes clases:

- [UberX.py](http://uberx.py/)
- [UberPool.py](http://uberpool.py/)
- [UberBlack.py](http://uberblack.py/)
- [UberVan.py](http://ubervan.py/)

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.34.29-529408ac-ff1a-436b-8344-39855722b74f.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.34.29-529408ac-ff1a-436b-8344-39855722b74f.jpg)

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.34.40-78ce47ee-78a5-4762-a637-0f202a92875e.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.34.40-78ce47ee-78a5-4762-a637-0f202a92875e.jpg)

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.34.56-96cc71e3-0b5a-446e-ba9a-645a8e41228c.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.34.56-96cc71e3-0b5a-446e-ba9a-645a8e41228c.jpg)

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.35.10-b9cd1d31-867d-431f-bcef-d5d1ac648a74.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.35.10-b9cd1d31-867d-431f-bcef-d5d1ac648a74.jpg)

El código completo puedes verlo aquí: [https://github.com/anncode1/Curso-POO-Platzi/tree/2cbdf9db470a98323328f8a21bf6a9de941d008e/Python](https://github.com/anncode1/Curso-POO-Platzi/tree/2cbdf9db470a98323328f8a21bf6a9de941d008e/Python)

## JavaScript

En clases anteriores te expliqué cómo ejecutar herencia en estándares anteriores al EcmaScript 6. Uno de los beneficios de utilizar este nuevo estándar que ejecutar herencia es tan simple como utilizar la palabra reservada **extends**.

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.10.32-fde223fb-648d-4607-9ecc-abb90aff4246.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.10.32-fde223fb-648d-4607-9ecc-abb90aff4246.jpg)

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.10.48-2d526a66-e015-461f-8253-ef8a6a4eabd5.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.10.48-2d526a66-e015-461f-8253-ef8a6a4eabd5.jpg)

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.11.01-522ece85-3a5c-44e1-9f69-6070cef7677e.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.11.01-522ece85-3a5c-44e1-9f69-6070cef7677e.jpg)

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.11.18-e0aa5965-0996-43d7-a279-95b9fca40a9b.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.11.18-e0aa5965-0996-43d7-a279-95b9fca40a9b.jpg)

Ahora para utilizar una de las clases y crear un objeto, por ejemplo de UberX, no olvides declarar la clase en el archivo **index.html**.

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.11.34-74307d10-e9a0-4e21-a797-385a71fd16f2.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.11.34-74307d10-e9a0-4e21-a797-385a71fd16f2.jpg)

Nuestro ejemplo se verá así:

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.11.52-12657ec7-3103-4a47-aaef-632b38d1dad2.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%204.11.52-12657ec7-3103-4a47-aaef-632b38d1dad2.jpg)

El código completo puedes verlo aquí: [https://github.com/anncode1/Curso-POO-Platzi/tree/9251101bdc2722ed13f9d93cb432ba8e9aba17b4/JS](https://github.com/anncode1/Curso-POO-Platzi/tree/9251101bdc2722ed13f9d93cb432ba8e9aba17b4/JS)

## Otros tipos de Herencia

A partir de ahora las clases que estén siendo heredades las llamaremos familias.

Acabamos de aplicar herencia a la familia **Car**. Ahora apliquémosla a la familia **Payment**.

En clases anteriores te mencioné que otro punto de partida que puedes tomar para aplicar herencia es del hecho de que hay clases que lógicamente deberían estar en una familia, como es el caso de Payment.

Repasemos el diagrama de Payment

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%2012.21.03-6c3f1263-88f7-44db-a123-ba70c028069c.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%2012.21.03-6c3f1263-88f7-44db-a123-ba70c028069c.jpg)

Notarás que a nivel de código parece inservible pero cuando estemos en el caso de uso Pagar un Viaje, probablemente en ese momento no sabremos cuál es el método de pago, y necesitemos ingresar un dato lo suficientemente genérico que conceptualmente nos dé la información que necesitamos, en este caso que es un Payment. Este es un tipo de Polimorfismo y uno de los principios SOLID del software que obedece a la Inyección de Dependencias. Lo veremos más adelante a detalle.

Ahora nos faltará crear las clases y aplicar su herencia.

![src/Untitled%2014.png](src/Untitled%2014.png)

![https://static.platzi.com/media/user_upload/Paypal-8744983d-6bb2-4c36-bc2b-1463e3cb5da8.jpg](https://static.platzi.com/media/user_upload/Paypal-8744983d-6bb2-4c36-bc2b-1463e3cb5da8.jpg)

![https://static.platzi.com/media/user_upload/Card-93d59d21-ef9a-4e2f-a996-34eb2ac727de.jpg](https://static.platzi.com/media/user_upload/Card-93d59d21-ef9a-4e2f-a996-34eb2ac727de.jpg)

![https://static.platzi.com/media/user_upload/Cash-8982072a-cea4-449a-a1d6-569480e801c7.jpg](https://static.platzi.com/media/user_upload/Cash-8982072a-cea4-449a-a1d6-569480e801c7.jpg)

## Reto 4

Tomando como referencia nuestros diagramas. Plásmala en tu lenguaje de programación favorito.Compártenos tus resultados.

![https://static.platzi.com/media/user_upload/1CBC2F61-08EB-4F0E-AE72-E13356C7E0EE-201e3c36-c34a-47ca-bea7-5bfa9ac10e15.jpg](https://static.platzi.com/media/user_upload/1CBC2F61-08EB-4F0E-AE72-E13356C7E0EE-201e3c36-c34a-47ca-bea7-5bfa9ac10e15.jpg)

```jsx
class Account {

    constructor(name, document, email, password) {
        this.id;
        this.name = name;
        this.document = document;
        this.email = email;
        this.password = password;
    }

    printDataAccount() {
        console.log("The name: " + this.name);
        console.log("The document: " + this.document);
        console.log("The email: " + this.email);
        console.log("The password: " + this.password);
    }

}
```

```jsx
class User extends Account {

    constructor(name, document, email, password) {
        super(name, document, email, password)
    }

}
```

```jsx
class Driver extends Account {

    constructor(name, document, email, password) {
        super(name, document, email, password)
    }

}
```

```jsx
var user = new User("Jose Ramirez", "INE001","jose@mail.com", "mypass");
user.printDataAccount();
```

```jsx
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <h1>Programación Orientada a Objetos en JavaScript</h1>
    
</body>
<script src="Account.js"></script>
<script src="Car.js"></script>
<script src="UberX.js"></script>
<script src="Users.js"></script>
<script src="index.js"></script>
</html>
```

# Encapsulamiento

## Encapsulamiento

El **encapsulamiento** es hacer que un dato sea inviolable, inalterable cuando se le asigne un **modificador de acceso** (no se trata solo de ocultar el dato sino también de protegerlo). Un modificador de acceso define el alcance y visibilidad de un miembro de clase.

La encapsulación es también llamada **ocultamiento de información**.

Algunos beneficios de encapsulación son:

- Controlar la manera en que los datos son accedidos o modificados
- El código es mas flexible y fácil de cambiar a partir de nuevos requerimientos
- Poder modificar una parte del código sin afectar otras partes del mismo
- Ayuda a mantener la integridad de los datos//Nota: esta información la obtuve de la app SoloLearn (en donde puedes aprender diferentes lenguajes de programación).

# Polimorfismo

## Generando polimorfismo en Java

Creo que en este punto hay unos conceptos que se pueden confundir, son en especifico 3:

1. Sobrecarga -> Principalmente con los métodos
2. Sobre-escritura -> Debe haber herencia, Cuando le cambias el comportamiento a un método que definió la super-clase
3. Polimorfismo de Subtipado -> Centrado en usar el mimos nombre de método en diferentes clases, cuando se llamen se ejecutara

Daré unos ejemplos de cada uno con python:

**Sobrecarga**Según algunos autores se le llamaría polimorfismo de sobrecarga, algunos ni si quiera lo llaman polimorfismo así que lo dejare:

```
classpunto:
    # Nótese que no ninguna clase de herencia
def__init__(self, x):
        # Creo cualquier método, en este caso el constructor
        self.x = x

def__init__(self, x, y):
        # Mi primer caso de sobrecarga
        self.x = x
        self.y = y

def__init__(self, x, y, z):
        # Mi segundo caso de sobrecarga
        self.x = x
        self.y = y
        self.z = z

```

Como pueden ver puede ser productivo en algunos casos, pero empieza a ser contraproducente cuando se usa demasiado(en el segundo caso por ejemplo).

**Sobre-Escritura**Un caso puro de polimorfismo, busca alterar el método de la súper-clase, ya que el comportamiento es diferente

```
classAve:
    # Nuestra Super-Clase
def__init__(self, altura_vuelo):
        self.altura_vuelo = altura_vuelo

defaccion_animal(self):
        # Nuestro metodo a sobre-escribir
        # Obvia que todos volaran
        print("El ave volara a una altura {}".format(self.altura_vuelo))

classPingüino(Ave):
    # Clase Hija o Sub-Clase
def__init__(self, altura_vuelo, velocidad_nado):
        # Puse otro parametro para diferenciar un poco el metodo
        super.__init__(self, altura_vuelo) # pongo los metodos de la super-clase
        self.velocidad_nado = velocidad_nado

defaccion_animal(self):
        super.accion_animal()
        # Hagamos que tambien muestre eso
        print("El Ave nadará con una velocidad {}".format(self.velocidad_nado))
        # Tiene Su comportamiento diferente

```

Realmente muy útil, es l a mejor practica ya que la herencia podrá extender el proceso y si se quiere generar una particularidad se hace una clase

**Polimorfismo de sobrecarga**Yo lo llamaría una “mala practica de uso para la sobrecarga”, prefiero usar la herencia y lo sobre-escribo, sin embargo la opción esta ahí

```
classPingüino:
    # No hay ningun clase de herencia
def__init__(self, velocidad_nado, velocidad_correr):
        self.velocidad_nado = velocidad_nado
        self.velocidad_correr = velocidad_correr

defaccion_animal(self):
        # Tengo que definir el mismo nombre
        print("El Ave nadará con una velocidad {} y corre a una velocidad {}".format(self.velocidad_nado, self.velocidad_correr))

classAguila:
    # No hay ninguna clase de herencia
def__init__(self, fuerza_garras, velocidad_vuelo):
        self.velocidad_vuelo = velocidad_vuelo
        self.fuerza_garras = fuerza_garras

defaccion_animal(self):
        # Tengo que definir el mismo nombre
        print("El Ave atacara a su victica con una velocidad de {} y una fuerza de {}".format(self.velocidad_vuelo, self.fuerza_garras))

# Cuando se llame se deberia ejecutar el metodo
aves = [Pingüino("100","120"), Aguila("120","300")] # Numeros hipoteticos
for avein aves:
    ave.accion_animal()

```

Este ultimo me parece algo innecesario pero que también se puede hacer sin necesidad de heredar.

Otra cosa que de pronto se me escapo pero es porque python al ser débilmente tipado puede hacer de forma natural y es el termino llamado **Cohersion**, algo que en Java puede compilarse un poco mas.

```java
<?php
require_once('car.php');
class UberX extends Car {
    public $brand;
    public $model;

    public function __construct($license, $driver, $brand, $model){
        parent::__construct($license,$driver);
        $this->license = $license;
        $this->driver = $driver;
        $this->brand = $brand;
        $this->model = $model;
    }

    public function PrintDataCar(){
        parent::PrintDataCar();
        echo" 
        Modelo: $this->model
        Marca: $this->brand 
        ";
      }
}
?>
```

# Cierre del curso

## El Diagrama UML de Uber

Este es el diagrama que finalmente obtuvimos, aquí solo faltaría añadirle los atributos que posee cada clase.

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.20.10-075bf981-504e-46b5-acb5-3d9bc67e8ea5.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-21%20a%20la%28s%29%203.20.10-075bf981-504e-46b5-acb5-3d9bc67e8ea5.jpg)

Recopilemos todo lo que hemos aprendido para explicar los últimos detalles.

En primer lugar notarás que tenemos 3 tipos de flechas:

## Asociación

![https://static.platzi.com/media/user_upload/associacion-d2e1b691-b6e9-4854-85e2-d3ffdf0a9049.jpg](https://static.platzi.com/media/user_upload/associacion-d2e1b691-b6e9-4854-85e2-d3ffdf0a9049.jpg)

Como su nombre lo dice, notarás que cada vez que esté referenciada este tipo de flecha significará que ese elemento contiene al otro en su definición. Si recuerdas la clase Car, este contenía una instancia de Driver. La flecha apuntará hacia la dependencia.

![https://static.platzi.com/media/user_upload/car-driver-204d198e-60fa-4c57-a0d0-0668c0e011d7.jpg](https://static.platzi.com/media/user_upload/car-driver-204d198e-60fa-4c57-a0d0-0668c0e011d7.jpg)

## Herencia

![https://static.platzi.com/media/user_upload/herencia-2eb98d5e-bcad-4162-b236-aa87eba20e76.jpg](https://static.platzi.com/media/user_upload/herencia-2eb98d5e-bcad-4162-b236-aa87eba20e76.jpg)

Siempre que veamos este tipo de flecha se estará expresando la herencia.En nuestro diagrama tuvimos al menos tres familias conviviendo. La dirección de la flecha irá desde el hijo hasta el padre.

**Familia Car**

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-24%20a%20la%28s%29%201.24.30-ff45a4c0-dfa8-464b-8590-5d48cfa03eb5.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-24%20a%20la%28s%29%201.24.30-ff45a4c0-dfa8-464b-8590-5d48cfa03eb5.jpg)

**Familia Account**

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-24%20a%20la%28s%29%201.24.13-bc9edb69-8909-487b-9619-350dcb933638.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-24%20a%20la%28s%29%201.24.13-bc9edb69-8909-487b-9619-350dcb933638.jpg)

**Familia Payment**

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-24%20a%20la%28s%29%201.24.42-ef7679b6-3b93-45c1-a4d9-1d6a24f4aa2a.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-24%20a%20la%28s%29%201.24.42-ef7679b6-3b93-45c1-a4d9-1d6a24f4aa2a.jpg)

## Composición

![https://static.platzi.com/media/user_upload/composicion-1da1dd19-6925-42d9-9727-7fd8cb031b0c.jpg](https://static.platzi.com/media/user_upload/composicion-1da1dd19-6925-42d9-9727-7fd8cb031b0c.jpg)

Pasemos a una de nuestras piezas claves, pues notarás en el centro del diagrama la clase **Trip** que está vinculada a User, Car, Route y Payment. La composición va a significar una asociación entre estas clases con la diferencia de que para que esta clase pueda vivir forzosamente necesita a las demás. Es decir que estas clases son obligatorias para que la clase Trip pueda existir, esta dependencia obligatoria podríamos expresarla en el método constructor de la clase Trip, pues para que un objeto pueda ser creado dependerá de que los demás existan.

![https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-24%20a%20la%28s%29%201.46.08-72aaa220-d916-4cae-9ac2-5a8ebe375b80.jpg](https://static.platzi.com/media/user_upload/Captura%20de%20pantalla%202019-01-24%20a%20la%28s%29%201.46.08-72aaa220-d916-4cae-9ac2-5a8ebe375b80.jpg)

Esta clase Trip poseerá la lógica más fuerte del negocio aquí será donde se concentrarán la mayor cantidad de clases.

Esto es todo nuestro diagrama de clases, que quedó totalmente expresado en nuestro proyecto.

## Bonus: Qué es la Programación Orientada a Objetos

**En Resumen**

- En la POO hay 5 cosas fundamentales:
    - **Clases:** Son el molde más genérico y del cual podemos instanciar muchos objetos.
    - **Objetos:** Son creados de las clases y tienen datos y funcionalidad.
    - **Atributos:** Son las características especificas del objeto (Son las variables dentro del código)
    - **Métodos:** Son las funciones o acciones que puede hacer este objeto.
    - **Instaciar:** Es la creación de un objeto desde una clase a eso se le llama instancia o instancias.

- **Los pilares de la POO son:**
    - **Abstracción:** Es separar cada uno de los datos de un objeto para poder crear su molde (clase)
    - **Encapsulamiento:** Es aislar un dato para que este sea privado y no pueda ser visto o modificado.
    - **Herencia:** Es crear una o más clases a partir de una clase que ya existe. Y se les llaman subclases.
    - *Polomorfismo:**Es construir métodos con el mismo nombre pero con comportamiento diferente.