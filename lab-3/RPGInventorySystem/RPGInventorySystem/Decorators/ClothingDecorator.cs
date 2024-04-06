using RPGInventorySystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventorySystem.Decorators
{
    class ClothingDecorator : InventoryDecorator
    {
        public ClothingDecorator(IInventory inventory) : base(inventory)
        {
        }

        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Clothing equipped");
        }
    }
}
