using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextReaderProxy
{
    public class SmartTextReaderLocker : IDisposable
    {
        private readonly SmartTextReader _textReader;

        public SmartTextReaderLocker(string filePath)
        {
            if (Regex.IsMatch(filePath, @"limitedfile\d\.txt")) // Приклад регулярного виразу для обмеження доступу до певних файлів
            {
                Console.WriteLine("Access denied!");
            }
            else
            {
                _textReader = new SmartTextReader(filePath);
            }
        }

        public void DisplayText()
        {
            if (_textReader != null)
                _textReader.DisplayText();
        }

        public void Dispose()
        {
            if (_textReader != null)
                _textReader.Dispose();
        }
    }
}
