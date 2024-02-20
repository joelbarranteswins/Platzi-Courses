function sum(num1, num2) {
    return num1 + num2;
}

function calc(num1, num2, callback) {
    return callback(num1, num2);
}

console.log(calc(6, 2, sum));

setTimeout(() => {
    console.log('Hola JavaScript');
}, 2000);


function greeting(name) {
    console.log( `Hola ${name}`);
}

setTimeout(greeting, 2000, 'Jorge');