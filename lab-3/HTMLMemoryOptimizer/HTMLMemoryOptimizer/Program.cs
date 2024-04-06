using HTMLMemoryOptimizer.Models;

namespace HTMLMemoryOptimizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приклад використання
            var rootNode = new HTMLParagraphNode(
                new HTMLTextNode("This is a paragraph.")
            );

            var document = new HTMLDocument(rootNode);
            int memoryUsage = document.MemoryUsage();
            Console.WriteLine($"Memory usage of the document: {memoryUsage} bytes");
        }
    }
}
