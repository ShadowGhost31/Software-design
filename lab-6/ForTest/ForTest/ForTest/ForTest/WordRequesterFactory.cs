using System.Net.Http;

namespace ForTest
{
    internal class WordRequesterFactory
    {
        private readonly HttpClient _httpClient;

        public WordRequesterFactory(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IWordRequester CreateWordRequester(int mode)
        {
            return mode switch
            {
                1 => new SingleWordRequester(_httpClient),
                2 => new MultiWordRequester(_httpClient),
                _ => throw new ArgumentException("Invalid mode"),
            };
        }
    }
}
