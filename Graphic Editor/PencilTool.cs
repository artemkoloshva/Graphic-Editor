using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    internal class PencilTool : ITool
    {
        private DrawingMode _mode;

        public DrawingMode Mode { get; }

        public PencilTool() 
        { 
            Mode = DrawingMode.Pencil;
        }

        public void OnMouseDown(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {
            Graphics.SetPixel(buffer, point, color, brushSize);
        }

        public void OnMouseMove(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize) 
        { 
            Graphics.SetPixel(buffer, point, color, brushSize);
        }

        public void OnMouseUp(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {

        }
    }
}
