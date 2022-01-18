using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            float[] pricesArray;

            pricesArray = new float[10];
            pricesArray[0] = 1.5f;
            pricesArray[1] = 2.5f;
            pricesArray[3] = 3f;
            pricesArray[4] = 5f;

            Random rnd = new Random();
            Console.WriteLine("random numbers!");
            Console.WriteLine($"{rnd.Next(1,10)}");


            Console.WriteLine("------------------");

            string ClassTopic = "Métodos de strings";
            string School = "Platzi";
            Console.WriteLine("Estoy aprendiendo de " + ClassTopic + " en " + School + ".");

            string Schoolclone = School.Clone().ToString();
            Console.WriteLine(Schoolclone);


            Console.WriteLine("------------------");

        }
    }
}
