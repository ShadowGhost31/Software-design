using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Handlers
{
    public class LevelOneHandler : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Проблема вирішена на першому рівні підтримки.");
            }
            else
            {
                base.HandleRequest(level);
            }
        }
    }
}
