// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number1;
int number2;

Console.WriteLine("Input the first number: ");
//convert a value into a number of 32 bits
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number: ");
number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 + number2;
Console.WriteLine("the result is: " + result);

