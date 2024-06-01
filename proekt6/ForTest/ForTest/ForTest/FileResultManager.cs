using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.ForTest
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
            if (!System.IO.File.Exists(_filePath))
            {
                System.IO.File.WriteAllText(_filePath, result + Environment.NewLine);
            }
            else
            {
                System.IO.File.AppendAllText(_filePath, result + Environment.NewLine);
            }
        }

        public void PrintResults()
        {
            if (System.IO.File.Exists(_filePath))
            {
                string[] results = System.IO.File.ReadAllLines(_filePath);
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
