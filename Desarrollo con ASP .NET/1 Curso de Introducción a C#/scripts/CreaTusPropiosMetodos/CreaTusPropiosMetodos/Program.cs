using System;

namespace CreaTusPropiosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethods MyProgram = new MyMethods();

            int result = MyProgram.IntegerAddition(3, 6);
            Console.WriteLine("el resultado es " + result);

            int result2 = MyProgram.IntegerMultiplication(3, 6);
            Console.WriteLine($"el resultado es {result2}");

            //llamando metodos de otra clase

            Methods MyProgram2 = new Methods();

            int Result3 = MyProgram2.Sum(2,17);
            Console.WriteLine(Result3);

            int Result4 = MyProgram2.Sustraction(4, -8);
            Console.WriteLine(Result4);

            float Result5 = MyProgram2.Division(4, 3);
            Console.WriteLine(Result5);


        }
    }

    public class MyMethods
    {
        public int IntegerAddition(int a, int b)
        {
            int Addition = a + b;
            return Addition;
        }

        public int IntegerMultiplication(int a, int b)
        {
            int multiplication = a * b;
            return multiplication;
        }
    }

    
}
