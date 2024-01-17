
function* iterate(array) {
    for (let value of array) {
        yield value;
    }
}

const iterable = iterate([1, 2, 3, 4, 5]);

console.log(iterable.next().value);
console.log(iterable.next().value);
console.log(iterable.next().value);
console.log(iterable.next().value);
console.log(iterable.next().value);
console.log(iterable.next().value);