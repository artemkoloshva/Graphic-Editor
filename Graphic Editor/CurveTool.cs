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

        public void OnMouseDown(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {

        }

        public void OnMouseMove(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {

        }

        public void OnMouseUp(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {

        }
    }
}
