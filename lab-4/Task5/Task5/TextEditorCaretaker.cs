using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace Task5
{

    public class TextEditorCaretaker
    {
        private List<TextEditorMemento> _mementos = new List<TextEditorMemento>();

        public void AddMemento(TextEditorMemento memento)
        {
            _mementos.Add(memento);
        }

        public TextEditorMemento GetMemento(int index)
        {
            return _mementos[index];
        }
    }

}
