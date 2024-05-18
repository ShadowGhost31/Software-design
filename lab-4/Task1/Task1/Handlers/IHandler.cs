using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Handlers
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void HandleRequest(int level);
    }
}

