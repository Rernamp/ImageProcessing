using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageReadCS
{
    public class GrayscaleFloatImage : PixelContainer<float>
    {
        public GrayscaleFloatImage(int Width, int Height) : base(Width, Height)
        {
        }
        public GrayscaleByteImage ToGrayscaleByteImage()
        {
            GrayscaleByteImage res = new GrayscaleByteImage(Width, Height);
            for (int i = 0; i < res.rawdata.Length; i++)
                res.rawdata[i] = rawdata[i] < 0.0f ? (byte)0 : rawdata[i] > 255.0f ? (byte)255 : (byte)rawdata[i];
            return res;
        }

        public ColorFloatImage ToColorFloatImage()
        {
            ColorFloatImage res = new ColorFloatImage(Width, Height);
            for (int i = 0; i < res.rawdata.Length; i++)
                res.rawdata[i] = new ColorPixel<float>() { b = rawdata[i], g = rawdata[i], r = rawdata[i], a = 0.0f };
            return res;
        }

        public ColorByteImage ToColorByteImage()
        {
            ColorByteImage res = new ColorByteImage(Width, Height);
            for (int i = 0; i < res.rawdata.Length; i++)
            {
                byte c = rawdata[i] < 0.0f ? (byte)0 : rawdata[i] > 255.0f ? (byte)255 : (byte)rawdata[i];
                res.rawdata[i] = new ColorPixel<byte>() { b = c, g = c, r = c, a = 0 };
            }
            return res;
        }
    }
}
