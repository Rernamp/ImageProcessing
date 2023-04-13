using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageReadCS
{
    public class GrayscaleByteImage : PixelContainer<byte>
    {
        public GrayscaleByteImage(int Width, int Height) : base(Width, Height)
        {
        }
    }
}
