using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class FileWriter
    {
        public void Write(string text)
        {
            // Логіка запису тексту в файл
            Console.WriteLine($"Writing to file: {text}");
        }

        public void WriteLine(string line)
        {
            // Логіка запису рядка в файл
            Console.WriteLine($"Writing line to file: {line}");
        }
    }
}
