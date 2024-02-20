import fetch from 'node-fetch';

const API = 'https://api.escuelajs.co/api/v1';

function deleteData(urlApi) {
    const response = fetch(urlApi, {
        method: 'DELETE',
        mode: 'cors',
        credentials: 'same-origin',
        headers: {
            'Content-Type': 'application/json',
        }
    });
    return response;
}

deleteData(`${API}/products/127`)
    .then(response => response.json())
    .then(data => {
        console.log(data)
    })
    .catch(error => console.log(error))
    .finally(() => {
        console.log('Finally!');
    })