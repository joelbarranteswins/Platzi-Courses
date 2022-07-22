using System;

namespace StringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name? write your full name");
            string fullUserName = Console.ReadLine();

            Console.WriteLine("hello" + fullUserName + "Welcome to platzi");
        }
    }
}
