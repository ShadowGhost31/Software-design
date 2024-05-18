using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class TextEditor
    {
        private TextDocument _document;

        public TextDocument Document
        {
            get { return _document; }
            set { _document = value; }
        }

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public TextEditorMemento Save()
        {
            return new TextEditorMemento(_document);
        }

        public void Restore(TextEditorMemento memento)
        {
            _document = memento.GetSavedDocument();
        }
    }

}
