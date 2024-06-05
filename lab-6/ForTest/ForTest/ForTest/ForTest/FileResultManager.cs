using ForTest;
using System;
using System.IO;

namespace ForTest
{
    internal class FileResultManager : IResultManager
    {
        private readonly string _filePath;

        public FileResultManager(string filePath)
        {
            _filePath = filePath;
        }

        public void SaveResult(string name, int errors, double timeInSeconds)
        {
            string result = $"{name} made {errors} errors in {timeInSeconds} seconds.";
            File.AppendAllText(_filePath, result + Environment.NewLine);
        }

        public void PrintResults()
        {
            if (File.Exists(_filePath))
            {
                string[] results = File.ReadAllLines(_filePath);
                foreach (string result in results)
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("No results file found.");
            }
        }
    }
}
