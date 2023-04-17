
# **Curso Básico de Programación en Go**

# Hola mundo en Go

## ¿Qué es, por qué y quienes utilizan Go?

### ¿Qué es?

* Lenguaje compilado (se recopilan los códigos) y estáticamente tipado (se debe indicar el tipo de variable o constante para que guarde algún valor en él)
* Maneja procesos pesados, es potente, pero amigable.
* Se utiliza Go/Goland para nombrarlo.
* Los programadores de este lenguaje se hacen llamar gophers.


### ¿Porqué Go/Goland?
* Es veloz
* Tiene alto rendimiento para tareas pesadas
* Maneja soporte nativo por concurrencia
* Un Gopher puede ganar $74k al año
* Facilita ajustar sintaxis de forma nativa
* Comunidad receptiva, contribuye y apoya.


¿Dónde se usa?
* Mercado Libre
* Twich
* Twitter
* Uber
* Docker y Kubernetes



## Primeras líneas de Código
Antes de todo creamos un archivo llamado main.go

despues debemos hacer al momento de iniciar a desarrollar en go, es definir nuestro package lo cual indica el nombre de la carpeta donde esta guardado.

* En go para definir una función utilizamos la palabra reservada **func()**

Para imprimir en pantalla importamos la librería **fmt** y utilizamos la función **Println** y le pasamos como parámetro lo que queremos imprimir en pantalla

~~~go
package main

import "fmt"

func main() {
	fmt.Println("Hola Mucho")
}
~~~

para ejecutar el codigo usaremos:
> go run main.go




## Variables, constantes y zero values

Los tipos de datos que Go soporta (por defecto) son:

* bool (verdadero o falso)
* string (cadenas de texto)
* int y uint (enteros)
* float (decimales)
* complex (numeros complejos)
* Tambien estan byte (que es un uint de 8 bits) y rune (int de 32 bits), pero no los incluyo por que son “aliases” de int.


#### Ejemplo de como crear variables y constantes

~~~go
func main() {
	//Declaracion de constantes
	const pi float64 = 3.14
	const pi2 = 3.16

	fmt.Println("Pi:", pi)
	fmt.Println("Pi2:", pi2)

	//Declaracion de varaibles
	base := 12          //Primera forma
	var altura int = 14 //Segunda forma
	var area int        //Go no compila si las variables no son usadas

	fmt.Println(base, altura, area)

	//Zero values
	//Go asigna vaalores a variables vacías
	var a int
	var b float64
	var c string
	var d bool

	fmt.Println(a, b, c, d)

	//Ejercicio
	//Calcular el áera del cuadrado
	const baseCuadrado = 10
	areaCuadrado := baseCuadrado * baseCuadrado

	fmt.Println("El área del cuadrado es:", areaCuadrado)
}
~~~


## Operadores aritméticos

Arithmetic Operators
Arithmetic operators are used to perform common mathematical operations.

| Operator | Name | Description | Example |
| -------- | ---- | ----------- | ------- |
| + | Addition | Adds together two values | x + y |
| - | Subtraction | Subtracts one value from another | x - y |
| * | Multiplication | Multiplies two values | x * y |
| / | Division | Divides one value by another | x / y |
| % | Modulus | Returns the division remainder | x % y |
| ++ | Increment | Increases the value of a variable by 1 | x++ |
| -- | Decrement | Decreases the value of a variable by 1 | x-- |



## Tipos de datos en programación

En programación, existen diferentes tipos de datos que pueden ser utilizados para representar información en una aplicación. A continuación se presentan algunos de los tipos de datos más comunes:

| Tipo de dato | Descripción |
| ------------ | ----------- |
| int8/16/32/64 | Indica el tipo de dato "int" con signo y el tamaño del dato. |
| uint8/16/32/64 | Indica el tipo de dato "int" sin signo (solo positivos) y el tamaño máximo del dato. |
| int/uint | Toma el tamaño de bits en el que está basado el procesador (con signo / sin signo). |
| float32 | Número con coma flotante de 32 bits con signo. |
| float64 | Número con coma flotante de 64 bits con signo. |
| string | Cadena de caracteres que se deben declarar con comillas dobles "". |
| bool | Tipo de dato booleano que solo puede ser verdadero (true) o falso (false). |
| complex64 | Números complejos con una parte real e imaginaria de 32 bits con signo. |
| complex128 | Números complejos con una parte real e imaginaria de 64 bits con signo. |

¡WOW, qué interesante es el mundo de los tipos de datos en programación! 


## Paquete fmt: algo más que imprimir en consola


%T = identificar el tipo de datof



## Verbos de formato general en Go

Los siguientes verbos pueden ser usados con todos los tipos de datos:

| Verbo | Descripción |
| ----- | ----------- |
| %v | Imprime el valor en el formato predeterminado |
| %#v | Imprime el valor en el formato de sintaxis de Go |
| %T | Imprime el tipo de valor |
| %s | significa que el valor sera un String |
| %d | significa que el valor sera un entero int |
| %% | Imprime el signo % |


## Tipos de Print:

- Println: Es un print normal con un salto de linea al final. Ejemplo:

```go
fmt.Println("Hola Mundo")
```

- Printf: Es un print al cual le puedes especificar el tipo de objeto que le vas
  a dar. Ejemplo:

```go
fmt.Printf("%s tiene más de %d cursos\n", nombre, cursos)
```

- Sprintf: No imprime nada en consola, simplemente lo guarda como un String.
  Ejemplo de uso:

```go
var message string = fmt.Sprintf("%v tiene más de %v cursos\n", nombre, cursos)
fmt.Println(message)
```

~~~go
package main

import "fmt"

func main() {

	const nombre string = "UltiRequiem"

	fmt.Printf("La variable 'nombre' es de tipo : %T\n", nombre)
}
~~~


## Uso de funciones

Para crear (también conocido como declarar) una función en Go, sigue estos pasos:

1. Usa la palabra clave func.
2. Especifica un nombre para la función, seguido de paréntesis ().
3. Finalmente, agrega el código que define lo que la función debe hacer, dentro de llaves {}.

### Sintaxis

~~~go
func NombreDeFuncion() {
  // código a ejecutar
}

func FunctionName(param1 type, param2 type, param3 type) {
  // code to be executed
}

func FunctionName(param1 type, param2 type) type {
  // code to be executed
  return output
}
~~~


* Ejemplo de codigo de uso de funciones

~~~go
package main

import "fmt"

func normalFunction(message string) {
	fmt.Println(message)
}

func tripeArgument(a, b int, c string) {
	fmt.Println(a, b, c)
}

func returnValue(a int) int {
	return a * 2
}

func doubleReturn(a int) (c, d int) {
	return a, a * 2
}

func main() {
	normalFunction("Hola mundo")
	tripeArgument(1, 2, "hola")

	var value int = returnValue(2)
	fmt.Println("Value:", value)

	value1, _ := doubleReturn(2)
	fmt.Println("value1", value1)
}
~~~



## Go doc: La forma de ver documentación


* go doc para leer documentación mas ordenada https://pkg.go.dev/

* tambien existe esta pagina. https://pkg.go.dev/std



# Estructuras de control de flujo y condicionales


## El poder de los ciclos en Golang: for, for while y for forever


~~~go
package main

import "fmt"

func main() {

	// For condicinal
	for i := 0; i < 10; i++ {
		fmt.Println(i)
	}

	// For while
	counter := 0
	for counter < 10 {
		fmt.Println(counter)
		counter++
	}

	// For forever
	counterForever := 0
	for {
		fmt.Println(counterForever)
		counterForever++
	}

}
~~~



## Operadores lógicos y de comparación