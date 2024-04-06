using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLMemoryOptimizer.Models
{
    public class HTMLHeaderNode : HTMLNode
    {
        public string Text { get; }

        public HTMLHeaderNode(string text)
        {
            Text = text;
        }

        public override int GetMemorySize()
        {
            // Оцінка розміру об'єкта
            return Text.Length * sizeof(char);
        }
    }
}
