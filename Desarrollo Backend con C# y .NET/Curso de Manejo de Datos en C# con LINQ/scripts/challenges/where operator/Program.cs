using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    List<Animal> animales = new List<Animal>();
    animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
    animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
    animales.Add(new Animal() { Nombre = "", Color = "" });
    animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
    animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
    animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
    animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
    animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
    animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

    // Escribe tu código aquí
    // filtra todos los animales que sean de color verde que su nombre inicie con una vocal
    animales = (from animal in animales 
                where animal.Color == "Verde" && "AEIOUaeiou".Contains(animal.Nombre[0])
                select animal).ToList();

    foreach (var animal in animales)
    {
        Console.WriteLine($"Nombre: {animal.Nombre}, Color: {animal.Color}");
    }
  }

  public class Animal
  {
    public string Nombre {get;set;}
    public string Color {get;set;}
  }
}