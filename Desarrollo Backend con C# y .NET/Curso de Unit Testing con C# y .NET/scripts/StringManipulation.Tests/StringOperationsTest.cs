using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact(Skip = "Esta prueba no es valida")]
        public void ConcatenateStrings()
        {
            //Arrange
            var strOperation = new StringOperations();
            
            //act
            var result = strOperation.ConcatenateStrings("Hello", "Platzi");
            
            //Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello Platzi", result);
        }

        [Fact]
        public void ReverseStrin()
        {
            var strOperation = new StringOperations();
            string result = strOperation.ReverseString("platzi");
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("iztalp", result);
        }


        [Fact]
        public void IsPalindrome_True()
        {
            //Arrange
            var strOperation = new StringOperations();

            //act
            bool result = strOperation.IsPalindrome("ana");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            //Arrange
            var strOperation = new StringOperations();

            //Act
            bool result = strOperation.IsPalindrome("platzi");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            var strOperation = new StringOperations();
            string result = strOperation.RemoveWhitespace(" platzi ");
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("platzi", result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            //Arrange
            var strOperation = new StringOperations();
            //Act
            var result = strOperation.QuantintyInWords("cat", 10);
            //Assert
            Assert.StartsWith("diez", result);
            Assert.Contains("cat", result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            var strOperation = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(() => strOperation.GetStringLength(null));
        }

        [Fact]
        public void TruncateString_Exception()
        {
            var strOperation = new StringOperations();

            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => strOperation.TruncateString("platzi", 0));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("XX", 20)]
        [InlineData("L", 50)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var strOperation = new StringOperations();

            int result = strOperation.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountOccurrences()
        {
            var mockLogger = new Mock<ILogger<StringOperations>>();

            var strOperation = new StringOperations(mockLogger.Object);

            var result = strOperation.CountOccurrences("Hello platzi", 'l');

            Assert.Equal(3, result);
        }

        [Fact]
        public void ReadFile()
        {
            var strOperation = new StringOperations();

            var mockFileReader = new Mock<IFileReaderConector>();
            //mockFileReader.Setup(p => p.ReadString("file.txt")).Returns("Reading file");
            mockFileReader.Setup(p => p.ReadString(It.IsAny<string>())).Returns("Reading file");
            var result = strOperation.ReadFile(mockFileReader.Object, "file_download.txt");

            Assert.Equal("Reading file", result);

        }

    }
}
