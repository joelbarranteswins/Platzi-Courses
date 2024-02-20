# Crear proyectos usando API's

En JavaScript, los términos "fetch", "async-await" y "try-catch" tienen relación con el manejo de solicitudes y respuestas a través de la red, mientras que el archivo JSON es un formato de datos comúnmente utilizado para el intercambio de información a través de la red.

1. "fetch": es un método nativo de JavaScript que permite realizar solicitudes HTTP asincrónicas (AJAX) a servidores web y recibir respuestas en formato JSON, texto, blob, entre otros. El método "fetch" devuelve una promesa que puede ser resuelta para obtener la respuesta del servidor.

2. "async-await": es una sintaxis para manejar promesas en JavaScript. Permite que las funciones asincrónicas se escriban de una manera más sencilla y legible, sin tener que encadenar múltiples callbacks. La palabra clave "async" se utiliza para definir una función asincrónica, mientras que "await" se usa para esperar a que una promesa se resuelva antes de continuar con la ejecución.

3. "try-catch": es un bloque de código utilizado para manejar errores en JavaScript. El bloque "try" contiene el código que se ejecutará y el bloque "catch" se ejecuta si hay alguna excepción lanzada en el bloque "try". El bloque "catch" permite manejar el error y tomar medidas para corregirlo o recuperarse de él.

4. Archivo JSON: es un formato de datos utilizado para el intercambio de información a través de la red. La sintaxis de JSON es similar a la sintaxis de los objetos JavaScript, lo que lo hace fácil de leer y escribir. Los archivos JSON se utilizan comúnmente para enviar y recibir datos entre servidores y clientes web en aplicaciones basadas en AJAX. En JavaScript, los archivos JSON se pueden leer y manipular utilizando el método "fetch" para obtener los datos del servidor y los métodos "JSON.parse" y "JSON.stringify" para analizar y convertir los datos a objetos JavaScript.


## Rick and Morty 

Creamos un archivo `index.html` con esta estructura:  

```js
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Rick and Morty</title>
  </head>
  <body>
    <div id="characters"></div>
    <script src="./main.js"></script>
  </body>
</html>
```

Agregamos este código para ver las imágenes y nombres en la web. Usaremos una [API de Rick and Morty](https://rickandmortyapi.com/):   

```js
/* 
🔥 No Hace falta usar import fetch...
import fetch from "node-fetch"; 
*/
const API = 'https://rickandmortyapi.com/api/character';
let characters = document.querySelector('#characters');

fetch(API)
	.then(response => response.json())
	.then(data => {
		console.log(data.results)

		data.results.map((item) => {
			const content = document.createElement("div");
			content.innerHTML =
				`
			<h4>${item.name}</h4>
			<img src="${item.image}">
			`;
			characters.append(content)
		})
	});
```

🔥 No Hace falta usar `import fetch`, ni instalar el módulo desde consola. 

![Resultado](https://i.postimg.cc/nrdwS7c5/rick-morty.png)


## NASA 

Para hacer uso de la [API de la NASA](https://api.nasa.gov/), debemos registrarnos y luego entramos a APOD. 

> https://api.nasa.gov/planetary/apod
> PNmL8OBHZyiJFCAeRyGdL5qxemQSmOCGln
> https://api.nasa.gov/planetary/apod?api_key=PNmL8OBHZyiJFCAeRyGdL5qxemQSmOCGln

`index.html`  

```html
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>NASA</title>
  </head>
  <body>
    <div id="infoNasa"></div>
    <script src="./main.js"></script>
  </body>
</html>
```
`main.js`  
```js
let infoNasa = document.querySelector("#infoNasa");
const API = 'https://api.nasa.gov/planetary/apod?api_key=PNmL8OBHZyiJFCAeRyGdL5qxemQSmOCGlni';

const fetchNasa = async () => {
	try {
		const response = await fetch(API);
		const data = await response.json();
		console.log(data);

		const spaceInfo = document.createElement('div');
		spaceInfo.innerHTML = `
		<img src="${data.url}"/>
		<h4>${data.title}</h4>
		<p>${data.explanation}</p>		
		`;

		infoNasa.append(spaceInfo);
	} catch (err) {
		console.log(err);
	}
};

fetchNasa();
```



## Star Wars 

🔥 Debes crear un archivo `data.json` y agregar datos que puedes obtener con los enlaces del párrafo siguiente. 

Revisa [swapi.dev](https://swapi.dev/), puedes obtener más datos desde la [Api Root](https://swapi.dev/api/), aunque esto no tiene imágenes, por eso decidí usar esto [starwars-api](https://github.com/akabab/starwars-api). Aquí están los datos que agregué [Characters](https://akabab.github.io/starwars-api/api/all.json)


`index.html`
```html
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Star Wars</title>
  </head>
  <body>
	<div id="star-wars"></div>
    <script src="./main.js"></script>
  </body>
</html>
```
`main.js`
```js
let starwars = document.querySelector('#star-wars');

fetch('./data.json')
	.then(response => response.json())
	.then(data => {
		console.log(data)
		data.map(item => {
			const content = document.createElement('div');
			content.innerHTML = `
				<h4>${item.name}</h4>
				<img src="${item.image}" width="50%" height="50%">
			`;

			starwars.append(content);
		})
	});
```

[🔥 Como utilizar fetch, async-await, try-catch + archivo json](https://www.youtube.com/watch?v=z5C-NB9Nexc)