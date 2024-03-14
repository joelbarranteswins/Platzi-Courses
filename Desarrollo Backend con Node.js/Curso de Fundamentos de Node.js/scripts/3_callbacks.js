function hola(nombre, miCallback) {
  console.log('Hola, soy una función asíncrona');
  setTimeout(function () {
    console.log('hola ' + nombre);
    miCallback(nombre);
  }, 2000);
}


function adios(nombre, otroCallback) {
  setTimeout(function () {
    console.log('Adios ' + nombre);
    otroCallback();
  }, 1000);
}

console.log('Iniciando proceso...');
hola('joel', function (nombre) {
    adios(nombre, function () {
        console.log('Terminando proceso...');
    });
});

//esto genera el problema de asincronismo, cuando no se sabe cuánto tiempo tardará en ejecutarse la función
// hola('joel', function () {});
// adios('joel', function () {});


// console.log('Terminado proceso...');