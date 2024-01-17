// arrays destructuring

let fruits = ['apple', 'orange', 'banana'];

let [a, b, c] = fruits;

console.log(a, b, c);

console.log(fruits[0], fruits[1], fruits[2]);

// objects destructuring

let user = {
    name: 'Ricardo',
    age: 23
    };

let { name, age} = user;

console.log(name, age);

// spread operator

let person = {
    name: 'Ricardo',
    age: 23,
    country: 'MX'
    };

let country = 'MX';

let data = {...person, country};

console.log(data);


// rest operator

function sum(num, ...values) {
    console.log(values);
    console.log(num + values[0])
    return num + values[0];
}

sum(1, 2, 3, 4, 5, 6)