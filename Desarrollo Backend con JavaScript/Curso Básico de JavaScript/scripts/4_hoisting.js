// Hoisting es cuando las declaraciones de variables y funciones se procesan antes de ejecutar cualquier código, al momento de qe se genere el hosting, las funciones se declarán primero, y despues las variables.
// El Hoisting ahorita solo pasa con versiones pasadas de JavaScript es decir de M script 5 hacia abajo y de M script 6 hacia delante ya no sucede


// Qué resultado esperas que nos aparezca si corremos este ejemplo? "undefined"

console.log(miNombre);

var miNombre = "Diego";

// Lo que sucede con el hoisting
// Hoistin: Declara y asigna undefined

var miNombre = undefined;

console.log(miNombre + " soy hoisting");

miNombre = "Diego";


// ===  Hoisting con funcionts  ===
// se puede llamar un funcion antes de declararlo
hey();

function hey() {
    console.log('Hola ' + miNombre);
};

var miNombre = 'Diego';

// Lo que sucede con hoisting 
//Como buena practica la función se declara hasta arriba, y después se declaran las variables.

function hey() {  
    console.log('Hola ' + miNombre);
};

var miNombre;

hey();

miNombre = 'Diego';