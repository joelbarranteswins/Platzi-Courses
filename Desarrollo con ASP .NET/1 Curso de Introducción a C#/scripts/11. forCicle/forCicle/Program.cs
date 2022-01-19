using System;

namespace forCicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Te estamos saludando Joel #{0}", i);
            }  
            */
            for (int i=0 /*condicion inicial*/; i <= 15 /* limite de repeticiones*/; i = i + 5  /*increment*/)
                {
                    Console.WriteLine($"te saludamos Joel {i}");
                }
                
        }
    }
}
