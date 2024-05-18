using System;
using System.IO;

namespace Task4
{
    public class FileImageLoader : IImageLoader
    {
        public void LoadImage(string href)
        {
            if (File.Exists(href))
            {
                Console.WriteLine($"Зображення завантажено з файлу: {href}");
                // Логіка завантаження зображення з файлової системи
            }
            else
            {
                Console.WriteLine($"Файл {href} не знайдено.");
            }
        }
    }
}
