using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmCraft.CharacterBuilder
{
    public class Hero : Character
    {
        public Hero(string height, string build, string hairColor, string eyeColor, string clothing, List<string> inventory)
            : base(height, build, hairColor, eyeColor, clothing, inventory)
        {
        }

        public override void DisplayCharacter()
        {
            Console.WriteLine("Hero:");
            base.DisplayCharacter();
        }
    }

}
