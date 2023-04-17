package main

import "fmt"

func main() {

	// For condicinal
	for i := 0; i < 10; i++ {
		fmt.Println(i)
	}

	fmt.Println("/n")

	for i := 10; i > 0; i-- {
		fmt.Println(i)
	}

	fmt.Println("/n")

	// For while
	counter := 0
	for counter < 10 {
		fmt.Println(counter)
		counter++
	}

	fmt.Println("/n")

	// For range of list
	lista := []string{"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"}
	for i, letra := range lista {
		fmt.Printf("posicion %d letra: %s \n", i, letra)
	}

	fmt.Println("/n")

	listaNumerosPares := []float64{2, 4, 6, 8, 10, 12, 14, 16, 18, 20}
	for i, numero := range listaNumerosPares {
		fmt.Printf("posicion %d numero: %f \n", i, numero)
	}

	fmt.Println("/n")

	//For forever
	// counterForever := 0
	// for {
	// 	fmt.Println(counterForever)
	// 	counterForever++
	// }

	// fmt.Println("-------------For con goto tags-------------")
	var i int
CICLO:
	fmt.Println("estamos fuera del for")
	for i < 10 {
		if i == 6 {
			i = i + 3
			fmt.Println("Saltando a etiqueta CICLO con i = i + 3")
			goto CICLO2
		}
		fmt.Printf("Valor de i: %d\n", i)
		i++
	}
CICLO2:
	fmt.Printf("ciclo 2 Valor de i: %d\n", i)
	if i == 9 {
		fmt.Printf("Valor de i: %d\n", i)
		i = i + 3
		fmt.Println("Saltando a etiqueta CICLO con i = i + 3")
		goto CICLO
	}
	fmt.Printf("terminamos\n")

}
