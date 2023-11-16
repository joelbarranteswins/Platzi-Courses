const h1 = document.querySelector('h1');
const p = document.querySelectorAll('p');
const parrafito = document.querySelector('.parrafito');
const pid = document.getElementById('pid');
const input = document.querySelector('input');

console.log(input.value);
console.log({ h1, p, parrafito, pid, input });

h1.innerHTML = 'Hola desde JS <br> !';
h1.innerText = 'Hola desde JS <br> !';
console.log(h1.getAttribute('class'));
// h1.setAttribute('class', 'rojo');

h1.classList.add('rojo');
console.log(h1.getAttribute('class'));

h1.classList.remove('rojo');
console.log(h1.getAttribute('class')); 
h1.classList.toggle('verde');
console.log(h1.getAttribute('class'));

input.value = 'Hola desde JS';

const img = document.createElement('img');
console.log(img);
img.setAttribute('src', 'https://images.pexels.com/photos/1181263/pexels-photo-1181263.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1');
console.log(img);
//modify width and height
img.style.width = '200px';
img.style.height = '200px';

pid.innerHTML = '';
pid.appendChild(img);