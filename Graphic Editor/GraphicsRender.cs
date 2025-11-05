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
    internal static class GraphicsRender
    {
        public static void SetPixel(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {
            int half = brushSize / 2;
            int minX = Math.Max(0, point.X - half);
            int minY = Math.Max(0, point.Y - half);
            int maxX = Math.Min(buffer.Width - 1, minX + brushSize - 1);
            int maxY = Math.Min(buffer.Height - 1, minY + brushSize - 1);

            for (int x = minX; x <= maxX; x++)
            {
                for (int y = minY; y <= maxY; y++)
                {
                    buffer.SetPixel(x, y, color);
                }
            }
        }

        public static void DeletePixel(ByteGraphicsBuffer buffer, Point point, int brushSize)
        {
            int half = brushSize / 2;
            int minX = Math.Max(0, point.X - half);
            int minY = Math.Max(0, point.Y - half);
            int maxX = Math.Min(buffer.Width - 1, minX + brushSize - 1);
            int maxY = Math.Min(buffer.Height - 1, minY + brushSize - 1);

            for (int x = minX; x <= maxX; x++)
            {
                for (int y = minY; y <= maxY; y++)
                {
                    buffer.SetPixel(x, y, 0, 0, 0, 0);
                }
            }
        }

        public static void DrawLine(ByteGraphicsBuffer buffer, Point pointStart, Point pointEnd, Color color, int brushSize)
        {
            DrawLineBresenham(buffer, pointStart, pointEnd, color, brushSize);
        }

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

        public static void DrawLineWu(ByteGraphicsBuffer buffer, Point pointStart, Point pointEnd, Color color, int brushSize)
        {
            int x0 = pointStart.X, y0 = pointStart.Y;
            int x1 = pointEnd.X, y1 = pointEnd.Y;

            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);

            if (steep)
            {
                (x0, y0) = (y0, x0);
                (x1, y1) = (y1, x1);
            }

            if (x0 > x1)
            {
                (x0, x1) = (x1, x0);
                (y0, y1) = (y1, y0);
            }

            float dx = x1 - x0;
            float dy = y1 - y0;
            float gradient = dx == 0 ? 1 : dy / dx;

            float y = y0;
            for (int x = x0; x <= x1; x++)
            {
                if (steep)
                {
                    DrawWuPixel(buffer, new Point((int)y, x), color, 1 - (y - (int)y), brushSize);
                    DrawWuPixel(buffer, new Point((int)y + 1, x), color, y - (int)y, brushSize);
                }
                else
                {
                    DrawWuPixel(buffer, new Point(x, (int)y), color, 1 - (y - (int)y), brushSize);
                    DrawWuPixel(buffer, new Point(x, (int)y + 1), color, y - (int)y, brushSize);
                }
                y += gradient;
            }
        }

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

        public static void DrawCircleBresenham(ByteGraphicsBuffer buffer, Point pointStart, Point pointEnd, Color color, int brushSize)
        {
            int centerX = (pointStart.X + pointEnd.X) / 2;
            int centerY = (pointStart.Y + pointEnd.Y) / 2;
            int width = Math.Abs(pointEnd.X - pointStart.X);
            int height = Math.Abs(pointEnd.Y - pointStart.Y);
            int radius = Math.Min(width, height) / 2;

            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            while (x <= y)
            {
                SetPixel(buffer, new Point(centerX + x, centerY + y), color, brushSize);
                SetPixel(buffer, new Point(centerX - x, centerY + y), color, brushSize);
                SetPixel(buffer, new Point(centerX + x, centerY - y), color, brushSize);
                SetPixel(buffer, new Point(centerX - x, centerY - y), color, brushSize);
                SetPixel(buffer, new Point(centerX + y, centerY + x), color, brushSize);
                SetPixel(buffer, new Point(centerX - y, centerY + x), color, brushSize);
                SetPixel(buffer, new Point(centerX + y, centerY - x), color, brushSize);
                SetPixel(buffer, new Point(centerX - y, centerY - x), color, brushSize);

                if (d <= 0)
                {
                    d = d + 4 * x + 6;
                }
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }
        }

        public static void FillScanline(ByteGraphicsBuffer buffer, Point point, Color fillColor)
        {
            Color targetColor = buffer.GetPixel(point.X, point.Y);

            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            var stack = new Stack<Point>();
            stack.Push(point);

            while (stack.Count > 0)
            {
                Point current = stack.Pop();
                int x = current.X;
                int y = current.Y;

                if (x < 0 || x >= buffer.Width || y < 0 || y >= buffer.Height)
                    continue;

                if (buffer.GetPixel(x, y).ToArgb() != targetColor.ToArgb())
                    continue;

                int left = x;
                while (left > 0 && buffer.GetPixel(left - 1, y).ToArgb() == targetColor.ToArgb())
                    left--;

                int right = x;
                while (right < buffer.Width - 1 && buffer.GetPixel(right + 1, y).ToArgb() == targetColor.ToArgb())
                    right++;

                for (int i = left; i <= right; i++)
                    buffer.SetPixel(i, y, fillColor);

                for (int row = y - 1; row <= y + 1; row += 2)
                {
                    if (row < 0 || row >= buffer.Height)
                        continue;

                    int scanLeft = left;
                    while (scanLeft <= right)
                    {
                        while (scanLeft <= right && buffer.GetPixel(scanLeft, row).ToArgb() != targetColor.ToArgb())
                            scanLeft++;

                        if (scanLeft > right) break;

                        int segmentRight = scanLeft;
                        while (segmentRight <= right && buffer.GetPixel(segmentRight, row).ToArgb() == targetColor.ToArgb())
                            segmentRight++;

                        if (segmentRight > scanLeft)
                        {
                            stack.Push(new Point(scanLeft, row));
                            scanLeft = segmentRight;
                        }
                    }
                }
            }
        }

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

        public static void CopyBuffer(ByteGraphicsBuffer src, ByteGraphicsBuffer dest)
        {
            if (src.Width != dest.Width || src.Height != dest.Height)
                throw new ArgumentException("Размеры буферов не совпадают.");

            Array.Copy(src.PixelData, dest.PixelData, src.PixelData.Length);
        }

        private static void DrawWuPixel(ByteGraphicsBuffer buffer, Point point, Color color, float brightness, int brushSize)
        {
            var alphaColor = Color.FromArgb((int)(color.A * brightness), color.R, color.G, color.B);
            SetPixel(buffer, point, alphaColor, brushSize);
        }
    }
}
