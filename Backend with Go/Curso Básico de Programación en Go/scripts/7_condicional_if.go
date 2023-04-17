package main

import (
	"fmt"
	"log"
	"strconv"
)

func esPar(value int) bool {
	if module := value % 2; module == 0 {
		return true
	}
	return false
}

func getLogin(username, password string) {
	/* Esta función compara el username y el password y verificar si coincide
	   hacer login de esta manera (username y password en el código), es una muy mala práctica
	   usualmente los frameworks utilizan librerías para hacer este check
	   con passwords encriptados desde la base de datos.
	*/
	if username == "platzi" && password == "platzi" {
		fmt.Println("You are logged")
	} else {
		fmt.Println("Username or password incorrect")
	}
}

func main() {
	valor1 := 1
	valor2 := 2

	if valor1 == 1 {
		fmt.Println("Es 1")
	} else {
		fmt.Println("No es 1")
	}

	// With and
	if valor1 == 1 && valor2 == 3 {
		fmt.Println("Es verdad")
	}

	// With or
	if valor1 == 0 || valor2 == 2 {
		fmt.Println("Es verdad, OR")
	}

	// Convertir texto a número
	value, err := strconv.Atoi("53")
	if err != nil {
		log.Fatal(err)
	}
	fmt.Println("Value:", value)

	// Evaluar número par e impar
	fmt.Println(esPar(2))
	fmt.Println(esPar(3))

	// Función para hacer login
	username := "platzi"
	password := ""
	getLogin(username, password)

}
