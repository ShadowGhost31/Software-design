using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення злітно-посадкових смуг
            var runway1 = new Runway();
            var runway2 = new Runway();

            // Створення посередника
            var commandCentre = new CommandCentre(new Runway[] { runway1, runway2 }, Array.Empty<Aircraft>());

            // Створення літаків з посиланням на посередника
            var aircraft1 = new Aircraft("Aircraft1", commandCentre);
            var aircraft2 = new Aircraft("Aircraft2", commandCentre);

            // Додавання літаків у посередник
            commandCentre = new CommandCentre(new Runway[] { runway1, runway2 }, new Aircraft[] { aircraft1, aircraft2 });

            // Запити на посадку та зліт через посередника
            aircraft1.RequestLanding(runway1);
            aircraft1.RequestTakeOff(runway1);
            aircraft2.RequestLanding(runway2);
        }
    }
}
