using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ForTest
{
    internal class MultiWordRequester : IWordRequester
    {
        private readonly HttpClient _httpClient;

        public MultiWordRequester(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetRandomWordAsync()
        {
            string finalStr = "";
            var rand = new Random();
            int num = rand.Next(1, 6);

            try
            {
                HttpResponseMessage response = await GetResponseWithRetryAsync($"https://random-word-api.herokuapp.com/word?number={num}");
                string jsonResponse = await response.Content.ReadAsStringAsync();

                foreach (string str in ParseJsonToList(jsonResponse))
                {
                    finalStr += str + " ";
                }

                return finalStr.Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching words: {ex.Message}");
                return string.Empty;
            }
        }

        private List<string> ParseJsonToList(string json)
        {
            JArray wordsArray = JArray.Parse(json);
            List<string> words = new List<string>();

            foreach (JToken word in wordsArray)
            {
                words.Add(word.ToString());
            }

            return words;
        }

        private async Task<HttpResponseMessage> GetResponseWithRetryAsync(string requestUri, int maxRetries = 3)
        {
            int retries = 0;
            while (retries < maxRetries)
            {
                HttpResponseMessage response = await _httpClient.GetAsync(requestUri);
                if (response.IsSuccessStatusCode)
                {
                    return response;
                }

                retries++;
                if (retries < maxRetries)
                {
                    Console.WriteLine("Retrying...");
                    await Task.Delay(1000); // Затримка перед повторною спробою
                }
            }

            throw new HttpRequestException($"Failed to get a successful response after {maxRetries} attempts.");
        }
    }
}
