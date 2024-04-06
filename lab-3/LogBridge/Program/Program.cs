namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляру FileWriter
            FileWriter fileWriter = new FileWriter();

            // Створення адаптера для файлу
            FileLoggerAdapter fileLogger = new FileLoggerAdapter(fileWriter);

            // Тестування роботи логера
            fileLogger.Log("This is a log message.");
            fileLogger.Warn("This is a warning message.");
            fileLogger.Error("This is an error message.");
        }

    }
}
