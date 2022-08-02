using System;

namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anyValue = 9;
            string message = "";

            if (anyValue == 7)
            {
                message = " value is different to 7";
                Console.WriteLine($"the answer: {message}");
            }
            else if (anyValue == 9)
            {
                message = " value is 9";
                Console.WriteLine($"the answer: {message}");
            }
            else
            {
                message = " value is not number";
                Console.WriteLine($"the answer: {message}");
            }
            Console.WriteLine("-------------------------------");
            
        }
    }
}
