using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    internal interface ITool
    {
        DrawingMode Mode { get; }

        void OnMouseDown(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize);

        void OnMouseMove(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize);

        void OnMouseUp(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize);
    }
}
