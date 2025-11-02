using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    internal class Render
    {
        private ByteGraphicsBuffer _buffer;
        private ITool[] tools;
        private ITool _currentTool;

        public Render(int width, int height)
        {
            _buffer = new ByteGraphicsBuffer(width, height);

            tools = new ITool[9]
            {
                new PencilTool(),
                new EraserTool(),
                new FillTool(),
                new FillPatternTool(),
                new CircleTool(),
                new RectangleTool(),
                new LineTool(),
                new CurveTool(),
                new PipetteTool()
            };

            _currentTool = tools[0];
        }

        public void HandleMouseDown(MouseEventArgs e, DrawingMode mode, Color color, int brushSize)
        {
            SetTool(mode);
            _currentTool.OnMouseDown(e, _buffer, color, brushSize);
        }

        public void HandleMouseMove(MouseEventArgs e, DrawingMode mode, Color color, int brushSize)
        {
            SetTool(mode);
            _currentTool.OnMouseMove(e, _buffer, color, brushSize);
        }

        public void HandleMouseUp(MouseEventArgs e, DrawingMode mode, Color color, int brushSize)
        {
            SetTool(mode);
            _currentTool.OnMouseUp(e, _buffer, color, brushSize);
        }

        private void SetTool(DrawingMode mode)
        {
            if (!_currentTool.Mode.Equals(mode))
            {
                foreach (ITool tool in tools)
                {
                    if (tool.Mode.Equals(mode))
                    {
                        _currentTool = tool;
                    }
                }
            }
        }
    }
}
