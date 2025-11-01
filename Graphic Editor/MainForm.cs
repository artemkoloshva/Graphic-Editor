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
        private const ushort MAX_SIZE_IMAGE = 512;
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
        private PixelMode _pixelMode = PixelMode.Single;
        private Button _currentDrawingModdeButton;
        private Button _currentPixelModdeButton;

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
            SetModeButton(singleModeButton, ref _currentPixelModdeButton);
        }

        private void DoubleModeButton_Click(object sender, EventArgs e)
        {
            _pixelMode = PixelMode.Double;
            SetModeButton(doubleModeButton, ref _currentPixelModdeButton);
        }

        private void TripleModeButton_Click(object sender, EventArgs e)
        {
            _pixelMode = PixelMode.Triple;
            SetModeButton(tripleModeButton, ref _currentPixelModdeButton);
        }

        private void QuadrupleModeButton_Click(object sender, EventArgs e)
        {
            _pixelMode = PixelMode.Quadruple;
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

        private void CurveButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Curve;
            SetModeButton(curveButton, ref _currentDrawingModdeButton);
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

        private void PipetteButton_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Pipette;
            SetModeButton(pipetteButton, ref _currentDrawingModdeButton);
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

            _currentDrawingModdeButton = pencilButton;
            _currentPixelModdeButton = singleModeButton;
            _currentDrawingModdeButton.FlatAppearance.BorderColor = Color.Gold;
            _currentDrawingModdeButton.FlatAppearance.BorderSize = CURRENT_MODE_BORDERSIZE;
            _currentPixelModdeButton.FlatAppearance.BorderColor = Color.Gold;
            _currentPixelModdeButton.FlatAppearance.BorderSize = CURRENT_MODE_BORDERSIZE;

            drawPictureBox.Parent = texturePictureBox;
            currentPositionLabel.Visible = false;
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
    }
}
