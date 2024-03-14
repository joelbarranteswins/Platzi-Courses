function hola(nombre) {
    console.log('Hola, soy una función asíncrona');

    return new Promise(function (resolve, reject) {
        setTimeout(function () {
            console.log('hola ' + nombre);
            resolve(nombre);
          }, 1000);
    });
}


function hablar(nombre) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log('bla bla bla bla...');
            resolve();
        }, 1000);
    });
}
  
  
function adios(nombre) {
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

console.log('Iniciando proceso...');
// hola('joel', function (nombre) {
//     conversacion(nombre, 3, function () {
//         console.log('Proceso terminado');
//     });
// });

hola('joel')
    .then(hablar)
    .then(adios)
    .then(() => {
            console.log('Terminado el proceso');
    })
    .catch(error => {
        console.error('Ha habido un error:');
        console.error(error);
    });