using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLMemoryOptimizer.Models
{
    public class HTMLTextNode : HTMLNode
    {
        public string Text { get; }

        public HTMLTextNode(string text)
        {
            Text = text;
        }

        public override int GetMemorySize()
        {
            // Розмір тексту у пам'яті
            return Text.Length * sizeof(char);
        }
    }
}
