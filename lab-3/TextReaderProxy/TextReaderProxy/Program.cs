namespace TextReaderProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Перевірка SmartTextChecker
            using (var checker = new SmartTextChecker("sample.txt"))
            {
                checker.DisplayText();
            }

            // Перевірка SmartTextReaderLocker
            using (var locker = new SmartTextReaderLocker("limitedfile1.txt"))
            {
                locker.DisplayText();
            }

            Console.ReadLine();
        }
    }
}
