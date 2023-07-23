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
// Retorna los elementos de la colleción animal ordenados por nombre
List<Animal> animalsSortedByName = (from animal in animales orderby animal.Nombre select animal).ToList();

foreach (var animal in animalsSortedByName)
{
    Console.WriteLine($"Nombre: {animal.Nombre} - Color:{animal.Color}");
}

  

  public class Animal
  {
    public string? Nombre {get;set;}
    public string? Color {get;set;}
  }