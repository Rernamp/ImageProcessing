using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageReadCS {
    public class ColorPixel<T> {
        public T b, g, r, a;

        public static ColorPixel<T> operator +(ColorPixel<T> pixel1, ColorPixel<T> pixel2) {
            ColorPixel<T> result = new ColorPixel<T>();

            return result;
        }
    }
}
