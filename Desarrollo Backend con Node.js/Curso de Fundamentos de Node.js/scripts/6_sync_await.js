async function hola(nombre) {
    console.log('Hola, soy una función asíncrona');

    return new Promise(function (resolve, reject) {
        setTimeout(function () {
            console.log('hola ' + nombre);
            resolve(nombre);
          }, 1000);
    });
}


async function hablar(nombre) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log('bla bla bla bla...');
            resolve();
        }, 1000);
    });
}
  
  
async function adios(nombre) {
    return new Promise(function(resolve, reject) {
        setTimeout(() => {
            console.log('Adios ' + nombre);
            resolve();
        }, 1000);
    });
}

function conversacion(nombre, veces, callback) {
    if (veces > 0) {
        hablar(function () {
            conversacion(nombre, --veces, callback);
        });
    } else {
        adios(nombre, callback);
    }
}


async function main() {
    let nombre = await hola('joel');
    await hablar();
    hablar();
    await hablar();
    await adios('joel');
}

console.log('Iniciando proceso...');
main();
console.log('Terminando proceso...');