package main

import (
	"fmt"
	"strings"
)

func isPalindromo(text string) {
	var textReverse string

	// Convert text to lower
	text = strings.ToLower(text)

	for i := len(text) - 1; i >= 0; i-- {
		textReverse += string(text[i])
	}

	if text == textReverse {
		fmt.Println("Es palindromo")
	} else {
		fmt.Println("No es un palíndromo")
	}
}

func main() {
	slice := []string{"hola", "que", "hace"}
	for _, value := range slice {
		fmt.Println(value)
	}

	for i := range slice {
		fmt.Println(i)
	}
	// ama
	// amor a roma

	isPalindromo("Ama")
}
