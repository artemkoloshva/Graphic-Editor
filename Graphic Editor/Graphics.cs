using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic_Editor
{
    internal static class Graphics
    {
        /// <summary>
        /// Изменяет цвет пикселя на кординатах (x, y)
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        public static void SetPixel(ByteGraphicsBuffer buffer, Point point, Color color)
        {
            buffer.SetPixel(point.X, point.Y, color);
        }

        /// <summary>
        /// Удаление пикселя по кординатам
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void DeletePixel(ByteGraphicsBuffer buffer, Point point)
        {
            buffer.SetPixel(point.X, point.Y, 0, 0, 0, 0);
        }

        /// <summary>
        /// Отрисовывает прямую линию по дефолту
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="color"></param>
        public static void DrawLine(ByteGraphicsBuffer buffer, int x0, int y0, int x1, int y1, Color color)
        {
            DrawLineBresenham(buffer, x0, y0, x1, y1, color);
        }

        /// <summary>
        /// Отрисовывает прямую линию по алгоритму Брезенхема
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="color"></param>
        public static void DrawLineBresenham(ByteGraphicsBuffer buffer, int x0, int y0, int x1, int y1, Color color)
        {
            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);

            int sx = (x0 < x1) ? 1 : -1;
            int sy = (y0 < y1) ? 1 : -1;

            int err = dx - dy;

            while (true)
            {
                buffer.SetPixel(x0, y0, color);

                if (x0 == x1 && y0 == y1)
                    break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }
        }

        /// <summary>
        /// Отрисовывает прямую линию по естественному алгоритму
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="color"></param>
        public static void DrawLineDDASmooth(ByteGraphicsBuffer buffer, int x0, int y0, int x1, int y1, Color color)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            if (steps == 0)
            {
                buffer.SetPixel(x0, y0, color);
                return;
            }

            double xIncrement = (double)dx / steps;
            double yIncrement = (double)dy / steps;

            double x = x0 + 0.5;
            double y = y0 + 0.5;

            for (int i = 0; i <= steps; i++)
            {
                buffer.SetPixel((int)x, (int)y, color);
                x += xIncrement;
                y += yIncrement;
            }
        }

        /// <summary>
        /// Отрисовывает прямоугольник по двум крайним точкам
        /// </summary>
        public static void DrawRectangle(ByteGraphicsBuffer buffer, int x0, int y0, int x1, int y1, Color color)
        {
            int left = Math.Min(x0, x1);
            int right = Math.Max(x0, x1);
            int top = Math.Min(y0, y1);
            int bottom = Math.Max(y0, y1);

            for (int x = left; x <= right; x++)
            {
                buffer.SetPixel(x, top, color);    
                buffer.SetPixel(x, bottom, color); 
            }

            for (int y = top + 1; y < bottom; y++)
            {
                buffer.SetPixel(left, y, color); 
                buffer.SetPixel(right, y, color);
            }
        }

        /// <summary>
        /// Отрисовывает окружность по алгоритму Брезенхема
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="color"></param>
        public static void DrawCircle(ByteGraphicsBuffer buffer, int x, int y, int x1, int y1, Color color)
        {
            int centerX = (x + x1) / 2;
            int centerY = (y + y1) / 2;
            int width = Math.Abs(x1 - x);
            int height = Math.Abs(y1 - y);
            int radius = Math.Min(width, height) / 2;

            int x0 = 0;
            int y0 = radius;
            int delta = 2 - 2 * radius;
            int error = 0;

            while (y0 >= 0)
            {
                buffer.SetPixel(centerX + x0, centerY + y0, color);
                buffer.SetPixel(centerX + x0, centerY - y0, color);
                buffer.SetPixel(centerX - x0, centerY + y0, color);
                buffer.SetPixel(centerX - x0, centerY - y0, color);

                error = 2 * (delta + y0) - 1;

                if (delta < 0 && error <= 0)
                {
                    x0++;
                    delta += 2 * x0 + 1;
                    continue;
                }

                error = 2 * (delta - x0) - 1;

                if (delta > 0 && error > 0)
                {
                    y0--;
                    delta += 1 - 2 * y0;
                    continue;
                }

                x0++;
                delta += 2 * (x0 - y0);
                y0--;
            }
        }

        /// <summary>
        /// Закрашивает отбласть построчным алгоритмом
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="fillColor"></param>
        public static void ScanlineFill(ByteGraphicsBuffer buffer, int x, int y, Color fillColor)
        {
            Color targetColor = buffer.GetPixel(x, y);
            if (targetColor.ToArgb() == fillColor.ToArgb()) return;

            var stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                Point point = stack.Pop();
                int py = point.Y;
                int px = point.X;

                int left = px;
                while (left >= 0 && buffer.GetPixel(left, py).ToArgb() == targetColor.ToArgb())
                    left--;
                left++;

                int right = px;
                while (right < buffer.Width && buffer.GetPixel(right, py).ToArgb() == targetColor.ToArgb())
                    right++;

                for (int i = left; i < right; i++)
                    buffer.SetPixel(i, py, fillColor);

                for (int row = py - 1; row <= py + 1; row += 2)
                {
                    if (row < 0 || row >= buffer.Height) continue;

                    for (int i = left; i < right; i++)
                    {
                        if (buffer.GetPixel(i, row).ToArgb() == targetColor.ToArgb())
                        {
                            stack.Push(new Point(i, row));
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Закрашивает область определенным узором
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="pattern"></param>
        public static void PatternFill(ByteGraphicsBuffer buffer, int x, int y, Color[,] pattern)
        {
            Color targetColor = buffer.GetPixel(x, y);

            var stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            int patternWidth = pattern.GetLength(0);
            int patternHeight = pattern.GetLength(1);

            while (stack.Count > 0)
            {
                Point point = stack.Pop();
                int px = point.X;
                int py = point.Y;

                if (px < 0 || px >= buffer.Width || py < 0 || py >= buffer.Height) continue;
                if (buffer.GetPixel(px, py).ToArgb() != targetColor.ToArgb()) continue;

                Color patternColor = pattern[px % patternWidth, py % patternHeight];
                buffer.SetPixel(px, py, patternColor);

                stack.Push(new Point(px + 1, py));
                stack.Push(new Point(px - 1, py));
                stack.Push(new Point(px, py + 1));
                stack.Push(new Point(px, py - 1));
            }
        }
    }
}
