using lab_1;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Створення тварин
        Animal lion = new Animal("Lion", "African Lion", 5, "Large", "Carnivore", "Yellow", "Roar");
        Animal elephant = new Animal("Elephant", "African Elephant", 10, "Huge", "Herbivore", "Grey", "Trumpet");

        // Створення співробітників
        Employee zookeeper1 = new Employee("John Doe", "Zookeeper", 35, "Male", 3000);
        Employee zookeeper2 = new Employee("Jane Doe", "Assistant Zookeeper", 28, "Female", 2500);

        // Створення інвентаризації
        Inventory zooInventory = new Inventory();

        // Додавання тварин та співробітників до інвентаризації
        zooInventory.AddAnimal(lion);
        zooInventory.AddAnimal(elephant);
        zooInventory.AddEmployee(zookeeper1);
        zooInventory.AddEmployee(zookeeper2);

        // Виведення інформації про тварин та співробітників
        Console.WriteLine("Zoo Inventory:");
        zooInventory.DisplayAnimals();
        zooInventory.DisplayEmployees();
    }
}
