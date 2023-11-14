const prompt = require('prompt-sync')();

do {
  var userAnswer = prompt("Please, how much is 2 + 2: ");
} while (+userAnswer !== 4);
console.log("felicitaciones")
