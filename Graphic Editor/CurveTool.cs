using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    internal class CurveTool : ITool
    {
        private DrawingMode _mode;

        public DrawingMode Mode { get; }

        public CurveTool()
        {
            Mode = DrawingMode.Curve;
        }

        public void OnMouseDown(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize)
        {

        }

        public void OnMouseMove(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize)
        {

        }

        public void OnMouseUp(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize)
        {

        }
    }
}
