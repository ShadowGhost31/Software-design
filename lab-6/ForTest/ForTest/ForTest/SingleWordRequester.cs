using System.Net.Http;
using System.Threading.Tasks;

namespace ForTest
{
    internal class SingleWordRequester : IWordRequester
    {
        private readonly HttpClient _httpClient;

        public SingleWordRequester(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetRandomWordAsync()
        {
            try
            {
                HttpResponseMessage response = await GetResponseWithRetryAsync("https://random-word-api.herokuapp.com/word");
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return jsonResponse.Split('"')[1];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching word: {ex.Message}");
                return string.Empty;
            }
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
