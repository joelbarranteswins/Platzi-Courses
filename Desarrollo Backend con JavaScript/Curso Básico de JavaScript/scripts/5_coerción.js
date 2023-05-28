// La forma de convertir un type a otro: Coercion 

// === Implicit Coercion === 

var a = 20;

var b = a + ""; 
console.log(b, typeof b); // "20" "string"

// Otro ejemplo
var c = 4 * "7"
console.log(c, typeof c); // 28 "number"


// más ejemplos

var x = [1,2];
var y = [3,4]; 

x + y // En este ejemplo, por la concatenación, ambos arrays son obligados a convertirse en strings, y luego se juntan.

// === Explicit coercion ===

var c = String( a );
console.log(c, typeof c); // "20" "string"

var d = Number( c );
console.log(d, typeof d); // 20 "number"

// Otro ejemplo

var a = 30; 
var b = a.toString();
console.log(b, typeof b); // "30" "string"

var c = "100"; 
var d = +c; // Unary operator '+' de forma explícita convierte a número
console.log(d, typeof d); // 100 "number"

// más ejemplos

var num1 = "3.14"; 
var num2 = 5 + +num1; 
console.log(num2); // 8.14


var value = "1"
var booleanValue = Boolean(value)
console.log(booleanValue, typeof boolean) // true "boolean"

// === Coercion en comparaciones ===
/*  
Number + Number = Number
Number + String = String
String + Number = String
String + String = String
*/

 
