using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ForTest.ForTest;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ForTest
{
    internal class MultiWordRequester : IWordRequester
    {
        public async Task<string> GetRandomWordAsync()
        {
            string finalStr = "";
            var rand = new Random();
            int num = rand.Next(1, 6);  // Adjusted to get at least 1 word

            HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync($"https://random-word-api.herokuapp.com/word?number={num}");
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();

            foreach (string str in ParseJsonToList(jsonResponse))
            {
                finalStr += str + " ";  // Corrected string concatenation
            }

            return finalStr.Trim();  // Trim to remove the trailing space
        }

        private List<string> ParseJsonToList(string json)
        {
            // Использование библиотеки Newtonsoft.Json для парсинга JSON
            JArray wordsArray = JArray.Parse(json);

            // Создание списка строк для хранения слов
            List<string> words = new List<string>();

            // Итерация по массиву слов в JSON и добавление их в список
            foreach (JToken word in wordsArray)
            {
                words.Add(word.ToString());
            }

            return words;
        }
    }
}
