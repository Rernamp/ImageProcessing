using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ImageReadCS
{
    public class ColorFloatImage : PixelContainer<ColorPixel<float>>
    {
        public ColorFloatImage(int Width, int Height) : base(Width, Height)
        {
        }
    }
}
