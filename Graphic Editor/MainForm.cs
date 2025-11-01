using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    public partial class MainForm : Form
    {
        private const ushort MAX_SIZE_IMAGE = 513;
        private const ushort DEFULT_HEIGHT = 32;
        private const ushort DEFULT_WIDTH = 32;
        private const byte DEFAULT_COLOR_R = 0;
        private const byte DEFAULT_COLOR_G = 0;
        private const byte DEFAULT_COLOR_B = 0;
        private const byte DEFAULT_COLOR_A = 255;

        private Color _currentColor;
        private DrawingMode _drawingMode = DrawingMode.Pencil;
        private PixelMode _pixelMode = PixelMode.Single;

        private ushort _heightImage;
        private ushort _widthImage;
        private float _cellWidth = 0;
        private float _cellHeight = 0;
        private short _hoveredCellX = -1;
        private short _hoveredCellY = -1;

        public MainForm()
        {
            InitializeComponent();
            InitializeDefaultOptions();

            drawPictureBox.Parent = texturePictureBox;
            currentPositionLabel.Visible = false;
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

        private void DrawPictureBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrawPictureBox_MouseMove(object sender, MouseEventArgs e)
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

                SetCurrentPositionLabel();
            }
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

            ResizeDrawPictureBox();
            SetCurrentSizeLabel();
        }

        private void SingleModeButton_Click(object sender, EventArgs e)
        {
            _pixelMode = PixelMode.Single;
        }

        private void DoubleModeButton_Click(object sender, EventArgs e)
        {
            _pixelMode = PixelMode.Double;
        }

        private void TripleModeButton_Click(object sender, EventArgs e)
        {
            _pixelMode = PixelMode.Triple;
        }

        private void QuadrupleModeButton_Click(object sender, EventArgs e)
        {
            _pixelMode = PixelMode.Quadruple;
        }

        private void PencilButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Pencil;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Eraser;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Fill;
        }

        private void FillPatternButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.FillPattern;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Line;
        }

        private void CurveButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Curve;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Rectangle;
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Circle;
        }

        private void PipetteButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Pipette;
        }

        private void InitializeDefaultOptions()
        {
            _heightImage = DEFULT_HEIGHT;
            _widthImage = DEFULT_WIDTH;
            widthTextBox.Text = _widthImage.ToString();
            heightTextBox.Text = _heightImage.ToString();

            gridCheckBox.Checked = false;

            _currentColor = Color.FromArgb(DEFAULT_COLOR_A, DEFAULT_COLOR_R, DEFAULT_COLOR_G, DEFAULT_COLOR_B);
            rTextBox.Text = DEFAULT_COLOR_R.ToString();
            gTextBox.Text = DEFAULT_COLOR_G.ToString();
            bTextBox.Text = DEFAULT_COLOR_B.ToString();
            hexTextBox.Text = ColorTranslator.ToHtml(_currentColor);

            currentColorPictureBox.BackColor = _currentColor;

            SetCurrentSizeLabel();
        }

        private void ResizeDrawPictureBox()
        {
            float ratioOfTheSides = (float)_heightImage / _widthImage;

            if (ratioOfTheSides >= 1)
            {
                texturePictureBox.Height = drawPanel.Height;
                texturePictureBox.Width = (int)(texturePictureBox.Height / ratioOfTheSides);
                texturePictureBox.Location = new Point(drawPanel.Width / 2 - texturePictureBox.Width / 2, 0);
            }
            else
            {
                texturePictureBox.Width = drawPanel.Width;
                texturePictureBox.Height = (int)(texturePictureBox.Width * ratioOfTheSides);
                texturePictureBox.Location = new Point(0, drawPanel.Height / 2 - texturePictureBox.Height / 2);
            }

            if (_widthImage > 0 && _heightImage > 0)
            {
                _cellWidth = (float)drawPictureBox.Width / _widthImage;
                _cellHeight = (float)drawPictureBox.Height / _heightImage;
            }

            drawPictureBox.Invalidate();
        } 

        private void SetCurrentSizeLabel()
        {
            currentSizeLabel.Text = $"[{_widthImage}x{_heightImage}]";
        }

        private void SetCurrentPositionLabel()
        {
            currentPositionLabel.Text = $"{_hoveredCellX}:{_hoveredCellY}";
        }
    }
}
