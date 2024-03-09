using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Food
    {
        public string Name { get; set; } // Назва корму
        public string Type { get; set; } // Тип корму (сухий, вологий, тощо)
        public decimal Price { get; set; } // Ціна за одиницю корму
        public int Quantity { get; set; } // Кількість доступного корму
        public DateTime ExpiryDate { get; set; } // Дата закінчення терміну придатності

        // Конструктор класу для ініціалізації об'єктів класу Food
        public Food(string name, string type, decimal price, int quantity, DateTime expiryDate)
        {
            Name = name;
            Type = type;
            Price = price;
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }

        // Метод для відображення інформації про корм
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Expiry Date: {ExpiryDate}");
        }
    }

}
