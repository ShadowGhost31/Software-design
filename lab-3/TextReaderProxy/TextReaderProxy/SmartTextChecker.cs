using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReaderProxy
{

    public class SmartTextChecker : IDisposable
    {
        private readonly SmartTextReader _textReader;

        public SmartTextChecker(string filePath)
        {
            Console.WriteLine("Opening file: " + filePath);
            _textReader = new SmartTextReader(filePath);
        }

        public void DisplayText()
        {
            _textReader.DisplayText();
        }

        public void Dispose()
        {
            Console.WriteLine("Closing file.");
            _textReader.Dispose();
        }
    }
}
