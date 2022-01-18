// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<string> tacoShoppingList = new List<string>();
tacoShoppingList.Add("cinco Tacos de suadero");
tacoShoppingList.Add("cuatro tacos de tripa");
tacoShoppingList.Add("cinco tacos de pastor");
tacoShoppingList.Add("Cuatro coca colas");

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}

Console.WriteLine("-----------------------");

//tacoShoppingList.Remove("cinco Tacos de suadero"); //delete a value by name
tacoShoppingList.RemoveAt(0); //delete a value by index

for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine(tacoShoppingList[i]);
}