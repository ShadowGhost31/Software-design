using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        // Конструктор класу
        public Employee(string name, string position, int age, string department, decimal salary)
        {
            Name = name;
            Position = position;
            Age = age;
            Department = department;
            Salary = salary;
        }

        // Метод для виведення інформації про працівника
        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

}
