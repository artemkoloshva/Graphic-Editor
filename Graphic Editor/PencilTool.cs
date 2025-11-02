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

        public void OnMouseDown(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize)
        {
            Graphics.SetPixel(buffer, e.Location, color, brushSize);
        }

        public void OnMouseMove(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize) 
        { 

        }

        public void OnMouseUp(MouseEventArgs e, ByteGraphicsBuffer buffer, Color color, int brushSize)
        {

        }
    }
}
