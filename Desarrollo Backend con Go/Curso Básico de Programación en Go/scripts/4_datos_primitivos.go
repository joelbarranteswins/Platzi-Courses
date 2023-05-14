package main

import "fmt"

func main() {
	// Declaración de variables
	helloMessage := "Hello"
	worldMesssage := "world"

	// Println
	fmt.Println(helloMessage, worldMesssage)
	fmt.Println(helloMessage, worldMesssage)

	// Printf
	nombre := "Platzi"
	cursos := 500
	fmt.Printf("%s tiene más de %d cursos\n", nombre, cursos)
	fmt.Printf("%v tiene más de %v cursos\n", nombre, cursos)

	// Sprintf
	message := fmt.Sprintf("%s tiene más de %d cursos", nombre, cursos)
	fmt.Println(message)

	// Tipo datos
	fmt.Printf("helloMessage: %T\n", helloMessage)
	fmt.Printf("cursos: %T", cursos)
}
