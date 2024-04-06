using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLMemoryOptimizer.Models
{
    public class HTMLParagraphNode : HTMLNode
    {
        public HTMLNode Content { get; }

        public HTMLParagraphNode(HTMLNode content)
        {
            Content = content;
        }

        public override int GetMemorySize()
        {
            // Оцінка розміру об'єкта
            return Content.GetMemorySize();
        }
    }
}
