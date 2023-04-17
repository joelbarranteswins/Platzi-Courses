package main

import "fmt"

func main() {

	// Area cuadrado
	const baseCuadrado = 10
	areaCuadrado := baseCuadrado * baseCuadrado
	fmt.Println("Area cuadrado:", areaCuadrado)

	x := 10
	y := 50

	// Suma
	result := x + y
	fmt.Println("Suma:", result)

	// Resta
	result = y - x
	fmt.Println("Resta:", result)

	// Multiplicación
	result = x * y
	fmt.Println("Multiplicación:", result)

	// División
	result = y / x
	fmt.Println("División:", result)

	// Modulo
	result = y % x
	fmt.Println("Modulo:", result)

	// Incremental
	x++
	fmt.Println("Incremental:", x)

	// Decremental
	x--
	fmt.Println("Decremental:", x)

	// Retos
	// -Rectángulo, trapecio y de un círculo

	// Rectangle area
	const baseRectangle = 10
	const heightRectangle = 5
	areaRectangle := baseRectangle * heightRectangle
	fmt.Println("Area rectangle:", areaRectangle)

	// Trapezoid area
	const baseTrapezoid1 = 10
	const baseTrapezoid2 = 5
	const heightTrapezoid = 5
	areaTrapezoid := (baseTrapezoid1 + baseTrapezoid2) / 2 * heightTrapezoid
	fmt.Println("Area trapezoid:", areaTrapezoid)

	// Circle area
	const pi = 3.1416
	const radius = 5
	areaCircle := pi * radius * radius
	fmt.Println("Area circle:", areaCircle)
}
