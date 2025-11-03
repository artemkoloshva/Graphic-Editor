using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    internal class RectangleTool : ITool
    {
        public DrawingMode Mode { get; } = DrawingMode.Rectangle;

        private Point? _startPoint = null;

        public void OnMouseDown(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {
            _startPoint = point;
        }

        public void OnMouseMove(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {
            if (!_startPoint.HasValue) return;

            var tempBuffer = new ByteGraphicsBuffer(buffer.Width, buffer.Height);
            GraphicsRender.CopyBuffer(buffer, tempBuffer);

            GraphicsRender.DrawRectangle(tempBuffer, _startPoint.Value, point, color, brushSize);

            buffer.RenderPreview(tempBuffer.ToBitmap());
        }

        public void OnMouseUp(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {
            if (!_startPoint.HasValue) return;

            GraphicsRender.DrawRectangle(buffer, _startPoint.Value, point, color, brushSize);
            buffer.RenderPreview(null);
            _startPoint = null;
        }
    }

}
