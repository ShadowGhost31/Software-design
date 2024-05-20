// Program.cs

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ForTest.ForTest
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
            stopwatch.Start();

            for (int i = 0; i < totalWords; i++)
            {
                string word = await GetRandomWordAsync();
                Console.WriteLine($"Type the following word: {word}");

                string userInput;
                while (true)
                {
                    userInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(userInput)) break;
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }

                if (!validator.Validate(userInput, word))
                {
                    errorCount++;
                    Console.WriteLine("Incorrect! Try again.");
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"You made {errorCount} errors.");
            Console.WriteLine($"Total time: {stopwatch.Elapsed.TotalSeconds} seconds.");
        }

        private static async Task<string> GetRandomWordAsync()
        {
            try
            {
                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync("word");
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                return jsonResponse.Trim('[', ']', '"');
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return "error"; 
            }
        }
    }
}
