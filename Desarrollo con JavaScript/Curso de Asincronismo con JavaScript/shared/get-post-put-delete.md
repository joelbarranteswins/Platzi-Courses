# Verbos HTTP

Se utilizan para realizar operaciones CRUD (crear, leer, actualizar y eliminar) en recursos de una API (interfaz de programación de aplicaciones).

## POST: Enviar data

```js
import fetch from "node-fetch";
const API = 'https://api.escuelajs.co/api/v1';

function postData(urlApi, data) {
	const response = fetch(urlApi, {
		method: 'POST',
		// compartición de rec. / dif. origenes
		mode: 'cors', 
		credentials: 'same-origins',
		headers: {
			'Content-type': 'application/json'
		},
		body: JSON.stringify(data)
	});
	return response;
}

const data = {
	"title": "New Product Ghost 06",
	"price": 111,
	"description": "Ghost is a dead human",
	"categoryId": 3,
	"images": ["https://placeimg.com/640/480/any"]
}

postData(`${API}/products`, data)
	.then(response => response.json())
	.then(data => console.log(data))
	.catch(err => console.log(err))
```

## PUT: Actualizar data

```js
import fetch from "node-fetch";
const API = 'https://api.escuelajs.co/api/v1';

function putData(urlApi, updateData) {
	const response = fetch(urlApi, {
		method: 'PUT',
		mode: 'cors',
		credentials: 'same-origin',
		headers: {
			'content-type': 'application/json'
		},
		body: JSON.stringify(updateData)
	});

	return response;
}

const updateData = {
	"title": "GHOST IS DEAD...",
	"price": 222
}

const id = 276

putData(`${API}/products/${id}`, updateData)
	/* .then(response => response.json())
	.then(data => console.log(data))
	.catch(err => console.log(err)) */
	.finally(() => console.log('The update is finished'));
```

## GET: Traer data

```js
import fetch from "node-fetch";
const API = 'https://api.escuelajs.co/api/v1';

function getData(urlApi) {
	return fetch(urlApi);
}

getData(`${API}/products`)
	.then(response => response.json())
	.then(data => console.log(data[-1]))
	.catch(err => console.log(err))
```

## DELETE: Eliminar data

```js
import fetch from "node-fetch";
const API = 'https://api.escuelajs.co/api/v1';

function deleteData(urlApi) {
	const response = fetch(urlApi, {
		method: 'DELETE',
		headers: {
			'content-type': 'application/json'
		}
	});

	return response;
}

const id = 277;

deleteData(`${API}/products/${id}`)
	.then(() => console.log(`Se elimino: id ${id}`))
	.catch((err) => console.log(err));
```

