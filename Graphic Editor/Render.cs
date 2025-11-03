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
        private DateTime _lastRedraw = DateTime.MinValue;
        private ITool[] _tools;
        private ITool _currentTool;
        private bool _isDrawing;

        public event Action<Bitmap> OnRedrawRequested;

        public ByteGraphicsBuffer Buffer { get { return this._buffer; } }

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
            _isDrawing = false;
        }

        public void HandleMouseDown(DrawingMode mode, Point point, Color color, int brushSize)
        {
            _isDrawing = true;
            SetTool(mode);
            _currentTool.OnMouseDown(_buffer, point, color, brushSize);
            RequestRedraw();
        }

        public void HandleMouseMove(DrawingMode mode, Point point, Color color, int brushSize)
        {
            if (_isDrawing)
            {
                SetTool(mode);
                _currentTool.OnMouseMove(_buffer, point, color, brushSize);

                var now = DateTime.Now;
                if ((now - _lastRedraw).TotalMilliseconds > 16)
                {
                    _lastRedraw = now;
                    RequestRedraw();
                }
            }
        }

        public void HandleMouseUp(DrawingMode mode, Point point, Color color, int brushSize)
        {
            _isDrawing = false;
            SetTool(mode);
            _currentTool.OnMouseUp(_buffer, point, color, brushSize);
            RequestRedraw();
        }

        public void SetTool(DrawingMode mode)
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

        public void RequestRedraw()
        {
            OnRedrawRequested?.Invoke(_buffer.ToBitmap());
        }
    }
}
