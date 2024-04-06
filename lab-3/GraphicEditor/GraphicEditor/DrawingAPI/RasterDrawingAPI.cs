using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.DrawingAPI
{
    class RasterDrawingAPI : IDrawingAPI
    {
        public void DrawShape()
        {
            Console.WriteLine("Drawing shape as raster graphics");
        }
    }
}
