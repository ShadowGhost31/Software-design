using HTMLMemoryOptimizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLMemoryOptimizer
{
    public class HTMLDocument
    {
        public HTMLNode RootNode { get; }

        public HTMLDocument(HTMLNode rootNode)
        {
            RootNode = rootNode;
        }

        // Метод для обчислення обсягу пам'яті, що використовується документом
        public int MemoryUsage()
        {
            return RootNode.GetMemorySize();
        }
    }
}
