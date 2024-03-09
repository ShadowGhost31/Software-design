using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Inventory
    {
        public List<Animal> Animals { get; set; }
        public List<Employee> Employees { get; set; }

        public Inventory()
        {
            Animals = new List<Animal>();
            Employees = new List<Employee>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public void DisplayAnimals()
        {
            Console.WriteLine("List of Animals:");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"{animal.Species} ({animal.Breed}), Age: {animal.Age}");
            }
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("List of Employees:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.Name}, Position: {employee.Position}");
            }
        }
    }

}
