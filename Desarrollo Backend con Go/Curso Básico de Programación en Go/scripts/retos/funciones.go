package main

import (
	"fmt"
	"math"
)

func getRectangleArea(width float64, height float64) float64 {
	return width * height
}

func getTrapezoidArea(base1 float64, base2 float64, height float64) float64 {
	return (base1 + base2) / 2 * height
}

func getCircleArea(radius float64) float64 {
	const pi = 3.1416
	return pi * math.Pow(radius, 2)
}

func main() {
	// Rectangle area
	const widthRectangle = 10.0
	const heightRectangle = 5.0
	areaRectangle := getRectangleArea(widthRectangle, heightRectangle)
	fmt.Println("Area rectangle:", areaRectangle)

	// Trapezoid area
	const baseTrapezoid1 = 10.0
	const baseTrapezoid2 = 5.0
	const heightTrapezoid = 5.0
	areaTrapezoid := getTrapezoidArea(baseTrapezoid1, baseTrapezoid2, heightTrapezoid)
	fmt.Println("Area trapezoid:", areaTrapezoid)

	// Circle area
	const radiusCircle = 5.0
	areaCircle := getCircleArea(radiusCircle)
	fmt.Println("Area circle:", areaCircle)
}
