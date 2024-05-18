using Task5;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextDocument document = new TextDocument("Initial content");
            TextEditor editor = new TextEditor(document);
            TextEditorCaretaker caretaker = new TextEditorCaretaker();

            // Збереження початкового стану документа
            caretaker.AddMemento(editor.Save());

            // Робота з редактором: зміна вмісту
            editor.Document.Content = "Modified content";

            // Збереження зміненого стану документа
            caretaker.AddMemento(editor.Save());

            // Відновлення початкового стану документа
            editor.Restore(caretaker.GetMemento(0));

            Console.WriteLine("Current content: " + editor.Document.Content);
        }
    }

}
