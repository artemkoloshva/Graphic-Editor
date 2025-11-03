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
        private byte[] _pixelData; // pixelData хранит данные о пикселях в виде [A, R, G, B, A, R, G ...]

        private int _width;
        private int _height;

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        public ByteGraphicsBuffer(int width, int height)
        {
            this._width = width;
            this._height = height;

            _pixelData = new byte[width * height * 4];
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
            _pixelData[index] = color.A;
            _pixelData[index + 1] = color.R;
            _pixelData[index + 2] = color.G;
            _pixelData[index + 3] = color.B;
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
            _pixelData[index] = a;
            _pixelData[index + 1] = r;
            _pixelData[index + 2] = g;
            _pixelData[index + 3] = b;
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
                // Переставляем из [A,R,G,B] в [B,G,R,A]
                byte[] bmpBytes = new byte[_pixelData.Length];
                for (int i = 0; i < _width * _height; i++)
                {
                    int src = i * 4;
                    byte a = _pixelData[src + 0];
                    byte r = _pixelData[src + 1];
                    byte g = _pixelData[src + 2];
                    byte b = _pixelData[src + 3];

                    int dst = i * 4;
                    bmpBytes[dst + 0] = b;
                    bmpBytes[dst + 1] = g;
                    bmpBytes[dst + 2] = r;
                    bmpBytes[dst + 3] = a;
                }

                Marshal.Copy(bmpBytes, 0, bitmapData.Scan0, bmpBytes.Length);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            return bitmap;
        }

    }
}
