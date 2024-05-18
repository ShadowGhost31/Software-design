using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class TextEditorMemento
    {
        private readonly TextDocument _document;

        public TextEditorMemento(TextDocument document)
        {
            _document = document;
        }

        public TextDocument GetSavedDocument()
        {
            return _document;
        }
    }

}
