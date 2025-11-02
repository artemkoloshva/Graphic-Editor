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

        void OnMouseDown(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize);

        void OnMouseMove(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize);

        void OnMouseUp(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize);
    }
}
