using System;
using System.Net.Http;

namespace Task4
{
    public class NetworkImageLoader : IImageLoader
    {
        public void LoadImage(string href)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync(href).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Зображення завантажено з мережі: {href}");
                        // Логіка завантаження зображення з мережі
                    }
                    else
                    {
                        Console.WriteLine($"Не вдалося завантажити зображення з мережі: {href}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при завантаженні зображення з мережі: {ex.Message}");
                }
            }
        }
    }
}
