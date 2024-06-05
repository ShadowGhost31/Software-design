using System.Net.Http;

namespace ForTest
{
    public class HttpClientSingleton
    {
        private static readonly HttpClient _instance = new HttpClient();

        private HttpClientSingleton() { }

        public static HttpClient Instance => _instance;
    }
}
