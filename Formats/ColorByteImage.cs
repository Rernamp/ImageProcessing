using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ImageReadCS
{

    public class ColorByteImage : PixelContainer<ColorPixel<byte>>
    {        
        public ColorByteImage(int Width, int Height) : base(Width, Height)
        {
        }
    }
}
