using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    public partial class MainForm : Form
    {
        private const ushort MAX_SIZE_IMAGE = 256;
        private const ushort DEFULT_HEIGHT = 32;
        private const ushort DEFULT_WIDTH = 32;
        private const byte DEFAULT_COLOR_R = 0;
        private const byte DEFAULT_COLOR_G = 0;
        private const byte DEFAULT_COLOR_B = 0;
        private const byte DEFAULT_COLOR_A = 255;
        private const byte CURRENT_MODE_BORDERSIZE = 2;
        private const byte DEFAULT_MODE_BORDERSIZE = 1;

        private Color _currentColor;
        private DrawingMode _drawingMode = DrawingMode.Pencil;
        private Button _currentDrawingModdeButton;
        private Button _currentPixelModdeButton;
        private Render _render;

        private byte _brushSize = 1;
        private ushort _heightImage;
        private ushort _widthImage;
        private short _hoveredCellX = -1;
        private short _hoveredCellY = -1;
        private float _cellWidth = 0;
        private float _cellHeight = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeDefaultOptions();
            InitializeRender();
            SetCurrentSizeLabel();
            ResizeDrawPictureBox();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            texturePictureBox.Invalidate();
        }

        private void TexturePictureBox_Resize(object sender, EventArgs e)
        {
            texturePictureBox.Invalidate();
        }

        private void DrawPanel_Resize(object sender, EventArgs e)
        {
            ResizeDrawPictureBox();
        }

        private void TexturePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (texturePictureBox.Image != null)
            {
                using (TextureBrush brush = new TextureBrush(texturePictureBox.Image))
                {
                    e.Graphics.FillRectangle(brush, texturePictureBox.ClientRectangle);
                }
            }
        }

        private void DrawPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            SetCurrentPositionLabel(e);

            if (_hoveredCellX >= 0 && _hoveredCellY >= 0 &&
                _hoveredCellX < _widthImage && _hoveredCellY < _heightImage)
            {
                _render.HandleMouseMove(_drawingMode, new Point(_hoveredCellX, _hoveredCellY), _currentColor, _brushSize);
            }
        }

        private void DrawPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            SetCurrentPositionLabel(e);
            _render.HandleMouseDown(_drawingMode, new Point(_hoveredCellX, _hoveredCellY), _currentColor, _brushSize);
        }

        private void DrawPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            SetCurrentPositionLabel(e);
            _render.HandleMouseUp(_drawingMode, new Point(_hoveredCellX, _hoveredCellY), _currentColor, _brushSize);
        }

        private void DrawPictureBox_MouseLeave(object sender, EventArgs e)
        {
            _hoveredCellX = -1;
            _hoveredCellY = -1;

            drawPictureBox.Invalidate();

            currentPositionLabel.Visible = false;
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            if (ushort.TryParse(heightTextBox.Text, out _heightImage) && 
                ushort.TryParse(widthTextBox.Text, out _widthImage) && 
                _heightImage < MAX_SIZE_IMAGE && 
                _widthImage < MAX_SIZE_IMAGE) { }
            else
            {
                _heightImage = DEFULT_HEIGHT;
                _widthImage = DEFULT_WIDTH;

                heightTextBox.Text = DEFULT_HEIGHT.ToString();
                widthTextBox.Text = DEFULT_WIDTH.ToString();

                MessageBox.Show($"Введите корректные числовые значения (0-{MAX_SIZE_IMAGE})");
            }

            InitializeRender();
            ResizeDrawPictureBox();
            SetCurrentSizeLabel();
        }

        private void RecolorButton_Click(object sender, EventArgs e)
        {
            byte r, g, b;

            if (byte.TryParse(rTextBox.Text, out r) && byte.TryParse(gTextBox.Text, out g) && byte.TryParse(bTextBox.Text, out b))
            {
                _currentColor = Color.FromArgb(DEFAULT_COLOR_A, r, g, b);
            }
            else
            {
                _currentColor = Color.FromArgb(DEFAULT_COLOR_A, DEFAULT_COLOR_R, DEFAULT_COLOR_G, DEFAULT_COLOR_B);
                rTextBox.Text = DEFAULT_COLOR_R.ToString();
                gTextBox.Text = DEFAULT_COLOR_G.ToString();
                bTextBox.Text = DEFAULT_COLOR_B.ToString();

                MessageBox.Show("Неверный ввод цвета");
            }

            currentColorPictureBox.BackColor = _currentColor;
        }

        private void SingleModeButton_Click(object sender, EventArgs e)
        {
            _brushSize = 1;
            SetModeButton(singleModeButton, ref _currentPixelModdeButton);
        }

        private void DoubleModeButton_Click(object sender, EventArgs e)
        {
            _brushSize = 2;
            SetModeButton(doubleModeButton, ref _currentPixelModdeButton);
        }

        private void TripleModeButton_Click(object sender, EventArgs e)
        {
            _brushSize = 3;
            SetModeButton(tripleModeButton, ref _currentPixelModdeButton);
        }

        private void QuadrupleModeButton_Click(object sender, EventArgs e)
        {
            _brushSize = 4;
            SetModeButton(quadrupleModeButton, ref _currentPixelModdeButton);
        }

        private void PencilButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Pencil;
            SetModeButton(pencilButton, ref _currentDrawingModdeButton);
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Eraser;
            SetModeButton(eraserButton, ref _currentDrawingModdeButton);
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Fill;
            SetModeButton(fillButton, ref _currentDrawingModdeButton);
        }

        private void FillPatternButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.FillPattern;
            SetModeButton(fillPatternButton, ref _currentDrawingModdeButton);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Line;
            SetModeButton(lineButton, ref _currentDrawingModdeButton);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Rectangle;
            SetModeButton(rectangleButton, ref _currentDrawingModdeButton);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Circle;
            SetModeButton(circleButton, ref _currentDrawingModdeButton);
        }

        private void InitializeDefaultOptions()
        {
            _heightImage = DEFULT_HEIGHT;
            _widthImage = DEFULT_WIDTH;
            widthTextBox.Text = _widthImage.ToString();
            heightTextBox.Text = _heightImage.ToString();

            _currentColor = Color.FromArgb(DEFAULT_COLOR_A, DEFAULT_COLOR_R, DEFAULT_COLOR_G, DEFAULT_COLOR_B);
            rTextBox.Text = DEFAULT_COLOR_R.ToString();
            gTextBox.Text = DEFAULT_COLOR_G.ToString();
            bTextBox.Text = DEFAULT_COLOR_B.ToString();
            currentColorPictureBox.BackColor = _currentColor;

            _currentDrawingModdeButton = pencilButton;
            _currentPixelModdeButton = singleModeButton;
            _currentDrawingModdeButton.FlatAppearance.BorderColor = Color.Gold;
            _currentDrawingModdeButton.FlatAppearance.BorderSize = CURRENT_MODE_BORDERSIZE;
            _currentPixelModdeButton.FlatAppearance.BorderColor = Color.Gold;
            _currentPixelModdeButton.FlatAppearance.BorderSize = CURRENT_MODE_BORDERSIZE;

            drawPictureBox.Parent = texturePictureBox;
            currentPositionLabel.Visible = false;
        }

        private void InitializeRender()
        {
            _render = new Render(_widthImage, _heightImage);

            _render.OnRedrawRequested += (bitmap) =>
            {
                drawPictureBox.Image?.Dispose();

                var scaledBitmap = ScaleBitmap(bitmap, drawPictureBox.Width, drawPictureBox.Height);
                drawPictureBox.Image = scaledBitmap;

                bitmap.Dispose();

                drawPictureBox.Invalidate();
            };

            _render.SetTool(_drawingMode);
        }

        private void ResizeDrawPictureBox()
        {
            float ratioOfTheSidesImage = (float)_heightImage / _widthImage;
            float ratioOfTheSidesPanel = (float)drawPanel.Height / drawPanel.Width;

            if (ratioOfTheSidesImage >= ratioOfTheSidesPanel)
            {
                texturePictureBox.Height = drawPanel.Height;
                texturePictureBox.Width = (int)(texturePictureBox.Height / ratioOfTheSidesImage);
                texturePictureBox.Location = new Point(drawPanel.Width / 2 - texturePictureBox.Width / 2, 0);
            }
            else
            {
                texturePictureBox.Width = drawPanel.Width;
                texturePictureBox.Height = (int)(texturePictureBox.Width * ratioOfTheSidesImage);
                texturePictureBox.Location = new Point(0, drawPanel.Height / 2 - texturePictureBox.Height / 2);
            }

            drawPictureBox.Size = texturePictureBox.Size;
            drawPictureBox.Location = new Point(0, 0);

            if (_widthImage > 0 && _heightImage > 0)
            {
                _cellWidth = (float)drawPictureBox.Width / _widthImage;
                _cellHeight = (float)drawPictureBox.Height / _heightImage;
            }

            drawPictureBox.Invalidate();
            _render?.RequestRedraw();
        }

        private void SetCurrentSizeLabel()
        {
            currentSizeLabel.Text = $"[{_widthImage}x{_heightImage}]";
        }

        private void SetCurrentPositionLabel(MouseEventArgs e)
        {
            short cellX = (short)(e.X / _cellWidth);
            short cellY = (short)(e.Y / _cellHeight);

            if (cellX != _hoveredCellX || cellY != _hoveredCellY ||
                cellX >= _widthImage || cellY >= _heightImage)
            {
                _hoveredCellX = cellX;
                _hoveredCellY = cellY;

                drawPictureBox.Invalidate();

                if (currentPositionLabel.Visible != true)
                {
                    currentPositionLabel.Visible = true;
                }

                currentPositionLabel.Text = $"{_hoveredCellX}:{_hoveredCellY}";
            }
        }

        private void SetModeButton(Button setButton, ref Button currentButton)
        {
            if(setButton != currentButton)
            {
                setButton.FlatAppearance.BorderColor = Color.Gold;
                setButton.FlatAppearance.BorderSize = CURRENT_MODE_BORDERSIZE;

                currentButton.FlatAppearance.BorderColor = Color.Black;
                currentButton.FlatAppearance.BorderSize = DEFAULT_MODE_BORDERSIZE;

                currentButton = setButton;
            }
        }

        private Bitmap ScaleBitmap(Bitmap original, int newWidth, int newHeight)
        {
            var scaled = new Bitmap(newWidth, newHeight);
            using (var g = System.Drawing.Graphics.FromImage(scaled))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.DrawImage(original, 0, 0, newWidth, newHeight);
            }
            return scaled;
        }
    }
}
