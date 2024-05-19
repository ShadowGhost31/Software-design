using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ForTest.ForTest
{
    // Singleton pattern
    public class HttpClientSingleton
    {
        private static readonly HttpClient instance = new HttpClient();

        private HttpClientSingleton() { }

        public static HttpClient Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
