function hola(nombre, miCallback) {
    console.log('Hola, soy una función asíncrona');
    setTimeout(function () {
      console.log('hola ' + nombre);
      miCallback(nombre);
    }, 1000);
  }


function hablar(callbackHablar) {
    setTimeout(() => {
        console.log('bla bla bla bla...');
        callbackHablar();
    }, 1000);
}
  
  
function adios(nombre, otroCallback) {
    setTimeout(function () {
        console.log('Adios ' + nombre);
        otroCallback();
    }, 1000);
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
hola('joel', function (nombre) {
    conversacion(nombre, 3, function () {
        console.log('Proceso terminado');
    });
});
