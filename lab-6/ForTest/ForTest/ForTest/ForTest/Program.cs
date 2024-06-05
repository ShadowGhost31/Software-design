using ForTest;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ForTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var program = new Program();
            await program.RunValidationProcessAsync();
        }

        private async Task RunValidationProcessAsync()
        {
            var validator = new WordValidator();
            int totalWords = 20;
            int errorCount = 0;
            var stopwatch = new Stopwatch();
            string filePath = "results.txt";
            IResultManager resultManager = new FileResultManager(filePath);

            int mode = GetModeFromUser();
            IWordRequester wordRequester = new WordRequesterFactory(HttpClientSingleton.Instance).CreateWordRequester(mode);

            stopwatch.Start();

            for (int i = 0; i < totalWords; i++)
            {
                string word = await wordRequester.GetRandomWordAsync();
                Console.WriteLine($"Type the following word: {word}");

                string userInput = Console.ReadLine();
                if (!validator.Validate(userInput, word))
                {
                    errorCount++;
                    Console.WriteLine("Incorrect! Try again.");
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"You made {errorCount} errors.");
            Console.WriteLine($"Total time: {stopwatch.Elapsed.TotalSeconds} seconds.");

            string name = GetUserName();
            resultManager.SaveResult(name, errorCount, stopwatch.Elapsed.TotalSeconds);
            resultManager.PrintResults();
        }

        private int GetModeFromUser()
        {
            int mode;
            Console.Write("1. Single word mode\n2. Multi word mode\nChoose mode: ");
            while (!int.TryParse(Console.ReadLine(), out mode) || mode < 1 || mode > 2)
            {
                Console.WriteLine("Invalid input. Try again.");
            }
            return mode;
        }

        private string GetUserName()
        {
            string name;
            Console.Write("Enter your name: ");
            while (string.IsNullOrEmpty(name = Console.ReadLine()))
            {
                Console.WriteLine("Invalid input. Try again.");
            }
            return name;
        }
    }
}
