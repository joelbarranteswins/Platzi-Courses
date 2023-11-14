// Un objeto es una colección de propiedades, y una propiedad es una asociación de key (nombre, o clave) y valores.

var objecto = {}; // Object Literal Syntax 

var miAuto = {
    marca: "Toyota",  // key - value 
    modelo: "Corolla",
    annio: 2020,
    detallesDelAuto: function() {   // Metodo de un objeto (una función dentro de un objeto)
      return `Auto ${this.modelo} ${this.annio}`;
  }
};

console.log(miAuto)

console.log(miAuto.annio) 
console.log(miAuto.modelo) 

console.log(miAuto.detallesDelAuto()) 




// Función constructora 

function auto(marca, modelo, annio) {  // Creas una función con los parametros que va a recibir, 
    this.marca = marca;   // Utilizamos el "this" para asignar valores a las propiedades del objeto 
    this.modelo = modelo;
    this.annio = annio;
    this.detalle = function () {
        console.log(`Auto ${this.modelo} del ${this.año}.`)
    }
}

var newAuto = new auto("Tesla", "Model 3", 2020);
console.log(newAuto)