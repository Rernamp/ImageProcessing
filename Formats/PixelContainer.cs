using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageReadCS {
    public class PixelContainer<T> where T : System.Numerics.INumber<T> {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public readonly T[] rawdata;

        public PixelContainer(int Width, int Height) {
            this.Width = Width;
            this.Height = Height;
            rawdata = new T[Width * Height];
        }

        public static bool checkSizeEquality(PixelContainer<T> container1, PixelContainer<T> container2) {
            return container1.Width == container2.Width && container1.Height == container2.Height;
        }
        public static PixelContainer<T> operator +(PixelContainer<T> container1, PixelContainer<T> container2) {
            if (!checkSizeEquality(container1, container2)) {
                throw new InvalidOperationException("Сontainers of different sizes");
            }
            PixelContainer<T> result = new PixelContainer<T>(container1.Width, container1.Height);

            for (int i = 0; i < container1.rawdata.Length; i++) {
                result.rawdata[i] = ((dynamic)container1.rawdata[i]) + ((dynamic)container2.rawdata[i]);
            }

            return result;
        }

        public T this[int x, int y] {
            get {
#if DEBUG
                if (x < 0 || x >= Width || y < 0 || y >= Height)
                    throw new IndexOutOfRangeException(string.Format("Trying to access pixel ({0}, {1}) in {2}x{3} image", x, y, Width, Height));
#endif
                return rawdata[y * Width + x];
            }
            set {
#if DEBUG
                if (x < 0 || x >= Width || y < 0 || y >= Height)
                    throw new IndexOutOfRangeException(string.Format("Trying to access pixel ({0}, {1}) in {2}x{3} image", x, y, Width, Height));
#endif
                rawdata[y * Width + x] = value;
            }
        }
    }
}
