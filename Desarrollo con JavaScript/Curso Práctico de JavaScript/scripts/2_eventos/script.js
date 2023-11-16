const h1 = document.querySelector('h1');
const form = document.querySelector('#form');
const input1 = document.querySelector('#calculo1');
const input2 = document.querySelector('#calculo2');
const btn = document.querySelector('#btnCalcular');
const pResult = document.querySelector('#result');

// btn.addEventListener('click', btnOnClick);
// form.addEventListener('submit', btnOnClick);

// function btnOnClick(event) {
//     console.log('escuchando el evento');
//     event.preventDefault();
//     const valor1 = input1.value;
//     const valor2 = input2.value;
//     const resultado = Number(valor1) + Number(valor2);
//     console.log(resultado);
//     pResult.innerText = "Resultado: " + resultado;
// }


btn.addEventListener('click', btnOnClick);

function btnOnClick(event) {
    console.log('escuchando el evento');
    const valor1 = input1.value;
    const valor2 = input2.value;
    const resultado = Number(valor1) + Number(valor2);
    console.log(resultado);
    pResult.innerText = "Resultado: " + resultado;
}