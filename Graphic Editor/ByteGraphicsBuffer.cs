using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Graphic_Editor
{
    internal class ByteGraphicsBuffer
    {
        private byte[] _pixelData; // pixelData хранит данные о пикселях в виде [R, G, B, A, R, G ...]

        private int _width;
        private int _height;

        public int Width { get; }
        public int Height { get; }

        public ByteGraphicsBuffer(int width, int height)
        {
            this._width = width;
            this._height = height;

            _pixelData = new byte[width * height * 3];
            for (int i = 0; i < _pixelData.Length; i++)
            {
                _pixelData[i] = 0;
            }
        }

        /// <summary>
        /// Сохраняет данные пикселя в буфер
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        public void SetPixel(int x, int y, Color color)
        {
            int index = (y * _width + x) * 4;
            _pixelData[index] = color.R;
            _pixelData[index + 1] = color.G;
            _pixelData[index + 2] = color.B;
            _pixelData[index + 3] = color.A;
        }

        /// <summary>
        /// Сохраняет данные пикселя в буффер
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        public void SetPixel(int x, int y, byte r, byte g, byte b, byte a)
        {
            int index = (y * _width + x) * 4;
            _pixelData[index] = r;
            _pixelData[index + 1] = g;
            _pixelData[index + 2] = b;
            _pixelData[index + 3] = a;
        }

        public Color GetPixel(int x, int y)
        {
            int index = (y * _width + x) * 4;
            return Color.FromArgb(_pixelData[index], _pixelData[index + 1], _pixelData[index + 2], _pixelData[index + 3]);
        }

        /// <summary>
        /// Переводит байтовый буфер в BitMap
        /// </summary>
        /// <returns></returns>
        public Bitmap ToBitmap()
        {
            var bitmap = new Bitmap(_width, _height, PixelFormat.Format32bppArgb);
            var bitmapData = bitmap.LockBits(new Rectangle(0, 0, _width, _height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            try
            {
                Marshal.Copy(_pixelData, 0, bitmapData.Scan0, _pixelData.Length);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            return bitmap;
        }
    }
}
