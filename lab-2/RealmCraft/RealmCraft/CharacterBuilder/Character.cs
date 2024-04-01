using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmCraft.CharacterBuilder
{
    using System.Collections.Generic;

    public class Character
    {
        protected string Height { get; }
        protected string Build { get; }
        protected string HairColor { get; }
        protected string EyeColor { get; }
        protected string Clothing { get; }
        protected List<string> Inventory { get; }

        public Character(string height, string build, string hairColor, string eyeColor, string clothing, List<string> inventory)
        {
            Height = height;
            Build = build;
            HairColor = hairColor;
            EyeColor = eyeColor;
            Clothing = clothing;
            Inventory = inventory;
        }

        public virtual void DisplayCharacter()
        {
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Build: {Build}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothing: {Clothing}");
            Console.WriteLine($"Inventory: {string.Join(", ", Inventory)}");
        }
    }

}
