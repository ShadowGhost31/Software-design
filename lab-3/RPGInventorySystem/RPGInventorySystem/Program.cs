using RPGInventorySystem.Characters;
using RPGInventorySystem.Decorators;
using RPGInventorySystem.Interfaces;

namespace RPGInventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо героїв
            IInventory warrior = new Warrior();
            IInventory mage = new Mage();
            IInventory paladin = new Paladin();

            // Додаємо до них інвентар у вигляді декораторів
            warrior = new ClothingDecorator(warrior);
            warrior = new WeaponDecorator(warrior);

            mage = new WeaponDecorator(mage);

            paladin = new ClothingDecorator(paladin);
            paladin = new WeaponDecorator(paladin);

            // Екіпіруємо героїв
            warrior.Equip();
            Console.WriteLine();

            mage.Equip();
            Console.WriteLine();

            paladin.Equip();
        }
    }
}
