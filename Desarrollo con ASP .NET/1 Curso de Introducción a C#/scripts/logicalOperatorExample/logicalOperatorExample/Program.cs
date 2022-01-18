// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool value1 = true;
bool value2 = true;
bool value3 = false;

// && = and, || = or, ! = different

bool result = value1 && value2;
Console.WriteLine($"the result of the logical (true AND true) is: {result}");

bool result1 = value2 && value3;
Console.WriteLine($"the result of the logical (true AND false)is: {result1}");

bool result2 = value1 || value2;
Console.WriteLine($"the result of the logical (true OR true) is: {result2}");

bool result3 = value2 || value3;
Console.WriteLine($"the result of the logical (true OR false) is: {result3}");

bool result4 = !value1;
Console.WriteLine($"the result of the logical (! true) is: {result4}");



int number1 = 1;
int number2 = 18;
int number3 = -18;

//using operator ==
bool result0 = number1 == number2;
Console.WriteLine($"operator {number1} == {number2} \nresult: {result0}");

bool result5 = number1 != number2;
Console.WriteLine($"operator {number1}!={number2} \nresult: {result5}");

bool result6 = number1 > number2;
Console.WriteLine($"operator {number1}>{number2} \nresult: {result6}");

bool result7 = number1 < number2;
Console.WriteLine($"operator {number1}<{number2} \nresult: {result7}");

bool result8 = number1 >= number2;
Console.WriteLine($"operator {number1}>={number2} \nresult: {result8}");

bool result9 = number1 <= number2;
Console.WriteLine($"operator {number1}<={number2} \nresult: {result9}");

