using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Enclosure
    {
        public string Type { get; set; } // Тип вольєру (наприклад, "Для хижаків", "Акваріум" і т.д.)
        public int Size { get; set; } // Розмір вольєру (наприклад, площа у квадратних метрах)
        public List<Animal> Animals { get; set; } // Список тварин, які знаходяться у вольєрі

        // Конструктор класу Enclosure
        public Enclosure(string type, int size)
        {
            Type = type;
            Size = size;
            Animals = new List<Animal>(); // Ініціалізація списку тварин
        }

        // Метод для додавання тварини до вольєру
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            Console.WriteLine($"Додано тварину {animal.Species} до вольєру типу {Type}");
        }

        // Метод для видалення тварини з вольєру
        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
            Console.WriteLine($"Видалено тварину {animal.Species} з вольєру типу {Type}");
        }

        // Метод для виведення інформації про вольєр
        public void DisplayInfo()
        {
            Console.WriteLine($"Вольєр типу {Type}, розмір: {Size} кв.м");
            Console.WriteLine("Тварини у вольєрі:");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"{animal.Species}, {animal.Breed}, {animal.Age} років");
            }
        }
    }
}
