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
        private ushort _height;
        private ushort _width;
        private Color _color;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            drawPictureBox.Invalidate();
        }

        private void DrawPictureBox_Resize(object sender, EventArgs e)
        {
            drawPictureBox.Invalidate();
        }

        private void DrawPictureBox_PaintTexture(object sender, PaintEventArgs e)
        {
            if (drawPictureBox.Image != null)
            {
                using (TextureBrush brush = new TextureBrush(drawPictureBox.Image))
                {
                    e.Graphics.FillRectangle(brush, drawPictureBox.ClientRectangle);
                }
            }
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
