using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Handlers;

namespace Task1.Support
{
    using Task1.Handlers;

    public class SupportSystem
    {
        private IHandler _initialHandler;

        public SupportSystem()
        {
            // Створюємо обробників
            var levelOneHandler = new LevelOneHandler();
            var levelTwoHandler = new LevelTwoHandler();
            var levelThreeHandler = new LevelThreeHandler();
            var levelFourHandler = new LevelFourHandler();

            // Налаштовуємо ланцюжок відповідальностей
            levelOneHandler.SetNext(levelTwoHandler);
            levelTwoHandler.SetNext(levelThreeHandler);
            levelThreeHandler.SetNext(levelFourHandler);

            _initialHandler = levelOneHandler;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Оберіть рівень підтримки (1-4): ");
                if (int.TryParse(Console.ReadLine(), out int level))
                {
                    if (level >= 1 && level <= 4)
                    {
                        _initialHandler.HandleRequest(level);
                    }
                    else
                    {
                        Console.WriteLine("Некоректний ввід. Будь ласка, спробуйте ще раз.");
                    }
                }
                else
                {
                    Console.WriteLine("Некоректний ввід. Будь ласка, спробуйте ще раз.");
                }
            }
        }
    }
}
