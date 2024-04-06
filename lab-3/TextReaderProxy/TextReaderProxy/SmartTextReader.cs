using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TextReaderProxy
{
    public class SmartTextReader : IDisposable
    {
        private readonly string _filePath;
        private string[][] _textArray;

        public SmartTextReader(string filePath)
        {
            _filePath = filePath;
            ReadFile();
        }

        private void ReadFile()
        {
            if (File.Exists(_filePath))
            {
                string[] lines = File.ReadAllLines(_filePath);
                _textArray = new string[lines.Length][];
                for (int i = 0; i < lines.Length; i++)
                {
                    _textArray[i] = lines[i].Split();
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public void DisplayText()
        {
            if (_textArray != null)
            {
                foreach (var line in _textArray)
                {
                    foreach (var word in line)
                    {
                        Console.Write(word + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No text to display.");
            }
        }

        public void Dispose()
        {
            // Dispose resources if needed
        }
    }
}
