const promise = new Promise(function(resolve, reject) {
  resolve('hey!')
});

const cows = 5;

const countCows = new Promise(function(resolve, reject) {
    if (cows > 10) {
        resolve('You have a lot of cows!');
    } else {
        reject('You have a few cows!');
    }
});


countCows.then((result) => {
    console.log(result);
}).catch((error) => {
    console.log(error);
}).finally(() => {
    console.log('I am done!');
});