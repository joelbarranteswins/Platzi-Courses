





## FRAMEWORK VS LIBRERÍA

**Framework:** Será la base sobre la cual podras construir y desarrollar tu proyecto, incluye todas las herramientas necesarias para completarlo (incluye librerías, estándares y reglas).

* tienen reglas, un estructura, resuelve un problema grande

**Librería:** Solo aborda una utilidad especifica, pudiendo agregar más de una en tu proyecto. Eso si, asegurate que no interfieran con el código de otra librería.

* no tiene reglas, puedes implementarlo a tu gusto, resuelve un problema especifico.


Recuerda: Ninguno es mejor que el otro, todo va a depender de la necesidad de tu proyecto

## Cómo se conecta el frontend con el backend: API y JSON

La unión entre el Frontend y el Backend se hace a través de una API: Application Programming Interface.

Una API es una sección del backend que permite que el frontend pueda comunicarse con él a través de mensajes bidireccionales (de ida y vuelta).

Tenemos dos grandes estándares para crear las APIs:

* **SOAP (Simple Objetct Access Protocol):**Mueve la información a través de un lenguaje XML (Extensible Markup Language). Es similar al HTML, es un lenguaje demarcado. SOAP es un protocolo que ha quedado en el olvido.

~~~XML
<?xml version="1.0"?>
<note>
	<to>Miguel</to>
	<from>Facundo</from>
	<heading>Recordatorio</heading>
	<body>No olvides publicar el curso!</body>
</note>
~~~

* **Rest (Representational State Transfer):** Utiliza otro lenguaje JSON (Javascript Objet Notation). Un JSON no es más que un diccionario de Python. Los diccionarios de Python son lo mismo que los objetos de JS.

<img src="./img/JSON.webp">


## El lenguaje que habla Internet: HTTP

HTTP: Hypertext Transfer Protocol

peticion y respuesta en HTTP:

<img src="./img/request.jpg">

**Request (petición) y Response (respuesta).**

Un request tiene headers (cabeceras)

Existen distintos métodos para una request, GET, DELETE, POST, etc.

Aquí un ejemplo Request HTTP:

<img src="./img/http_request.png">

A esto se responde con un Response, aquí dejo un ejemplo:

<img src="./img/http_response.png">

status code de HTTP (codigo de respuesta), respuestas:

<img src="./img/http_message.png">

### **la web:**

Para complementar el aporte 😀:

HTTP nos permite transportar la información que viene de distintas formas: HTML, CSS,JS, webAPIs.

En la capa capa inferior se vale de protocolos como

* **IP (internet Protocol):** para identificar y comunicarse con el servidor

* **TCP**  Son las siglas de Transmission Control Protocol, es un conjunto de reglas estandarizadas que permiten a los equipos comunicarse en una red como Internet.

* **TLS** Transport Layer Security, seguridad de la capa de transporte es el protocolo sucesor de SSL. Son protocolos criptográficos, que proporcionan comunicaciones seguras por una red, comúnmente Internet.​

* **DNS** El sistema de nombres de dominio (DNS) es el directorio telefónico de Internet. Las personas acceden a la información en línea a través de nombres de dominio

* **UDP** El Protocolo de datagrama de usuario (UDP) es un protocolo ligero de transporte de datos que funciona sobre IP. UDP proporciona un mecanismo para detectar datos corruptos en paquetes, pero no intenta resolver otros problemas que surgen con paquetes, como cuando se pierden o llegan fuera de orden.