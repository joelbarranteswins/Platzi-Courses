# Fundamentos de Node.js

# 1. Conceptos básicos de NodeJS

![imgs/Untitled.png](imgs/Untitled.png)

## Asincronia de node

[The Node.js Event Loop, Timers, and process.nextTick() | Node.js](https://nodejs.org/uk/docs/guides/event-loop-timers-and-nexttick/)

**Event Queue:** Contiene todos los eventos que se generan por nuestro código (Funciones, peticiones, etc.), estos eventos quedan en una cola que van pasando uno a uno al Event Loop.

**Event Loop:** Se encarga de resolver los eventos ultra rápidos que llegan desde el Event Queue. En caso de no poder resolverse rápido, enviá el evento al Thread Pool.

**Thread Pool:** Se encarga de gestionar los eventos de forma asíncrona. Una vez terminado lo devuelve al Event Loop. El Event Loop vera si lo pasa a Event Queue o no.

## Monohilo: implicaciones en diseño y seguridad

> Importante: Cuando ocurre un error dentro de alguno de los hilos y no se controla apropiadamente (catch); Node detiene todos los hilos ejecución. Esto puede ser muy peligroso, debido a que es dificil determinar fue el origen del problema y en que punto de ejecución se encontraba cada hilo cuando fue detenido.
> 

```jsx
console.log('Hola mundo');

// SetInterval me permtie ejecutar una función cada n cantidad de tiempo, por lo que quiere que recibe como argumentos: Función a ejecutarse, intervalo de tiempo.
//A tener  en cuenta esta función no se detiene y continúa su ejecución ad infinitum.
// Detener ejecución con ctrl+ alt + m en Run Code, o con Ctrl +c en la terminal.
setInterval(function(){console.log('Voy a contar hasta infinito, detén mi ejecución o consumo tu memoria'),1000}); // Esta instrucción es asíncrona, por lo que se ejecuta en n momento.

let i = 0;
setInterval(function() {
    console.log(i);
    i++;

// Al ser monohilo el peligro recae en que si el código se ejectua y no tenemos cuidado el no asignar una variable de manera correcta me puede arrojar un error.
//Hay que escuchar los errores, es muy imporante de todo lo que pase en el código. Comprobar funciones y revisar lo que posiblmente puede fallar.
//Es clave estar pendiente de todos los errores que pueda cortar la ejecución, lo que se corta corta todo.
// Todo lo que sea asíncono y lo pueda llevar a ello, pues llevarlo, y todo lo que no, revisar que no corte el programa.

    // if (i === 5) {
    //     console.log('forzamos error');
    //     var a = 3 + z;
    // }
}, 1000);

console.log('Segunda instrucción');
```

## Variables de entorno

[Manejo de variables de entorno en Node.js](https://medium.com/@jairofernandez/manejo-de-variables-de-entorno-en-node-js-ac90f7a2c1e5)

Me sirve para consigurar parametros como puertos e informacion sencibla la cual no debe estar en en codigo o repositorio.

Para ejecutar el codigo con variables de entorno hacemos lo siguiente

> NOMBRE=Camilo [WEB=camilomezu.com](http://web%3Dcamilomezu.com/) node variables_de_entorno.js
> 

Para windows | Powershell

> $env:NOMBRE="Camilo" ; $env:WEB="[Hola.com](http://hola.com/)"; node .\variables_de_entorno.js
> 

```jsx
let nombre = process.env.NOMBRE || 'Sin nombre';
let web = process.env.WEB || 'No tengo web.com';

console.log('Hola ' + nombre);
console.log('Mi web es  ' + web);
```

---

En caso de querer tener variables de entorno en un archivo, puede utilizar [dotenv](https://www.npmjs.com/package/dotenv), de esta manera puede crear el archivo .env y ahí configurar las variables necesarias.Y luego accederlas donde las necesite, ejemplo:

**file.js:**

```
require('dotenv').config();
console.log(process.env.NAME);

```

**.env**

```
NAME = 'u name'

```

Se suele utilizar mucho para variables de bases de datos, usuarios, etc.Y en caso de usar variables con información sensible, tener en cuenta nunca enviar el archivo .env al repositorio (:

## Herramientas para ser más felices: Nodemon y PM2

[nodemon](https://nodemon.io/)

[PM2 - Home](https://pm2.keymetrics.io/)

**nodemon** nodemon es una herramienta que ayuda a desarrollar aplicaciones basadas en node.js al reiniciar automáticamente la aplicación de nodo cuando se detectan cambios en el directorio.

```
sudo npm install -g nodemon
nodemon nombre_archivo
```

Recomendacion

- Nodemon: Para desarrollo
- PM2: para producción

# 2. Cómo manejar la asincronía

## Callbacks

## Callback Hell: refactorizar o sufrir

Cuando tenemos muchos callbacks anidados el codigo se hace ilegible y dificil de mantener.

Podeos utilizar estructuras de control y funciones para evitar este tipo de comportamientos.

```jsx
function hola(nombre, miCallback) {
  setTimeout(function () {
    console.log("Hola, " + nombre);
    miCallback(nombre);
  }, 1500);
}

function hablar(callbackHablar) {
  setTimeout(function () {
    console.log("Bla bla bla bla...");
    callbackHablar();
  }, 1000);
}

function adios(nombre, otroCallback) {
  setTimeout(function () {
    console.log("Adios", nombre);
    otroCallback();
  }, 1000);
}

/*En esta parte del código uso funciones recursivas porque estoy llamando a 
conversacion dentro de si misma.
 y mediante un If como estructura de control le digo que cantidad de veces va a
  ejectuarse la funcion hablar.*/
 
function conversacion(nombre, veces, callback) {
  if (veces > 0) {
    hablar(function () {
      conversacion(nombre, --veces, callback);
    });
  } else {
    adios(nombre, callback);
  }
}

// --

console.log("Iniciando proceso...");
hola("Aleajandro-sin", function (nombre) {
  conversacion(nombre, 10, function () {
    console.log("Proceso terminado");
  });
});

/****************HELL**********************/
// hola('Alejandro', function (nombre) {
//     hablar(function () {
//         hablar(function () {
//             hablar(function () {
//                 adios(nombre, function() {
//                     console.log('Terminando proceso...');
//                 });
//             });
//         });
//     });
// });
```

## Promesas

La ventaja que tienen las promesas respecto a los callbacks clásicos es que podemos saber el estado de ejecución de una promesa

Como nos dijo sasha.
Una `Promesa` se encuentra en uno de los siguientes estados:

- *pendiente (pending)*: estado inicial, no cumplida o rechazada.
- *cumplida (fulfilled)*: significa que la operación se completó satisfactoriamente.
- *rechazada (rejected)*: significa que la operación falló.
No nos olvidemos de mirar la documentación para estar pendiente de sus métodos
[https://developer.mozilla.org/es/docs/Web/JavaScript/Referencia/Objetos_globales/Promise#Propiedades](https://developer.mozilla.org/es/docs/Web/JavaScript/Referencia/Objetos_globales/Promise#Propiedades)

[Promise](https://developer.mozilla.org/es/docs/Web/JavaScript/Referencia/Objetos_globales/Promise)

```jsx
function hola(nombre, micallback) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      if (true) {
        console.log(`hola ${nombre}`);
        resolve(nombre);
      } else {
        reject("Error al saludar");
      }
    }, 1000);
  });
}

function hablar(nombre) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      if (true) {
        console.log("bla bla bla bla");
        resolve(nombre);
      } else {
        reject("Error encontrado al hablar");
      }
    }, 500);
  });
}

function adios(nombre, otrocallback) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      if (true) {
        console.log(`Adios ${nombre}`);
        resolve();
      } else {
        reject("error al despedirse");
      }
    }, 2000);
  });
}

function conversacion(nombre, veces, callback) {
  if (veces > 0) {
    hablar(() => {
      conversacion(nombre, --veces, callback);
    });
  } else {
    adios(nombre, callback);
  }
}

//-----------------

//callback hell

console.log("iniciando el proceso..");
hola("Camilo")
  .then(hablar)
  .then(hablar)
  .then(hablar)
  .then(hablar)
  .then(adios)
  .then((nombre) => {
    console.log("terminado el proceso");
  })
  .catch((error) => {
    console.error("ha habiado un error");
    console.error(error);
  });
```

## Async/Await

# 3. Modulos del core

## Global

[Node.js v15.4.0 Documentation](https://nodejs.org/docs/latest-v10.x/api/globals.html)

El alcance global de node son funciones u objetos que estan definidos de manera global, entre ellos estan setInterval, setTimeout, __dirname, __filename

## File System

Creamos un archivo llamado archivo1.txt y le ponemos texto

**RESUMEN**:

---

El **file system** provee una API para interactuar con el sistema de archivos cerca del estándar POSIX.
POSIX es el estándar para interfaces de comando y shell, las siglas las 
significan: “Interfaz de sistema operativo portátil” la X de POSIX es 
por UNIX.

El file system nos permite acceder archivo del sistema, leer, 
modificar., escribirlos, es muy útil para precompiladores, para lo que 
requiera hacer grabados de disco, o bases de datos en node requieren un 
uso intensivo de Node.Todo lo que hagamos con modulos por buenas 
prácticas son asincronos, pero tienen una version sincrona no 
recomendada pues pordría bloquear el event loop con más facilidad.

Para ver más sobre la documentación de FileSystem:

- [FileSystem Docs](https://nodejs.org/dist/latest-v12.x/docs/api/fs.html#fs_file_system)

```bash
const fs = require('fs');

function leer(ruta, cb) {
    fs.readFile(ruta, (err, data) => {
        cb(data.toString());
    })
}

function escribir(ruta, contenido, cb) {
    fs.writeFile(ruta, contenido, function (err) {
        if (err) {
            console.error('No he podido escribirlo', err);
        } else {
            console.log('Se ha escrito correctamente');
        }

    });
}

function borrar(ruta, cb) {
    fs.unlink(ruta, cb);
}

// escribir(__dirname + '/file.txt', 'Soy un archivo nuevo', console.log);
// leer(__dirname + '/file.txt', console.log)
borrar(__dirname + '/file.txt', console.log);

```

Lo mismo pero con promesas

```bash
const fs = require('fs');
const util = require('util');

const readFile = util.promisify(fs.readFile)

readFile('file.txt').then(file => {
	// 😎 do something 😎
}).catch(e => {
	console.error("🔥fire fire fire 🔥")
})

// o

async function foo() {
	try {
		const file = await readFile('file.txt')
		console.log("🥺🥺🥺")
	} catch(e) {
		console.error("🔥🔥🔥")
	}
}
```

## Console

Con console podemos imprimir todo tipo de valores por
nuestra terminal.

- **console.log**: recibe cualquier tipo y lo muestra en el consola.
- **[console.info](http://console.info/)**: es equivalente a log pero es usado para informar.
- **console.error**: es equivalente a log pero es usado para errores.
- **console.warn**: es equivalente a log pero es usado para warning.
- **console.table**: muestra una tabla a partir de un objeto.
- **console.count**: inicia un contador autoincremental.
- **console.countReset**: reinicia el contador a 0.
- **console.time**: inicia un cronometro en ms.
- **console.timeEnd**: Finaliza el cronometro.
- **console.group**: permite agrupar errores mediante identación.
- **console.groupEnd**: finaliza la agrupación.
- **console.clear**: Limpia la consola.

```jsx
// console.log()
    //imprime algo en consola
        console.log("Hola!");

// console.info()
    // es un alias de console.log
    console.info("Hola! (pero con .info)...");

// console.warn()
    // imprime una advertencia en consola;
        console.warn("Este sitio utiliza cookies" + " Este es un console.warn");

// console.error()
    //imprime un error en consola
        const code = 5;
        console.error("Hubo otro error", code);
        console.error(new Error ("Así también se declara un error"));

// console.table()
    // Tabula un grupo de datos
        const usuario = [
            {
                nombre: "Luis",
                apellido: "Lora",
                edad: 22
            },
            {
                nombre: "Agustín",
                apellido: "Morán",
                edad: 19
            }
        ]
        console.table(usuario);

// console.group() & console.groupEnd()
    // Agrupa una cantidad de datos en consola
        const dias = ["Lunes", "Martes", "Miércoles", "Jueves",
            "Viernes", "Sábado", "Domingo"];

        console.group("diasSemana")
        for (let i = 0; i < dias.length; i++) {
        console.log(dias[i]);
        };
        console.groupEnd("diasSemana")

// console.clear()
    // Límpia la consola
        function limpiarConsola () {
            setTimeout(() => {
                console.clear("Limpiando cada 5 segs");
            }, 10000)
        }
        limpiarConsola();

// console.count() & console.countReset()
    // Cuenta la cantidad de veces que se ejecuta algo
        console.count("Veces");
        console.count("Veces");
        console.countReset("Veces");
        console.count("Veces");
        console.count("Veces");

// console.time() & console.timeEnd()
    // determina el tiempo que demora un proceso en ocurrir
        console.time("100-elementos")
        for (let i = 0; i < 100; i++){
        };
        console.timeEnd("100-elementos")
```

## Try/Cathc Trow

[throw](https://developer.mozilla.org/es/docs/Web/JavaScript/Referencia/Sentencias/throw)

Usamos try catch para manejar errores y evitar que se detenga node

```jsx
function otraFuncion() {
     serompe();
}

function serompe() {
    return 3+z;
}

function serompeASYNC(cb) {

    setTimeout(function () {
        try {
            return z+3;
        } catch (error) {
            console.log('error funcion asincrona');
            cb(error);
        }
    },1000);
}

try {
    // otraFuncion();
    serompeASYNC(function (error) {
        console.log(error.message);
    
    });
} catch (error) {
    console.error("No fu posible entrgegar respuesta")
    console.error(error.message);
    console.error(error);
}
```

## Procesos hijo

[Node.js v15.4.0 Documentation](https://nodejs.org/api/child_process.html#child_process_child_process_spawn_command_args_options)

[Diferencia entre spawn y exec de child_process de NodeJS - michelletorres](https://blog.michelletorres.mx/diferencia-entre-spawn-y-exec-de-child_process-de-nodejs/)

Node nos permite ejecutar varios hilos de procesos desde el suyo propio,
 sin importar de que sea este proceso, es decir, puede ejecutar procesos
 de Python, otros procesos de Node u otro proceso que tengamos en 
nuestro sistema.

Para poder usar estos procesos usamos el modulo de child-process, este 
trae dos métodos que nos permitirá ejecutar los procesos que deseemos. 
El método exec y el método spawn.

El método exec nos permite ejecutar un comando en nuestro sistema, 
recibe como parametros el comando entero que deseemos y como segundo 
parámetro un callback con tres parámetros, un error, un stdout y un 
stderr.

El método spawn es parecido al método exec pero un poco más complejo, 
permitiéndonos conocer su estado y que datos procesa en cada momento del
 estado de comando ejecutado.

La diferencia más significativa entre child_process.spawn y 
child_process.exec está en lo que spawn devuelve un stream y exec 
devuelve un buffer.

- Usa **spawn** cuando quieras que el proceso hijo devuelva datos binarios enormes a Node.
- Usa **exec** cuando quieras que el proceso hijo devuelva mensajes de estado simples.
- Usa **spawn** cuando quieras recibir datos desde que el proceso arranca.
- Usa **exec** cuando solo quieras recibir datos al final de la ejecución.

Un buen blog para revisar mas del tema:

## Modulos nativos de c++

[Node.js v15.4.0 Documentation](https://nodejs.org/api/addons.html)

[node-gyp](https://www.npmjs.com/package/node-gyp)

Debido a que node y V8 estan escritos en c++ podemos crear modulos nativos en c++ para aprovechar la potencia del mismo para fines especificos

primero tenemos que descarga node-gyp

```jsx

npm install -g node-gyp
```

<aside>
💡 Hay que tener instalado el compilador de c++, make,     python                                                         Ubuntu:  sudo apt install build-essentials python2 python3                                                                                                    Fedora   dnf install @development-tools                                                                                         Arch:     ya viene instalado

</aside>

creamos el archivo del modulo en c++

```cpp
// hello.cc
#include <node.h>

namespace demo {

using v8::FunctionCallbackInfo;
using v8::Isolate;
using v8::Local;
using v8::Object;
using v8::String;
using v8::Value;

void Method(const FunctionCallbackInfo<Value>& args) {
  Isolate* isolate = args.GetIsolate();
  args.GetReturnValue().Set(String::NewFromUtf8(
      isolate, "world").ToLocalChecked());
}

void Initialize(Local<Object> exports) {
  NODE_SET_METHOD(exports, "hello", Method);
}

NODE_MODULE(NODE_GYP_MODULE_NAME, Initialize)

}  // namespace demo
```

Creamos el archivo de configuracion para los modulos

binding.gyp

```python
{
  "targets": [
    {
      "target_name": "addon",
      "sources": [ "hello.cc" ]
    }
  ]
}
```

configuramos el modulo

<aside>
💡 node-gyp configure

</aside>

Para ejecutarlo hacemos lo llamamos desde un archivo js

```python
// hello.js
const addon = require('./build/Release/addon');

console.log(addon.hello());
// Prints: 'world'
```

## HTTP

![https://2a316z1f16h02cda9nrufi1q-wpengine.netdna-ssl.com/wp-content/uploads/HTTP-Response-Cheat-Sheet.png](https://2a316z1f16h02cda9nrufi1q-wpengine.netdna-ssl.com/wp-content/uploads/HTTP-Response-Cheat-Sheet.png)

To use the HTTP server and client one must `require('http')`.

The HTTP interfaces in Node.js are designed to support many features
of the protocol which have been traditionally difficult to use.
In particular, large, possibly chunk-encoded, messages. The interface is
careful to never buffer entire requests or responses, so the
user is able to stream data.

[Node.js v15.4.0 Documentation](https://nodejs.org/dist/latest-v14.x/docs/api/http.html)

```jsx
const {createServer} = require('http')

const port = 3000

function router(req, res) {
    console.info('Nueva petición')
    console.log(req.url);
    res.writeHead(200, {'Content-Type': 'text/plain'})
    switch (req.url) {
        case '/':
            res.end('<h1>Hola mundo</h1>')
            break;
            default:
                res.write('404 ! Ingresa un url Valida ;)')
                res.end()
         
    }
}

const server = createServer(router).listen(port)
console.log('Escuchando en el puerto ' + port);
```

## OS

[Node.js v15.4.0 Documentation](https://nodejs.org/dist/latest-v14.x/docs/api/os.html)

El modulo OS nos provee utilidades a nivel del sistema operativo

Como la arquitectura, la cantidad de memoria libre, entre otros.

```jsx
const os = require("os");
console.clear()
// Architecture
console.log("Architecture:");
console.log(os.arch());
console.log("");

// Platform
console.log("Platform:");
console.log(os.platform());
console.log("");

// cpus
console.log("cpus");
console.log(os.cpus().length);
console.log("");

// Errores y señales del sistema
console.log("Erros and signals of the system");
console.log(os.constants);
console.log("");

// Function to convert from bytes to kbytes, mbytes and gbytes
const SIZE = 1024;

kb = (bytes) => {
  return bytes / SIZE;
};
mb = (bytes) => {
  return kb(bytes) / SIZE;
};
gb = (bytes) => {
  return mb(bytes) / SIZE;
};

// Total Ram Memory
console.log("Total Ram Memory:");
console.log(`${os.totalmem()} bytes`);
console.log(`${kb(os.totalmem)} kb`);
console.log(`${mb(os.totalmem)} mb`);
console.log(`${gb(os.totalmem)} gb`);
console.log("");

// Free memory we have in bytes units
console.log("Free memory we have in kbytes units");
console.log(`free Ram memory: ${os.freemem()} bytes`);
console.log(`free Ram memory: ${kb(os.freemem())} kb`);
console.log(`free Ram memory: ${mb(os.freemem())} mb`);
console.log(`free Ram memory: ${gb(os.freemem())} mb`);
console.log("");

// Directory for the user root
console.log("Directory for the user root");
console.log(os.homedir());
console.log("");

// Directory for temporal files
console.log("Directory for temporal files");
console.log(os.tmpdir());
console.log("");

// Hostname of a server
console.log("Hostname of any server");
console.log(os.hostname());
console.log("");

// Actived Network interfaces right now
console.log("Network Interfaces right now");
console.log(os.networkInterfaces());
console.log("");
```

![https://static.platzi.com/media/user_upload/Unidades-de-medida-de-almacenamiento1-59bd448f-6ac5-4aca-8841-dce5e93aaf97.jpg](https://static.platzi.com/media/user_upload/Unidades-de-medida-de-almacenamiento1-59bd448f-6ac5-4aca-8841-dce5e93aaf97.jpg)

## Process

[Node.js v15.4.0 Documentation](https://nodejs.org/dist/latest-v14.x/docs/api/process.html)

The process object is a global that provides information about, and control over, the current Node.js process. As a global, it is always available to Node.js applications without using require(). It can also be explicitly accessed using require():

<aside>
💡 const process = require('process');

</aside>

El objecto process es una instancia de  `EventEmitter`; podemos suscribirnos a el para escuchar eventos de node.

- **UncaughtException**: Permite capturar cualquier error
que no fue caputurado previamente. Esto evita que Node cierre todos los
hijos al encontrar un error no manejado.
    
    ```
    process.on('uncaughtException', (error, origen) => console.log(error, origen));
    
    ```
    
- **exit**: Se ejecuta cuando node detiene el `eventloop` y cierra su proceso principal.
    
    ```
    process.on('exit', () => console.log('Adios'));
    
    ```
    
    ```jsx
    const process = require('process')
    
    process.on('beforeExit', () =>{
        console.log('Ey !! El proceso esta a punto de acabar')
    })
    
    process.on('exit', () =>{
        console.log('El proceso acabo')
    })
    
    process.on('uncaughtException', (err) =>{
        console.log(`Ocurio un error: ${err.message}`)
    })
    
    ```
    
    ## Require e Import
    
    En Node tenemos una forma de importar módulos la cual es con el método 
    require, el cual es la forma por defecto de importar módulos, ya sean 
    nuestros propios módulos como los de otras personas en nuestros 
    proyectos JS, pero suele haber mucha confusión debido al import.
    
    Import es la forma de importar módulos en Ecmascript, el cual es un 
    estándar de JavaScript para la web, esta forma de importar en teoría 
    Node no la acepta oficialmente, a no ser que usemos su modo de .mjs.
    
    Pero gracias a compiladores como Babel, nosotros podremos utilizar estas
     normas de Ecmascript en nuestro código para cuando se ejecute se 
    transforme en código que sea aceptable por Node.
    
    Se recomienda en la mayoría de veces la importación con require.
    
    ## Modulos Utiles
    
    La función de cifrado de **bcrypt** nos permite construir una plataforma de seguridad utilizando contraseñas encriptadas con Salt.
    
    ```
    const bcrypt = require("bcrypt");
    const password = "NuncaParesDeAprender2020";
    
    bcrypt.hash(password, 5, function(err, hash){
    	console.log(hash)
    });
    // La consola nos entregaria una contraseña distinta en cada oportunidad.
    
    // Para evaluar si una contraseña concuerda con un hash
    bcrypt.compare(password, hash, function(error, result){
    	console.log(result)
    	console.log(error)
    })
    // Nos va a responder **true** *(en el result)* o **false** *(en el error)* dependiendo si la contraseña puede generar el hash
    
    ```
    
    **Moment. js** es una librería que nos permite solventar estos problemas e implementa un sistema de manejo de fechas mucho más cómodo.
    
    ```
    const moment = require('moment')
    const ahora = moment();
    
    // Para formatear una fecha
    ahora.format('MM/DD/YYYY HH:MM A'); // 04/11/2020 20:10 PM
    
    // Para validad una fecha
    moment('2020-04-11').isValid(); // Nos dara **true** o **false** dependiendo de si la fecha es valida o no
    
    // Para encontrar cuanto tiempo ha pasado hasta hoy
    moment('2018-04-11').fromNow(); // Hace 2 años
    
    // Para agregar o eliminar años, días o meses
    moment('2020-04-11').add(1, 'years'); // 2021-04-11
    moment('2020-04-11').subtract(1, 'years'); // 2019-04-11
    
    ```
    
    **Sharp** puede convertir imágenes grandes en imágenes JPEG, PNG más pequeñas y compatibles con la web de diferentes dimensiones.
    
    ```
    const sharp = require('sharp')
    
    // La siguiente reducira una imagen de 120x120 o cualquier tamaño a 80x80 y lo guardara en una imagen mas pequeña sin eliminr la original.
    sharp('imagen.png').resize(80, 80).toFile('imagen_80x80.png');
    ```
    
    ## Buffers
    
    [Do you want a better understanding of Buffer in Node.js? Check this out.](https://medium.com/free-code-camp/do-you-want-a-better-understanding-of-buffer-in-node-js-check-this-out-2e29de2968e8)
    
    **¿Qué es un Buffer?**
    Buffers son objetos usados para represnetar un secuencia de bytes con 
    una longitud fija. Es una subclase de Uint8Arrays  y esta en el scope 
    global. Estan diseñadas para trabajar con datos binarios.
    
    **¿Por qué usar Buffers?**
    JavaScript puro aunque bueno con cadenas de texto unicode no maneja muy 
    bien datos binarios. Esto esta bien el el navegador donde casi toda la 
    data proviene de strings. Sin embargo los servidores con Node también 
    tienen que lidiar con TCP strams o con leet y escribir en el sistema de 
    archivos. Ambos necesitan usar streams de datos binarios.
    
    Una maneja de manjear esto es usar strings que es lo que Node intento
     hacer primero. Este approach resulto bastante problematico porque tiene
     una tendencia a romperse de maneas extrañas y misteriosas.
    
    Para crear un buffer, con 4 espacios por ejemplo, podemos hacerlo con la siguiente sintaxis.
    
    ```
    let buffer = Buffer.alloc(4);
    console.log(buffer); 
    // Output:
    //<Buffer 00 00 00 00>
    
    ```
    
    <h3>Otras formas de crear un buffer</h3>
    
    Datos en un arreglo
    
    ```
    let buffer2 = Buffer.from([1,2,3]);
    console.log(buffer2);
    
    ```
    
    Datos de tipo string
    
    ```
    let buffer3 = Buffer.from('Hola');
    console.log(buffer3);
    console.log(buffer3.toString());
    
    ```
    
    Guardar el abecedario en un buffer
    
    ```
    let abc =  Buffer.alloc(26);
    console.log(abc);
    
    for (let i = 0; i< abc.length; i++){
      abc[i] = i + 97;
    }
    
    console.log(abc);
    console.log(abc.toString())
    
    ```
    
    ## Streams
    
    - * Stream**
    Podría decirse que un Stream es el proceso de ir consumiendo datos al
    tiempo en que se reciben. Por ejemplo, cuando vemos un video en Youtube
    estamos consumiendo datos por medio de streaming (readable stream,
    porque solo podemos ver los videos mas no editarlos) ya que lo vemos al
    mismo tiempo en que este se está descargando. de lo contrario habría que esperar a que se descargue el video por completo para poder verlo.
    
    **buffer**
    Si en el caso anterior, mientras vemos el video, fallara el internet, 
    así sea por un segundo, la reproducción se pararía instantáneamente. 
    Pero sabemos que en realidad no es así, el video continúa 
    reproduciéndose por un tiempo mas. Esto es gracias a la implementación  
    de un buffer el cuál es un espacio en memoria ram en donde la 
    información proveniente del servidor llega por fragmentos (chunks), para
     luego ser consumido, y como ese almacenamiento de datos en el buffer se
     hace a bajo nivel, de forma binaria, el proceso es mucho mas rápido de 
    lo que se consume. Es por eso que cuando reproducimos un video en 
    Youtube vemos que este se carga mas rápido. (dependiendo del ancho de 
    banda claro está)
    
    ![https://static.platzi.com/media/user_upload/Ejemplobuffer-7c9b1f95-15ae-44d0-b460-405f66297583.jpg](https://static.platzi.com/media/user_upload/Ejemplobuffer-7c9b1f95-15ae-44d0-b460-405f66297583.jpg)
    
    ![https://static.platzi.com/media/user_upload/stream-5fb5aa4a-f262-41f3-a19c-a44b356f1f37.jpg](https://static.platzi.com/media/user_upload/stream-5fb5aa4a-f262-41f3-a19c-a44b356f1f37.jpg)
    
    # 5. Conocer trucos que no quieren que sepas
    
    ## Benchmarking (console time y timeEnd)
    
    La función **console.time(‘nombre’)**
     inicia un temporizador que se puede usar para rastrear cuánto tiempo 
    dura una operación. El temporizador sera identificado por el *nombre* dado a la consola. Ese mismo nombre se utilizara cuando se llame a **console.timeEnd(*‘nombre’*)** para detener el temporizador y obtener el tiempo demorado durante el proceso.
    
    ```jsx
    console.time("Temporizador");
    for (var i = 0; i < 10000; i++) {
      // Nuestro codigo entre los temporizadores puede ser cualquier cosa.
    }
    console.timeEnd("Temporizador");
    ```
    
    ## Error First Callbacks
    
    Los Error First Callbacks se utilizan para pasar primero el error y los datos posteriormente. Entonces, puedes verificar el primer argumento, es decir, el objeto de error para ver si algo salió mal y puedes manejarlo. En caso de que no haya ningún error, puedes utilizar los argumentos posteriores y seguir adelante. Básicamente es todo lo que el profesor ha estado haciendo cuando en el callback devuelve (err, result)
    
    ```jsx
    fs.readFile('/text.txt', function(err, data) {
    	if (err) {
    		console.log(err);
    	} else {
    		console.log(data);
    	} 
    });
    ```
    
    ## Scraping
    
    Web scraping es una técnica utilizada mediante programas de software 
    para extraer información de sitios web. Usualmente, estos programas 
    simulan la navegación de un humano en la World Wide Web ya sea 
    utilizando el protocolo HTTP manualmente, o incrustando un navegador en 
    una aplicación.
    
    [Wikipedia: Web Scraping](https://es.wikipedia.org/wiki/Web_scraping)
    
    ```jsx
    /*
      Entendiendo web scrapping con puppeteer...
      Funciona de forma asincrona
    */
    const puppeteer = require('puppeteer');
    
    // Funcion autoejecutable
    (async () => {
      console.log('Lanzar el navegador');
      // const browser = await puppeteer.launch();
      /*
        {headless: false} lo que hace es que el navegador no
        se lance en segundo plano
      */
      const browser = await puppeteer.launch({headless: false});
      // Abrir una pagina en el navegador
      const page = await browser.newPage();
      // Ir a una pagina
      await page.goto('https://wikipedia.org/wiki/Node.js');
      /*
        Ejecutar un script, con page.evaluate,
        lo que hace es evaluar lo que le digamos dentro de la pagina y
        devolver el resultado
      */
      const titulo1 = await page.evaluate(() => {
        const h1 = document.querySelector('h1');
        return h1.innerHTML;
      });
      console.log(titulo1);
      // Usamos browser.close para cerrar el navegador despues de haber extraido los datos;
      console.log('Cerrando el navegador');
      browser.close();
      console.log('Navegador cerrado');
    
    })();`
    ```
    
    ## Automatización de procesos - Gulp
    
    **Que es gulp.js?** 📖🖥💥
    
    Es una herramienta de construcción en JavaScript construida sobre 
    flujos de nodos . Estos flujos facilitan la conexión de operaciones de 
    archivos a través de canalizaciones . Gulp lee el sistema de archivos y 
    canaliza los datos disponibles de un complemento de un solo propósito a 
    otro a través del .pipe()operador, haciendo una tarea a la vez. Los 
    archivos originales no se ven afectados hasta que se procesan todos los 
    complementos. Se puede configurar para modificar los archivos originales
     o para crear nuevos. Esto otorga la capacidad de realizar tareas 
    complejas mediante la vinculación de sus numerosos complementos. Los 
    usuarios también pueden escribir sus propios complementos para definir 
    sus propias tareas. [Wikipedia](https://en.wikipedia.org/wiki/Gulp.js).
    
    👉 [Empezando con Gulp.js](https://semaphoreci.com/community/tutorials/getting-started-with-gulp-js)
    👉 [Automatiza tu flujo de trabajo con GulpJS](https://platzi.com/blog/automatizacion-gulp-js/)
    
    ```jsx
    /*
      Trabajando automatizacion de procesos con gulp
    */
    const gulp = require('gulp');
    const server = require('gulp-server-livereload');
    
    /*
      Iniciar una tarea con gulp, usando task que recibe dos parametros
      1. El nombre de la tarea.
      2. Un callback que tambien recibe un callback
    */
    gulp.task('build', function(fn){
      console.log('Contruyendo el sitio');
      setTimeout(fn, 1200);
    });
    
    gulp.task('serve', function(fn){
      // pipe encadena streams
      gulp.src('www')
        .pipe(server({
          livereload: true,
          open: true
        }))
    });
    
    // Encadenar tareas
    gulp.task('default', gulp.series('build', 'serve'));
    ```
    
    ## Aplicaciones de escritorio
    
    ```html
    <html>
        <head>
            <style>
                body {
                    background: #333333;
                    color: #ffffff;
                }
            </style>
        </head>
        <body>
            <h1>Soy una apliccion de escritorio</h1>
            <button>Super bonton</button>
        </body>
        
    </html>
    
    ```
    
    ```jsx
    const { app, BrowserWindow } = require('electron');
    
    let ventanaPrincipal;
    
    app.on('ready', crearVentana);
    
    function crearVentana() {
        ventanaPrincipal = new BrowserWindow({
            width: 800,
            height: 600,
        });
    
        ventanaPrincipal.loadFile('index.html');
    }
    
    ```