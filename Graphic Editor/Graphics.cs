using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

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
        public static void SetPixel(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {
            int minX = Math.Max(0, point.X - brushSize / 2);
            int maxX = Math.Min(buffer.Width - 1, point.X + brushSize / 2);
            int minY = Math.Max(0, point.Y - brushSize / 2);
            int maxY = Math.Min(buffer.Height - 1, point.Y + brushSize / 2);

            for (int x = minX; x <= maxX; x++)
            {
                for (int y = minY; y <= maxY; y++)
                {
                    buffer.SetPixel(x, y, color);
                }
            }
        }

        /// <summary>
        /// Удаление пикселя по кординатам
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void DeletePixel(ByteGraphicsBuffer buffer, Point point, int brushSize)
        {
            int minX = Math.Max(0, point.X - brushSize / 2);
            int maxX = Math.Min(buffer.Width - 1, point.X + brushSize / 2);
            int minY = Math.Max(0, point.Y - brushSize / 2);
            int maxY = Math.Min(buffer.Height - 1, point.Y + brushSize / 2);

            for (int x = minX; x <= maxX; x++)
            {
                for (int y = minY; y <= maxY; y++)
                {
                    buffer.SetPixel(x, y, 0, 0, 0, 0);
                }
            }
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
        public static void DrawLine(ByteGraphicsBuffer buffer, Point pointStart, Point pointEnd, Color color, int brushSize)
        {
            DrawLineBresenham(buffer, pointStart, pointEnd, color, brushSize);
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
        public static void DrawLineBresenham(ByteGraphicsBuffer buffer, Point pointStart, Point pointEnd, Color color, int brushSize)
        {
            int dx = Math.Abs(pointEnd.X - pointStart.X);
            int dy = Math.Abs(pointEnd.Y - pointStart.Y);

            int sx = (pointStart.X < pointEnd.X) ? 1 : -1;
            int sy = (pointStart.Y < pointEnd.Y) ? 1 : -1;

            int err = dx - dy;

            while (true)
            {
                SetPixel(buffer, pointStart, color, brushSize);

                if (pointStart.X == pointEnd.X && pointStart.Y == pointEnd.Y)
                    break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    pointStart.X += sx;
                }

                if (e2 < dx)
                {
                    err += dx;
                    pointStart.Y += sy;
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
        public static void DrawLineDDASmooth(ByteGraphicsBuffer buffer, Point pointStart, Point pointEnd, Color color, int brushSize)
        {
            int dx = pointEnd.X - pointStart.X;
            int dy = pointEnd.Y - pointStart.Y;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            if (steps == 0)
            {
                buffer.SetPixel(pointStart.X, pointStart.Y, color);
                return;
            }

            double xIncrement = (double)dx / steps;
            double yIncrement = (double)dy / steps;

            double x = pointStart.X + 0.5;
            double y = pointStart.Y + 0.5;

            for (int i = 0; i <= steps; i++)
            {
                SetPixel(buffer, new Point((int)x, (int)y), color, brushSize);
                x += xIncrement;
                y += yIncrement;
            }
        }

        /// <summary>
        /// Отрисовывает прямоугольник по двум крайним точкам
        /// </summary>
        public static void DrawRectangle(ByteGraphicsBuffer buffer, Point pointStart, Point pointEnd, Color color, int brushSize)
        {
            int left = Math.Min(pointStart.X, pointEnd.X);
            int right = Math.Max(pointStart.X, pointEnd.X);
            int top = Math.Min(pointStart.Y, pointEnd.Y);
            int bottom = Math.Max(pointStart.Y, pointEnd.Y);

            for (int x = left; x <= right; x++)
            {
                SetPixel(buffer, new Point(x, top), color, brushSize);
                SetPixel(buffer, new Point(x, bottom), color, brushSize);
            }

            for (int y = top + 1; y < bottom; y++)
            {
                SetPixel(buffer, new Point(left, y), color, brushSize);
                SetPixel(buffer, new Point(right, y), color, brushSize);
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
        public static void DrawCircle(ByteGraphicsBuffer buffer, Point pointStart, Point pointEnd, Color color, int brushSize)
        {
            int centerX = (pointStart.X + pointEnd.X) / 2;
            int centerY = (pointStart.Y + pointEnd.Y) / 2;
            int width = Math.Abs(pointEnd.X - pointStart.X);
            int height = Math.Abs(pointEnd.Y - pointStart.Y);
            int radius = Math.Min(width, height) / 2;

            int x0 = 0;
            int y0 = radius;
            int delta = 2 - 2 * radius;
            int error = 0;

            while (y0 >= 0)
            {
                SetPixel(buffer, new Point(centerX + x0, centerY + y0), color, brushSize);
                SetPixel(buffer, new Point(centerX + x0, centerY - y0), color, brushSize);
                SetPixel(buffer, new Point(centerX - x0, centerY + y0), color, brushSize);
                SetPixel(buffer, new Point(centerX - x0, centerY - y0), color, brushSize);

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
        public static void FillScanline(ByteGraphicsBuffer buffer, Point point, Color fillColor)
        {
            Color targetColor = buffer.GetPixel(point.X, point.Y);
            if (targetColor.ToArgb() == fillColor.ToArgb()) return;

            var stack = new Stack<Point>();
            stack.Push(point);

            while (stack.Count > 0)
            {
                Point pointStack = stack.Pop();
                int py = pointStack.Y;
                int px = pointStack.X;

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
        public static void FillPattern(ByteGraphicsBuffer buffer, Point point, Color[,] pattern)
        {
            Color targetColor = buffer.GetPixel(point.X, point.Y);

            var stack = new Stack<Point>();
            stack.Push(point);

            int patternWidth = pattern.GetLength(0);
            int patternHeight = pattern.GetLength(1);

            while (stack.Count > 0)
            {
                Point pointStack = stack.Pop();
                int px = pointStack.X;
                int py = pointStack.Y;

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
