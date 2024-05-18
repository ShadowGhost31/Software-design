using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class ImageContext
    {
        private IImageLoader _imageLoader;

        public void SetImageLoader(IImageLoader imageLoader)
        {
            _imageLoader = imageLoader;
        }

        public void LoadImage(string href)
        {
            _imageLoader?.LoadImage(href);
        }
    }
}

