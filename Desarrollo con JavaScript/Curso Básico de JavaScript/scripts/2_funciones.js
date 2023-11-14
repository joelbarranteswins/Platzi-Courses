
// Las funciones 

// Declarativas
function miFuncion() {  
    return 3; 
}

miFuncion(); 


// Expresiva (también conocidas como funciones anónimas)
var miFuncion = function(a,b) {  
    return a + b;
}

miFuncion(); 



function saludarEstudiante(estudiante) {
    console.log(`Hola ${estudiante}`);  // template strings (Plantillas de cadena de texto)
}



function suma(a,b) {
    var resultado =  a + b; 
    return resultado;
}

function suma(a,b) {
    return a + b; 
}

suma(20, 30); 