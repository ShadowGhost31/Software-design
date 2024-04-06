using RPGInventorySystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventorySystem.Decorators
{
    abstract class InventoryDecorator : IInventory
    {
        protected IInventory _inventory;

        public InventoryDecorator(IInventory inventory)
        {
            _inventory = inventory;
        }

        public virtual void Equip()
        {
            _inventory.Equip();
        }
    }
}
