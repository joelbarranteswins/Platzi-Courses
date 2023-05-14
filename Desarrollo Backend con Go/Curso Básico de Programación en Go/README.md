
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

* el siguiente key permite obtener el tipo de dato en un print
	~~~
	%T = identificar el tipo de datof
	~~~


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

### Operadores de comparación

Son aquellos que retornan TRUE o FALSE en caso de cumplirse o no una expresión. Son los siguientes:

* `valor1 == valor2`: Retorna TRUE si valor1 y valor2 son exactamente iguales.
* `valor1 != valor2`: Retorna TRUE si valor1 es diferente de valor2.
* `valor1 < valor2`: Retorna TRUE si valor1 es menor que valor2
* `valor1 > valor2`: Retorna TRUE si valor1 es mayor que valor2
* `valor1 >= valor2`: Retorna TRUE si valor1 es igual o mayor que valor2
* `valor1 <= valor2`: Retorna TRUE si valor1 es menor o igual que valor2.

### Operadores lógicos

Son aquellos que retorna TRUE o FALSE si cumplen o no una condición utilizando puertas lógicas.

#### Operador AND:

Este operador indica que todas las condiciones declaradas deben cumplirse para poderse marcar como TRUE. En Go, se utiliza este símbolo `&&`.

Ejemplo1: `1>0 && 2 >0` Esto retornará TRUE porque tanto la primera como la segunda condición son verdaderas.

Ejemplo2: `2<0 && 1 > 0` Esto retornará FALSE porque una de las condiciones no es verdadera.

### Operador OR:

Este operador indica que al menos una de las condiciones debe cumplirse para marcarse como TRUE. En Go, se representa con el símbolo `||`.

Ejemplo: `2<0 || 1 > 0` Esto retornará TRUE porque la segunda condición se cumple, a pesar que la primera no.

### Operador NOT:

Este operador retornará el opuesto al booleano que está dentro de la variable. Ejemplo:

~~~go
myBool := true
fmt.Println(!myBool) // Esto retornará false
~~~


## El condicional If

La sentencia if (si, en inglés) verifica que la expresión que se le indique sea verdadera para entonces ejecutar la sección de código destinada solamente a ejecutarse cuando eso suceda. Si la condicional es falsa, se continúa ejecutando el código de forma secuencial.

~~~go
package main
import "fmt"
func main() {
  /*variable local de tipo entero*/
  var calificacion int = 5
  /*Sentencia if, que verifica si calificación es menor a 6*/
  if calificacion < 6 {
    /*Si la condición se cumple, imprime*/
    fmt.Println("Reprobaste")
  }
  fmt.Println("Tu calificación fue de: ", calificacion)
}
~~~

Cuando necesitamos que el programa ejecute ciertas sentencias cuando la condición es verdadera, pero a su vez necesitamos que ejecute otras sentencias solamente cuando la condición es falsa, necesitamos una sentencia condicional if-else


~~~go
package main
import "fmt"
func main() {
  /*variable local de tipo entero*/
  var calificacion int = 7
  /*Sentencia if, verifica calificación menor 6*/
  if calificacion < 6 {
    /*Si la condición se cumple*/
    fmt.Println("Reprobaste")
  }else{
    /*Si la condición no se cumple*/
    fmt.Println("Aprobaste")
  }
  fmt.Println("Tu calificación fue de: ", calificacion)
}
~~~


* Un if puede tener 0 o 1 else que funciona para señalar las sentencias que se ejecutan cuando no se cumplió ninguna de las condiciones anteriores.

* Un if puede tener de 0 a N else if siempre y cuando no estén después de un else (ya que el ***else***, en caso de que exista, debe ser la sentencia final).






## Múltiple condiciones anidadas con Switch

* switch case sin condicional
~~~go
package main

import "fmt"

func main() {
	// Estructura condicional - Switch
	var dia int8 = 4

	switch dia {
	case 1:
		fmt.Println("Lunes")
	case 2:
		fmt.Println("Martes")
	case 3:
		fmt.Println("Miercoles")
	case 4:
		fmt.Println("Jueves")
	case 5:
		fmt.Println("Viernes")
	case 6:
		fmt.Println("Sabado")
	case 7:
		fmt.Println("Domingo")
	default:
		fmt.Println("Ese no es un día valido de la semana!")
	}
}
~~~


* switch case con condicional

~~~go
	// Estructura condicional - Switch
	var mes int8 = 10
	switch {
	case mes <= 3:
		fmt.Println("Primer Trimestre")
	case mes > 3 && mes <= 6:
		fmt.Println("Segundo Trimestre")
	case mes > 6 && mes <= 9:
		fmt.Println("Tercer Trimestre")
	case mes > 9 && mes <= 12:
		fmt.Println("Cuarto Trimestre")
	default:
		fmt.Println("Este no es un mes valido")
	}
~~~


## El uso de los keywords defer, break y continue

* defer: keyword para indicar que se ejecute al final de nuestro codigo, equivalente a la sección finally de un try … except … finally

* continue: si encuentra este keyword, regresará a evaluar la condición del ciclo for y si cumple entra al for y sino terminará el for. Lo importante del continue, es que ya no ejecuta el código que se encuentre después o abajo del continue.

* break: al encontrar esta keyword, termina si o si con el ciclo for, sin importar ninguna condición.


~~~go
package main

import "fmt"

func main() {
	// Defer: se ejecuta al final de la función o despues de todo el código
	defer fmt.Println("Hola")
	fmt.Println("Mundo")

	// Continue y break
	for i := 0; i < 10; i++ {
		fmt.Println(i)

		// Continue
		if i == 2 {
			fmt.Println("Es 2")
			continue
		}

		// Break
		if i == 8 {
			fmt.Println("Break")
			break
		}
	}
}
~~~


# Estructuras de datos básicas

## Arrays y Slices

La diferencia principal entre los arrays es que estos tienen una longitud fija e invariable y deben declarase especifiandola

~~~go
x := [5]int{0, 1 ,2, 3, 4}
~~~

mientras que los Slices tienen una longitud variable y no hay que especificarla en la declaración

~~~go
var x [ ]float64
~~~

en este caso se crea un Slice con una longitud de cero
Si queremos crear un slice deberiamos usar la funcion make:

~~~go
x := make([]float64, 5)
~~~

esto crea un Slice asociado a un array subjacente de longitud 5.

Los Slices siempre están asociados a un array y aunque nunca pueden ser mas largos que el aray, pueden ser mas cortos.

La función make también permite un tercer parámetro, que representa la capacidad del array, por lo que

~~~go
x := make([]float64, 5, 10)
~~~

representa un Slice de longitud 5 y capacidad de 10


## Recorrido de Slices con Range


~~~go
package main

import "fmt"

func main() {
	// Array -> Array estático
	var array [4]int
	array[0] = 1
	array[1] = 2
	fmt.Println(array, len(array), cap(array))

	// Slice -> Array dinámico
	slice := []int{0, 1, 2, 3, 4, 5, 6}
	fmt.Println(slice, len(slice), cap(slice))

	// Métodos en el slice
	fmt.Println(slice[0])
	fmt.Println(slice[:3])
	fmt.Println(slice[2:4])
	fmt.Println(slice[4:])

	// Append
	slice = append(slice, 7)
	fmt.Println(slice)

	// Append nueva list
	newSlice := []int{8, 9, 10}
	slice = append(slice, newSlice...)
	fmt.Println(slice)
}

~~~


~~~go
package main

import (
	"fmt"
	"strings"
)

func isPalindromo(text string) {
	var textReverse string

	// Convert text to lower
	text = strings.ToLower(text)

	for i := len(text) - 1; i >= 0; i-- {
		textReverse += string(text[i])
	}

	if text == textReverse {
		fmt.Println("Es palindromo")
	} else {
		fmt.Println("No es un palíndromo")
	}
}

func main() {
	slice := []string{"hola", "que", "hace"}
	for _, value := range slice {
		fmt.Println(value)
	}

	for i := range slice {
		fmt.Println(i)
	}
	// ama
	// amor a roma

	isPalindromo("Ama")
}
~~~


## Llave valor con Maps


Los maps/hash son más eficientes según el caso de uso, si conoces el KEY siempre será más eficiente usar un MAP, debido a que el tiempo de acceso es EN PROMEDIO constante (O(1)) para todos los keys independientemente del tamaño del MAP.

* Map son diccionarios en GO

* Se usa para manejar valores constantes

* Hay que tener cuidado con el recorrido ya que es concurrente se puede ejecutar de forma aleatoria

* Si solo necesitas iterar sobre un conjunto de elementos, siempre es mejor alternativa usar un Array.

* Usa concurrencia de manera nativa

* Arrays y Hashes, son bastante similares en memoria, los hashes son en resumen un hack para crear arreglos en los que podemos definir un KEY distinto a un índice entero.

* Este es un muy buen artículo para conocer más de los hashes, aunque usa Python para los ejemplos: [Articulo](https://www.geeksforgeeks.org/hashing-data-structure/)


~~~go
//Declaración 1 Forma 
temperature := map[string]int{
		"Earth": 15,
		"Mars":  -65,
	}

// Declaración forma 2 
m:= make(map[string]int)
m["Jose"] = 25
m["Maria"] = 20

fmt.Println(m)

for i, v := range m{
	fmt.Println(i,v)
}

//Encotrar vaor 

value, ok := m["Josep"]
fmt.Println(value, ok)
~~~



## Structs: La forma de hacer clases en Go

Es una manera de generar Clases solo que un tantito diferente usamos la palabra reservada Structs

### Caracteristicas

* Muy Parecido a C
* Muy parecido a JavaScript


~~~go
package main

import "fmt"

type car struct {
	brand   string
	year    int
	seating int
	color   string
	owner   string
}

func main() {
	//Forma 1 de instanciar 
	myCar := car{brand: "Toyota", year: 2018, seating: 10, color: "Rojo", owner: "Eliaz Bobadilla"}
	fmt.Println("Los Datos de mi auto son:", myCar)

	//Forma Dos de instanciar 
	var otherCar car
	otherCar.brand = "Ferrari";
	otherCar.year  = 2023;

	fmt.Println("Los Datos de mi otro auto son:", otherCar)
}
~~~


## Modificadores de acceso en funciones y Structs

* para inicializar un proyecto en go

~~~shell
go mod init <host/user/module-name>
~~~

* el script que importares mypackage.go que estara dentro de la carpeta mypackage

~~~go
package mypackage

import "fmt"

// CarPublic Car con acceso publico
type CarPublic struct {
	Brand string
	Year  int
}

type carPrivate struct {
	brand string
	year  int
}

// PrintMessage imprimir un mensaje
func PrintMessage(text string) {
	fmt.Println(text)
}

func printMessage1(text string) {
	fmt.Println(text)
}

~~~

* el script main.go que llamar el anterior script

~~~go
package main

import (
	"fmt"

	pk "platzi.com/joel/funciones/mypackage"
)

func main() {
	var myCar pk.CarPublic
	myCar.Brand = "Ferrari"
	myCar.Year = 2020
	fmt.Println(myCar)

	pk.PrintMessage("Hola Platzi")

	// pk.printMessage1("Hola")

}

~~~


# Métodos e interfaces


## Structs y Punteros

* El “&” accede a la dirección del espacio de memoria de la variable.

* “*” accede al valor que contiene ese espacio de memoria, dado el nombre de una variable o una dirección especifica.


~~~go
package main

import (
	"curso_golang_platzi/src/mypackage"
	"fmt"
)

//POINTERS
func main() {

	a := 50
	// The & returns the memory address of the given var
	b := &a

	fmt.Println(b)
	// The * returns the content of a given memory address
	fmt.Println(*b)

	//In the same way we can change the content of the given memory address
	*b = 100
	fmt.Println(a)
}
~~~


~~~go
package main

import "fmt"

type pc struct {
	ram   int
	disk  int
	brand string
}

func (myPC pc) ping() {
	fmt.Println(myPC.brand, "Pong")
}

func (myPC *pc) duplicateRAM() {
	myPC.ram = myPC.ram * 2
}

func main() {
	myPC := pc{ram: 16, disk: 200, brand: "msi"}
	fmt.Println(myPC)

	myPC.ping()

	fmt.Println(myPC)
	myPC.duplicateRAM()

	fmt.Println(myPC)
	myPC.duplicateRAM()

	fmt.Println(myPC)
}
~~~


## Stringers: personalizar el output de Structs

* La estructura de datos " Struct " tiene un método llamado " String " , que podemos sobrescribir para personalizar la salida a consola de los datos del struct.

~~~go
package main

import "fmt"

type pc struct {
	ram   int
	brand string
	disk  int
}

func (myPC pc) String() string {
	return fmt.Sprintf("Tengo %d GB RAM, %d GB Disco y es una %s", myPC.ram, myPC.disk, myPC.brand)
}

func main() {
	myPC := pc{ram: 16, brand: "msi", disk: 100}

	fmt.Println(myPC)
}
~~~



## Interfaces y listas de interfaces

Si los structs que tenemos en el código tienen métodos que hacen algo en común (Cálculos, obtener data, etc), es posible ejecutar éstos métodos usando una interfaz, de esta forma evitamos hacer código por cada struct.

~~~go
package main

import "fmt"

type figuras2D interface {
	area() float64
}

type cuadrado struct {
	base float64
}

type rectangulo struct {
	base   float64
	altura float64
}

func (c cuadrado) area() float64 {
	return c.base * c.base
}

func (r rectangulo) area() float64 {
	return r.base * r.altura
}

func calcular(f figuras2D) {
	fmt.Println("Area:", f.area())
}

func main() {

	var value int
	fmt.Println(value)
	myCuadrado := cuadrado{base: 2}
	myRectangulo := rectangulo{base: 2, altura: 4}

	calcular(myCuadrado)
	calcular(myRectangulo)

	// Lista interfaces
	myInterface := []interface{}{"Hola", 12, 4.90}
	fmt.Println(myInterface...)
}
~~~



# Concurrencia y Channels

## ¿Qué es la concurrencia?

* Concurrencia te permite estar pendiente de varios procesos, comienzas uno, empiezas otro, ves si el anterior ya terminó, luego crear otro así

* El paralelismo, es usar varios hilos del procesador para hacer varios procesos a la vez, pero siempre estas esperando que la tarea termine.

![tipos](./imgs/tipos%20de%20programacion.png)


## Primer contacto con las Goroutines

### Hilos (Concurrencia)
💡 La concurrencia es un paradigma que indica la manera de ejecución de algunos procesos.


Podemos denotar 2 aspectos importantes en este tema:

* Sincronizmo: Ejecución secuencial bloqueable.
* Asíncronizmo: Ejecución paralela de procesos

En este punto, JavaScript se ve vulnerable porque la concurrencia no es uno de sus fuertes y por ello, pudiera romper el concepto a algunos.


Definición

💡 Un hilo, es una línea de ejecución de algún proceso que fundamentalmente no es ni sincrónico, ni asincrónico.

Mencionamos que la concurrencia es un paradigma ya que nos permite realizar procesos delegados según sea SO, su peso o prioridad.

~~~go
package main

import (
	"fmt"
	"sync"
	"time"
)

func say(text string, wg *sync.WaitGroup) {
	defer wg.Done()

	fmt.Println(text)
}

func main() {
	var wg sync.WaitGroup

	fmt.Println("Hello")
	wg.Add(1)

	go say("World", &wg)

	wg.Wait()

	go func(text string) {
		fmt.Println(text)
	}("Adios")

	time.Sleep(time.Second * 1)
}
~~~



## Channels: La forma de organizar las goroutines

Entre las aplicaciones de las go routines, me vienen a la cabeza estas:

* Procesamiento de archivos por lotes (cada lote sería un proceso distinto).
* Algoritmos en los que pueda aprovechar paralelismo, como la búsqueda bidireccional.
* Simulaciones que aprovechen la concurrencia, por ejemplo, un modelo estadístico de la pandemia (cada region sería un proceso diferente)
* Entrenamiento de agentes con aprendizaje por refuerzos. Por ejemplo, agentes que compiten en un entorno. Cada agente podría ser un proceso y el entorno en sí mismo también.

~~~go
package main

import"fmt"

func say(text string, c chan<- string) { // canal de entrada de datos
	c <- text
}

func printChannelOutput(c <-chanstring) { // canal de salida de datos
	var output string
	output = <-c
	fmt.Println(output)
}

funcmain() {
	// c := make(chan string) // dinamically accepts goroutines
	c := make(chanstring, 1) // one goroutine at time
	fmt.Println("Hello")
	go say("Bye", c)

	//fmt.Println(<-c)
	printChannelOutput(c)
}
~~~


## Range, Close y Select en channels


~~~go
package main

import "fmt"

func message(text string, c chan string) {
	c <- text
}

func main() {
	c := make(chan string, 2)
	c <- "Mensaje 1"
	c <- "Mensaje 2"

	// len -> number of elements in the channel
	// cap -> capacity of the channel

	fmt.Println(len(c), cap(c))

	//Range and Close
	// lo ideal es cerrar el channel cuando ya no puede recibir mas elementos
	close(c)

	// c <- "Mensaje 3"

	for message := range c {
		fmt.Println(message)
	}

	// select

	email1 := make(chan string)
	email2 := make(chan string)

	go message("mensaje 1", email1)
	go message("mensaje 2", email2)

	for i := 0; i < 2; i++ {
		select {
		case m1 := <-email1:
			fmt.Println("Email recibido de email1", m1)
		case m2 := <-email2:
			fmt.Println("Email recibido de email2", m2)
		}
	}
}
~~~


## Go get: El manejador de paquetes

* go get <nombre del paquete>: Descarga y construye el paquete especificado.
* go get -u <nombre del paquete>: Descarga y actualiza el paquete especificado y sus dependencias.
* go get -t <nombre del paquete>: Descarga y construye el paquete especificado, y también descarga y construye los paquetes de prueba.
* go get -d <nombre del paquete>: Descarga el paquete especificado y sus dependencias, pero no lo construye ni lo instala.

### Crear un modulo:

* En el directorio "mi-proyecto", ejecuta el siguiente comando para iniciar un nuevo módulo de Go:
csharp

~~~go
go mod init "host/user/module"    
~~~


## Go modules: Ir más allá del GoPath con Echo

1. Abre una terminal y escribe el siguiente comando para ver el valor actual del GOPATH:
bash
~~~go
go env GOPATH
~~~

2. Para modificar el GOPATH, escribe el siguiente comando:

~~~go
export GOPATH=/ruta/nueva/para/el/gopath
~~~

Reemplaza "/ruta/nueva/para/el/gopath" con la ruta deseada para el nuevo GOPATH.

3. Para verificar que el GOPATH se ha actualizado correctamente, escribe el siguiente comando:

~~~go
go env GOPATH
~~~


## Modificando módulos con Go


1. Primero, debes asegurarte de tener Go instalado en tu computadora y configurado correctamente.

2. Luego, abre una terminal y navega al directorio de tu proyecto Go.

3. Verifica que estás usando el módulo adecuado ejecutando el siguiente comando: go list -m. Este comando mostrará el módulo raíz y sus dependencias.

4. Si deseas eliminar una dependencia, puedes usar el comando go mod edit -dropreplace <nombre_del_módulo>. Este comando elimina cualquier reemplazo que se haya definido para el módulo especificado en el archivo go.mod. Si no hay ningún reemplazo para el módulo, este comando no tiene ningún efecto.

5. Después de realizar cualquier cambio en el archivo go.mod, es recomendable verificar que todas las dependencias se resuelven correctamente. Puedes hacer esto ejecutando el comando go mod verify. Este comando verifica que todas las dependencias requeridas se puedan descargar y construir correctamente.

6. Si deseas asegurarte de que todas las dependencias estén incluidas en tu proyecto, puedes usar el comando go mod vendor. Este comando copia todas las dependencias requeridas en el directorio vendor de tu proyecto.

7. go mod tidy te ayuda a limpiar librerias no usadas.