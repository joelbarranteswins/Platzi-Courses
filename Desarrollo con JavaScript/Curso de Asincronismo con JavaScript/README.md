# Curso de Asincronismo con JavaScript

## 1. Lo que aprenderás en este curso

Aprenderemos:  
- La importancia del uso de este concepto en JS
- Las principales elementos que tiene JS para manejar el asincronismo:
    - Callbacks
    - Promesas
    - Async/await
- Tendremos un proyecto aplicando lo aprendido, usaremos HTML, CSS y JS además de desplegarlo.

El asincronismo en JS tiene 2 aspectos:  
- Los elementos del navegador que lo hacen posible
- Las formas de usarlo al escribir el código.

Este curso se centra en lo segundo, tocando por encima lo primero, en un video. Pero realmente no es necesario saber la funcionamiento del navegador, solo necesitas entender por encima el concepto de asincronismo, no que sucede tras la cortina.  

**Recomendación:**  
Para tener una mejor base sobre la forma de trabajar de JS en el navegador deben llevar el curso de JS Engine V8 y/o el curso de JS profesional. El asincronismo de JS es posible gracias a una parte del navegador conocido como event loop ( algo que el profesor explicará) la cual trabaja con otras partes del navegador que estaría bien conocieran.

- [Resumen 01 en Notion](https://luis-ariza.notion.site/Asincronismo-con-JavaScript-7307b668977d416690103a4dbbf2843a)
- [Resumen 02 en Notion](https://whip-soil-3b5.notion.site/Curso-de-Asincronismo-con-JavaScript-6ec5da50d2644a8aa046bfe23b217c22)

## 2. Qué es el asincronismo

JavaScript es síncrono por defecto y tiene un solo subproceso (un solo hilo para trabajar).

JavaScript es síncrono y no bloqueante, con un bucle de eventos (concurrencia), implementado con un único hilo para sus interfaces de I/O.

JavaScript es single-threaded aún con múltiples procesadores, solo se pueden ejecutar tareas en un solo hilo, llamado el hilo principal.

> 🔥 Sincrónico = sucede al mismo tiempo. 
> 🔥 Asincrónico = no sucede al mismo tiempo.

### Conceptos importantes para entender el asincronismo:  

#### Thread  
Un Thread o hilo, es una secuencia de instrucciones que se ejecutan de forma concurrente. Esto se **simula** mediante la programación asíncrona y el uso de Web Workers. Aunque no se creen hilos reales, se logra la ejecución concurrente de tareas en segundo plano, permitiendo un mejor rendimiento y evitando bloqueos en el hilo principal.  

#### Bloqueante  
Se refiere a una operación que detiene la ejecución del hilo principal hasta que dicha operación se complete. Una llamada u operación bloqueante no devuelve el control a la aplicación hasta que se ha completado. Durante ese tiempo, el thread o hilo principal no puede realizar ninguna otra tarea y queda bloqueado, en estado de espera (inactivo). Ejemplo: Una alerta.  

#### No bloqueante  
Se refiere a una operación que no detiene la ejecución del hilo principal mientras se lleva a cabo. En lugar de esperar a que la operación se complete, se programa para ejecutarse en segundo plano o de manera asíncrona. Esto permite que el hilo principal continúe ejecutando otras tareas sin quedar inactivo. Las operaciones no bloqueantes, como las solicitudes de red o las operaciones de archivo, se gestionan mediante devoluciones de llamada (callbacks), promesas o async/await, lo que permite que el programa siga avanzando sin interrupciones mientras se esperan los resultados de la operación.

> Una tarea no bloqueante se devuelve inmediatamente con independencia del resultado. Si se completó, devuelve los datos. Si no, un error.  

#### Síncrono  
En JavaScript, "síncrono" se refiere a un tipo de ejecución secuencial en la que una tarea debe completarse antes de que otra pueda comenzar. En un contexto síncrono, el programa espera a que una operación se complete antes de pasar a la siguiente línea de código. Esto significa que la ejecución se bloquea hasta que la operación actual finalice. Las operaciones síncronas pueden incluir llamadas a funciones, bucles y operaciones de lectura/escritura de archivos locales. Durante la ejecución sincrónica, no se pueden realizar otras tareas y el programa sigue una secuencia de instrucciones en orden.

#### Asíncrono  
Se refiere a un tipo de ejecución en la que las tareas se realizan de forma independiente y sin bloquear el hilo principal. En un contexto asíncrono, una tarea puede comenzar su ejecución y continuar en segundo plano mientras el programa principal sigue ejecutando otras tareas. 

Las operaciones asíncronas se gestionan mediante callbacks, promesas o async/await, lo que permite que el programa continúe su flujo de ejecución sin esperar a que la tarea asíncrona se complete. Esto es especialmente útil para operaciones que pueden llevar tiempo, como solicitudes de red, operaciones de archivo o llamadas a API, ya que permite que otras partes del programa sigan funcionando sin bloqueos.


#### Paralelismo
Se refiere a la capacidad de ejecutar múltiples tareas simultáneamente en diferentes hilos o núcleos de procesamiento. Sin embargo, es importante tener en cuenta que JavaScript por sí solo no admite paralelismo real a nivel de hilos debido a su naturaleza de un solo subproceso (single-threaded).

Sin embargo, mediante el uso de Web Workers, que son scripts en segundo plano, se puede lograr un tipo limitado de paralelismo en JavaScript. Los Web Workers permiten ejecutar tareas en hilos separados, lo que puede mejorar el rendimiento y la capacidad de respuesta de una aplicación al realizar cálculos intensivos o tareas que requieren mucho tiempo, dejando el hilo principal libre para otras operaciones. Aunque los Web Workers no brindan un paralelismo completo, pueden aprovechar los múltiples núcleos de procesamiento disponibles en los dispositivos modernos para realizar tareas en paralelo de manera eficiente.


#### Concurrencia  
Se refiere a la capacidad de ejecutar múltiples tareas de manera independiente y en un orden no determinístico. A diferencia del paralelismo, que implica la ejecución simultánea de tareas en diferentes hilos o núcleos, la concurrencia en JavaScript se logra a través del modelo de programación asíncrona.

Las operaciones asíncronas, como las solicitudes de red o las operaciones de lectura/escritura de archivos, se ejecutan de manera concurrente en el hilo principal y se manejan mediante callbacks, promesas o async/await. Esto permite que varias tareas se inicien y se realicen en paralelo, aprovechando eficientemente el tiempo de procesamiento y evitando bloqueos. La concurrencia en JavaScript es especialmente útil para mejorar la capacidad de respuesta de las aplicaciones y evita que el hilo principal se bloquee mientras se esperan resultados de operaciones que pueden llevar tiempo.


#### Eventloop o Bucle de eventos
Es un mecanismo clave para el manejo de la concurrencia y la ejecución asíncrona. Es parte del entorno de tiempo de ejecución de JavaScript, como el navegador o Node.js.

El Event Loop se encarga de manejar y coordinar la ejecución de eventos y tareas asíncronas en JavaScript. Funciona de la siguiente manera: cuando se ejecuta un código, las tareas síncronas se ejecutan de inmediato, mientras que las tareas asíncronas se colocan en una cola de eventos.

El Event Loop monitorea constantemente la pila de llamadas y la cola de eventos. Cuando la pila de llamadas está vacía, toma el siguiente evento de la cola y lo procesa, lo que implica la ejecución de su callback asociado. Esto permite que las tareas asíncronas se ejecuten en el momento adecuado sin bloquear la ejecución del hilo principal.

En resumen, el Event Loop garantiza que las tareas asíncronas se ejecuten en el momento adecuado y mantiene la capacidad de respuesta del programa mientras maneja la concurrencia en JavaScript.

> El bucle de eventos es un patrón de diseño que espera y distribuye eventos o mensajes en un programa.  

### Formas de manejar la asincronía en JavaScript:  

- **Callbacks**: Una función que se pasa como argumento de otra función y que será invocada.  
- **Promesas**: (Implementado en ES6) Una promesa es una función no-bloqueante y asíncrona, la cual puede retornar un valor ahora, en el futuro o nunca.  
- **Async / Await**: (Implementado en ES2017) Permite estructurar una función asincrónica sin bloqueo de una manera similar a una función sincrónica ordinaria.  

📌 _En JavaScript_ casi todas las operaciones de I/O (Entrada y Salida) no se bloquean. A esto se le conoce como asincronismo. Lo único que no es procesado antes de que termine la operación son _los callbacks_, ya que estos están amarrados a una operación y esperan a que sea finalizada para poder ejecutarse.  

⏳ _El asincronismo_ es una manera de aprovechar el tiempo y los recursos de la aplicación, ejecutando tareas y procesos mientras otros son resueltos en background (como la llegada de la información de una API), para posteriormente continuar con las tareas que requerían esa información que no tenías de manera instantánea.  

#### Ejemplo de sincronismo vs. asincronismo

Imagina que JavaScript es una tienda de tacos, tú trabajas ahí y solamente puedes hacer una preparación a la vez. Llegan tres personas que ordenan un taco, una torta y un taco, y tienes que atenderlos en ese orden.

El primer taco probablemente se demore 5 minutos. Luego, la preparación de la torta es más compleja, por lo que posiblemente demorará 20 minutos. En este punto, el **tercer** cliente se ha hartado de la espera y se retira. Este proceso no es óptimo.

```js
console.log("taco")
console.log("torta")
console.log("taco")
```

En Internet sucede lo mismo, si un usuario no observa información en tu página web en los primeros cinco segundo, se retirará.

Entonces, una solución sería ejecutar las tareas más lentas (torta) después de las más rápidas (tacos). Y esta solución se llama **asincronismo** y JavaScript tiene una manera de manejarlo.

Para entender mejor que es el asincronismo, retomemos el ejemplo de los tacos, pero ahora tienes un compañero. Entonces tú delegas la tarea de preparar la torta a otra persona, mientras realizas los tacos.

Luego de 5 minutos por cada tarea, entregas los tacos a los clientes correspondientes. Después de 10 minutos necesitas la torta, entonces preguntas ¿ya está lista la torta? Tu ayudante te entrega la torta y se lo entregas. En total fueron 20 minutos y todos los clientes recibieron su pedido. Así funciona la asincronía en JavaScript.

🌮 - **call stack** : _el taquero (órdenes rápidas)_  
👨‍🍳 - **web APIs** : _la cocina_  
🌯 - **callback queue** : _las órdenes preparadas_  
💁‍♂️ - **event loop** : _el mesero_

![](https://i.postimg.cc/L5pgfgVK/3-v8.png)

[[js-engine-v8+nav#11. JavaScript Runtime o tiempo de ejecución]]  
[[js-engine-v8+nav#12. Qué es la asincronía en JavaScript]]
[JavaScript — Cómo funciona el Runtime Environment — JRE)](https://mauriciogc.medium.com/javascript-c%C3%B3mo-funciona-el-runtime-environment-jre-8ebceafdc938)


## 3. Event Loop

[[js-engine-v8+nav#Event Loop]]  

El bucle de eventos es un patrón de diseño que **espera** y **distribuye** eventos o mensajes en un programa. 

![](https://i.postimg.cc/L5pgfgVK/3-v8.png)
![](https://i.postimg.cc/hvfjTH0v/3-runtime-environment.png)
![](https://i.postimg.cc/zXGHtjtD/12-asincronia.gif)
![](https://i.postimg.cc/qMgpkN4d/3-proceso.png)


Ver los apuntes del `Curso de JavaScript Engine (V8) y el Navegador`:  
[[js-engine-v8+nav#7. Memory Heap]]
[[js-engine-v8+nav#8. Qué es Call Stack]]
[[js-engine-v8+nav#12. Qué es la asincronía en JavaScript]]

[Más info](https://slawinski.dev/blog/javascript-runtime-environment-web-api-task-queue-and-event-loop/)

## 4. Iniciando a programar con JavaScript

> Insistir, persistir, resistir y nunca desistir. ❤️


## 5. Configuración

Creamos una carpeta para trabajar el proyecto y luego ejecutamos uno de estos dos comandos: 

```bash
git init // Para configuración personalizada
npm init -y // Para configuración por defecto
```

Creamos la siguiente estructura para trabajar e instalamos la extensión **Code Runner**: 

```bash
╰─ tree -L 3
.
├── package.json
├── .gitignore //👈👀🔥 Agregamos /node_modules/
└── src
    └── callback
        └── index.js
```

📌 Nota: Un comando útil para ignorar archivos cuando se utiliza git con **node** es:

```bash
npx gitignore node
```


### Conceptos fundamentales antes de crear el proyecto:  

#### Web APIs JavaScript del lado del cliente
Las "Web APIs JavaScript del lado del cliente" son conjuntos de interfaces y funcionalidades proporcionadas por el entorno del navegador para permitir la interacción del código JavaScript con diversos aspectos del navegador y el entorno del usuario.

Estas APIs incluyen funcionalidades como la manipulación del DOM (Document Object Model), la gestión de eventos, la manipulación de elementos multimedia (audio y video), la manipulación de formularios, el acceso a la geolocalización, el almacenamiento local (localStorage, IndexedDB), la comunicación con servidores a través de XMLHttpRequest o Fetch API, entre otros.

Estas APIs proporcionan a los desarrolladores herramientas y capacidades adicionales para crear aplicaciones web interactivas y ricas en funcionalidades, permitiendo interactuar con elementos de la interfaz de usuario, acceder y modificar datos, realizar llamadas a servicios externos, entre otras operaciones, todo desde el lado del cliente (es decir, en el navegador del usuario).

Algunas de las Web APIs del lado del cliente más comunes incluyen:

- `DOM` (Document Object Model): Esta API proporciona una representación estructurada y accesible de los documentos HTML y XML en el navegador. Permite la manipulación y navegación de elementos, estilos, eventos y contenido de la página.

- `XMLHttpRequest` (XHR): Esta API permite realizar solicitudes HTTP asíncronas desde el navegador y recibir respuestas del servidor. Es ampliamente utilizada para realizar llamadas AJAX y obtener datos actualizados sin necesidad de recargar la página.

- `Fetch`: Esta API también permite realizar solicitudes HTTP asíncronas desde el navegador, pero proporciona una interfaz más moderna y basada en promesas para manejar las respuestas.

- `Web Storage`: Esta API proporciona mecanismos para almacenar datos en el navegador, incluyendo `localStorage` y `sessionStorage`, que permiten almacenar datos persistentes o de sesión respectivamente.

- `Geolocation`: Esta API permite acceder a la ubicación geográfica del usuario si se le da permiso. Proporciona información sobre la latitud, longitud y precisión del dispositivo.

- `Canvas`: Esta API permite la creación y manipulación de gráficos y dibujos en tiempo real utilizando JavaScript. Se utiliza para crear gráficos, animaciones y visualizaciones interactivas en el navegador.

Estas son solo algunas de las Web APIs del lado del cliente disponibles en los navegadores modernos. Existen muchas más API que proporcionan funcionalidades adicionales para interactuar con el entorno del usuario y crear aplicaciones web ricas en funcionalidades.

#### API
API significa "Application Programming Interface" (Interfaz de Programación de Aplicaciones). 

En JavaScript una API es un conjunto de reglas y funciones que proporcionan una interfaz estandarizada para interactuar con componentes de software, como el navegador, el sistema operativo o servicios externos. Estas APIs permiten a los desarrolladores acceder a funcionalidades específicas y realizar tareas como manipular el DOM, realizar solicitudes HTTP, acceder a la geolocalización y mucho más, simplificando el desarrollo de aplicaciones al proporcionar una interfaz bien definida y documentada.


#### Hoisting
El "hoisting" en JavaScript es un comportamiento especial del lenguaje donde las declaraciones de variables y funciones se mueven automáticamente al comienzo de su ámbito, antes de que se ejecute el código. En otras palabras, las declaraciones son "elevadas" o "izadas" al principio del ámbito en lugar de mantenerse en su posición original en el código.

Esto significa que, aunque se declare una variable o función en cualquier parte del código, en realidad se procesará y se reconocerá antes de ejecutar cualquier otra línea de código en ese ámbito.

Por ejemplo, en el siguiente código:

```javascript
console.log(x); // undefined
var x = 5;
console.log(x); // 5
```

Aunque la variable `x` se imprime antes de que se le asigne un valor, no se produce un error. Esto se debe a que la declaración `var x` es elevada al principio del ámbito, lo que significa que su declaración se procesa antes de que se ejecute el código en sí. Como resultado, `x` se considera declarada pero sin un valor asignado, lo que se representa como `undefined` cuando se imprime en la primera línea. Luego, cuando se le asigna o inicializa con el valor `5`, se imprime correctamente.

📌 Nota: Es importante tener en cuenta que solo se eleva la **declaración** de las variables y no la asignación. Además, el hoisting solo ocurre en el ámbito de las funciones o en el ámbito global cuando se utiliza `var`. Otros tipos de declaraciones, como `let` y `const`, no se ven afectados por el hoisting en la misma medida. Por lo tanto, es una buena práctica declarar las variables al comienzo de su ámbito para evitar confusiones y errores.

#### XML  
XML (eXtensible Markup Language) es un lenguaje de marcado utilizado para estructurar datos en un formato legible por humanos y máquinas. En JavaScript, se puede trabajar con XML utilizando las API proporcionadas por el navegador, como el DOM (Document Object Model).

Con el DOM, es posible cargar y analizar documentos XML, acceder a los elementos y atributos del documento, realizar modificaciones en la estructura, y extraer o modificar los datos contenidos en el XML.

Por ejemplo, supongamos que tenemos el siguiente fragmento de un documento XML:

```xml
<person>
  <name>John Doe</name>
  <age>30</age>
  <city>New York</city>
</person>
```

En JavaScript, podemos cargar este documento XML y acceder a sus elementos y atributos utilizando el DOM:

```js
// Cargar el documento XML
const parser = new DOMParser();
const xmlDoc = parser.parseFromString(xmlString, "text/xml");

// Acceder a los elementos y atributos
const personElement = xmlDoc.querySelector("person");
const nameElement = personElement.querySelector("name");
const ageElement = personElement.querySelector("age");
const cityElement = personElement.querySelector("city");

const name = nameElement.textContent;
const age = parseInt(ageElement.textContent);
const city = cityElement.textContent;

console.log(name); // "John Doe"
console.log(age); // 30
console.log(city); // "New York"
```

De esta manera, podemos utilizar JavaScript para cargar y manipular documentos XML, extraer datos, realizar modificaciones y trabajar con la estructura del XML utilizando el DOM y las API proporcionadas por el navegador.

##### JSON en lugar de XML 
Si bien JavaScript se puede utilizar para manipular documentos XML utilizando las API del DOM, es importante tener en cuenta que el uso de XML ha disminuido en popularidad en comparación con otros formatos de intercambio de datos, como JSON (JavaScript Object Notation).

En la actualidad, JSON es el formato de datos preferido en la mayoría de las aplicaciones web y servicios web. JSON es más ligero, más fácil de leer y escribir para los programadores, y se integra de manera más natural con JavaScript.

Sin embargo, aún puede haber casos en los que se encuentre trabajando con XML, especialmente en sistemas heredados o en aplicaciones específicas que todavía utilizan XML como formato de intercambio de datos. En tales casos, JavaScript y las API del DOM pueden ser utilizadas para cargar, manipular y extraer datos de documentos XML.

Ahora que si tiene el control sobre el formato de los datos y puede elegir, es recomendable considerar el uso de JSON u otros formatos más modernos y ampliamente aceptados en lugar de XML al trabajar con JavaScript y aplicaciones web en general.

#### DOM
DOM (Document Object Model) se refiere a una representación estructurada y accesible de los documentos HTML, XHTML o XML en forma de un árbol de elementos. El DOM permite manipular y acceder a los elementos, atributos y contenido de un documento web utilizando JavaScript.

En términos más simples, el DOM en JavaScript proporciona una interfaz para interactuar con los elementos de una página web. Esto significa que puedes acceder al contenido de un elemento, modificar su estilo, agregar o eliminar elementos, controlar eventos y realizar muchas otras acciones en tiempo real.

Por ejemplo, supongamos que tienes el siguiente fragmento de un documento HTML:

```html
<!DOCTYPE html>
<html>
  <head>
    <title>Mi página web</title>
  </head>
  <body>
    <h1>Bienvenido</h1>
    <p>Este es un párrafo de ejemplo.</p>
    <button id="myButton">Haz clic aquí</button>
  </body>
</html>
```

En JavaScript, puedes utilizar el DOM para acceder y manipular los elementos de la página:

```js
// Acceder al título de la página
const pageTitle = document.title;
console.log(pageTitle); // "Mi página web"

// Acceder al contenido del párrafo
const paragraph = document.querySelector("p");
console.log(paragraph.textContent); // "Este es un párrafo de ejemplo."

// Modificar el estilo del encabezado
const heading = document.querySelector("h1");
heading.style.color = "red";

// Agregar un evento al botón
const button = document.getElementById("myButton");
button.addEventListener("click", function() {
  alert("¡Haz hecho clic en el botón!");
});
```

En resumen, el DOM permite acceder, manipular y controlar los elementos y contenido de una página web. Esto proporciona la capacidad de interactuar con los elementos de una página, modificar su apariencia y comportamiento, y responder a eventos del usuario.

#### Events
Los "events" (eventos) son acciones o sucesos que ocurren en la interfaz de usuario o en el entorno de ejecución de una aplicación. Los eventos pueden ser desencadenados por el usuario, como hacer clic en un botón, mover el mouse sobre un elemento, o por el sistema, como la carga completa de un documento o el tiempo transcurrido en un temporizador.

Los eventos en JavaScript permiten que tu código responda y realice acciones específicas cuando ocurren estos sucesos. Puedes utilizar "event listeners" (escuchadores de eventos) para configurar funciones que se ejecuten cuando un evento en particular ocurra.

Por ejemplo, supongamos que tienes un botón con el id "myButton" en tu página HTML y deseas mostrar un mensaje cuando se haga clic en él. Puedes utilizar el evento "click" y un event listener para lograrlo:

```js
const button = document.getElementById("myButton");

button.addEventListener("click", function() {
  console.log("¡Has hecho clic en el botón!");
});
```

En este caso, cuando el usuario hace clic en el botón, se dispara el evento "click" y la función proporcionada como argumento al event listener se ejecuta, mostrando el mensaje en la consola.

Los eventos en JavaScript son fundamentales para crear interactividad en las aplicaciones web. Puedes utilizar eventos para responder a las acciones del usuario, como hacer clic, pasar el mouse, escribir en un campo de texto, así como para reaccionar a eventos del sistema, como la carga de la página o cambios en el estado de la aplicación.

En resumen, los eventos en JavaScript son sucesos que ocurren en la interfaz de usuario o en el entorno de ejecución de una aplicación. Permiten que tu código responda y realice acciones específicas cuando estos eventos ocurren, lo que brinda interactividad y dinamismo a tus aplicaciones web.


#### Compilar
En desarrollo web, "compilar" se refiere al proceso de convertir código fuente escrito en un lenguaje de programación adicional, como TypeScript o Sass, en código JavaScript que pueda ser interpretado por los navegadores. Esto se logra mediante el uso de herramientas llamadas "compiladores" o "transpiladores". La compilación permite utilizar características avanzadas y sintaxis propias de estos lenguajes adicionales, y luego transformarlas en código JavaScript estándar para su ejecución en el navegador. Es un paso importante para optimizar y preparar el código antes de su despliegue en un sitio web.

#### Transpilar
Transpilar en JavaScript significa convertir código fuente escrito en un lenguaje de programación adicional o de próxima generación en código JavaScript equivalente que sea compatible con versiones anteriores del lenguaje y pueda ser ejecutado por los navegadores actuales.

La transpilación se utiliza principalmente cuando se desea utilizar características avanzadas y sintaxis de lenguajes como TypeScript, JSX, ECMAScript 6 (ES6) o versiones posteriores, que no son compatibles con todos los navegadores. El código fuente en estos lenguajes adicionales se transpila a una versión anterior de JavaScript, generalmente ES5, que es ampliamente soportada por los navegadores.

Durante la transpilación, se aplican transformaciones al código fuente para convertir las características específicas del lenguaje adicional en código JavaScript equivalente. Esto puede incluir la verificación de tipos, el soporte para clases, funciones de flecha, módulos, desestructuración y muchas otras características avanzadas.

El uso de herramientas de transpilación, como Babel, permite a los desarrolladores escribir código en lenguajes adicionales o de próxima generación sin preocuparse por la compatibilidad del navegador. El código se transpila a una versión de JavaScript que puede ser interpretada y ejecutada de manera confiable por una amplia gama de navegadores.

En resumen, transpilar en JavaScript implica convertir código fuente escrito en un lenguaje adicional o de próxima generación en código JavaScript compatible con versiones anteriores, utilizando herramientas de transpilación. Esto permite utilizar características avanzadas y sintaxis moderna, mientras se garantiza la compatibilidad con los navegadores actuales.

#### Compilar vs. Transpilar
Compilar y transpilar no son lo mismo, aunque están relacionados y comparten algunas similitudes.

La compilación se refiere al proceso de convertir un código fuente en un lenguaje de programación a un código ejecutable en un formato diferente. Por lo general, implica la traducción completa del código fuente en un solo paso, generando un archivo ejecutable o un archivo de código objeto que puede ser ejecutado directamente por una máquina o un entorno de ejecución específico.

Por otro lado, la transpilación es una forma específica de compilación en la que el código fuente se traduce de un lenguaje de programación a otro lenguaje de programación de nivel similar. En el contexto de JavaScript, la transpilación se refiere principalmente a convertir código fuente escrito en un lenguaje adicional o de próxima generación (como TypeScript, JSX o ECMAScript 6) a código JavaScript equivalente que pueda ser interpretado y ejecutado por los navegadores actuales.

La diferencia principal radica en que la compilación puede implicar la traducción a un lenguaje completamente diferente y en un formato ejecutable final, mientras que la transpilación se enfoca en la traducción a un lenguaje similar y compatible con un entorno de ejecución específico.

En resumen, la compilación y la transpilación son procesos relacionados pero distintos. La compilación implica la traducción completa del código fuente a un formato ejecutable diferente, mientras que la transpilación se refiere a la traducción de un lenguaje de programación a otro lenguaje de nivel similar, generalmente para garantizar la compatibilidad con un entorno de ejecución específico.

## 6. Qué son los Callbacks

**Un Callback** es una una función que se pasa como argumento de otra función y que será invocada.

Los callbacks son útiles en JavaScript cuando se necesita ejecutar una función después de que se complete otra función o tarea de forma asincrónica. En otras palabras, los callbacks se utilizan en situaciones en las que la ejecución de una tarea puede llevar tiempo y no se debe bloquear el hilo principal de JavaScript mientras se espera el resultado.

Algunos ejemplos comunes de uso de callbacks en JavaScript son:

1. Manejo de eventos: Los Callbacks son muy útiles para manejar eventos. Por ejemplo, cuando se hace clic en un botón, se puede llamar a una función de Callback que ejecuta una acción específica. 

2. Operaciones asincrónicas: Cuando se realizan operaciones que pueden tardar mucho tiempo, como la lectura de un archivo o la llamada a una API, se puede utilizar un Callback para manejar el resultado de la operación una vez que se ha completado.

3. Animaciones: Los callbacks también se utilizan en animaciones para controlar la secuencia de los eventos. Por ejemplo, se puede utilizar un callback para iniciar la siguiente animación después de que se haya completado la anterior.

4. Programación funcional: La programación funcional en JavaScript se basa en gran medida en el uso de callbacks. Por ejemplo, se pueden pasar funciones de callback como argumentos a otras funciones para crear funciones más complejas.

En resumen, los callbacks son útiles en cualquier situación en la que se necesite ejecutar una función después de que se haya completado otra tarea de forma asincrónica.

### Ejemplos + Explicación 

Puedes ver como se ejecuta el código línea a línea usando el debugger de Chrome o Edge. Para usarlo presiona `Ctrl + Shift + I` en cualquier web o si prefieres coloca en la URL `about:blank` para abrir una página en blanco, ahora busca Sources y por ultimo `>> Snippets`. Ahora ya puedes probar tu código creando `+ New snippet`

```js
function greeting(name){ 👈👀
    alert(`Hi ${name}!!!`);
}

function ask_for_name(callback){
    let name = prompt('Enter your name: ');
    callback(name); 👈👀
}

debugger;

ask_for_name(greeting); 👈👀
```

1. Al correr el snippet en la parte de Call Stack vemos que de manera global coloca todo el proyecto como anonymous.
2. Luego llega a la invocación de la función `ask_for_name(greeting);` que se le está pasando la función `greeting` como argumento, tener en cuenta que al pasarle la función `greeting` todavía no se está invocando. 
3. Al entrar a la función `ask_for_name(callback);` ahora ejecuta el `prompt` que muestra un input para ingresar un nombre. 
4. Ahora llega al `callback(name)` que es el  `greeting` anteriormente pasado como argumento, pero esta vez ya se está invocando y al cual se le está dando el argumento que necesita, extraído de `let name` para mostrar el `alert` final. 

![](https://i.postimg.cc/rsBdXs7r/video1377438465-online-video-cutter-com.gif)

Otro ejemplo: 
```js
function makingOrder(orden) {
    console.log(`Ready ${orden}`);
}

function order(orden, callback) {
    console.log(`Taking order ${orden}`);
    setTimeout(() => {
        callback(orden)
    }, 3000)
    console.log(`Doing order ${orden}`,);
}

order('Burger', makingOrder);
```

![](https://i.postimg.cc/4y2rvzZR/6-callback2.gif)

Más ejemplos:  
```js
/* Ejemplo 01 */
function sum(num1, num2) {
    return num1 + num2;
}

function calc(num1, num2, sumNumers) {
    // sumNumers = callback
    // No necesariamente se debe llamar callback
    return sumNumers(num1, num2);
};

console.log(calc(2, 2, sum)); // 4
```

```js
/* Ejemplo 02 */

// Por si mismo ya es un callback
setTimeout(() => {
	// La función es anónima por eso no tiene nombre
    console.log('Hola');
}, 2000);
// Hola

// Ahora hagamos lo mismo pero con otra estructura
function greeting(name){
    console.log(`Hola ${name}`);
}

setTimeout(greeting, 2000, 'Ghost!');
// Hola Ghost!
```


```js
/* Ejemplo 03 */
function sum(num1, num2) {
    return num1 + num2;
}
function rest(num1, num2) {
    return num1 - num2;
}
function mult(num1, num2) {
    return num1 * num2;
}
function div(num1, num2) {
    return num1 / num2;
}
function calc(num1, num2, callback) {
    return callback(num1, num2);
};

console.log(calc(2, 2, sum)); // 4
console.log(calc(2, 2, rest)); // 0
console.log(calc(2, 2, mult)); // 4
console.log(calc(2, 2, div)); // 1
```

**Alt + 96 = ``**

[Documentación](https://developer.mozilla.org/es/docs/Glossary/Callback_function)

## 7. Playground: Ejecuta un callback con 2s de demora

Tienes la función `execCallback` que recibirá un `callback` es decir una función como parámetro, tu reto es ejecutar esa función con un tiempo de demora de 2 segundos.

Para hacer que la función se demore 2 segundos debes usar la función `setTimeout`, pero para ejecutarla debes llamarla mediante el namescpace `window` para poder monitorear su uso en la ejecución de pruebas, ejemplo:

```js
window.setTimeout(() => {
  // code
})
```

Dentro del cuerpo de la función `execCallback` debes escribir tu solución.

Ejemplo:

```js
Input:
const myFunc = () => console.log('Log after 2s')
execCallback(myFunc);

Output:
// Execute myFunc 2s after
```

### Solución: 

Según la guía, ya tenemos una función definida previamente y esta se ve así: 

```js
// Se crea la función 
const myFunc = () => console.log('Log after 2s');
// Se la pasamos como argumento a la función con el callback
execCallback(myFunc);
```

Solución:  
```js
export function execCallback(callback) {
  window.setTimeout(callback, 2000);
}
```

Si copiamos esto en la consola del navegador recuerda seguir este orden, de lo contrario tendremos un error: 

```js
const myFunc = () => console.log('Log after 2s');

function execCallback(callback) {
  window.setTimeout(callback, 2000);
}

execCallback(myFunc);

// Output:
// Log after 2s
```

📌Nota: No es estrictamente necesario usar `window`, ya que `setTimeout` es una función global en el ámbito global (también conocido como el objeto `window` en el navegador). Entonces, si estás trabajando en un entorno de navegador, puedes simplemente llamar `setTimeout` sin `window` y funcionará igual.

Sin embargo, al usar `window.setTimeout`, estamos siendo explícitos sobre el alcance de la función. `window` es el objeto global en el navegador, y al llamar a `setTimeout` en el objeto `window` estamos indicando que estamos llamando a una función global y no a una función que ha sido definida en el ámbito local.

El uso de `window` también puede ser útil en situaciones donde hay ambigüedad en el ámbito, por ejemplo, si una variable local tiene el mismo nombre que una función global, podríamos usar `window` para referirnos explícitamente a la versión global de la función.


## 8. XMLHTTPRequest

**XMLHttpRequest** (XHR) es un objeto JavaScript que se utiliza para realizar solicitudes HTTP / HTTPS asíncronas desde un navegador web para enviar y recibir datos hacia y desde un servidor web.

### Propiedades

|Propiedad    |Descripción |
|-------------|------------|
|`readyState`  |Valor numérico (entero) que almacena el estado de la petición|
|`responseText`|El contenido de la respuesta del servidor en forma de cadena de texto|
|`responseXML` |El contenido de la respuesta del servidor en formato XML. El objeto devuelto se puede procesar como un objeto DOM|
|`status`     |El código de estado HTTP devuelto por el servidor (`200` para una respuesta correcta, `404` para "No encontrado", `500` para un error de servidor, etc.)|
|`statusText`  |El código de estado HTTP devuelto por el servidor en forma de cadena de texto: "OK", "Not Found", "Internal Server Error", etc.|

### Estados 

Los valores definidos para la propiedad `readyState` son los siguientes:

|Valor |Estado        |Descripción |
|------|--------------|------------|
|`0`  |`UNINITIALIZED`|No inicializado, todavía no se llamó a `open()`.|
|`1`  |`LOADING`     |Cargando, todavía no se llamó a `send()`.|
|`2`  |`LOADED`      |Cargado, `send()` ya fue invocado, y los encabezados y el estado están disponibles.|
|`3`  |`INTERACTIVE`  |Interactivo, Descargando; `responseText` contiene información parcial.|
|`4`  |`COMPLETED`    |Completo, la operación está terminada.|

### Métodos

|Método |Descripción |
|---|---|
|`abort()`|Detiene la petición actual|
|`getAllResponseHeaders()`|Devuelve una cadena de texto con todas las cabeceras de la respuesta del servidor|
|`getResponseHeader("cabecera")`|Devuelve una cadena de texto con el contenido de la cabecera solicitada|
|`onreadystatechange`|Responsable de manejar los eventos que se producen. Se invoca cada vez que se produce un cambio en el estado de la petición HTTP. Normalmente es una referencia a una función JavaScript|
|`open("metodo HTTP", "url")`|Establece los parámetros de la petición que se realiza al servidor. Los parámetros necesarios son el método HTTP empleado y la URL destino (puede indicarse de forma absoluta o relativa)|
|`send(contenido)`|Realiza la petición HTTP al servidor|
|`setRequestHeader("cabecera", "valor")`|Permite establecer cabeceras personalizadas en la petición HTTP. Se debe invocar el método `open()` antes que `setRequestHeader()`|

El método `open()` requiere dos parámetros (método HTTP y URL) y acepta de forma opcional otros tres parámetros. Definición formal del método `open()`:

`open(string metodo, string URL [,boolean asincrono, string usuario, string password]);`

Por defecto, las peticiones realizadas son asíncronas. Si se indica un valor `false` al tercer parámetro, la petición se realiza de forma síncrona, esto es, se detiene la ejecución de la aplicación hasta que se recibe de forma completa la respuesta del servidor.

No obstante, las peticiones síncronas son justamente contrarias a la filosofía de AJAX. El motivo es que una petición síncrona _congela_ el navegador y no permite al usuario realizar ninguna acción hasta que no se haya recibido la respuesta completa del servidor. La sensación que provoca es que el navegador se ha _colgado_ por lo que no se recomienda el uso de peticiones síncronas salvo que sea imprescindible.

Los últimos dos parámetros opcionales permiten indicar un nombre de usuario y una contraseña válidos para acceder al recurso solicitado.

Por otra parte, el método `send()` requiere de un parámetro que indica la información que se va a enviar al servidor junto con la petición HTTP. Si no se envían datos, se debe indicar un valor igual a `null`. En otro caso, se puede indicar como parámetro una cadena de texto, un array de bytes o un objeto XML DOM.

### Características del protocolo HTTP

**Verbos**: También conocidos como métodos HTTP, indican acciones que están asociadas a peticiones y recursos, es decir, sirven para la manipulación de recursos cliente/servidor. 

#### Los Verbos HTTP mas comunes son:

1. **GET**: Recupera los datos identificados por el URI (Uniform Resource Identifier) proporcionado. Por lo general, se utiliza para solicitar información.

2. **POST**: Envía datos al servidor para crear o actualizar un recurso. Se utiliza para enviar información de formularios, subir archivos, etc.

3. **PUT**: Actualiza los datos identificados por el URI proporcionado. Se utiliza para actualizar la información existente.

4. **DELETE**: Elimina el recurso identificado por el URI proporcionado.

5. **HEAD**: Recupera los encabezados de respuesta que se devolverían si se realizara una solicitud GET al URI proporcionado. Se utiliza para verificar la existencia de un recurso y obtener información sobre él, sin descargar el cuerpo completo de la respuesta.

6. **OPTIONS**: Recupera los métodos HTTP que el servidor admite para un recurso determinado. Se utiliza para obtener información sobre los métodos disponibles para interactuar con un recurso.

7. **PATCH**: Realiza una actualización parcial de los datos identificados por el URI proporcionado. Es similar a PUT, pero se utiliza para realizar pequeñas actualizaciones en lugar de reemplazar completamente un recurso.

Estos son los verbos HTTP más comunes, pero también existen otros menos utilizados, como TRACE, CONNECT, PROPFIND, etc.


Otra definición:  
- **`GET`** → Solicita un recurso.
- **`HEAD`** → Solicita un recurso, pero sin retornar información, la estructura de esta petición es igual que get tanto en su headers como estatus. Es útil cuando vamos a utilizar API, para comprobar si lo que vamos a enviar está correcto y puede ser procesado.
- **`POST`** → Sirve para la creación de recursos en el servidor.
- **`PUT`** → Actualiza por completo un recurso, reemplaza todas las representaciones actuales del recurso de destino con la carga útil de la petición.
- **`PATCH`** → Actualiza parcialmente un recurso.
- **`DELETE`** → Elimina un recurso.  

### Códigos de estados del servidor 

Los códigos de estado (status codes) del servidor son una parte fundamental del protocolo HTTP, ya que indican el **resultado de una solicitud realizada por un cliente al servidor**. 

Los códigos de estado más comunes:

- **`1xx` Información** → Indican que la petición fue recibida por el servidor, pero está siendo procesada por el servidor.
	- 100: Continuar
	- 101: Cambio de protocolo
- **`2xx` Éxito** → Indican que la petición fue recibida, aceptada y procesada correctamente.
	- 200: OK
	- 201: Creado
	- 202: Aceptado
	- 204: Sin contenido
- **`3xx` Redirección** → Indican que hay que tomar acciones adicionales para completar la solicitud.
	- 300: Múltiples opciones
	- 301: Movido permanentemente
	- 302: Encontrado
	- 304: No modificado
	- 307: Redirección temporal
	- 308: Redirección permanente
- **`4xx` Errores del cliente** → Indican errores del lado del cliente que hizo mal una solicitud.
	- 400: Solicitud incorrecta
	- 401: No autorizado
	- 403: Prohibido
	- 404: No encontrado
	- 405: Método no permitido
	- 408: Tiempo de espera de solicitud
	- 429: Demasiadas solicitudes
- **`5xx` Errores del servidor** → Indican errores del servidor. Suelen aparecer cuando existe un fallo en la ejecución en el servidor.  
	- 500: Error interno del servidor
	- 501: No implementado
	- 502: Puerta de enlace incorrecta
	- 503: Servicio no disponible
	- 504: Tiempo de espera de la puerta de enlace
	- 505: Versión de HTTP no compatible


### Los códigos más comunes a la hora de interactuar con una API son:

- **`200`** → _OK_ → Indica que todo está correcto.
- **`201`** → _Created_ → Todo está correcto cuando se hizo una solicitud POST, el recurso se creó y se guardó correctamente.
- **`204`** → _No Content_ → Indica que la solicitud se completó correctamente, pero no devolvió información. Este es común cuando se hacen peticiones con el verbo DELETE.
- **`400`** → _Bad Request_ → Indica que la solicitud del cliente es incorrecta o que ha habido un error en su sintaxis.
- **`401`** → _Unauthorized_ → Significa que antes de hacer una solicitud al servidor nos debemos autenticar.
- **`403`** → _Forbidden_ → Indica que no tenemos acceso a ese recurso aunque se esté autenticado.
- **`404`** → _Not Found_ → Indica que no existe el recurso que se está intentando acceder.
- **`500`** → _Internal Server Error_ → Indica que algo falló, es un error que retorna el servidor cuando la solicitud no pudo ser procesada.  
- **`503`** → _Service Unavailable_: indica que el servidor no está disponible temporalmente para procesar la solicitud.


### Ejemplo usando GET 

1. Ir a la consola y ubicarnos en la carpeta del proyecto y escribir el comando para instalar el paquete **XMLHttpRequest**:  

```bash
npm i xmlhttprequest
```

2. En VSC creamos un archivo llamado `challenge.js` en la ruta `src/callback`.

```bash
.
├── node_modules
│   └── xmlhttprequest  
│       ├── LICENSE     
│       ├── README.md   
│       ├── lib
│       └── package.json
├── package-lock.json
├── package.json
└── src
    ├── callback
    │   ├── challenge.js 👈👀
    │   └── index.js
    └── playground // Esto es del reto anterior :v
        └── 07.callback.js
```

📌 Nota: En caso de tener algún error en consola como que `require` no está definido, crea nuevamente un proyecto en cualquier parte de tu PC menos en la misma carpeta donde te sale el error. 

Usa:   
```bash
npm init -y
npx gitignore node
npm i xmlhttprequest
```

`challenge.js`  
```js
const XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
const API = 'https://api.escuelajs.co/api/v1';

function fetchData(urlAPI, callback) {
  let xhttp = new XMLHttpRequest();

  xhttp.open('GET', urlAPI, true);
  xhttp.onreadystatechange = function (event) {
    if (xhttp.readyState === 4) {
      if (xhttp.status === 200) {
        callback(null, JSON.parse(xhttp.responseText));
      } else {
        const error = new Error(`Error en ${urlAPI}`);

        callback(error, null);
      }
    }
  }

  xhttp.send();
}
```

### 🔥 Explicación línea a línea

#### Importar módulo para acceder a su clase

```js
const XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
```  
Usamos la sentencia `require` para importar el módulo llamado `'xmlhttprequest'`.

La sintaxis `require('xmlhttprequest').XMLHttpRequest` se utiliza para acceder a la clase `XMLHttpRequest` del módulo `'xmlhttprequest'`. La clase `XMLHttpRequest` es una parte fundamental de la API de JavaScript que permite realizar solicitudes HTTP asíncronas desde el lado del cliente o del servidor.

Al asignarla a la constante `XMLHttpRequest`, se está creando una nueva instancia de la clase `XMLHttpRequest` que se puede utilizar para enviar y recibir datos a través de solicitudes HTTP.

#### Almacenar URL que representa nuestra API

```js
const API = 'https://api.escuelajs.co/api/v1';
```   
Al asignar la URL a la constante `API`, se facilita el acceso a la URL en el resto del código. Esto significa que se puede utilizar la constante `API` en otras partes del programa para realizar solicitudes a la API, obtener datos y trabajar con ellos en el código JavaScript.

#### Función fetchData

```js
function fetchData(urlApi, callback) {
}
```  
Esta función está diseñada para recibir la URL de la API y una función de devolución de llamada (callback) como argumentos. Esta última se invocará dentro de la función `fetchData` una vez que los datos estén disponibles. Esta función callback se utiliza para manejar y procesar los datos recibidos de la API de acuerdo con la lógica específica del programa.

####  Crear una nueva instancia

```js
const xhttp = new XMLHttpRequest();
``` 

Si recordamos la primera línea `const XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;` nos indica que está importando el módulo `'xmlhttprequest'` y asignando la clase `XMLHttpRequest` a la constante `XMLHttpRequest`. 

Dicho esto, en la siguiente línea de código `const xhttp = new XMLHttpRequest();`, se crea una nueva **instancia** de `XMLHttpRequest` utilizando la clase `XMLHttpRequest` importada en la primera línea. Esta instancia se almacena en la constante `xhttp` y se usará para realizar solicitudes HTTP/HTTPS en Node.js utilizando la implementación proporcionada por el módulo `'xmlhttprequest'`.

📌 Nota: Si estás familiarizado con OOP ([Programación Orientada a Objetos](https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Objects/Basics#object_basics)) sabrás entonces que esto no es más que un constructor vacío, de la misma forma que:

```js
let puppy = new Animal(); 🐶
let apple = new Fruit();  🍎
```

Una vez que has creado la instancia de `XMLHttpRequest`, puedes utilizar los métodos y propiedades que posee la clase `XMLHttpRequest` para realizar solicitudes HTTP/HTTPS y manejar la respuesta del servidor.

- Los métodos son las funciones que se pueden invocar en una instancia de `XMLHttpRequest` para realizar acciones específicas, como enviar una solicitud HTTP, establecer encabezados personalizados o cancelar una solicitud. Ejemplos de métodos son `open()`, `send()`, `abort()`, `setRequestHeader()`, entre otros.

- Las propiedades son los valores que se pueden leer o modificar en una instancia de `XMLHttpRequest` para obtener información sobre el estado de la solicitud o la respuesta recibida. Ejemplos de propiedades son `readyState`, `status`, `responseText`, `responseXML`, `onreadystatechange`, entre otros.

#### Usando métodos de XMLHttpRequest  

```js
xhttp.open('GET', urlAPI, true);
```

En esta línea de código, se utiliza el método `open()` del objeto `XMLHttpRequest` para configurar la solicitud HTTP antes de enviarla al servidor.

El método `open()` acepta tres parámetros:

1. El primer parámetro representa el método HTTP a utilizar, en este caso, se utiliza `'GET'` para indicar que se realizará una solicitud de tipo GET al servidor.

2. El segundo parámetro es la URL de la API a la cual se enviará la solicitud. En este caso, se utiliza la variable `urlAPI`, que es el primer parámetro de la función `fetchData`.

3. El tercer parámetro es un booleano que indica si la solicitud debe ser asíncrona (`true`) o síncrona (`false`). En este caso, se establece en `true` para realizar una solicitud asincrónica, lo que significa que la función `fetchData` no se bloqueará y permitirá que el código continúe ejecutándose mientras se espera la respuesta del servidor.

Al llamar al método `open()` con los parámetros adecuados, se configura la solicitud HTTP para que se realice una solicitud `GET` a la URL especificada, y se establece la asincronía para permitir un comportamiento no bloqueante.

#### Evento que se activa cada vez que el estado de la solicitud cambia

```js
xhttp.onreadystatechange = function (event) {

}
```
Esta línea se utiliza para asignar una función anónima a la propiedad `onreadystatechange` de la clase `XMLHttpRequest`. Esta función se ejecutará cada vez que cambie el estado de la solicitud y te permite realizar acciones específicas en función del estado y la respuesta recibida del servidor.

Con esto, vamos a verificar que el request de los datos ha salido con éxito y en caso de un tener error hacer registro de este. 

#### Comprobar el estado de la solicitud

```js
if (xhttp.readyState === 4) {
}
```

Dentro de la función anónima asignada a `onreadystatechange`, se puede realizar una comprobación utilizando la propiedad `readyState` de la clase `XMLHttpRequest`.

La propiedad `readyState` indica el estado actual de la solicitud y puede tener los siguientes valores:

|Valor |Estado        |Descripción |
|------|--------------|------------|
|`0`  |`UNINITIALIZED`|No inicializado, todavía no se llamó a `open()`.|
|`1`  |`LOADING`     |Cargando, todavía no se llamó a `send()`.|
|`2`  |`LOADED`      |Cargado, `send()` ya fue invocado, y los encabezados y el estado están disponibles.|
|`3`  |`INTERACTIVE`  |Interactivo, Descargando; `responseText` contiene información parcial.|
|`4`  |`COMPLETED`    |Completo, la operación está terminada.|

Entonces se realiza la comprobación si `readyState` es igual a `4`, lo que indica que la solicitud se ha completado.

[Documentación: readyState](https://developer.mozilla.org/es/docs/Web/API/Document/readyState)

#### Verificar si el estado de la respuesta del servidor es exitoso

```js
if (xhttp.readyState === 4) {
  if (xhttp.status === 200) {
  } ✅
} ✅
```

La línea `if (xhttp.status === 200) {}` dentro de la función anónima se utiliza para verificar si el estado de la respuesta del servidor es exitoso.

Después de que la solicitud HTTP se haya completado y el estado de `readyState` sea `4` (DONE), se puede acceder a la propiedad `status` de la clase `XMLHttpRequest` para obtener el código de estado de la respuesta del servidor.

El código de estado HTTP `200` representa una respuesta exitosa. Indica que la solicitud se realizó correctamente y el servidor devolvió una respuesta válida.


#### Invocar el callback

¡Ya comprobamos que tanto el request (pedido/solicitud) como él response (respuesta) hayan sido exitosos! Ahora podemos invocar nuestro callback (función por definir más tarde para manipular los datos).

```js
if (xhttp.readyState === 4) {
  if (xhttp.status === 200) {
    callback(null, JSON.parse(xhttp.responseText));
  } ✅
} ✅
```

Esta línea se utiliza para invocar a la función `callback` y pasarle los datos obtenidos de la respuesta del servidor.

Al alcanzar este punto del código, significa que la solicitud se ha completado exitosamente y se ha recibido una respuesta válida del servidor.

Al invocar `callback(null, JSON.parse(xhttp.responseText))`, se pasa `null` como el primer argumento, lo cual indica que no ha ocurrido ningún error durante la solicitud. El segundo argumento, `JSON.parse(xhttp.responseText)`, es el cuerpo de la respuesta del servidor que ha sido convertido de una cadena de texto JSON a un objeto JavaScript utilizando `JSON.parse`.

#### Else en caso la respuesta del servidor no tenga un estado exitoso

```js
if (xhttp.readyState === 4) {
  if (xhttp.status === 200) {
    callback(null, JSON.parse(xhttp.responseText)); ✅
  } ✅
} else ❌ {
  const error = new Error(`Error en ${urlAPI}`);
  callback(error, null);
}
```

El bloque `else` y la creación de la constante `error` en la función `fetchData` se utilizan para manejar los casos en los que la respuesta del servidor no tiene un estado exitoso.

Dentro del bloque de código condicional que verifica si el estado de la respuesta del servidor es `200`, en caso de que no sea así, se ejecuta el bloque `else`. Esto indica que la respuesta del servidor no fue exitosa y puede haber ocurrido algún error.

#### Crear objetos de error

Si te fijaste en el código anterior dentro del `else`, estamos usando una `const error`, pero que significa esto exactamente?   

```js
else ❌ {
  const error = new Error(`Error en ${urlAPI}`);
}
```

La línea `const error = new Error(`Error en ${urlAPI}`);` no está relacionada directamente con la clase `XMLHttpRequest`. En JavaScript, `Error` es una clase incorporada que se utiliza para crear objetos de error (es parte del lenguaje).

Cuando se crea una instancia de `Error` utilizando `new Error()`, se crea un nuevo objeto de error con un mensaje de error personalizado. El mensaje de error se puede proporcionar como argumento en la creación del objeto, como ocurre en este caso con el uso de una plantilla de cadena de texto (`template literal`) para incluir la URL de la API (`urlAPI`) que generó el error.

El objeto `Error` creado se utiliza para representar un error durante la ejecución del código. Al pasar este objeto como primer argumento a la función de devolución de llamada (`callback`), se indica que se ha producido un error durante la solicitud.

```js
else ❌ {
  const error = new Error(`Error en ${urlAPI}`);
  callback(error, null); 👈👀
}
```

#### Método send()

```js
xhttp.send();
```

Por último, `xhttp.send()` se utiliza para enviar la solicitud HTTP al servidor. Esta línea de código envía la solicitud que se configuró previamente con `xhttp.open()`. Después de llamar a `xhttp.send()`, la solicitud se envía al servidor y se espera recibir una respuesta.


### Resumen:  

```js
/* 
require para importar el módulo xmlhttprequest y a la vez acceder a su clase xmlhttprequest. Mas adelante usaremos la const creada aquí (puede tener cualquier nombre) para instanciar esta clase (crear un objeto basado en xmlhttprequest) esto va a funcionar como OOP permitiendonos usar sus propiedades y métodos internos. 
*/
const XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
/* Almacenamos la URL de la API a usar (esto por comodidad) */
const API = 'https://api.escuelajs.co/api/v1';

/* 
Para que el pedido funcione correctamente necesitamos que nuestra función tenga dos parametros: 1 para obtener la url de la api y 2 para procesar los datos recibidos usando una funtion callback que se creará despues. 
*/
function fetchData(urlAPI, callback) {
  /* 
  Instanciamos nuestra clase obtenida en la primera línea (prueba cambiando el nombre de XMLHttpRequest tanto en la primera const como en el new XMLHttpRequest verás que puede llevar cualquier nombre y que no es una palabra reservada de JS pero ambos deben ser iguales) ejemplo: const lol = require... y xhttp = new lol();. Como mencione antes esto permitirá usar las propiedades y métodos internos de la clase XMLHttpRequest que obtuvimos en la importación de este modulo. 
  */
  let xhttp = new XMLHttpRequest();

  /* 
  Habiendo creado el objeto xhttp podemos usar el método open que establece los parametros de la conexión al servidor como vemos, necesita tres parametros para funcionar de manera asincrona lo que significa que la funcion fetchData no se bloqueará y permitirá que el código continúe ejecutándose mientras espera alguna respuesta. 
  */
  xhttp.open('GET', urlAPI, true);
  /* 
  La propiedad onreadystatechange permite asignar una función en este caso anonima que se ejecutará cada vez que cambie el estado de la solicitud. Esto permitirá usar condicionales para verificar si la solicitud tuvo exito o no.  
  */
  xhttp.onreadystatechange = function (event) {
    /* 
    La propiedad readyState devuelve el estado actual de la solicitud. El 4 nos dice que la operación fue completada (completada si pero no nos dice si trae datos con exito o si se completo con algún error)
    */
    if (xhttp.readyState === 4) {
      /* 
      La propiedad status nos dice si la respuesta fue exitosa o no. El 200 nos dice que todo está ok y que trae el contenido con exito, contrario a 204 que nos dice que no hay contenido. 
      */
      if (xhttp.status === 200) {
        /* 
        Invocamos a la función callback la cual tendrá dos argumentos, uno en caso de error y el otro en caso todo esté bien. Si te das cuenta al alcanzar este punto de nuestros condicionales significa que todo está bien y que nuestra solicitud si trae datos, por lo que al no haber errores colocamos un null como primer argumento. Para el segundo argumento usamos la propiedad responseText que contiene la respuesta del servidor como una cadena de texto, lo cual es dificil de leer por lo que hacemos una coversión a formato JSON (objeto) de los datos obtenidos.
        */
        callback(null, JSON.parse(xhttp.responseText));
      } else {
        /* 
        Ahora en caso de error y si así lo deseamos definimos un error personalizado usando la clase Error incorporada en el lenguaje JS lo que nos permite crear un objeto que tendrá una cadena de texto y el enlace de la API que nos está mandando el error. 
        */
        const error = new Error(`Error en ${urlAPI}`);

        /* 
        Al tener un error como primer argumento le pasamos el error personalizado y como segundo parametro null. 
        */
        callback(error, null);
      }
    }
  }

  /* 
  Por último usamos el método send() para enviar la solicitud HTTP al servidor. Lo que quiere decir que envía los parametros establecidos en el método open()
  */
  xhttp.send();
}
```

🔥 _La nueva forma de hacer peticiones a una API es el_[fetch](https://developer.mozilla.org/es/docs/Web/API/Fetch_API).


- [Métodos y Propiedades del objeto XMLHttpRequest](http://dis.um.es/~lopezquesada/documentos/IES_1314/IAW/curso/UT7/libroswebajax/www.librosweb.es/ajax/capitulo7/metodos_y_propiedades_del_objeto_xmlhttprequest.html)
- [Fakeapi](https://fakeapi.platzi.com/)


### ⚠️(BONUS)⚠️
Para no usar “Magic numbers” se pueden declarar los estados a verificar como constantes, les dejo el código completo. 

```js
const XMLHttpRequest = require('XMLHttpRequest').XMLHttpRequest;
const API = 'https://api.escuelajs.co/api/v1/products';
const DONE = 4;
const OK = 200;

function fetchData(urlApi, callback) {
    let xhttp = new XMLHttpRequest();

    xhttp.open('GET', urlApi, true);
    xhttp.onreadystatechange = function (e) {
        if (xhttp.readyState === DONE && xhttp.status === OK) {
            callback(null, JSON.parse(xhttp.responseText));
        } else {
            const error = new Error('error' + urlApi);
            return callback(error, null);
        }
    }
    xhttp.send();
}
```

## 9. Fetch data

```js
const XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
const API = 'https://api.escuelajs.co/api/v1';

function fetchData(urlApi, callback) {
  let xhttp = new XMLHttpRequest();

  xhttp.open('GET', urlApi, true);
  xhttp.onreadystatechange = function (event) {
    if (xhttp.readyState === 4) {
      if (xhttp.status == 200) {
        // Puedes quitarle el JSON.parse para ver como viene toda la información (DOMString cadena de caracteres)
        callback(null, JSON.parse(xhttp.responseText));
      } else {
        const error = new Error('Error en ', urlApi);
        callback(error, null);
      }
    }
  }

  xhttp.send();
}


// Template strings y Optional chaining '?.'
fetchData(`${API}/products`, function (error1, data1) { 👈👀
  if (error1) return console.error(error1);

  fetchData(`${API}/products/${data1[0].id}`, function (error2, data2) {
    if (error2) return console.error(error2);

    fetchData(`${API}/categories/${data2?.category?.id}`, function (error3, data3) {
      if (error3) return console.error(error3);

      console.log(data1[0]);
      console.log(data2.title);
      console.log(data3.name);
    });
  });
});

// Obtenemos: 
{
  id: 2,
  title: 'Oriental Bronze Car',
  price: 342,
  description: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
  images: [
    'https://picsum.photos/640/640?r=2863',
    'https://picsum.photos/640/640?r=4222',
    'https://picsum.photos/640/640?r=3311'
  ],
  creationAt: '2023-07-16T06:10:35.000Z',
  updatedAt: '2023-07-16T06:10:35.000Z',
  category: {
    id: 3,
    name: 'Furniture',
    image: 'https://picsum.photos/640/640?r=2068',
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z'
  }
}
Oriental Bronze Car
Furniture
```

### ¿Cómo llegamos a ese resultado?

Ya vimos lo que obtenemos como resultado final, pero, ¿Cómo llegamos a ese resultado? 

1. En el primer `fetchData` obtenemos un array enorme con muchos objetos dentro: 
```js
fetchData(`${API}/products`, function (error1, data1) {
  if (error1) return console.error(error1);
  console.log(data1);
});

// Obtenemos esto y más:  
[
  {
    id: 2,
    title: 'Oriental Bronze Car',
    price: 342,
    description: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
    images: [
      'https://picsum.photos/640/640?r=2863',
      'https://picsum.photos/640/640?r=4222',
      'https://picsum.photos/640/640?r=3311'
    ],
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z',
    category: {
      id: 3,
      name: 'Furniture',
      image: 'https://picsum.photos/640/640?r=2068',
      creationAt: '2023-07-16T06:10:35.000Z',
      updatedAt: '2023-07-16T06:10:35.000Z'
    }
  },
  {
    id: 4,
    title: 'Tasty Frozen Table',
    price: 962,
    description: 'Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals',
    images: [
      'https://picsum.photos/640/640?r=7246',
      'https://picsum.photos/640/640?r=9914',
      'https://picsum.photos/640/640?r=1496'
    ],
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z',
    category: {
      id: 4,
      name: 'Shoes',
      image: 'https://picsum.photos/640/640?r=260',
      creationAt: '2023-07-16T06:10:35.000Z',
      updatedAt: '2023-07-16T06:10:35.000Z'
    }
  },
  ...
    {
    id: 102,
    title: 'Awesome Granite Bacon',
    price: 1,
    description: 'New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016',
    images: [
      'https://picsum.photos/640/640?r=4809',
      'https://picsum.photos/640/640?r=8923',
      'https://picsum.photos/640/640?r=8980'
    ],
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z',
    category: {
      id: 2,
      name: 'Electronics',
      image: 'https://picsum.photos/640/640?r=4582',
      creationAt: '2023-07-16T06:10:35.000Z',
      updatedAt: '2023-07-16T06:10:35.000Z'
    }
  }
  ... 100 more items
```

2. En el segundo `fetchData` obtenemos solo el primer objeto y extraemos el `title` usando `console.log(data2.title);`: 

```js
fetchData(`${API}/products`, function (error1, data1) {
  if (error1) return console.error(error1);
  /* console.log(data1); */

  fetchData(`${API}/products/${data1[0].id}`, function (error2, data2) {
    if (error2) return console.error(error2);
    console.log(data2);
  });
});

// Obtenemos el objeto de la posición [0], lo que no logro entender es el porqué le agregan un .id, ya que, sin eso no funciona :v
{
  id: 2,
  title: 'Oriental Bronze Car', 👈👀
  price: 342,
  description: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
  images: [
    'https://picsum.photos/640/640?r=2863',
    'https://picsum.photos/640/640?r=4222',
    'https://picsum.photos/640/640?r=3311'
  ],
  creationAt: '2023-07-16T06:10:35.000Z',
  updatedAt: '2023-07-16T06:10:35.000Z',
  category: {
    id: 3,
    name: 'Furniture',
    image: 'https://picsum.photos/640/640?r=2068',
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z'
  }
}
```
3. En el tercer  `fetchData` buscamos a qué categoría pertenece el producto que obtuvimos anteriormente, pero primero veamos las categorías existentes... :  

```js
fetchData(`${API}/products`, function (error1, data1) {
  if (error1) return console.error(error1);
  /* console.log(data1); */

  fetchData(`${API}/products/${data1[0].id}`, function (error2, data2) {
    if (error2) return console.error(error2);
    /* console.log(data2); */

    fetchData(`${API}/categories/`, function (error3, data3) {
      if (error3) return console.error(error3);
      console.log(data3);
    });
  });
});

// Obtenemos: 
[
  {
    id: 1,
    name: 'Clothes',
    image: 'https://picsum.photos/640/640?r=193',
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z'
  },
  {
    id: 2,
    name: 'Electronics',
    image: 'https://picsum.photos/640/640?r=4582',
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z'
  },
  {
    id: 3,
    name: 'Furniture', 👈👀 // Esto es lo que necesitamos
    image: 'https://picsum.photos/640/640?r=2068',
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z'
  },
  {
    id: 4,
    name: 'Shoes',
    image: 'https://picsum.photos/640/640?r=260',
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z'
  },
  {
    id: 5,
    name: 'Others',
    image: 'https://picsum.photos/640/640?r=5088',
    creationAt: '2023-07-16T06:10:35.000Z',
    updatedAt: '2023-07-16T06:10:35.000Z'
  },
  {
    id: 32,
    name: 'New Category',
    image: 'https://placeimg.com/640/480/any',
    creationAt: '2023-07-16T23:28:51.000Z',
    updatedAt: '2023-07-16T23:28:51.000Z'
  },
  {
    id: 33,
    name: 'New Category',
    image: 'https://placeimg.com/640/480/any',
    creationAt: '2023-07-16T23:31:07.000Z',
    updatedAt: '2023-07-16T23:31:07.000Z'
  }
]
```

Ahora filtremos la categoría de nuestro producto, para lo cual concatenamos el ID que debe buscar `${API}/categories/${data2?.category?.id}`, con esto a través de los datos del producto obtenidos en `data2` entramos a `producto.categoria.id` que si nos fijamos es igual a `3`. Usando `console.log(data3.name);` podemos tener el nombre de la categoría a la que pertenece nuestro producto: 

```js
fetchData(`${API}/products`, function (error1, data1) {
  if (error1) return console.error(error1);
  /* console.log(data1); */

  fetchData(`${API}/products/${data1[0].id}`, function (error2, data2) {
    if (error2) return console.error(error2);
    /* console.log(data2); */

    fetchData(`${API}/categories/${data2?.category?.id}`, function (error3, data3) {
      if (error3) return console.error(error3);
      console.log(data3);
    });
  });
});

// Obtenemos 
{
  id: 3,
  name: 'Furniture',👈👀 // Fin 
  image: 'https://picsum.photos/640/640?r=2068',
  creationAt: '2023-07-16T06:10:35.000Z',
  updatedAt: '2023-07-16T06:10:35.000Z'
}
```

### Otras formas 

#### Forma 01
✨ Esta es otra forma de hacer lo mismo, pero más sencilla de entender. 

```js
fetchData(`${API}/products`, function (error, all) {
  if (error) return console.log(error);

  const product = all[0];

  /* console.log(all); */ //👈👀 Muestra un array de objetos
  console.log(product);
  console.log(product.title)
  console.log(product.category.name)
})
```

#### Forma 02

```js
const XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
const xhr = new XMLHttpRequest();
const API = 'https://api.escuelajs.co/api/v1/products';

xhr.open('GET', API, true);
xhr.onreadystatechange = function () {
  if (xhr.readyState === xhr.DONE) { //4
    if (xhr.status === 200) {
      const respuesta = JSON.parse(xhr.responseText);
      console.log(respuesta);
    } else {
      console.log('Error en la solicitud');
    }
  }
};

xhr.send();
```

Obtenemos el objeto JSON completo, a partir de aquí podemos extraer lo que necesitamos. 

### Datos

- DOMString: En el lenguaje de programación JavaScript, un atributo de tipo `DOMString` representa una cadena de caracteres que se utiliza para representar texto o valores de cadena en el Document Object Model (DOM).

- El DOM es una representación en memoria de un documento HTML o XML que permite a los desarrolladores acceder y manipular los elementos de la página web de manera programática utilizando JavaScript. Cuando se manipulan elementos del DOM con JavaScript, los valores de los atributos se representan como `DOMString`.


### Optional chaining '?.' 

El operador de encadenamiento opcional `?.` es una característica introducida en ECMAScript 2020 que permite acceder a las propiedades de un objeto sin tener que verificar explícitamente si el objeto y sus propiedades existen. El operador `?.` se utiliza para evitar errores de referencia nula y simplificar el código en situaciones en las que se accede a propiedades anidadas de un objeto.

Antes de la introducción del operador de encadenamiento opcional, la forma común de acceder a las propiedades de un objeto anidado era verificar explícitamente si cada propiedad existía utilizando el operador `&&`:

```js
if (obj && obj.prop1 && obj.prop1.prop2) {
  // hacer algo con obj.prop1.prop2
}
```

Con el operador de encadenamiento opcional, podemos simplificar este código de la siguiente manera:

```js
if (obj?.prop1?.prop2) {
  // hacer algo con obj.prop1.prop2
}
```

En este ejemplo, el operador `?.` se utiliza para verificar si el objeto `obj` existe antes de acceder a sus propiedades `prop1` y `prop2`. Si alguna de las propiedades no existe o es nullish (`null` o `undefined`), se devuelve `undefined` en lugar de lanzar una excepción de referencia nula.

El operador de encadenamiento opcional también se puede utilizar para llamar a métodos en objetos anidados:

```js
obj?.method1?.();
```

En este ejemplo, el operador `?.` se utiliza para llamar al método `method1` en el objeto `obj` solo si existe.

En resumen, el operador de encadenamiento opcional `?.` es una característica útil de ECMAScript 2020 que simplifica el acceso a las propiedades de un objeto anidado y ayuda a evitar errores de referencia nula en el código.


### Console

JavaScript tiene una variedad de métodos de consola que se utilizan para imprimir o mostrar información en la consola del navegador o en el entorno de Node.js.

1. `console.log()`: Se utiliza para imprimir mensajes en la consola del navegador o en el entorno de Node.js. Puedes pasar cualquier tipo de dato a `console.log()` y se imprimirá en la consola.

2. `console.error()`: Este método se utiliza para imprimir mensajes de error en la consola del navegador o en el entorno de Node.js. Los mensajes de error aparecerán en rojo para que sea más fácil identificarlos.

3. `console.warn()`: Este método se utiliza para imprimir mensajes de advertencia en la consola del navegador o en el entorno de Node.js. Los mensajes de advertencia aparecerán en amarillo para que sea más fácil identificarlos.

4. `console.info()`: Este método se utiliza para imprimir mensajes informativos en la consola del navegador o en el entorno de Node.js. Los mensajes informativos aparecerán en azul para que sea más fácil identificarlos.

5. `console.clear()`: Este método se utiliza para borrar la consola del navegador o en el entorno de Node.js para eliminar cualquier mensaje previo.

6. `console.table()`: Este método se utiliza para imprimir datos en forma de tabla en la consola del navegador o en el entorno de Node.js. Se puede utilizar con matrices y objetos para visualizar los datos de una manera más legible.

7. `console.group() / console.groupEnd()`: Estos métodos se utilizan para agrupar mensajes de consola relacionados para que sea más fácil de leer. `console.group()` se utiliza para comenzar un grupo y `console.groupEnd()` se utiliza para finalizar el grupo.

8. `console.time() / console.timeEnd()`: Estos métodos se utilizan para medir el tiempo transcurrido entre dos puntos en el código. `console.time()` se utiliza para comenzar el temporizador y `console.timeEnd()` se utiliza para detener el temporizador y mostrar el tiempo transcurrido en la consola.

Estos son solo algunos de los métodos más comunes de consola en JavaScript, pero hay muchos más disponibles. Cada uno puede ser útil en diferentes situaciones para ayudarte a depurar y realizar un seguimiento del código.


- [Documentación](https://developer.mozilla.org/es/docs/Web/API/Console)
- [Optional Chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining)

## 10. Callback hell

"Callback hell" (o "infierno de los callbacks") es un término que se utiliza en JavaScript para describir una situación en la que se anidan múltiples funciones de devolución de llamada (callbacks) dentro de otras funciones de devolución de llamada, lo que puede dificultar la legibilidad y el mantenimiento del código.

En JavaScript, las funciones de devolución de llamada se utilizan comúnmente para realizar tareas asincrónicas, como realizar solicitudes HTTP o leer archivos. Cuando se anidan varias funciones de devolución de llamada, el código puede volverse difícil de leer y mantener debido a la cantidad de anidamiento y la necesidad de realizar un seguimiento de varias variables y estados.

Por ejemplo, un ejemplo de "callback hell" podría ser el siguiente:

```js
asyncOperation1(function(result1) {
  asyncOperation2(result1, function(result2) {
    asyncOperation3(result2, function(result3) {
      asyncOperation4(result3, function(result4) {
        // Hacer algo con los resultados
      });
    });
  });
});
```

En este ejemplo, cada función de devolución de llamada anida otra función de devolución de llamada, lo que puede hacer que el código sea difícil de leer y seguir. Para evitar el callback hell, se pueden utilizar técnicas como las promesas o async/await para manejar de forma más clara y legible el flujo de control asíncrono en el código JavaScript.

📌 Nota: Para evitar la mala práctica de un **Call Hell**, no es recomendable exceder de 3 _callback_, para ello se utilizan _las promesas o el Async Away_.  

> **CallBacks Hell**: Consiste en múltiples _Callbacks anidados_ que provocan que el código se vuelva difícil de leer y ‘_debuggear_’ y por eso se debe evitar.

### Otra forma de ejecutar el código creado

Lo común sería darle al icono ▶ Code Run, pero también podemos compilar y mostrar el resultado de nuestro código desde la consola y para esto podemos ejecutar este comando: 

```bash
node src/callback/challenge.js
```

También podemos agregar un `script` en nuestro archivo `package.json` para no tener que escribir toda la ruta cada vez que queramos ver los resultados desde consola.

```js
{
  "name": "asincronismo",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1",
    "callback": "node src/callback/challenge.js"👈👀
  },
  "keywords": [
    "javascript"
  ],
  "author": "aleroses <ale.vrs@outlook.com>",
  "license": "MIT",
  "dependencies": {
    "xmlhttprequest": "^1.8.0"
  }
}
```

Ahora ya podemos correr nuestro comando `npm run callback` y ver los resultados en consola.

## 11. Qué son las promesas

Las promesas en JavaScript son objetos que representan la eventual finalización (o falla) de una operación asíncrona y permiten manejar el resultado de dicha operación de manera más eficiente y legible que con **callbacks anidados**, los cuales puedes llegar a ser muy engorrosos (ejemplo clase 9). En lugar de esperar a que una operación asíncrona termine para continuar con el siguiente paso, se puede crear una promesa que se resolverá en el futuro, y luego trabajar con ella en lugar de bloquear el flujo del programa. Las promesas también permiten encadenar varias operaciones asíncronas en secuencia y manejar errores de manera centralizada.

Las promesas pueden suceder:  
- Ahora
- En el futuro
- Nunca  

### Crear una promesa

Utilizamos la palabra reservada `new` seguida de la palabra `Promise` que es _el constructor de la promesa_. Este constructor recibe un único parámetro que es una función, la cual, a su vez, recibe otros dos parámetros: `resolve` y `reject`.

- El parámetro `resolve` se utiliza para cuando la promesa devuelve el valor correctamente.
- El parámetro `reject`, se usa en el que caso de que no funcione.  

#### Ejemplo:

```js
const promise = new Promise(function (resolve, reject){
resolve('hey!');
});

console.log(promise);

// Obtenemos: 
Promise { 'hey!' }
```

### Los tres estados de las promesas:

1. **Pendiente (pending):** Es el estado inicial de una promesa, lo que significa que aún no se ha resuelto ni rechazado. En este estado, la promesa está esperando a que se complete la operación asíncrona que representa.

2. **Resuelta (fulfilled):** Es el estado en el que una promesa se encuentra cuando se ha completado correctamente la operación asíncrona que representa. En este estado, se ha llamado a la función `resolve` de la promesa con un valor que se puede manejar en la llamada posterior `then`. 

3. **Rechazada (rejected):** Es el estado en el que una promesa se encuentra cuando se produce un error durante la operación asíncrona que representa. En este estado, se ha llamado a la función `reject` de la promesa con un motivo que se puede manejar en la llamada posterior `catch`.

Es importante destacar que una vez que una promesa cambia de estado, no puede cambiar de nuevo a otro estado. Por ejemplo, una promesa que se ha resuelto no puede cambiar a estado pendiente o rechazado, y una promesa que se ha rechazado no puede cambiar a estado resuelto o pendiente.


#### Ejemplo con `then` y `catch`:  

Para probar el código, en el proyecto se crea la carpeta llamada `promise` dentro de la carpeta `src` y por último creamos el archivo `index.js` en la ruta: `src/promise`

```bash
╰─ tree -L 3
.
├── node_modules      
│   └── xmlhttprequest
│       ├── LICENSE   
│       ├── README.md     
│       ├── lib
│       └── package.json  
├── package-lock.json     
├── package.json
└── src 👈👀
    ├── callback
    │   ├── challenge.js  
    │   └── index.js      
    ├── playground        
    │   └── 07.callback.js
    └── promise 👈👀
        └── index.js 👈👀
```


`index.js`

```js
//ejemplo de contar vacas: 15 or 9
const cows = 15; //valor inicial de vacas

const countCows = newPromise(function (resolve, reject) {
  //solo si el número de vacas supera 10, se llama al resolve
  //de lo contrario: se llama a reject
  if (cows > 10) {
    resolve(`We have ${cows} cows on the farm`);
  } else {
    reject("There is no cows on the farm");
  }
});

//con solo .then se obtiene el resultado de la promesa de acuerdo a resolve o reject
//con .catch podemos obtener más información de un futuro error que se presente
//con .finally podemos imprimir un mensaje que indica que ya se ejecutó la promesa
countCows
  .then((result) => {
    console.log(result);
  }).catch((error) => {
    console.log(error);
  }).finally(() => console.log('Finally'));
//se usan arrow function () =>

// Usando 15 obtenemos: 
We have 15 cows on the farm
Finally

// Usando 9 obtenemos: 
There is no cows on the farm.
Finally
```

Otra forma:  
```js
const cows = 0;

const count_cows = new Promise((resolve, reject) => {
  cows >= 1
    ? resolve(`I have ${cows} cows on the farm.`)
    : reject('There is no cows on the farm.')
});

count_cows
  .then((result) => console.log(result))
  .catch((error) => console.log(error))
  .finally(() => console.log('Finally'));

// Usando 0 obtenemos: 
There is no cows on the farm.
Finally

// Usando 9 obtenemos: 
I have 9 cows on the farm.
Finally
```

#### Otros ejemplos: 

1. Realizar una solicitud HTTP asíncrona y manejar la respuesta:

```js
fetch('https://jsonplaceholder.typicode.com/todos/1')
  .then(response => response.json())
  .then(data => console.log(data))
  .catch(error => console.error(error))

// Obtenemos: 
{ userId: 1, id: 1, title: 'delectus aut autem', completed: false }
```

En este ejemplo, se usa la función `fetch` para realizar una solicitud HTTP asíncrona y se devuelve una promesa que representa la respuesta. Luego, se encadena una serie de llamadas `then` para procesar la respuesta, convirtiendo los datos a formato JSON y luego registrando los datos en la consola. Si se produce algún error durante la solicitud, se captura en el bloque `catch`.

2. Realizar múltiples solicitudes HTTP en paralelo y manejar los resultados:

Para estos ejemplos usaremos `Promise.all()` que es un método estático que se utiliza para combinar múltiples promesas en una sola. Toma un iterable (como un arreglo) que contiene promesas y devuelve una nueva promesa que se resuelve cuando todas las promesas del iterable se han resuelto.

Cuando se utiliza `Promise.all()`, se pasan las promesas como argumentos en forma de arreglo y se devuelve una nueva promesa. Esta nueva promesa se resuelve cuando todas las promesas del arreglo se han resuelto correctamente o se rechaza tan pronto como una de las promesas se rechaza.

Aquí hay un ejemplo para ilustrar su funcionamiento:

```js
const promise1 = new Promise((resolve, reject) => {
  setTimeout(() => {
    resolve('Promesa 1 resuelta');
  }, 2000);
});

const promise2 = new Promise((resolve, reject) => {
  setTimeout(() => {
    resolve('Promesa 2 resuelta');
  }, 3000);
});

const promise3 = new Promise((resolve, reject) => {
  setTimeout(() => {
    reject('Promesa 3 rechazada');
  }, 2500);
});

Promise.all([promise1, promise2, promise3])
  .then(resultados => {
    console.log(resultados);
  })
  .catch(error => {
    console.log(error);
  });

// Obtenemos: De las 3 promesas se rechazó una por lo que se devuelve el catch
Promesa 3 rechazada
```

En el ejemplo anterior, se crean tres promesas (`promise1`, `promise2` y `promise3`) que se resuelven o rechazan después de un tiempo determinado mediante el uso de `setTimeout`. Luego, se utiliza `Promise.all()` pasando las tres promesas como un arreglo.

Si todas las promesas se resuelven correctamente, el método `then` de la promesa devuelta por `Promise.all()` se ejecutará y recibirá un arreglo con los resultados de las promesas en el mismo orden que se pasaron. En este caso, se imprimirá en la consola: `["Promesa 1 resuelta", "Promesa 2 resuelta"]`.

Si alguna de las promesas se rechaza, el método `catch` de la promesa devuelta por `Promise.all()` se ejecutará y recibirá el motivo del rechazo de la primera promesa que se rechazó. En este caso, se imprimirá en la consola: `"Promesa 3 rechazada"`.

Otro ejemplo:  

```js
Promise.all([
  fetch('https://jsonplaceholder.typicode.com/todos/1'),
  fetch('https://jsonplaceholder.typicode.com/todos/2'),
  fetch('https://jsonplaceholder.typicode.com/todos/3')
])
.then(responses => Promise.all(responses.map(response => response.json())))
.then(data => console.log(data))
.catch(error => console.error(error))

// Obtenemos: 
[
  { userId: 1, id: 1, title: 'delectus aut autem', completed: false },
  {
    userId: 1,
    id: 2,
    title: 'quis ut nam facilis et officia qui',
    completed: false
  },
  { userId: 1, id: 3, title: 'fugiat veniam minus', completed: false }
]
```

En este ejemplo, se usan varias llamadas `fetch` para realizar múltiples solicitudes HTTP en paralelo, y se devuelve una matriz de promesas que representan las respuestas. Luego, se usa `Promise.all` para esperar a que todas las promesas se resuelvan y devolver una matriz con los resultados. Finalmente, se utiliza la función `map` para convertir cada respuesta en formato JSON y se registra la matriz de datos en la consola. Si se produce algún error durante alguna de las solicitudes, se captura en el bloque `catch`.

Para la API usada en clase sería así: 
```js
Promise.all([
  fetch('https://api.escuelajs.co/api/v1/products/6'),
  fetch('https://api.escuelajs.co/api/v1/categories/3'),
  fetch('https://api.escuelajs.co/api/v1/users/3')
])
  .then(responses => Promise.all(responses.map(response => response.json())))
  .then(data => console.log(data))
  .catch(e => console.log(e))
```

En resumen, `Promise.all()` es útil cuando se necesita realizar múltiples operaciones asíncronas y se desea esperar a que todas se completen antes de continuar con el código.


### Ejemplos de promesas

Ejemplos de cómo crear promesas en JavaScript utilizando el constructor `Promise`:

1. Crear una promesa que se resuelve después de un tiempo determinado:

```js
const delay = ms => {
  return new Promise((resolve) => {
    setTimeout(() => {
      resolve(`Resuelto después de ${ms} ms`);
    }, ms);
  });
}

delay(2000)
  .then(data => console.log(data))
  .catch(error => console.error(error));

// Obtenemos: 
Resuelto después de 2000 ms
```

En este ejemplo, se define una función `delay` que devuelve una promesa que se resuelve después de un tiempo determinado especificado en milisegundos. Dentro de la función, se utiliza el método `setTimeout` para retrasar la resolución de la promesa y luego se llama a la función `resolve` con un mensaje de éxito. Luego, se usa la llamada `then` para manejar el resultado de la promesa y se registra el mensaje en la consola después de que se resuelve. Si se produce algún error durante la ejecución de la promesa, se captura en el bloque `catch`.

2. Crear una promesa que se rechaza si se produce un error:

Para este ejemplo usaremos `onload` que es una propiedad de `XMLHttpRequest` que recibe una función que se ejecutará cuando la solicitud se halla realizado con éxito y se halla recibido una respuesta del servidor.

Además, usaremos la propiedad `onerror` que se utiliza para asignar una función que se ejecutará cuando se produzca un error durante la realización de la solicitud.

```js
const XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;

const getJSON = url => {
  return new Promise((resolve, reject) => {
    const xhr = new XMLHttpRequest();
    xhr.open('GET', url, true);
    xhr.onload = () => {
      if (xhr.status === 200) {
        resolve(JSON.parse(xhr.responseText));
      } else {
        reject(`Error al obtener los datos: ${xhr.status} ${xhr.statusText}`);
      }
    };
    xhr.onerror = () => {
      reject('Error de red');
    };
    xhr.send();
  });
}

getJSON('https://jsonplaceholder.typicode.com/todos/1')
  .then(data => console.log(data))
  .catch(error => console.error(error));

// Obtenemos: Si todo va bien
{ userId: 1, id: 1, title: 'delectus aut autem', completed: false }
// Obtenemos: Si algo sale mal 
Error al obtener los datos: 404 null
```

En este ejemplo, se define una función `getJSON` que devuelve una promesa que se resuelve si la solicitud HTTP se realiza correctamente o se rechaza si se produce algún error. Dentro de la función, se utiliza el objeto `XMLHttpRequest` para realizar una solicitud GET a una URL especificada y luego se llama a la función `resolve` con los datos si la solicitud se realiza correctamente. Si se produce algún error durante la solicitud, se llama a la función `reject` con un mensaje de error. Luego, se usa la llamada `then` para manejar el resultado de la promesa y se registra los datos en la consola si se resuelve correctamente. Si se produce algún error durante la ejecución de la promesa, se captura en el bloque `catch`.

🔥 [Arrow functions: Ejemplos ](https://developer.mozilla.org/es/docs/Web/JavaScript/Reference/Functions/Arrow_functions)


## 12. Playground: Crea una función de delay que soporte asincronismo

En este desafío tienes la función `delay` la cual se espera que un tiempo específico retorne un mensaje.

La función deberá recibir dos parámetros:

- time: el tiempo de espera
- message: el mensaje que debe imprimir después del tiempo de espera

La función `delay` debe retornar una promesa para poderlo usarlo de forma asíncrona.

> Nota: Debes usar la función `setTimeout` con el namespace `window` para poder monitorear su uso en la ejecución de pruebas, ejemplo:

```js
window.setTimeout(() => {
  // code
})
```

Ejemplo 1:

```js
Input:
delay(2000, "Hello after 2s")
.then((message) => console.log(message))

Output:
// after 2s
"Hello after 2s"
```

Ejemplo 2:

```js
Input:
delay(3000, "Hello after 3s")
.then((message) => console.log(message))

Output:
// after 3s
"Hello after 3s"
```

### Solución 

Forma 01:  
```js
const delay = (ms, message) => {
  return new Promise(resolve => {
    setTimeout(() => {
      resolve(message)
    }, ms)
  })
}

delay(2000, 'hi')
  .then(response => console.log(response))
  .catch(e => console.log(e));

// Obtenemos despues de 2 seg
hi
```

Forma 02:  
```js
function delay(time, message) {
  return new Promise((resolve) => {
    setTimeout(() => {
      resolve(message);
    }, time);
  });
};

delay(2000, 'Hi Ghost')
  .then((result) => console.log(result))
  .finally(() => console.log('Finally'));

// Obtenemos despues de 2 seg
Hi Ghost
Finally
```

Forma para Platzi: 
```js
export function delay(time, message) {
  return new Promise((resolve, reject) => {
    window.setTimeout(() => {
      resolve(message);
    }, time);
  });
}
```


## 13. Fetch 

`fetch` es una función nativa que proporciona una forma fácil de hacer solicitudes HTTP y obtener datos de recursos externos, como APIs web o archivos JSON. `fetch` usa promesas y proporciona una interfaz más simple y flexible que el antiguo objeto `XMLHttpRequest` (XHR).

La sintaxis básica de `fetch` es la siguiente:

```js
fetch(url)
  .then(response => response.json())
  .then(data => console.log(data))
  .catch(error => console.error(error));
```

Aquí, `fetch` toma una URL como argumento y devuelve una promesa que resuelve en la respuesta de la solicitud. Luego, se utiliza el método `json()` en la respuesta para extraer los datos en formato JSON de la respuesta. Finalmente, se procesan los datos en la segunda promesa `then`, y cualquier error se maneja en la cláusula `catch`.

### Primeros pasos con fetch (buscar)
 
Para poder usar **fetch**, primero tenemos que instalarlo, para eso nos vamos a la terminal del proyecto y ejecutamos el siguiente comando:

```bash
npm i node-fetch
```

Para poder compilar desde VSC, debemos registrar el módulo en `package.json`, abrimos el archivo y agregamos `"type": "module"`:

```json
{
  "name": "asincronismo",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "scripts": {
    "test": "echo \"Error: no test specified\" && exit 1",
    "callback": "node src/callback/challenge.js"
  },
  "keywords": [
    "javascript"
  ],
  "author": "aleroses <ale.vrs@outlook.com>",
  "license": "MIT",
  "dependencies": {
    "node-fetch": "^3.3.1",
    "xmlhttprequest": "^1.8.0"
  },
  "type": "module"👈👀🔥
}
```

Creamos la siguiente estructura donde haremos algunos ejemplos: 

```bash
.
├── node_modules
├── package-lock.json
├── package.json
└── src
    ├── callback
    │   ├── challenge.js
    │   └── index.js
    ├── playground
    │   ├── 07.callback.js
    │   └── 12.promise.js
    └── promise
        ├── challenge.js 👈👀🔥
        └── index.js
```

`challenge.js`  
```js
import fetch from 'node-fetch';
const API = 'https://api.escuelajs.co/api/v1';

function fetchData(urlApi) {
  return fetch(urlApi);
}

fetchData(`${API}/products`)
  .then(response => response.json())
  .then(products => {
    console.log(products);
  })
  .then(() => {
    console.log('Hi');
  })
  .catch(error => console.log(error));

// Obtenemos una Array con objetos que tienen información de muchos productos: 
[
  {
    id: 4,
    title: 'test',
    price: 2,
    description: 'string',
    images: [ 'https://picsum.photos/640/640?r=6088' ],
    creationAt: '2023-07-19T07:11:23.000Z',
    updatedAt: '2023-07-19T15:58:43.000Z',
    category: {
      id: 2,
      name: 'Electronics',
      image: 'https://picsum.photos/640/640?r=5082',
      creationAt: '2023-07-19T07:11:23.000Z',
      updatedAt: '2023-07-19T07:11:23.000Z'
    }
  },
  {
    id: 8,
    title: 'Ergonomic Soft Salad',
    price: 383,
    description: 'The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients',
    images: [
      'https://picsum.photos/640/640?r=1449',
      'https://picsum.photos/640/640?r=3868',
      'https://picsum.photos/640/640?r=2899'
    ],
    creationAt: '2023-07-19T07:11:23.000Z',
    updatedAt: '2023-07-19T07:11:23.000Z',
    category: {
      id: 1,
      name: 'Clothes',
      image: 'https://picsum.photos/640/640?r=5136',
      creationAt: '2023-07-19T07:11:23.000Z',
      updatedAt: '2023-07-19T07:11:23.000Z'
    }
  },
  {
    id: 106,
    title: 'Rustic Rubber Tuna',
    price: 626,
    description: 'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit',
    images: [
      'https://picsum.photos/640/640?r=3242',
      'https://picsum.photos/640/640?r=2927',
      'https://picsum.photos/640/640?r=2304'
    ],
    creationAt: '2023-07-19T07:11:23.000Z',
    updatedAt: '2023-07-19T07:11:23.000Z',
    category: {
      id: 3,
      name: 'Change title',
      image: 'https://picsum.photos/640/640?r=8535',
      creationAt: '2023-07-19T07:11:23.000Z',
      updatedAt: '2023-07-19T17:51:32.000Z'
    }
  },
  ... 364 more items
]
```

Ahora obtengamos el título y nombre de la categoría del producto seleccionado. 

```js
import fetch from 'node-fetch';
const API = "https://api.escuelajs.co/api/v1";

function fetchData(urlApi) {
  return fetch(urlApi);
}

// Para obtener datos necesitas 1 fetchData y 2 .then (1 para convertirlo a json y 1 para mostrarlo)
fetchData(`${API}/products`)
  .then(response => response.json())
  .then(products => {
    // console.log(products);
    return fetchData(`${API}/products/${products[0].id}`)
  })
  .then(response => response.json())
  .then(product => {
    // console.log(product);
    console.log(product.title);
    return fetchData(`${API}/categories/${product.category.id}`)
  })
  .then(response => response.json())
  .then(category => {
    // console.log(category)
    console.log(category.name);
  })
  .catch(err => console.log(err))
  .finally(() => console.log('Finally'));

// Obtenemos 
Handcrafted Cotton Bike
Electronics
Finally

// fetch - buscar
// delay - demora
```

Esta es una forma más sencilla de hacer lo mismo: 

```js
import fetch from "node-fetch";
const API = 'https://api.escuelajs.co/api/v1';

function fetchData(urlApi) {
  return fetch(urlApi);
}

fetchData(`${API}/products`)
  .then(response => response.json())
  .then(product => {
    // console.log(product[0]);
    console.log(product[0].title);
    console.log(product[0].category.name);
  })
  .catch(err => console.log(err))
  .finally(() => console.log('Finally'));
```

## 14. Fetch POST

🔥 Revisa los apuntes de la clase 8 [[asincronismo-con-js#8. XMLHTTPRequest#Características del protocolo HTTP]]

El método `POST` es uno de los métodos HTTP que se utilizan para enviar datos desde un cliente a un servidor. En particular, el método `POST` se utiliza para enviar datos que se utilizarán para crear o actualizar un recurso en el servidor.

> A diferencia del método `GET`, que se utiliza para recuperar información del servidor, el método `POST` envía datos al servidor para que se procesen.

### Opciones para realizar una solicitud HTTP `POST`

Cada opción o parámetro tiene un propósito específico en la configuración y el envío de la solicitud HTTP. Las opciones de solicitud se utilizan para especificar la forma en que se enviará la solicitud HTTP, qué tipo de datos se enviarán y cómo se procesarán los datos de respuesta. Algunas de las opciones de solicitud son obligatorias, mientras que otras son opcionales o dependen del tipo de solicitud que se esté realizando.

- `method: 'POST'`: Esto indica que se utilizará el método `POST` para realizar la solicitud.

- `mode: 'cors'`: Esto establece el modo de la solicitud. En este caso, se está utilizando el modo "cors" (Cross-Origin Resource Sharing -Compartición de recursos entre diferentes orígenes), que permite solicitudes entre diferentes dominios, esto quiere decir que permitir que los recursos de diferentes orígenes se compartan entre sí en la web. Por ejemplo, una página web alojada en un dominio diferente puede solicitar recursos de otro dominio mediante JavaScript. CORS funciona mediante el uso de encabezados HTTP especiales para indicar que un recurso determinado puede ser compartido entre diferentes orígenes. Los servidores pueden configurar sus respuestas HTTP para incluir estos encabezados y permitir que se compartan los recursos.

- `credentials: 'same-origin'`: Son cualquier información que se utiliza para autenticar a un usuario o para identificar una sesión de usuario en un sitio web. Las credenciales pueden incluir información como cookies, tokens de autenticación o certificados. Cuando se realizan solicitudes HTTP, se pueden enviar credenciales al servidor para identificar al usuario o sesión correspondiente. La opción `credentials` en una solicitud HTTP indica qué tipo de credenciales se deben enviar con la solicitud. En este caso, se está utilizando "same-origin", lo que significa que se enviarán las mismas credenciales utilizadas para la página actual.

- `headers: {'Content-Type': 'application/json'}`: Los encabezados HTTP son piezas de información que se envían junto con una solicitud HTTP o una respuesta HTTP. Los encabezados proporcionan información adicional sobre la solicitud o la respuesta, como el tipo de contenido que se está enviando, la longitud de los datos, el tipo de codificación, etc. Los encabezados también se pueden utilizar para enviar información personalizada entre el cliente y el servidor. Por ejemplo, un encabezado personalizado podría utilizarse para enviar un token de autenticación con una solicitud HTTP. En este caso, se está utilizando un encabezado `Content-Type` con el valor `application/json`, lo que indica que los datos que se enviarán en el cuerpo de la solicitud estarán en formato JSON.

- `body: JSON.stringify(data)`: Esto establece el cuerpo de la solicitud. En este caso, se está utilizando el método `JSON.stringify()` para convertir el objeto `data` a una cadena JSON que se enviará como el cuerpo de la solicitud.



Todos estos valores se utilizan para configurar y enviar una solicitud HTTP `POST` utilizando JavaScript, con la opción de enviar los datos en formato JSON.

Es importante tener en cuenta que las opciones de solicitud pueden variar según el lenguaje de programación o la biblioteca que se esté utilizando para realizar la solicitud HTTP. Pero en general, estas opciones se utilizan para configurar y enviar una solicitud HTTP con la información necesaria para que el servidor pueda procesarla correctamente.

###  ¿Qué es un origen cruzado?

El término "origen cruzado" (en inglés "cross-origin") se refiere a una situación en la que una página web (o una aplicación web) intenta acceder a recursos (como archivos, scripts, imágenes, etc.) que se encuentran en un servidor o dominio diferente al de la página web. Por ejemplo, si la página web se carga desde el dominio `www.example.com` y trata de acceder a recursos en el dominio `api.example.com`, esto se considera una situación de origen cruzado.

Los navegadores web modernos limitan el acceso de una página web a recursos de origen cruzado por motivos de seguridad. Sin embargo, en algunos casos, es necesario permitir el acceso a recursos de origen cruzado (por ejemplo, cuando se utiliza una API de terceros). En estos casos, se utiliza la técnica de "Compartición de recursos de origen cruzado" (CORS) para permitir que la página web acceda a los recursos de otro dominio.

La técnica de CORS utiliza encabezados HTTP especiales para indicar que un recurso determinado puede ser compartido entre diferentes orígenes. El servidor web debe configurar sus respuestas HTTP para incluir estos encabezados y permitir que se compartan los recursos.

Por lo tanto, CORS se utiliza para permitir que una página web acceda a recursos de origen cruzado de forma segura. Si los encabezados CORS no están configurados correctamente, el navegador web bloqueará la solicitud debido a motivos de seguridad.

### Usemos POST

Crea un archivo `post.js` dentro de `src/promise`:  

```bash
╰─ tree -L 3
.
├── node_modules
├── package-lock.json
├── package.json
└── src
    ├── callback
    │   ├── challenge.js
    │   └── index.js
    ├── playground
    │   ├── 07.callback.js
    │   └── 12.promise.js
    └── promise
        ├── challenge.js
        ├── index.js
        └── post.js 👈👀🔥
```

`post.js`
```js
import fetch from "node-fetch";
const API = "https://api.escuelajs.co/api/v1"

function postData(urlApi, data) {
  const response = fetch(urlApi, {
    method: 'POST',
    // Si comentas mode y credentials igual funciona
    mode: 'cors', // permiso, por defecto va estar siempre en cors
    credentials: 'same-origin',
    headers: {
      'Content-Type': 'application/json' // necesario indicar que es lo que se está enviando (data tipo json)
    },
    body: JSON.stringify(data) // el método JSON.stringify() convierte un objeto o valor de JavaScript en una cadena de texto JSON
  });

  return response;
}

// estructura obligatoria de como debe ser el objeto que se quiere crear con POST
const data = {
  "title": "New Product 212",
  "price": 212,
  "description": "A description",
  "categoryId": 1,
  "images": ["https://placeimg.com/640/480/any"]
}

// podemos usar el postData como una promesa y con .then obtener la respuesta como un objeto json y mostrarlo después en la consola
postData(`${API}/products`, data)
  .then((response) => response.json())
  .then(data => console.log(data))
  .catch((err) => console.log(err));
```

Si todo va bien podremos ver en la consola un objeto, pero si algo falla debería salir un 400 (Bad Request).

```js
Valores añadidos a la Fake API: 
https://api.escuelajs.co/api/v1/products/448
https://api.escuelajs.co/api/v1/products/212
```

### Usemos PUT 

```js
//Con PUT para actualizar un objeto
function putData(urlApi, dataUpdate) {
    const response = fetch(urlApi, {
        method: 'PUT',
        mode: 'cors',
        credentials: 'same-origin',
        headers:{
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(dataUpdate)
    });
    return response;
}

const dataUpdate = {
    "title": "Se puede cambiar tambien otras caracteristicas",
    "price": 10// no es necesario colocar todas las características del objeto, solo las que se cambiarán
}

putData(`${API}/products/271`, dataUpdate) //se debe colocar el id del objeto que se quiere modificar
    .then(response => response.json())
    .then(dataUpdate =>console.log(dataUpdate));
```

### Usemos DELETE 

```js
import fetch from 'node-fetch';
const API = 'https://api.escuelajs.co/api/v1';

//Eliminar un objeto indicando el id con DELETE
function deleteData(urlApi) { //no es necesario pasar la data
    const response = fetch(urlApi, {
        method: 'DELETE',
        mode: 'cors', //no es necesario
        credentials: 'same-origin',//no es necesario
        headers:{
            'Content-Type': 'application/json'
        } //no es necesario especificar el body
    });
    return response;
}

const idNumber = 271; //se debe colocar el id del objeto qu se quiere modificar

deleteData(`${API}/products/${idNumber}`) //no es necesario pasar data
    .then(() => {
        console.log(`Borrado ${idNumber}`); //es opcional imprimir en consola
    });
```


### [Imágenes Aleatorias](https://picsum.photos/)

Simplemente, agregue el tamaño de imagen deseado (ancho y alto) después de nuestra URL y obtendrá una imagen aleatoria.

```
https://picsum.photos/200/300
```

Para obtener una imagen cuadrada, simplemente agregue el tamaño.

```
https://picsum.photos/200
```


- [Concepto de Cors](https://javascript.info/fetch-crossorigin)
- [Documentación Cors](https://developer.mozilla.org/en-US/docs/Glossary/CORS)


## 15. Funciones asíncronas

`async` y `await` son características que permiten escribir código asíncrono de manera más legible y fácil de entender. `new Promise()` es una forma de crear una promesa en JavaScript que se utiliza comúnmente para manejar tareas asíncronas.

Una promesa es un objeto que representa un valor que puede no estar disponible de inmediato, pero que eventualmente se resolverá (con un valor) o se rechazará (con un error). Cuando se crea una promesa con `new Promise()`, se le pasa una función que define qué debe hacer la promesa. Esta función toma dos argumentos, `resolve` y `reject`, que son funciones que se llaman para resolver o rechazar la promesa, respectivamente.

Por ejemplo, la siguiente función devuelve una promesa que se resuelve después de 1 segundo con el valor "¡Hola Mundo!":

```js
function sayHello() {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve("¡Hola Mundo!");
    }, 1000);
  });
}
```

Para utilizar `async` y `await` con una promesa, primero se define una función `async` que contiene la lógica asincrónica. En este caso, llamamos a la función `sayHello()` y esperamos a que se resuelva usando la palabra clave `await`. Veamos un ejemplo:

```js
async function printHello() {
  const message = await sayHello();
  console.log(message);
}

printHello(); 
// esperará 1 segundo y luego imprimirá "¡Hola Mundo!"
```

En este ejemplo, la función `printHello()` llama a `sayHello()` y espera a que se resuelva antes de imprimir el mensaje en la consola. La palabra clave `await` hace que la función `printHello()` espere a que se resuelva la promesa devuelta por `sayHello()` antes de continuar con la siguiente línea de código.

`async` y `await` son útiles porque permiten escribir código asíncrono de manera más legible y fácil de entender, ya que se parece más a código sincrónico. También hacen que sea más fácil manejar errores, ya que se pueden utilizar bloques `try` / `catch` para capturar y manejar errores.

### Ejemplo de la clase:  

```js
const fnAsync = () => {
  return new Promise((resolve, reject) => {
    true // false para probar el reject
      ? setTimeout(() => resolve("3. Async!!!"), 2000)
      : setTimeout(() => reject("3. This is an error"), 2000);
  });
};

// async es para el cuerpo de la función
const anotherFn = async () => {
  try {
    // await estará dentro de la lógica a implementar
    const something = await fnAsync();
    console.log(something);
  } catch (error) {
    console.error(error);
  }
  console.log("4. Hello!!!");
};

console.log('1. Before');
anotherFn();
console.log('2. After');

// Obtenemos: 
1. Before
2. After
// Despues de 2 segundos...
3. Async!!!
4. Hello!!!
```

📌 Nota: En caso de ejecutarse el reject debemos usar un try catch de lo contrario no obtendremos el contenido de este. 

También podemos ver su ejecución de la siguiente manera: 

```js
function fnAsync() {
  return '3. Third'
}

const anotherFn = async () => {
  const response = await fnAsync();
  console.log(response);
  console.log('4. The end!!!');
}

console.log('1. First');
anotherFn();
console.log('2. Second');

// Obtenemos: 
1. First
2. Second
3. Third
4. The end!!!
```

![](https://i.postimg.cc/RqxVWb4t/async-await.gif)


## 16. Try and catch  

`try` y `catch` son constructores de JavaScript que se utilizan para manejar errores en el código. 

El bloque `try` se utiliza para envolver el código que se considera propenso a generar un error. Si ocurre un error en el bloque `try`, el control se transfiere al bloque `catch` correspondiente.

El bloque `catch` se utiliza para capturar y manejar cualquier excepción o error que se haya producido en el bloque `try`. El bloque `catch` toma un parámetro, que es el objeto de error que se ha producido en el bloque `try`.

Un ejemplo de uso de `try` y `catch` en JavaScript sería el siguiente:

```js
try {
  // Código propenso a generar un error
  console.log(variableInexistente);
} catch(error) {
  // Manejo del error
  console.log("Se ha producido un error: " + error.message);
}

// Obtenemos: 
Se ha producido un error: variableInexistente is not defined
```

Con `try` y `catch`, puedes manejar errores de manera efectiva y asegurarte de que tu programa no se bloquee o se cierre debido a errores inesperados.

### Ejemplo de la clase:  

```js
import fetch from 'node-fetch';
const API = 'https://api.escuelajs.co/api/v1';

async function fetchData(urlApi) {
  const response = await fetch(urlApi);
  const data = await response.json();
  return data;
}

const anotherFunction = async (urlApi) => {
  try {
    const products = await fetchData(`${urlApi}/products`);
    const product = await fetchData(`${urlApi}/products/${products[0].id}`);
    const category = await fetchData(`${urlApi}/categories/${product.category.id}`)

    // console.log(products);
    console.log(product.title);
    console.log(category.name);

  } catch (err) {
    console.error(err);
  }
}

anotherFunction(API);
```

### Lo mismo pero más sencillo: 

```js
import fetch from 'node-fetch';
const API = 'https://api.escuelajs.co/api/v1'

const fetchFunction = async () => {
  try {
    const response = await fetch(`${API}/products`);
    const data = await response.json();
    console.log({
      //data: data[0],
      title: data[0].title,
      category: data[0].category.name,
    });
  } catch (err) {
    console.error(err);
  }
}

fetchFunction();

// Obtenemos: 
{ title: 'Rustic Metal Computers', category: 'Others' }
```


## 17. Playground: Captura el error de una petición

En este desafío vas a conectarte a una API que no existe, por ende debes capturar el error haciendo uso de try/catch y lanzar un error con el mensaje `API Not Found`.

Para lanzar el error debes usar el siguiente bloque de código:

```js
throw new Error('API Not Found');
```

Para solucionarlo vas a encontrar una función llamada runCode que no recibe parámetros de entrada, dentro del cuerpo de la función runCode debes escribir tu solución.

Ejemplo:

```js
Input:
await runCode();
```
```js
Output:
Error: API Not Found
```

### Solución personal: 

```js
import fetch from "node-fetch";
// const API = 'https://api.escuelajs.co/api/v1'
const API = 'https://domain-api-com';

const x = async () => {
  try {
    //const response = await fetch(`${API}/products`);
    const response = await fetch(API);
    const data = await response.json();
    console.log(data[0]);
  } catch (e) {
    console.error(e);
  }
}

x();
```

### Solución Platzi:

```js
export async function runCode() {
  const url = 'https://domain-api-com';
  try {
    return await fetch(url);
  } catch {
    throw new Error('API Not Found'); 🔥🤔😢
  }
}
```

También:  

```js
export async function runCode() {
  try {
    const url = "https://domain-api-com";
    const response = await fetch(url);
    const data = await response.json();
    console.log(data);
  } catch {
    throw new Error("API Not Found");
  }
}

runCode();
```


## 18. ¿Cómo enfrentar los errores?

## 19. Generators

Los Generators son una característica que permite la creación de funciones especiales que pueden ser pausadas y reanudadas en cualquier momento mientras se ejecutan. 

> Estas funciones son conocidas como "generators" o "generadores" porque pueden generar una secuencia de valores a través de múltiples llamadas.

Los Generators se declaran usando la palabra clave `function*` en lugar de `function`. Dentro del cuerpo de una función Generadora, se pueden utilizar la palabra clave `yield` para **pausar la ejecución de la función y devolver un valor**. La función Generadora puede ser reanudada en cualquier momento llamándola nuevamente, y la ejecución continuará desde el punto donde se dejó.

### Utilidad 

Los Generators son útiles para generar secuencias de valores que pueden ser consumidos por otras partes de un programa de manera eficiente. Por ejemplo, se pueden utilizar para iterar sobre grandes conjuntos de datos de manera perezosa, lo que significa que los elementos se generan bajo demanda en lugar de cargarse todos de una vez en la memoria. Esto es especialmente útil para trabajar con conjuntos de datos que no caben en la memoria disponible.

Otro uso común de los Generators es en la implementación de iteradores personalizados. Al devolver valores de manera perezosa usando `yield`, se puede crear un iterador personalizado que permita recorrer una estructura de datos de manera más flexible y eficiente.

Aquí hay un ejemplo simple de cómo utilizar un Generador para iterar sobre una secuencia de números:

```js
// Función* Generadora 👀👇
function* generateNumbers() {
  let i = 0;
  while (true) {
    yield i++;
  }
}

// Para obtener la secuencia de valores generados
// por la función Generadora debemos asignar el
// objeto Generador devuelto a una const...
const numberGenerator = generateNumbers();
console.log(numberGenerator.next().value); // 0
console.log(numberGenerator.next().value); // 1
console.log(numberGenerator.next().value); // 2
```

En este ejemplo, la función Generadora `generateNumbers` utiliza un bucle infinito para generar una secuencia infinita de números enteros. Cada vez que se llama a la función `next` en el objeto Generador devuelto, la ejecución se reanuda en el punto donde se dejó y se devuelve el siguiente valor generado por la función.

📌 Nota: La expresión `yield i++` primero devuelve el valor actual de `i` y luego incrementa su valor en 1 para la siguiente llamada a la función generadora. Por lo tanto, el primer valor devuelto será siempre el valor actual de `i` antes de que se incremente.

### Ejemplos de la clase 

```js
// Ejemplo 1:
function* gen() {
  yield 1;
  yield 2;
  yield 3;
}

const g = gen();
console.log(g); // Object [Generator] {}
console.log(g.next()); // { value: 1, done: false }🔥
console.log(g.next().value); // 2
console.log(g.next().value); // 3
console.log(g.next().value); // undefined
```

La palabra clave `yield` dentro de una función Generadora devuelve un objeto con dos propiedades: `value` y `done`. La propiedad `value` representa el valor generado por la función Generadora, mientras que la propiedad `done` es un valor booleano que indica si la función Generadora ha terminado de generar valores o no.

```js
// Ejemplo 2:
function* iterate(array) {
  for (let value of array) {
    yield value
  }
}

const it = iterate(['oscar', 'omar', 'ana', 'lucia', 'juan']);
console.log(it.next()); // { value: 'oscar', done: false }
console.log(it.next().value); // omar
console.log(it.next().value); // ana
console.log(it.next().value); // lucia
console.log(it.next().value); // juan
console.log(it.next().value); // undefined
console.log(it.next().value); // undefined
```

### Usando una API

```js
import fetch from 'node-fetch';
const API = 'https://api.escuelajs.co/api/v1';

// Declaración de fetchData como la función del Generador
async function* fetchData(url) {
  const response = await fetch(url);
  yield await response.json();
};

fetchData(`${API}/product`)
  .next()
  .then(({ value, done }) => {
    //Imprime la lista de los Productos de la API
    // console.log(value);
    const id = value[0].id;
    const title = value[0].title;
    const category = value[0].category.name;
    console.log({
      id: id,
      title: title,
      category: category,
    });

    // En consola usa: Ctrl + Click sobre el enlace
    console.log(`Ctrl + Click: 🔥${API}/products/${id}`);
  })
  .catch((e) => console.log(e));

// Obtenemos: 
{ id: 30, title: 'Electronic Metal Table', category: 'Electronics' }
Ctrl + Click: 🔥https://api.escuelajs.co/api/v1/products/30
```

#### Otro ejemplo 

Si accedemos a `https://swapi.dev/api/people/` veremos como está construida la información por lo que en `yield` se usa `data.results`. 

```json
{
    "count": 82, 
    "next": "https://swapi.dev/api/people/?page=2", 
    "previous": null, 
    "results": [ 👈👀🔥
        {
            "name": "Luke Skywalker", 
            "height": "172", 
            "mass": "77", 
            "hair_color": "blond", 
            "skin_color": "fair", 
            "eye_color": "blue", 
            "birth_year": "19BBY", 
            "gender": "male", 
            "homeworld": "https://swapi.dev/api/planets/1/", 
            "films": [
                "https://swapi.dev/api/films/1/", 
                "https://swapi.dev/api/films/2/", 
                "https://swapi.dev/api/films/3/", 
                "https://swapi.dev/api/films/6/"
            ], 
            "species": [], 
            "vehicles": [
                "https://swapi.dev/api/vehicles/14/", 
                "https://swapi.dev/api/vehicles/30/"
            ], 
            "starships": [
                "https://swapi.dev/api/starships/12/", 
                "https://swapi.dev/api/starships/22/"
            ], 
            "created": "2014-12-09T13:50:51.644000Z", 
            "edited": "2014-12-20T21:17:56.891000Z", 
            "url": "https://swapi.dev/api/people/1/"
        } 
```

Con el código siguiente obtenemos todos los datos que posee esta api en cuanto a `people` se refiere. 

```js
async function* fetchAPI(url) {
  let nextPage = url;
  while (nextPage != null) {
    const response = await fetch(nextPage);
    const data = await response.json();
    yield data.results;
    nextPage = data.next;
  }
}

const API_URL = 'https://swapi.dev/api/people/';

(async () => {
  for await (const results of fetchAPI(API_URL)) {
    console.log(results);
  }
})();

// Alternativa a la función anonima
/* 
async function fetchAndLogData() {
  for await (const results of fetchAPI(API_URL)) {
    console.log(results);
  }
}

fetchAndLogData(); 
*/
```

Obtengamos solo los nombres de los personajes: 
```js
async function* data(url) {
  let nextPage = url;
  while (nextPage != null) {
    const response = await fetch(nextPage);
    const data = await response.json();

    for (const results of data.results) {
      yield results.name;
    }

    nextPage = data.next;
  }
}

const API_URL = "https://swapi.dev/api/people/";

(async () => {
  for await (const results of data(API_URL)) {
    console.log(results);
  }
})();
```


🔥 ¿Por qué usamos un While en este ejemplo??

La línea `while (nextPage != null)` se utiliza para hacer una solicitud a la API de varias páginas y recibir todos los datos disponibles.

Algunas APIs utilizan la paginación para devolver grandes cantidades de datos en bloques más pequeños. En lugar de devolver todos los datos en una sola respuesta, la API puede dividir los datos en páginas y devolver una URL para la siguiente página en la respuesta. Para obtener todos los datos, es necesario hacer solicitudes adicionales a cada página de la API hasta que se hayan recibido todos los datos disponibles.

> La línea `while (nextPage != null)` se utiliza para verificar si hay una URL de página siguiente en la respuesta de la API. Si una URL de página siguiente está presente, la función generadora hace una solicitud a esa URL y devuelve los datos de la página actual como parte de la secuencia generada. Si no hay URL de página siguiente, la función generadora termina y no devuelve más datos.

Por lo tanto, es importante incluir la verificación `while (nextPage != null)` en la función generadora si se espera que la API devuelva varias páginas de datos. De lo contrario, la función generadora solo devolverá los datos de la primera página y se detendrá.

🔥 ¿Por qué él async está en esta forma? `(async () => { ... })()`

La razón por la que el `async` está envuelto dentro de `(async () => { ... })()` en el código es para crear una función asincrónica anónima y ejecutarla inmediatamente.

En JavaScript, las funciones asincrónicas se definen con la palabra clave `async`, lo que indica que la función devuelve una promesa. En este caso, la función asincrónica es anónima, lo que significa que no tiene un nombre definido y se define dentro de los paréntesis. Luego, la función se ejecuta inmediatamente al envolverla con los paréntesis finales `()`.

Además, el bucle `for-await-of` que se utiliza para iterar sobre la secuencia generada por `fetchAPI` solo se puede utilizar dentro de una función asincrónica. Por lo tanto, la función asincrónica anónima se utiliza para crear un contexto asincrónico y permitir el uso del bucle `for-await-of`.

En resumen, el envoltorio `(async () => { ... })()` se utiliza para crear una función asincrónica anónima y ejecutarla inmediatamente, lo que permite el uso del bucle `for-await-of` para iterar sobre la secuencia generada por `fetchAPI`.


### For of vs For in 

La diferencia entre los bucles `for...in` y `for...of` en JavaScript radica en cómo iteran sobre las estructuras de datos y qué valores proporcionan durante la iteración.

1. `for...in`:

- El bucle `for...in` se utiliza para iterar sobre las propiedades enumerables de un objeto.
- Itera sobre las claves (propiedades) de un objeto, incluyendo las propiedades heredadas del prototipo.
- Es útil para recorrer objetos, pero no se recomienda para iterar sobre matrices o cadenas de caracteres.
- Proporciona el nombre de la propiedad en cada iteración.

Ejemplo de `for...in` con un objeto:

```javascript
const obj = { a: 1, b: 2, c: 3 };

for (const key in obj) {
  console.log(key); // Imprime: a, b, c
  console.log(obj[key]); // Imprime: 1, 2, 3
}
```

2. `for...of`:

- El bucle `for...of` se utiliza para iterar sobre elementos iterables, como matrices, cadenas de caracteres, conjuntos (Sets), mapas (Maps), etc.
- Itera sobre los valores de los elementos, en lugar de las claves o propiedades.
- No proporciona acceso directo a las claves o índices de los elementos iterados.
- Es útil cuando solo se necesitan los valores de los elementos y no se requiere el conocimiento de sus índices o claves.

Ejemplo de `for...of` con una matriz:

```javascript
const arr = [1, 2, 3];

for (const value of arr) {
  console.log(value); // Imprime: 1, 2, 3
}
```

Ejemplo de `for...of` con una cadena de caracteres:

```javascript
const str = 'Hola';

for (const char of str) {
  console.log(char); // Imprime: H, o, l, a
}
```

En resumen, `for...in` se utiliza para iterar sobre las propiedades de un objeto, mientras que `for...of` se utiliza para iterar sobre los valores de elementos en estructuras de datos iterables como matrices y cadenas de caracteres. 


## 20. Proyecto del curso

Creamos un repo en GitHub con el nombre async-landing, lo agregamos publico, agregamos un .gitignore template: Node y también agregamos una License: MIT License. 

Clonamos el repo: 
```bash
git clone https://github.com/aleroses/async-landing.git
```

```bash
cd async-landing/
npm init -y
code .
```

Creamos una carpeta src y debe tener la siguiente estructura: 

```bash
╰─ tree -L 3
.
├── LICENSE     
├── README.md   
├── package.json
└── src 👈👀
    ├── assets  
    │   └── main.js
    └── index.html
```

Si no quieres trabajar con Tailwind puedes hacer tu propia estructura de archivos, html y tus propios estilos css, algo así como lo siguiente:  

Estructura de carpetas: 

```bash
╰─ tree -L 3
.
├── LICENSE
├── README.md
├── node_modules
├── package-lock.json
├── package.json
└── public
    ├── css
    │   ├── desktop.css
    │   ├── light-mode.css
    │   ├── style.css
    │   └── tablet.css
    ├── img
    │   └── hero.jpg
    ├── index.html
    ├── light-mode.js
    ├── main.js
    └── svg
        ├── facebook.svg
        ├── moon.svg
        ├── purple-logo-01.svg
        ├── sun.svg
        └── twitter.svg
```

`index.html`  
```html
<!DOCTYPE html>
<html lang="en" data-theme="dark">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Fazt</title>
    <link rel="stylesheet" href="./css/style.css" />
    <link rel="stylesheet" href="./css/tablet.css" media="(min-width: 600px)" />
    <link
      rel="stylesheet"
      href="./css/desktop.css"
      media="(min-width: 750px)"
    />
    <link rel="stylesheet" href="./css/light-mode.css" disabled />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link
      href="https://fonts.googleapis.com/css2?family=Ubuntu:wght@400;500;700&display=swap"
      rel="stylesheet"
    />
  </head>
  <body data-theme="dark">
    <header class="header">
      <section class="header__logo item-1">
        <a href="#">
          <img src="./svg/purple-logo-01.svg" alt="" />
        </a>
      </section>

      <nav class="header__nav item-2">
        <!-- show -->
        <ul class="menu">
          <li><a href="#">About</a></li>
          <li><a href="#">Projects</a></li>
          <li><a href="#">Contact</a></li>
        </ul>
        <section class="burger item-3" onclick="toggleMenu()">
          <div class="bar"></div>
          <div class="bar"></div>
          <div class="bar"></div>
        </section>
      </nav>

      <section class="mode item-4">
        <figure class="dark-mode" onclick="toggleLight()">
          <!-- light-mode -->
          <button></button>
        </figure>
      </section>
    </header>

    <main class="main">
      <figure>
        <img src="./img/hero.jpg" alt="" />
      </figure>
      <article class="main__article">
        <h1>Fazt <span>@FaztTech</span></h1>
        <p>
          Fazt es un canal en donde podrás encontrar una variedad de videos de
          programación, desarrollo Web y muchos otros temas relacionados al
          mundo de la informática en general. Desde aprender las bases de un
          lenguaje de programacion hasta subir tu sitio o aplicación Web.
          Bienvenido al mundo de la web, un mundo en el que la información es
          libre, al igual que la información de este canal.
        </p>
      </article>
    </main>

    <section class="content">
      <h2>Last YouTube Videos</h2>
      <div class="content__show">
        <!-- Content API-->
        <!-- <article class="content__video">
          <figure>
            <img src="./img/x.jpg" alt="" />
          </figure>
          <div>
            <p>
              Twitter y AWS entrando al juego de los servicios basados en
              Inteligencia Artificial
            </p>
          </div>
        </article> -->
      </div>
    </section>

    <footer>
      <h2>Contact <br /><span>keep in touch.</span></h2>
      <div>
        <a href=""><img src="./svg/facebook.svg" alt="x" /></a>
        <a href=""><img src="./svg/twitter.svg" alt="x" /></a>
      </div>
    </footer>

    <script src="./light-mode.js"></script>
    <script src="./main.js"></script>
    <script>
      /* Burger Menu */
      function toggleMenu() {
        let menu = document.querySelector(".menu");
        menu.classList.toggle("show");
      }
    </script>
  </body>
</html>
```

### Herramientas que podemos usar para modificar la apariencia de la página:

- [Buscar imágenes para fondo gratuitas:](https://pixabay.com/es/)
- [Buscar iconos gratuitos:](https://icon-icons.com/es/)
- [Buscar paletas de colores:](https://htmlcolorcodes.com/es/)
- [Agregar efecto de gradiente a los fondos de colores:](https://cssgradient.io/)
- [Cambiar el tipo de fuente:](https://fonts.google.com/)
- [Convertir una imagen a formato svg:](https://picsvg.com/es/)

🔥 [Repositorio de mi proyecto](https://github.com/aleroses/async-landing)
🔥 [Repositorio del código de la clase](https://gist.github.com/gndx/2946ab4ac16597883dda5fb4de15e07a)
🔥 [Repositorio del proyecto de la clase](https://github.com/platzi/async-landing/tree/main)

## 21. Consumiendo API

Para obtener un script con async y await que podamos adaptar, nos debemos crear una cuenta en [✨RapidApi](https://rapidapi.com/hub). Esta es una colección de API's que se pueden implementar en nuestros proyectos de manera sencilla. 

Luego buscamos YouTube y entramos en [youtube v3](https://rapidapi.com/ytdlfree/api/youtube-v31/) esto para llamar los últimos videos de cualquier canal de YouTube. 

En el panel izquierdo seleccionamos Channel Videos y agregamos el ID del canal al que queremos acceder:   
- Channel Videos
	- Required Parameters
		- channelId: UCX9NJ471o7Wie1DQe94RVIg
	- Optional Parameters
		- maxResults: 2 (el número que quieras)

![](https://i.postimg.cc/rFLbCjdW/parameters.png)

Luego en la parte de **Code Snippets** elegimos `JavaScript` - `fetch`  
![](https://i.postimg.cc/zDwp5rBb/js-fetch.png)

Nos entrega el siguiente código, el cual usaremos en nuestro proyecto:  
```js
const url = 'https://youtube-v31.p.rapidapi.com/search?channelId=UCX9NJ471o7Wie1DQe94RVIg&part=snippet%2Cid&order=date&maxResults=2';
const options = {
  method: 'GET',
  headers: {
    'X-RapidAPI-Key': '6c8aec95f0mshc835fd1a770d505p1250bfjsn6fdebd898161',
    'X-RapidAPI-Host': 'youtube-v31.p.rapidapi.com'
  }
};

try {
  const response = await fetch(url, options);
  const result = await response.text();
  console.log(result);
} catch (error) {
  console.error(error);
}
```

 Al lado de **Code Snippets** encontramos la pestaña **Results** donde podremos ver los datos que necesitamos en formato JSON. Esto es importante porque a través de este accederemos a los datos que vayamos requiriendo.   

```js
{
  "kind": "youtube#searchListResponse",
  "nextPageToken": "CAIQAA",
  "regionCode": "DE",
  "pageInfo": {
    "totalResults": 463,
    "resultsPerPage": 2
  },
  "items": [
    {
      "kind": "youtube#searchResult",
      "id": {
        "kind": "youtube#video",
        "videoId": "ZN9Ygzx6Sfo"
      },
      "snippet": {
        "publishedAt": "2023-04-21T12:10:00Z",
        "channelId": "UCX9NJ471o7Wie1DQe94RVIg",
        "title": "Twitter y AWS entrando al juego de los servicios basados en Inteligencia Artificial",
        "description": "Este es un resumen semanal de Noticias IA en donde podemos encontrar mencionadas a organizaciones como OpenAI, Stable ...",
        "thumbnails": {
          "default": {
            "url": "https://i.ytimg.com/vi/ZN9Ygzx6Sfo/default.jpg",
            "width": 120,
            "height": 90
          },
          "medium": {
            "url": "https://i.ytimg.com/vi/ZN9Ygzx6Sfo/mqdefault.jpg",
            "width": 320,
            "height": 180
          },
          "high": {
            "url": "https://i.ytimg.com/vi/ZN9Ygzx6Sfo/hqdefault.jpg",
            "width": 480,
            "height": 360
          }
        },
        "channelTitle": "Fazt",
        "liveBroadcastContent": "none",
        "publishTime": "2023-04-21T12:10:00Z"
      }
    },
    {
      "kind": "youtube#searchResult",
      "id": {
        "kind": "youtube#video",
        "videoId": "qsT45AdEVco"
      },
      "snippet": {
        "publishedAt": "2023-04-19T20:50:17Z",
        "channelId": "UCX9NJ471o7Wie1DQe94RVIg",
        "title": "Como OpenAI hace que GPT no sea un IA Toxica",
        "description": "Reinforcement Learning from Human Feedback o abreviado RLHF es una tecnica en la que OpenAI alinea sus modelos de ...",
        "thumbnails": {
          "default": {
            "url": "https://i.ytimg.com/vi/qsT45AdEVco/default.jpg",
            "width": 120,
            "height": 90
          },
          "medium": {
            "url": "https://i.ytimg.com/vi/qsT45AdEVco/mqdefault.jpg",
            "width": 320,
            "height": 180
          },
          "high": {
            "url": "https://i.ytimg.com/vi/qsT45AdEVco/hqdefault.jpg",
            "width": 480,
            "height": 360
          }
        },
        "channelTitle": "Fazt",
        "liveBroadcastContent": "none",
        "publishTime": "2023-04-19T20:50:17Z"
      }
    }
  ]
}
```

### 🔥 Dato importante  

Para obtener el ID de cualquier canal que te interese, debes acceder a [COMMENT PICKER](https://commentpicker.com/youtube-channel-id.php#youtube-channel-id)

Una vez aquí, debes agregar el link del canal de tu interés, en mi caso es el canal de [Fazt](https://www.youtube.com/@FaztTech), luego debes resolver el ejercicio que aparezca y por último debes darle en `Get YouTube Channel ID`. 

![](https://i.postimg.cc/0yDfN15J/youtube-id.png)

Esto te dará algunos datos del canal incluido su ID: UCX9NJ471o7Wie1DQe94RVIg

![](https://i.postimg.cc/sgRncH1W/data-fazt.png)

📌 Nota: Si al darle a Get YouTube Channel ID te da error, recarga la página. 

### Código JS del proyecto  

Aquí modificamos el código, según convenga. Por comodidad, en mi HTML agregué un contenedor con la **clase** `content__show` y se ve de la siguiente manera `<div class="content__show">`, contrario a lo mostrado en clase donde agregan al contendedor de todos los elementos a llamar un **id** llamado `content` que se ve de la siguiente manera `<div id="content">`

```js
const API = 'https://youtube-v31.p.rapidapi.com/search?channelId=UCX9NJ471o7Wie1DQe94RVIg&part=snippet%2Cid&order=date&maxResults=9';

const content = document.querySelector('.content__show') || null;

const options = {
  method: 'GET',
  headers: {
    // Esta key no se debe mostrar 
    'X-RapidAPI-Key': '6c8aec95f0mshc835fd1a770d505p1250bfjsn6fdebd898161',
    'X-RapidAPI-Host': 'youtube-v31.p.rapidapi.com'
  }
};

async function fetchData(urlApi) {
  const response = await fetch(urlApi, options);
  const data = await response.json();
  return data;
}

(async () => {
  try {
    const videos = await fetchData(API);
    let view = `
      ${videos.items.map(video => `
        <a href="https://youtube.com/watch?v=${video.id.videoId}" target="_blank">
          <article class="content__video">
            <figure>
              <img src="${video.snippet.thumbnails.high.url}" alt="${video.snippet.description}" />
            </figure>
            <div>
              <p>
                ${video.snippet.title}
              </p>
            </div>
          </article>
        </a>
        `).slice(0, 4).join('')}
    `;

    content.innerHTML = view;
  } catch (e) {
    console.log(e);
    console.warn(e);
  }
})();
```

📌 Nota: Ten en cuenta que para mostrar los resultados en la web debes seguir la estructura comentada en el archivo `index.html`  código que agregamos en la clase anterior. Ver ✨`<!-- Content API-->`.  


- [Proyecto desplegado](https://aleroses.github.io/async-landing/)
- [Como evitar mostrar la Key](https://kinsta.com/knowledgebase/what-is-an-environment-variable/)
- [Paquete dotenv](https://www.npmjs.com/package/dotenv)
- [YouTube Data API](https://developers.google.com/youtube/v3?hl=es-419)
- [Modo oscuro en tu aplicación de react! 🌙](https://dev.to/franklin030601/usando-modo-oscuro-en-tu-aplicacion-de-react-m48)


## 22. Desplegando el proyecto

Para desplegar nuestro proyecto dentro de GitHub Pages debemos instalar un paquete que nos permitirá agregar todo el proyecto en una rama llamada gh-pages, permitiendo habilitar automáticamente la opción de mostrar nuestra página web, esto en lugar de hacerlo manualmente.   

```bash
// Instalación dentro de nuestro proyecto: 
npm i gh-pages

// También puedes usar..
npm install gh-pages --save-dev
```

Puedes crear un script dentro de nuestro archivo `package.json` que permita correr el comando de despliegue de manera más intuitiva o amigable. 

```json
{
  "name": "async-landing",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "scripts": {
    "deploy": "gh-pages -d public" 👈👀
  },
  "keywords": [],
  "author": "",
  "license": "ISC",
  "dependencies": {
    "gh-pages": "^5.0.0"
  }
}
```
En este caso yo estoy trabajando con una carpeta llamada public, pero puedes agregar el nombre de tu carpeta sin problemas. 

📌 Nota: Antes de hacer deploy no olvides realizar `git add .`,  `git commit -am "cambios"` y un `git push origin master`.  

Ahora, para desplegar el proyecto en GitHub Pages ejecuta el siguiente comando:  

```bash
// Si agregaste el script
npm run deploy

// Si no agregaste el script... 
npx gh-pages -d public
```

✨ Ahora si ingresas al repositorio de tu proyecto en GitHub dentro de Settings - Pages, podrás encontrar el enlace a tu web desplegada. 

### Atributo `defer`

El atributo `defer` en la etiqueta `<script>` se utiliza para indicarle al navegador que el script se debe descargar de forma asíncrona mientras se sigue procesando el resto de la página, pero se debe ejecutar solo después de que se haya cargado y procesado todo el contenido HTML.

La principal ventaja de usar `defer` es que permite que el script se ejecute después de que la estructura HTML se haya construido, pero antes de que se dispare el evento `DOMContentLoaded`. Esto significa que el script no bloqueará la renderización ni la interactividad de la página, ya que se ejecutará en segundo plano mientras los usuarios pueden interactuar con el contenido visible.

Al usar `defer`, se mantiene el orden de los scripts en el documento, lo que puede ser importante si hay dependencias entre ellos. Además, si hay varios scripts con el atributo `defer`, se ejecutarán en el orden en el que aparecen en el HTML.

Aquí tienes un ejemplo de cómo se puede utilizar el atributo `defer` en la etiqueta `<script>`:

```html
<!DOCTYPE html>
<html>
<head>
  <title>Título de la página</title>
  <script src="archivo1.js" defer></script>
  <script src="archivo2.js" defer></script> 👈👀
</head>
<body>
  <!-- Contenido de la página -->
</body>
</html>
```

También:  

```html
<!DOCTYPE html>
<html>
<head>
  <title>Título de la página</title>
</head>
<body>
  <!-- Contenido de la página -->
 
  <script src="archivo.js" defer></script> 👈👀
</body>
</html>
```

En resumen, el uso de `defer` te permite cargar y ejecutar scripts de forma asíncrona, manteniendo el orden y evitando bloquear la renderización de la página, lo que puede mejorar el rendimiento y la experiencia del usuario.


✨ Indentar hacia atrás: `Ctrl` + `?`

## 23. Playground: Crea una utilidad para hacer peticiones

En este desafío debes crear una función que usando `fetch` haga llamadas a una API y esta función debe contar las siguientes características:

- Realiza la transformación de datos a JSON
- Solo permite hacer peticiones tipo GET
- Recibir como parámetro de entrada un string que será la URL
- Validar que una URL sea correcta, si no lo es debe lanzar un error con el mensaje `Invalid URL`
- Si la URL tiene el formato correcto, pero no existe, debería lanzar un error con el mensaje `Something was wrong`

Recuerda, para lanzar el error debes usar `throw`, ejemplo:

```js
throw new Error('Something was wrong');
```

Para solucionarlo vas a encontrar una función llamada `fetchData` que recibe un parámetros de entrada:

- url: La url de la API.

Dentro del cuerpo de la función `fetchData` debes escribir tu solución.

Ejemplo 1:

```js
Input:
await fetchData('https://api.escuelajs.co/api/v1/categories');

Output
// return data in json
[...]
```

Ejemplo 2:

```js
Input:
await fetchData('----');

Output
Error: Invalid URL
```

Ejemplo 3:

```js
Input:
await fetchData('https://domain-a.com/api-1');

Output:
Error: Something was wrong
```

### Soluciones 

#### Primera posible solución:

```js
async function fetchData(url) {
  if (!url.startsWith("http://") && !url.startsWith("https://")) {
    throw new Error("Invalid URL");
  }

  const response = await fetch(url, { method: "GET" });

  if (!response.ok) {
    throw new Error("Something was wrong");
  }

  const data = await response.json();
  return data;
}

try {
  const data = await fetchData("https://api.escuelajs.co/api/v1/categories");
  console.log(data);
} catch (error) {
  console.error(error);
}
```

🔥 `.startsWith()`   
La función `startsWith()` es un método disponible en las cadenas de texto en JavaScript. Se utiliza para verificar si una cadena comienza con el texto especificado. Retorna `true` si la cadena empieza con el texto proporcionado, y `false` en caso contrario.

La sintaxis básica del método `startsWith()` es la siguiente:

```js
cadena.startsWith(texto)
```

- `cadena`: La cadena de texto en la cual se va a realizar la verificación.
- `texto`: El texto que se va a verificar si es el inicio de la cadena.

Aquí tienes un ejemplo de uso del método `startsWith()`:

```js
const cadena = "Hola, mundo";

console.log(cadena.startsWith("Hola"));
// Resultado: true

console.log(cadena.startsWith("mundo"));
// Resultado: false
```

> En el contexto de la solución proporcionada, `url.startsWith("http://")` y `url.startsWith("https://")` se utilizan para verificar si la URL comienza con "http://" o "https://". Esto se hace para asegurarse de que la URL tenga el formato correcto, ya que generalmente las direcciones web válidas comienzan con uno de estos dos protocolos.


🔥 `response.ok`   
La propiedad `ok` de un objeto de respuesta (`response`) es un valor booleano que indica si la respuesta de la solicitud HTTP se considera exitosa. Si el valor de `response.ok` es `true`, significa que la respuesta tiene un código de estado HTTP en el rango 200-299, lo que indica una respuesta exitosa. Si el valor de `response.ok` es `false`, significa que el código de estado de la respuesta no está en ese rango y se considera que la respuesta no fue exitosa.

Para verificar si una respuesta HTTP es exitosa, se debe utilizar la propiedad `ok` de la respuesta, como se muestra en el siguiente ejemplo:

```js
if (response.ok) {
  // La respuesta fue exitosa (código de estado 200-299)
  // Realizar alguna acción...
} else {
  // La respuesta no fue exitosa (código de estado fuera del rango 200-299)
  // Realizar alguna acción...
}
```


#### Segunda para PLATZI:

```js
export async function runCode(url) {
  try { // validar formato correcto url
    new URL(url);
  } catch (e) {
    throw new Error('Invalid URL');
  }
  try { // validar que exista url
    const response = await fetch(url)
    return response.json();
  } catch (e) {
    throw new Error('Something was wrong');
  }
}
```

🔥 `new URL(url);`  
`new URL(url)` es una forma de crear un objeto URL en JavaScript utilizando la clase `URL`. Esta clase proporciona métodos y propiedades para trabajar con URLs de manera más conveniente.

Cuando se crea un objeto URL utilizando `new URL(url)`, se realiza una validación de la URL proporcionada y se descompone en sus diferentes componentes, como el protocolo, el nombre de dominio, el puerto, la ruta, los parámetros de consulta, entre otros.

Aquí tienes un ejemplo de cómo se utiliza `new URL(url)`:

```js
const url = "https://www.example.com/path?param1=value1&param2=value2";
const objURL = new URL(url);

console.log(objURL.protocol);
// Resultado: "https:"

console.log(objURL.hostname);
// Resultado: "www.example.com"

console.log(objURL.pathname);
// Resultado: "/path"

console.log(objURL.search);
// Resultado: "?param1=value1&param2=value2"
```

En este ejemplo, se crea un objeto URL a partir de la cadena `url` utilizando `new URL(url)`. Luego, se pueden acceder a los diferentes componentes de la URL utilizando las propiedades del objeto URL, como `protocol`, `hostname`, `pathname` y `search`.

Esta forma de trabajar con objetos URL puede ser útil para analizar y manipular fácilmente las diferentes partes de una URL, como extraer parámetros de consulta, modificar componentes individuales o construir nuevas URLs basadas en la existente.

Es importante tener en cuenta que la clase `URL` está disponible en los navegadores modernos y en el entorno de ejecución de Node.js a partir de la versión 10. Si estás utilizando un entorno más antiguo, es posible que `URL` no esté disponible o requiera de un polyfill o una librería adicional para su uso.