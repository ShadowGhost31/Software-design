using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Handlers
{
    public class LevelThreeHandler : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 3)
            {
                Console.WriteLine("Проблема вирішена на третьому рівні підтримки.");
            }
            else
            {
                base.HandleRequest(level);
            }
        }
    }
}
