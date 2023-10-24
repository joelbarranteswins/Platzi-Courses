using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class FileReaderConector : IFileReaderConector
    {
        public string ReadString(string fileName)
        {
            try
            {
                // Read all lines from the file
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                string lines = File.ReadAllText(filePath);

                return lines;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return "";
        }
    }

    public interface IFileReaderConector
    {
        string ReadString(string fileName);
    }
}
