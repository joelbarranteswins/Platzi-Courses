var lastName = 'david';

lastName = 'Oscar';
console.log(lastName);

let fruit = 'apple';
fruit = 'banana';
console.log(fruit);

const animal = 'dog';
// animal = 'cat';
console.log(animal);

const fruits = () => {
    if (true) {
        var fruit1 = 'apple'; // function scope
        let fruit2 = 'banana'; // block scope
        const fruit3 = 'kiwi'; // block scope
    }
    console.log(fruit1);
    console.log(fruit2);
    console.log(fruit3);
}

fruits();