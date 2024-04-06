using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLMemoryOptimizer.Models
{
    public abstract class HTMLNode
    {
        public abstract int GetMemorySize();
    }
}
