using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Animal
    {
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Health { get; set; }
        public string Feeding { get; set; }
        public string Personality { get; set; }

        public Animal(string species, string breed, int age, string gender, string health, string feeding, string personality)
        {
            Species = species;
            Breed = breed;
            Age = age;
            Gender = gender;
            Health = health;
            Feeding = feeding;
            Personality = personality;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Feeding: {Feeding}");
            Console.WriteLine($"Personality: {Personality}");
        }
    }

}
