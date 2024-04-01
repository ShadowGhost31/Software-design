using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmCraft.CharacterBuilder
{
    public class CharacterDirector
    {
        private ICharacterBuilder characterBuilder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            characterBuilder = builder;
        }

        public void ConstructCharacter()
        {
            characterBuilder
                .SetHeight("Tall")
                .SetBuild("Muscular")
                .SetHairColor("Brown")
                .SetEyeColor("Blue")
                .SetClothing("Armor")
                .SetInventory(new List<string> { "Sword", "Shield" });
        }
    }
}
