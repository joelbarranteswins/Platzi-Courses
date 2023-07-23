

var frutas = new string[] {"Sandia", "Fresa", "Mango", "Mango de azúcar", "Mango Tomy"};
var mangoList = frutas.Where(fruit => fruit.StartsWith("Mango")).ToList();
mangoList.ForEach(mango => Console.WriteLine(mango));