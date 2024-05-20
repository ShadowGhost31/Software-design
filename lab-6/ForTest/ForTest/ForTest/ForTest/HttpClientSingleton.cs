using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ForTest.ForTest
{
    // Singleton pattern
    public sealed class HttpClientSingleton
    {
        private static readonly Lazy<HttpClient> lazyInstance = new Lazy<HttpClient>(() => 
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://random-word-api.herokuapp.com/");
            return client;
        });

        private HttpClientSingleton() { }

        public static HttpClient Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }
    }
}
