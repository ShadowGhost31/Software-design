using RPGInventorySystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventorySystem.Characters
{
    class Mage : IInventory
    {
        public void Equip()
        {
            Console.WriteLine("Mage equipped");
        }
    }
}
