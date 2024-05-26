using System;
using System.Net.Http;

namespace ForTest.ForTest
{
    // Singleton pattern
    public sealed class HttpClientSingleton
    {
        private static readonly Lazy<HttpClient> lazyInstance = new Lazy<HttpClient>(() =>
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://random-word-api.herokuapp.com/"),
                Timeout = TimeSpan.FromSeconds(10)
            };
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        });

        private HttpClientSingleton() { }

        public static HttpClient Instance => lazyInstance.Value;
    }
}
