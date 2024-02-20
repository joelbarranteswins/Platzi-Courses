const fnAsync = () => {
  return new Promise((resolve, reject) => {
    (true)
    ? setTimeout(() => resolve('Async Hello World'), 2000)
    : reject(new Error('Test Error'))
  });
}

const anotherFn = async () => {
    try {
        const something = await fnAsync();
        console.log(something);
        console.log('This is an async function');
    } catch (error) {
        console.error(error);
    }
}

console.log('Before');
anotherFn();
console.log('After');