using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    internal class FillPatternTool : ITool
    {
        private DrawingMode _mode;

        public DrawingMode Mode { get; }

        public FillPatternTool()
        {
            Mode = DrawingMode.FillPattern;
        }

        public void OnMouseDown(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {
            GraphicsRender.FillPattern
            (
                buffer, 
                point, 
                new Color[2, 2] { { color, Color.Pink},{ Color.Pink, color } }
            );
        }

        public void OnMouseMove(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {

        }

        public void OnMouseUp(ByteGraphicsBuffer buffer, Point point, Color color, int brushSize)
        {

        }
    }
}
