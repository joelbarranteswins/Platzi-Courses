using Humanizer;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class StringOperations
    {
        private readonly ILogger _logger;
        public StringOperations() {
        }

        public StringOperations(ILogger<StringOperations> logger)
        {
            _logger = logger;
        }

        public string ConcatenateStrings(string str1, string str2)
        {
            return str1 + " " + str2;
        }

        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int GetStringLength(string? str)
        {
            if(str is null)
            {
                throw new ArgumentNullException();
            }

            return str.Length;
        }

        public string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        public string TruncateString(string input, int maxLength)
        {
            if(maxLength <=0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (string.IsNullOrEmpty(input) || maxLength >= input.Length)
            {
                return input;
            }

            return input.Substring(0, maxLength);
        }

        public bool IsPalindrome(string input)
        {
            string reversed = ReverseString(input);
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public int CountOccurrences(string input, char character)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == character)
                {
                    count++;
                }
            }

            _logger.LogInformation($"Number of concurrecies is:{count}");
            return count;
        }

        public string Pluralize(string input)
        {
            return input.Pluralize();
        }

        public string QuantintyInWords(string input, int quantity)
        {
            return input.ToQuantity(quantity, ShowQuantityAs.Words);
        }

        public int FromRomanToNumber(string input)
        {
            return input.FromRoman();
        }

        public string ReadFile(IFileReaderConector fileReader, string fileName)
        {
            return fileReader.ReadString(fileName);
        }

    }
}
