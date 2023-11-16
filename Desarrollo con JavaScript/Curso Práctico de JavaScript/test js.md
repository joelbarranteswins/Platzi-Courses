# Test de javascript

## Variables y operaciones

1️⃣ Responde las siguientes preguntas en la sección de comentarios:

* ¿Qué es una variable y para qué sirve?

Una variable es un espacio en la memoria ram la cual permite almacenar valores que luego son asignados con un identificador

* ¿Cuál es la diferencia entre declarar e inicializar una variable?

Declarar: es definir el tipo de valor que sera y no asignarle un valor como tal.
inicializar: es definir el tipo de valor y asignarle un valor a la variable.

* ¿Cuál es la diferencia entre sumar números y concatenar strings?

sumar: es juntar dos valores y segun sea el valor genera un nuevo numero mayor a ambos
concatenar: es unir el final de una palabra con eel inicio de otra palabra.

* ¿Cuál operador me permite sumar o concatenar?

operador de sumar: +
operador de concatenare: +

2️⃣ Determina el nombre y tipo de dato para almacenar en variables la siguiente información:

(string) Nombre
(string) Apellido
(string) Nombre de usuario en Platzi
(int) Edad
(string) Correo electrónico
(bool) Mayor de edad
(float) Dinero ahorrado
(float) Deudas


3️⃣ Traduce a código JavaScript las variables del ejemplo anterior y deja tu código en los comentarios.

~~~js
let nombre = "joel";
let apellido = "barrantes";
let nombre_de_usuario_en_Platzi = "joel_barrantes"
let edad = 28
let correo_electrónico = "joel_barrantes_palacios";
let mayor_de_edad = true;
let dinero_ahorrado = 17000
let deudas = 0
~~~

4️⃣ Calcula e imprime las siguientes variables a partir de las variables del ejemplo anterior:

let nombreCompleto ="$(nombre) $(apellido)"
console.log(nombreCompleto);

let dinero = "dinero ahorrado: $(dinero_ahorrado) dolares, deudas: $(deudas)"
consoel.log(dinero);

## Funciones

1️⃣ Responde las siguientes preguntas en la sección de comentarios:

* ¿Qué es una función?
nos permiten encapsular bloques de codigo que pueden tener un input o no pero que si puede generar un output o un comportamiento.

* ¿Cuándo me sirve usar una función en mi código?
nos sirve cuando tenemos variables o bloques de codigo muy parecido que podemos encapsular y reutilizar como función.
sirve para poder modularizar los bleques de codigo, por ello existe la programación funcional

Tambien nos sirve para mejorar la legibilidad de nuestro codigo.

* ¿Cuál es la diferencia entre parámetros y argumentos de una función?
parametros: son las variables definidas de una funcion que seran un input
argumentos: son los valores que se definen a cada parametro cuando se usa una funcion.

2️⃣ Convierte el siguiente código en una función, pero, cambiando cuando sea necesario las variables constantes por parámetros y argumentos en una función:

~~~js
const name = "Juan David";
const lastname = "Castro Gallego";
const completeName = name + lastname;
const nickname = "juandc";

~~~

~~~js
function printUser(completeName, nickname) {    
    console.log("Mi nombre es " + completeName + ", pero prefiero que me digas " + nickname + ".");
}
~~~

## Condicionales

1️⃣ Responde las siguientes preguntas en la sección de comentarios:

* ¿Qué es un condicional?
es una forma de comparar 2 valores segun sea el tipo
Son la forma en que ejecutamos un bloque de código u otro dependien de alguna condición o validación.

* ¿Qué tipos de condicionales existen en JavaScript y cuáles son sus diferencias?
condiconales aritmeticos: + - * / //
condiciones anidados: if, else if, else, ternario
condicionales compuestos: && ||  
condicionales booleanos: true false


IF (else y else if), Switch El codicional if (con el se y else if) nos permite hacer validaciones completamente distintas (si así queremos) en cada validación o condional. En cambio, en el switch todos los cases se comparan con la misma variable o condición que definimos en el switch.

los keyword para hacer condicionales:
if, else if, else, switch and case

* ¿Puedo combinar funciones y condicionales?

Sí. Las funciones pueden encapsular cualquier bloque de código, incluyendo condicionales.

2️⃣ Replica el comportamiento del siguiente código que usa la sentencia switch utilizando if, else y else if:

~~~js
const tipoDeSuscripcion = "Basic";

switch (tipoDeSuscripcion) {
   case "Free":
       console.log("Solo puedes tomar los cursos gratis");
       break;
   case "Basic":
       console.log("Puedes tomar casi todos los cursos de Platzi durante un mes");
       break;
   case "Expert":
       console.log("Puedes tomar casi todos los cursos de Platzi durante un año");
       break;
   case "ExpertPlus":
       console.log("Tú y alguien más pueden tomar TODOS los cursos de Platzi durante un año");
       break;
}
~~~


~~~js
const tipoDeSuscripcion = "Basic";
if (tipoDeSuscripcion === "Free") {
    console.log("Solo puedes tomar los cursos gratis");
}
else if (tipoDeSuscripcion === "Basic") {
    console.log("Puedes tomar casi todos los cursos de Platzi durante un mes");
}
else if (tipoDeSuscripcion === "Expert") {
    console.log("Puedes tomar casi todos los cursos de Platzi durante un año");
}
else if (tipoDeSuscripcion === "ExpertPlus") {
    console.log("Tú y alguien más pueden tomar TODOS los cursos de Platzi durante un año");
}
else {
    console.warn("Tipo de suscripción no valida");
}
~~~


3️⃣ Replica el comportamiento de tu condicional anterior con if, else y else if, pero ahora solo con if (sin else ni else if).

    💡 Bonus: si ya eres una experta o experto en el lenguaje, te desafío a comentar cómo replicar este comportamiento con arrays u objetos y un solo condicional. 😏

~~~js

let suscriptionTypeDict = {
    free: "Solo puedes tomar los cursos gratis",
    basic: "Puedes tomar casi todos los cursos de Platzi durante un mes",
    expert: "Tú y alguien más pueden tomar TODOS los cursos de Platzi durante un año",
    expertPlus: "Tipo de suscripción no válida"
};

var suscriptionType = "basic";

function getSuscriptionType(suscriptionType) {
    if (suscriptionTypeDict.hasOwnProperty(suscriptionType)) {
        console.log(suscriptionTypeDict[suscriptionType]);
        return;
    } 

    console.warn("Tipo de suscripción no encontrada");
}

getSuscriptionType(suscriptionType);

~~~


## Ciclos
1️⃣ Responde las siguientes preguntas en la sección de comentarios:

* ¿Qué es un ciclo?

es hacer que un bleque de codigo se ejecute continuamente segun una condición

* ¿Qué tipos de ciclos existen en JavaScript?

ciclo for, While, Do while, for in, for of 

* ¿Qué es un ciclo infinito y por qué es un problema?

es cuando un bloque de codigo se ejecuta continuamente sin parar,
de es del todo un problema si realmente si el ciclo infinito es una funcionalidad 

* ¿Puedo mezclar ciclos y condicionales?

si se puede

2️⃣ Replica el comportamiento de los siguientes ciclos for utilizando ciclos while:

~~~js
for (let i = 0; i < 5; i++) {
    console.log("El valor de i es: " + i);
}

for (let i = 10; i >= 2; i--) {
    console.log("El valor de i es: " + i);
}
~~~

utilizando ciclos

~~~js
let i = 0;
while (i < 5) {
    console.log("El valor de i es: " + i);
    i++
}

i = 10
while (i >= 2) {
    console.log("El valor de i es: " + i);
    i--
}
~~~


3️⃣ Escribe un código en JavaScript que le pregunte a los usuarios cuánto es 2 + 2. Si responden bien, mostramos un mensaje de felicitaciones, pero si responden mal, volvemos a empezar.

    💡 Pista: puedes usar la función prompt de JavaScript.

~~~js
const prompt = require('prompt-sync')();

do {
  var userAnswer = prompt("Please, how much is 2 + 2: ");
} while (+userAnswer !== 4);
console.log("felicitaciones")
~~~

## Listas

1️⃣ Responde las siguientes preguntas en la sección de comentarios:

* ¿Qué es un array?

es un conjunto de  valores agrupados e asignado  a una variable

* ¿Qué es un objeto?

es un conjunto de datos el cual se asemeja a un diccionario, tienen keys y values

* ¿Cuándo es mejor usar objetos o arrays?

ninguno, tienen diferentes usos

* ¿Puedo mezclar arrays con objetos o incluso objetos con arrays?

si se puede

2️⃣ Crea una función que pueda recibir cualquier array como parámetro e imprima su primer elemento.

~~~js
let numbers = [1,2,3,4,5]

function printFirstValueFromArray(arraysValues) {
    console.log(arraysValues[0]);
}

printFirstValueFromArray(arraysValues=numbers)
~~~

3️⃣ Crea una función que pueda recibir cualquier array como parámetro e imprima todos sus elementos uno por uno (no se vale imprimir el array completo).

~~~js
let numbers = [1,2,3,4,5]

function printValuesFromArray(arrayValues) {
    for (let item of arrayValues){
        console.log(item)
    }
}

printValuesFromArray(arraysValues=numbers)
~~~


4️⃣ Crea una función que pueda recibir cualquier objeto como parámetro e imprima todos sus elementos uno por uno (no se vale imprimir el objeto completo).

~~~js
function printObjectElements(obj) {
  for (let key in obj) {
    if (Object.prototype.hasOwnProperty.call(obj, key)) {
      console.log(key + ':', obj[key]);
    }
  }
}

let myObject = {
  name: 'Alice',
  age: 30,
  city: 'New York'
};

printObjectElements(myObject);
~~~


~~~js
const object = {
    name: "goku",
    age: 110,
    poder: "Kamehame haaaaaaaaaa",
    debilidad: "Jeringas",
}

console.log(Object.entries(object));
~~~

~~~js
function imprimirElementoPorElementoObjeto(obj) {
    const arr = Object.values(obj);
    for (let i = 0; i < arr.length; i++) {
        console.log(arr[i])
    }
}
~~~