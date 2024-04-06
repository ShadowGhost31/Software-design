using GraphicEditor.DrawingAPI;
using GraphicEditor.Shapes;

namespace GraphicEditor
{

    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єктів фігур з різними типами рендерінгу
            Shape circle = new Circle(new VectorDrawingAPI());
            Shape square = new Square(new RasterDrawingAPI());
            Shape triangle = new Triangle(new VectorDrawingAPI());

            // Рендерінг фігур
            circle.Draw();
            square.Draw();
            triangle.Draw();
        }
    }
}
