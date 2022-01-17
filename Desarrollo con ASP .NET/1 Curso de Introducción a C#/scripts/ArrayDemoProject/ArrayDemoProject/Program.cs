// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] coffeeTypes;
float[] coffeeValues;

coffeeTypes = new string[] {"Expresso", "Largo", "Filtrado", "latte"}; //4 elementos
coffeeValues = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };

coffeeTypes[1] = "Lungo"; //modifica la posicion 1 del array

for(int i = 0; i < 4; i++)
    Console.WriteLine($"{coffeeTypes[i]} cuesta {coffeeValues[i]}");

Console.WriteLine("-------------------------------");


for (int i = 0; i < coffeeTypes.Length; i++)
    Console.WriteLine($"{coffeeTypes[i]} cuesta {coffeeValues[i]} USD");

