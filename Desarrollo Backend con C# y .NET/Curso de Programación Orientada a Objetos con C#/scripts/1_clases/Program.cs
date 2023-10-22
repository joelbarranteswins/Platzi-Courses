// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Television tv = new Television();
tv.Brand = "Samsung";
tv.Color = "negro";

Console.WriteLine($"Brand: {tv.Brand}, Color: {tv.Color}");

class Television{
  public string Color;
  public double Width;
  public double Height;
  public int Buttom;
  public string Brand;
  public bool Status;
}

