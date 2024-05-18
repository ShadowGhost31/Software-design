using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Handlers
{
    public class LevelTwoHandler : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 2)
            {
                Console.WriteLine("Проблема вирішена на другому рівні підтримки.");
            }
            else
            {
                base.HandleRequest(level);
            }
        }
    }
}
