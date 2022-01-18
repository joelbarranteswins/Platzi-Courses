using System;

namespace ExerciseMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es mi Programa");
            Console.WriteLine("Porfavor escribe su nombre: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Porfavor escribe su apellido: ");
            string lastname = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Porfavor escribe su DNI: ");
            string DNI = Convert.ToString(Console.ReadLine());


            Console.WriteLine("-----------------------------");
            Console.WriteLine("Resumen:");
            string CompleteName = string.Concat(name.Trim(), lastname.Trim());
            string identifier = string.Concat(DNI.Trim());
            Console.WriteLine($"Nombre y Apellido: {CompleteName}");
            Console.WriteLine($"Su DNI tiene {identifier.Length} digitos");
            Console.WriteLine($"los ultimo digitos son *****{identifier.Substring(identifier.Length - 3)}");
            Console.WriteLine("----------------------------- \nMuchas Gracias Por usar nuestro programa");

        }
    }
}
