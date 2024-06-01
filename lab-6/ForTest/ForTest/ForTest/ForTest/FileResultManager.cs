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

        // Конструктор приймає шлях до файлу
        public FileResultManager(string filePath)
        {
            _filePath = filePath;
        }

        // Метод для збереження результату
        public void SaveResult(string name, int errors, double timeInSeconds)
        {
            string result = $"{name} made {errors} errors in {timeInSeconds} seconds.";

            // Перевіряємо, чи існує файл перед записом
            if (!System.IO.File.Exists(_filePath))
            {
                // Якщо файл не існує, створюємо його і записуємо результат
                System.IO.File.WriteAllText(_filePath, result + Environment.NewLine);
            }
            else
            {
                // Якщо файл існує, додаємо новий результат в кінець файлу
                System.IO.File.AppendAllText(_filePath, result + Environment.NewLine);
            }
        }

        // Метод для виведення результатів на консоль
        public void PrintResults()
        {
            // Перевіряємо, чи існує файл перед читанням
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