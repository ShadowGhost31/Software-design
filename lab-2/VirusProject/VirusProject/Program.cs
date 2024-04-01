using System;

namespace VirusProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо віруси
            Virus firstGenerationVirus = new Virus(1.5, 1, "Virus1", "Type1");
            Virus secondGenerationVirus1 = new Virus(2.0, 2, "Virus2", "Type2");
            Virus secondGenerationVirus2 = new Virus(2.5, 2, "Virus3", "Type3");
            Virus thirdGenerationVirus1 = new Virus(3.0, 3, "Virus4", "Type4");
            Virus thirdGenerationVirus2 = new Virus(3.5, 3, "Virus5", "Type5");

            // Додаємо дітей до вірусів
            firstGenerationVirus.Children.Add(secondGenerationVirus1);
            firstGenerationVirus.Children.Add(secondGenerationVirus2);
            secondGenerationVirus1.Children.Add(thirdGenerationVirus1);
            secondGenerationVirus2.Children.Add(thirdGenerationVirus2);

            // Клонуємо віруси
            Virus clonedFirstGenerationVirus = (Virus)firstGenerationVirus.Clone();

            // Виводимо інформацію про клоновані віруси
            Console.WriteLine("Original Virus:");
            PrintVirusInfo(firstGenerationVirus);

            Console.WriteLine("\nCloned Virus:");
            PrintVirusInfo(clonedFirstGenerationVirus);
        }

        static void PrintVirusInfo(Virus virus)
        {
            Console.WriteLine($"Name: {virus.Name}, Type: {virus.Type}, Weight: {virus.Weight}, Age: {virus.Age}");

            foreach (var child in virus.Children)
            {
                PrintVirusInfo(child);
            }
        }
    }
}
