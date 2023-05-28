
// create a list of options
var options = ["piedra", "papel", "tijera"];

function game_if(value){
    // chose a value from option array
    var machine_choice = options[Math.floor(Math.random() * options.length)];
    
    console.log("Tu elegiste " + value);
    console.log("La máquina eligió " + machine_choice);
    if (value == machine_choice){
        console.log("Empate");
    } else if (value == "piedra" && machine_choice == "tijera"){
        console.log("Ganaste");
    } else if (value == "papel" && machine_choice == "piedra"){
        console.log("Ganaste");
    }   else if (value == "tijera" && machine_choice == "papel"){
        console.log("Ganaste");
    } else {
        console.log("Eligiste una opción inválida");
    }
}


function game_switch(value){
    var machine_choice = options[Math.floor(Math.random() * options.length)];
    
    console.log("Tu elegiste " + value);
    console.log("La máquina eligió " + machine_choice);

    switch (value) {
        case machine_choice:
            console.log("Empate");
            break;
        case "piedra":
            if (machine_choice == "tijera"){
                console.log("Ganaste");
            }
            else {
                console.log("Perdiste");
            }
            break;  
        case "papel":
            if (machine_choice == "piedra"){
                console.log("Ganaste");
            }
            else {
                console.log("Perdiste");
            }
            break;
        case "tijera":
            if (machine_choice == "papel"){
                console.log("Ganaste");
            }
            else {
                console.log("Perdiste");
            }
            break;
        default:
            console.log("Eligiste una opción inválida");
            break;
        }
}

game_switch("piedra");