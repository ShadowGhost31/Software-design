using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmCraft.CharacterBuilder
{
    using System.Collections.Generic;

    public class EnemyBuilder : ICharacterBuilder
    {
        private string height;
        private string build;
        private string hairColor;
        private string eyeColor;
        private string clothing;
        private List<string> inventory;

        public EnemyBuilder()
        {
            inventory = new List<string>();
        }

        public ICharacterBuilder SetHeight(string height)
        {
            this.height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            this.build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            this.hairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            this.eyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            this.clothing = clothing;
            return this;
        }

        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            this.inventory = inventory;
            return this;
        }

        public Enemy Build()
        {
            return new Enemy(height, build, hairColor, eyeColor, clothing, inventory);
        }
    }

}
