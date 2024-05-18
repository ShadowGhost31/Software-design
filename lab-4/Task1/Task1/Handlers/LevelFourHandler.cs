using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Handlers
{
    public class LevelFourHandler : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level == 4)
            {
                Console.WriteLine("Проблема вирішена на четвертому рівні підтримки.");
            }
            else
            {
                base.HandleRequest(level);
            }
        }
    }
}
