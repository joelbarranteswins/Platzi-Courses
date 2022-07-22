using System;

namespace whileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            bool continueSoftwareExecution = true;
            while (continueSoftwareExecution == true)
            {
                Console.WriteLine("Do youwant to keep the software running? write 1 if it's YES, 0 if it's NO");
                int keepGoing = Convert.ToInt16(Console.ReadLine());

                if (keepGoing == 1)
                {
                    Console.WriteLine("the software continue running");
                    continueSoftwareExecution = true;
                }
                else if (keepGoing == 0)
                {
                    Console.WriteLine("this is the last time of this software");
                    continueSoftwareExecution = false;
                }
                else
                {
                    Console.WriteLine("invalid value");
                }
                    
            }
            */

            bool continueSoftwareExecution = true;
            do
            {
                Console.WriteLine("Do youwant to keep the software running? write 1 if it's YES, 0 if it's NO");
                int keepGoing = Convert.ToInt16(Console.ReadLine());

                if (keepGoing == 1)
                {
                    Console.WriteLine("the software continue running");
                    continueSoftwareExecution = true;
                }
                else if (keepGoing == 0)
                {
                    Console.WriteLine("this is the last time of this software");
                    continueSoftwareExecution = false;
                }
                else
                {
                    Console.WriteLine("invalid value");
                }

            } while (continueSoftwareExecution == true);


        }
    }
}
