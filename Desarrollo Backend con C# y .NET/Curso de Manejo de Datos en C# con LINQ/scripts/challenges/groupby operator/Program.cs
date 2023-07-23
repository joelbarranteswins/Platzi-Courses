// See https://aka.ms/new-console-template for more information

List<Animal> animales = new()
{
    new Animal() { Nombre = "Hormiga", Color = "Rojo" },
    new Animal() { Nombre = "Lobo", Color = "Gris" },
    new Animal() { Nombre = "Elefante", Color = "Gris" },
    new Animal() { Nombre = "Pantegra", Color = "Negro" },
    new Animal() { Nombre = "Gato", Color = "Negro" },
    new Animal() { Nombre = "Iguana", Color = "Verde" },
    new Animal() { Nombre = "Sapo", Color = "Verde" },
    new Animal() { Nombre = "Camaleon", Color = "Verde" },
    new Animal() { Nombre = "Gallina", Color = "Blanco" }
};

// Escribe tu código aquí
// Retorna los datos de la colleción Animales agrupada por color
var AnimalsGroupByColor = from animal in animales
                        orderby animal.Color, animal.Nombre
                        group animal by animal.Color;

foreach(var group in AnimalsGroupByColor)
{
    Console.WriteLine("");
    Console.WriteLine($"Grupo: { group.Key }");
    Console.WriteLine("{0,-60} {1, 15}\n", "Nombre", "Color");
    foreach(var item in group)
    {
        Console.WriteLine("{0,-60} {1, 15}", item.Nombre, item.Color); 
    }
}

  

  public class Animal
  {
    public string? Nombre {get;set;}
    public string? Color {get;set;}
  }