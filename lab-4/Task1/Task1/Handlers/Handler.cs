using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Handlers
{
    public abstract class Handler : IHandler
    {
        private IHandler _nextHandler;

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual void HandleRequest(int level)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(level);
            }
            else
            {
                Console.WriteLine("Проблема не вирішена. Будь ласка, спробуйте ще раз.");
            }
        }
    }
}
