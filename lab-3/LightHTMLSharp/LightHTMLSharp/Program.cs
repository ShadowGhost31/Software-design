using LightHTMLSharp.Models;

namespace LightHTMLSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення таблиці за допомогою мови розмітки LightHTML
            var table = new LightElementNode("table", "block", "dual", new List<string>(), new List<LightNode>
        {
            new LightElementNode("tr", "block", "dual", new List<string>(), new List<LightNode>
            {
                new LightElementNode("td", "inline", "dual", new List<string>(), new List<LightNode>
                {
                    new LightTextNode("Row 1, Cell 1")
                }),
                new LightElementNode("td", "inline", "dual", new List<string>(), new List<LightNode>
                {
                    new LightTextNode("Row 1, Cell 2")
                })
            }),
            new LightElementNode("tr", "block", "dual", new List<string>(), new List<LightNode>
            {
                new LightElementNode("td", "inline", "dual", new List<string>(), new List<LightNode>
                {
                    new LightTextNode("Row 2, Cell 1")
                }),
                new LightElementNode("td", "inline", "dual", new List<string>(), new List<LightNode>
                {
                    new LightTextNode("Row 2, Cell 2")
                })
            })
        });

            // Виведення таблиці в консоль
            Console.WriteLine(table.OuterHTML);
        }
    }
}
