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
        private ITool[] _tools;
        private ITool _currentTool;

        public Render(int width, int height)
        {
            _buffer = new ByteGraphicsBuffer(width, height);

            _tools = new ITool[9]
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

            _currentTool = _tools[0];
        }

        public void HandleMouseDown(MouseEventArgs e, DrawingMode mode, Color color, int brushSize)
        {
            SetTool(mode);
            _currentTool.OnMouseDown(_buffer, color, brushSize);
        }

        public void HandleMouseMove(MouseEventArgs e, DrawingMode mode, Color color, int brushSize)
        {
            SetTool(mode);
            _currentTool.OnMouseMove(_buffer, color, brushSize);
        }

        public void HandleMouseUp(MouseEventArgs e, DrawingMode mode, Color color, int brushSize)
        {
            SetTool(mode);
            _currentTool.OnMouseUp(_buffer, color, brushSize);
        }

        private void SetTool(DrawingMode mode)
        {
            if (!_currentTool.Mode.Equals(mode))
            {
                foreach (ITool tool in _tools)
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
