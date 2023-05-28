
//Ejemplos de uso de Boolean:
//generar todo el codigo de arriba con console.log
console.log(Boolean(0)); //false
console.log(Boolean(null)); //false
console.log(Boolean(NaN)); //false
console.log(Boolean(undefined)); //false
console.log(Boolean(false)); //false
console.log(Boolean("")); //false

console.log(Boolean(1)); //true -> para 1 o cualquier número diferente de cero (0)
console.log(Boolean(-1)); //true  -> numeronegativos
console.log(Boolean(true)); //true
console.log(Boolean("a")); //true ->para cualquier caracter o espacio en blanco en el string
console.log(Boolean([])); //true -> aunque el array esté vacío
console.log(Boolean({})); //true -> aunque el objeto esté vacío
console.log(Boolean(function hello(){})); //Cualquier función es verdadera también
