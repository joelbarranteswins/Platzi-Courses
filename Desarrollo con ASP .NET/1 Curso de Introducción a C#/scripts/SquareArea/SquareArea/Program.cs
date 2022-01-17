// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//RECTANGLE CALCULATION


//values
Console.WriteLine("Enter the first and second value");
float sideA = float.Parse(Console.ReadLine());
float sideB = float.Parse(Console.ReadLine());
sideB++; //aumenta el valor en 1
sideB--; //recude el valor en 1


//formula
float area = sideA * sideB;

Console.WriteLine($"the result is: {area}");