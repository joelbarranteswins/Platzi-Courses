import fetch from 'node-fetch';

const API = 'https://api.escuelajs.co/api/v1';

async function fetchData(url_api) {
    try {
        const response = await fetch(url_api);
        const data = await response.json();
        return data;
    } catch (error) {
        console.log(error);
    }
}

const anotherFunction = async (urlApi) => {
    try {
        const data = await fetchData(`${urlApi}/products`);
        console.log(data);
        const product = await fetchData(`${urlApi}/products/${data[0].id}`);
        console.log(product.title);
        const category = await fetchData(`${urlApi}/categories/${product.category.id}`);
        console.log(category.name);
    } catch (error) {
        console.log(error);
    }
}

anotherFunction(API);