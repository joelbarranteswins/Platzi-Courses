import fetch from 'node-fetch';

const API = 'https://api.escuelajs.co/api/v1';

function updateData(urlApi, data) {
    const response = fetch(urlApi, {
        method: 'PUT',
        mode: 'cors',
        credentials: 'same-origin',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
    });
    return response;
}

const data = {
    "title": "127",
    "price": 127,
    "description": "This is a description",
    "categoryId": 1,
    "images": [
        "http://placeimg.com/640/480/any",
    ]
}


updateData(`${API}/products/127`, data)
    .then(response => response.json())
    .then(data => {
        console.log(data)
    })