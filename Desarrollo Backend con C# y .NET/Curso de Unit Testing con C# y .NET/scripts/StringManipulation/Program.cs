
using Microsoft.Extensions.Logging;
using StringManipulation;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
internal class Program
{
    private static void Main(string[] args)
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            // Add console logger
            builder.AddConsole();
        });

        // Create a logger
        var logger = loggerFactory.CreateLogger<StringOperations>();


        while (true)
        {
            Console.WriteLine("Select the action");
            Console.WriteLine("1. contact 2 strings");
            Console.WriteLine("2. reverse string");
            Console.WriteLine("3. string length");
            Console.WriteLine("4. remove white spaces");
            Console.WriteLine("5. truncate string");
            Console.WriteLine("6. check if the word is palindrome");
            Console.WriteLine("7. count character concurrency");
            Console.WriteLine("8. plularize a word");
            Console.WriteLine("9. express a quantity in words");
            Console.WriteLine("10. convert from roman to number");
            Console.WriteLine("11. read text file");

            int optionSelected = int.Parse(Console.ReadLine());

            StringOperations stringOperations = new StringOperations(logger);

            switch (optionSelected)
            {
                case 1:
                    Console.WriteLine("write a string 1");
                    string input = Console.ReadLine();

                    Console.WriteLine("write a string 2");
                    string input2 = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.ConcatenateStrings(input, input2));
                    break;
                case 2:
                    Console.WriteLine("write a string");
                    string inputToReverse = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.ReverseString(inputToReverse));
                    break;
                case 3:
                    Console.WriteLine("write a string");
                    string inputLength = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.GetStringLength(inputLength));
                    break;
                case 4:
                    Console.WriteLine("write a string");
                    string inputWhiteSpaces = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.RemoveWhitespace(inputWhiteSpaces));
                    break;
                case 5:
                    Console.WriteLine("write a string");
                    string inputTruncate = Console.ReadLine();

                    Console.WriteLine("set max lenght");
                    int maxLenght = int.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.TruncateString(inputTruncate, maxLenght));
                    break;
                case 6:
                    Console.WriteLine("write a string");
                    string inputPalandrime = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.IsPalindrome(inputPalandrime));
                    break;
                case 7:
                    Console.WriteLine("write a string");
                    string inputConcurrency = Console.ReadLine();

                    Console.WriteLine("write a character");
                    char charToFind = char.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.CountOccurrences(inputConcurrency, charToFind));
                    break;
                case 8:
                    Console.WriteLine("write a string");
                    string inputToPluralize = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.Pluralize(inputToPluralize));
                    break;
                case 9:
                    Console.WriteLine("write a word");
                    string word = Console.ReadLine();

                    Console.WriteLine("write quantity");
                    int quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.QuantintyInWords(word, quantity));
                    break;
                case 10:
                    Console.WriteLine("write a roman number");
                    string romanNumber = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine(stringOperations.FromRomanToNumber(romanNumber));
                    break;
                case 11:
                    Console.WriteLine("");
                    IFileReaderConector fileReader = new FileReaderConector();
                    Console.WriteLine(stringOperations.ReadFile(fileReader, "information.txt"));
                    break;
                default:
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("///");

        }
    }
}