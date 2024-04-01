using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusProject
{
    class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }

        public object Clone()
        {
            // Створюємо новий об'єкт Virus
            Virus clonedVirus = new Virus(this.Weight, this.Age, this.Name, this.Type);

            // Клонуємо всі діти віруса
            foreach (var child in this.Children)
            {
                // Рекурсивно клонуємо кожного нащадка
                Virus clonedChild = (Virus)child.Clone();
                clonedVirus.Children.Add(clonedChild);
            }

            return clonedVirus;
        }
    }
}
