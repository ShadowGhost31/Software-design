using GraphicEditor.DrawingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Shapes
{
    class Circle : Shape
    {
        public Circle(IDrawingAPI drawingAPI) : base(drawingAPI)
        {
        }

        public override void Draw()
        {
            drawingAPI.DrawShape();
        }
    }
}
