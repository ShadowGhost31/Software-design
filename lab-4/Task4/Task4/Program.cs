using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageContext imageContext = new ImageContext();

            // Завантаження зображення з файлової системи
            imageContext.SetImageLoader(new FileImageLoader());
            imageContext.LoadImage(@"D:\бекап3\Університет\2 курс\2 семестр\Software-design\lab-4\Task4\image.jpg");

            // Завантаження зображення з мережі
            imageContext.SetImageLoader(new NetworkImageLoader());
            imageContext.LoadImage("https://picsum.photos/200/300");
        }
    }
}
