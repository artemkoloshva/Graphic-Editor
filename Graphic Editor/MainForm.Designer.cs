namespace Graphic_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.quadrupleModeButton = new System.Windows.Forms.Button();
            this.tripleModeButton = new System.Windows.Forms.Button();
            this.doubleModeButton = new System.Windows.Forms.Button();
            this.singleModeButton = new System.Windows.Forms.Button();
            this.pipetteButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.curveButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.fillPatternButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.pencilButton = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.hexLabel = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.gTextBox = new System.Windows.Forms.TextBox();
            this.gLabel = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.rLabel = new System.Windows.Forms.Label();
            this.currentColorPictureBox = new System.Windows.Forms.PictureBox();
            this.removeColorPictureBox = new System.Windows.Forms.PictureBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.currentSizeLabel = new System.Windows.Forms.Label();
            this.resizeButton = new System.Windows.Forms.Button();
            this.pxLabel2 = new System.Windows.Forms.Label();
            this.pxLabel1 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.drawPictureBox = new System.Windows.Forms.PictureBox();
            this.texturePictureBox = new System.Windows.Forms.PictureBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.createNewPictureButton = new System.Windows.Forms.Button();
            this.pictureNameLabel = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeColorPictureBox)).BeginInit();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturePictureBox)).BeginInit();
            this.namePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelLeft.Controls.Add(this.quadrupleModeButton);
            this.panelLeft.Controls.Add(this.tripleModeButton);
            this.panelLeft.Controls.Add(this.doubleModeButton);
            this.panelLeft.Controls.Add(this.singleModeButton);
            this.panelLeft.Controls.Add(this.pipetteButton);
            this.panelLeft.Controls.Add(this.circleButton);
            this.panelLeft.Controls.Add(this.rectangleButton);
            this.panelLeft.Controls.Add(this.curveButton);
            this.panelLeft.Controls.Add(this.lineButton);
            this.panelLeft.Controls.Add(this.fillPatternButton);
            this.panelLeft.Controls.Add(this.fillButton);
            this.panelLeft.Controls.Add(this.eraserButton);
            this.panelLeft.Controls.Add(this.pencilButton);
            this.panelLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(400, 980);
            this.panelLeft.TabIndex = 1;
            // 
            // quadrupleModeButton
            // 
            this.quadrupleModeButton.BackgroundImage = global::Graphic_Editor.Properties.Resources._4;
            this.quadrupleModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quadrupleModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quadrupleModeButton.Location = new System.Drawing.Point(240, 125);
            this.quadrupleModeButton.Name = "quadrupleModeButton";
            this.quadrupleModeButton.Size = new System.Drawing.Size(35, 35);
            this.quadrupleModeButton.TabIndex = 12;
            this.quadrupleModeButton.UseVisualStyleBackColor = true;
            this.quadrupleModeButton.Click += new System.EventHandler(this.QuadrupleModeButton_Click);
            // 
            // tripleModeButton
            // 
            this.tripleModeButton.BackgroundImage = global::Graphic_Editor.Properties.Resources._3;
            this.tripleModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tripleModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tripleModeButton.Location = new System.Drawing.Point(199, 125);
            this.tripleModeButton.Name = "tripleModeButton";
            this.tripleModeButton.Size = new System.Drawing.Size(35, 35);
            this.tripleModeButton.TabIndex = 11;
            this.tripleModeButton.UseVisualStyleBackColor = true;
            this.tripleModeButton.Click += new System.EventHandler(this.TripleModeButton_Click);
            // 
            // doubleModeButton
            // 
            this.doubleModeButton.BackgroundImage = global::Graphic_Editor.Properties.Resources._2;
            this.doubleModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doubleModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubleModeButton.Location = new System.Drawing.Point(158, 125);
            this.doubleModeButton.Name = "doubleModeButton";
            this.doubleModeButton.Size = new System.Drawing.Size(35, 35);
            this.doubleModeButton.TabIndex = 10;
            this.doubleModeButton.UseVisualStyleBackColor = true;
            this.doubleModeButton.Click += new System.EventHandler(this.DoubleModeButton_Click);
            // 
            // singleModeButton
            // 
            this.singleModeButton.BackgroundImage = global::Graphic_Editor.Properties.Resources._1;
            this.singleModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.singleModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleModeButton.Location = new System.Drawing.Point(117, 125);
            this.singleModeButton.Name = "singleModeButton";
            this.singleModeButton.Size = new System.Drawing.Size(35, 35);
            this.singleModeButton.TabIndex = 9;
            this.singleModeButton.UseVisualStyleBackColor = true;
            this.singleModeButton.Click += new System.EventHandler(this.SingleModeButton_Click);
            // 
            // pipetteButton
            // 
            this.pipetteButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.copyСolor;
            this.pipetteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipetteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipetteButton.Location = new System.Drawing.Point(132, 772);
            this.pipetteButton.Margin = new System.Windows.Forms.Padding(10);
            this.pipetteButton.Name = "pipetteButton";
            this.pipetteButton.Size = new System.Drawing.Size(125, 125);
            this.pipetteButton.TabIndex = 8;
            this.pipetteButton.UseVisualStyleBackColor = true;
            this.pipetteButton.Click += new System.EventHandler(this.PipetteButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.circle;
            this.circleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton.Location = new System.Drawing.Point(206, 627);
            this.circleButton.Margin = new System.Windows.Forms.Padding(10);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(125, 125);
            this.circleButton.TabIndex = 7;
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.rectangle;
            this.rectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Location = new System.Drawing.Point(61, 627);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(10);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(125, 125);
            this.rectangleButton.TabIndex = 6;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // curveButton
            // 
            this.curveButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.curve1;
            this.curveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.curveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curveButton.Location = new System.Drawing.Point(206, 482);
            this.curveButton.Margin = new System.Windows.Forms.Padding(10);
            this.curveButton.Name = "curveButton";
            this.curveButton.Size = new System.Drawing.Size(125, 125);
            this.curveButton.TabIndex = 5;
            this.curveButton.UseVisualStyleBackColor = true;
            this.curveButton.Click += new System.EventHandler(this.CurveButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.line;
            this.lineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Location = new System.Drawing.Point(61, 482);
            this.lineButton.Margin = new System.Windows.Forms.Padding(10);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(125, 125);
            this.lineButton.TabIndex = 4;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // fillPatternButton
            // 
            this.fillPatternButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.fillingPattern;
            this.fillPatternButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillPatternButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillPatternButton.Location = new System.Drawing.Point(206, 337);
            this.fillPatternButton.Margin = new System.Windows.Forms.Padding(10);
            this.fillPatternButton.Name = "fillPatternButton";
            this.fillPatternButton.Size = new System.Drawing.Size(125, 125);
            this.fillPatternButton.TabIndex = 3;
            this.fillPatternButton.UseVisualStyleBackColor = true;
            this.fillPatternButton.Click += new System.EventHandler(this.FillPatternButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.filling;
            this.fillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Location = new System.Drawing.Point(61, 337);
            this.fillButton.Margin = new System.Windows.Forms.Padding(10);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(125, 125);
            this.fillButton.TabIndex = 2;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.eraser;
            this.eraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserButton.Location = new System.Drawing.Point(206, 192);
            this.eraserButton.Margin = new System.Windows.Forms.Padding(10);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(125, 125);
            this.eraserButton.TabIndex = 1;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // pencilButton
            // 
            this.pencilButton.BackgroundImage = global::Graphic_Editor.Properties.Resources.pencil;
            this.pencilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilButton.Location = new System.Drawing.Point(61, 192);
            this.pencilButton.Margin = new System.Windows.Forms.Padding(10);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(125, 125);
            this.pencilButton.TabIndex = 0;
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelRight.Controls.Add(this.hexTextBox);
            this.panelRight.Controls.Add(this.hexLabel);
            this.panelRight.Controls.Add(this.bTextBox);
            this.panelRight.Controls.Add(this.bLabel);
            this.panelRight.Controls.Add(this.gTextBox);
            this.panelRight.Controls.Add(this.gLabel);
            this.panelRight.Controls.Add(this.rTextBox);
            this.panelRight.Controls.Add(this.rLabel);
            this.panelRight.Controls.Add(this.currentColorPictureBox);
            this.panelRight.Controls.Add(this.removeColorPictureBox);
            this.panelRight.Controls.Add(this.colorLabel);
            this.panelRight.Controls.Add(this.gridCheckBox);
            this.panelRight.Controls.Add(this.currentPositionLabel);
            this.panelRight.Controls.Add(this.currentSizeLabel);
            this.panelRight.Controls.Add(this.resizeButton);
            this.panelRight.Controls.Add(this.pxLabel2);
            this.panelRight.Controls.Add(this.pxLabel1);
            this.panelRight.Controls.Add(this.heightTextBox);
            this.panelRight.Controls.Add(this.widthTextBox);
            this.panelRight.Controls.Add(this.heightLabel);
            this.panelRight.Controls.Add(this.widthLabel);
            this.panelRight.Controls.Add(this.sizeLabel);
            this.panelRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelRight.Location = new System.Drawing.Point(1408, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(337, 980);
            this.panelRight.TabIndex = 2;
            // 
            // hexTextBox
            // 
            this.hexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hexTextBox.BackColor = System.Drawing.Color.Black;
            this.hexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexTextBox.ForeColor = System.Drawing.Color.White;
            this.hexTextBox.Location = new System.Drawing.Point(87, 595);
            this.hexTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(151, 35);
            this.hexTextBox.TabIndex = 22;
            this.hexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hexLabel
            // 
            this.hexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hexLabel.Location = new System.Drawing.Point(15, 601);
            this.hexLabel.Margin = new System.Windows.Forms.Padding(10);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(63, 25);
            this.hexLabel.TabIndex = 21;
            this.hexLabel.Text = "HEX:";
            // 
            // bTextBox
            // 
            this.bTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTextBox.BackColor = System.Drawing.Color.Black;
            this.bTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTextBox.ForeColor = System.Drawing.Color.White;
            this.bTextBox.Location = new System.Drawing.Point(54, 528);
            this.bTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(71, 35);
            this.bTextBox.TabIndex = 20;
            this.bTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bLabel
            // 
            this.bLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bLabel.Location = new System.Drawing.Point(15, 534);
            this.bLabel.Margin = new System.Windows.Forms.Padding(10);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(33, 25);
            this.bLabel.TabIndex = 19;
            this.bLabel.Text = "B:";
            // 
            // gTextBox
            // 
            this.gTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gTextBox.BackColor = System.Drawing.Color.Black;
            this.gTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gTextBox.ForeColor = System.Drawing.Color.White;
            this.gTextBox.Location = new System.Drawing.Point(54, 473);
            this.gTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.gTextBox.Name = "gTextBox";
            this.gTextBox.Size = new System.Drawing.Size(71, 35);
            this.gTextBox.TabIndex = 18;
            this.gTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gLabel
            // 
            this.gLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gLabel.AutoSize = true;
            this.gLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gLabel.Location = new System.Drawing.Point(15, 479);
            this.gLabel.Margin = new System.Windows.Forms.Padding(10);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(35, 25);
            this.gLabel.TabIndex = 17;
            this.gLabel.Text = "G:";
            // 
            // rTextBox
            // 
            this.rTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rTextBox.BackColor = System.Drawing.Color.Black;
            this.rTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTextBox.ForeColor = System.Drawing.Color.White;
            this.rTextBox.Location = new System.Drawing.Point(54, 418);
            this.rTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(71, 35);
            this.rTextBox.TabIndex = 16;
            this.rTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rLabel
            // 
            this.rLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rLabel.AutoSize = true;
            this.rLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rLabel.Location = new System.Drawing.Point(15, 424);
            this.rLabel.Margin = new System.Windows.Forms.Padding(10);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(33, 25);
            this.rLabel.TabIndex = 15;
            this.rLabel.Text = "R:";
            // 
            // currentColorPictureBox
            // 
            this.currentColorPictureBox.BackColor = System.Drawing.Color.Black;
            this.currentColorPictureBox.Location = new System.Drawing.Point(72, 664);
            this.currentColorPictureBox.Name = "currentColorPictureBox";
            this.currentColorPictureBox.Size = new System.Drawing.Size(150, 150);
            this.currentColorPictureBox.TabIndex = 14;
            this.currentColorPictureBox.TabStop = false;
            // 
            // removeColorPictureBox
            // 
            this.removeColorPictureBox.BackColor = System.Drawing.Color.Black;
            this.removeColorPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeColorPictureBox.BackgroundImage")));
            this.removeColorPictureBox.Location = new System.Drawing.Point(136, 724);
            this.removeColorPictureBox.Name = "removeColorPictureBox";
            this.removeColorPictureBox.Size = new System.Drawing.Size(150, 150);
            this.removeColorPictureBox.TabIndex = 13;
            this.removeColorPictureBox.TabStop = false;
            // 
            // colorLabel
            // 
            this.colorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorLabel.ForeColor = System.Drawing.Color.Gold;
            this.colorLabel.Location = new System.Drawing.Point(134, 376);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(88, 25);
            this.colorLabel.TabIndex = 13;
            this.colorLabel.Text = "COLOR";
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gridCheckBox.Location = new System.Drawing.Point(20, 328);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(78, 29);
            this.gridCheckBox.TabIndex = 12;
            this.gridCheckBox.Text = "Grid";
            this.gridCheckBox.UseVisualStyleBackColor = true;
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPositionLabel.AutoSize = true;
            this.currentPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentPositionLabel.ForeColor = System.Drawing.Color.Gold;
            this.currentPositionLabel.Location = new System.Drawing.Point(15, 902);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(43, 25);
            this.currentPositionLabel.TabIndex = 8;
            this.currentPositionLabel.Text = "0:0";
            // 
            // currentSizeLabel
            // 
            this.currentSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentSizeLabel.AutoSize = true;
            this.currentSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentSizeLabel.ForeColor = System.Drawing.Color.Gold;
            this.currentSizeLabel.Location = new System.Drawing.Point(9, 927);
            this.currentSizeLabel.Name = "currentSizeLabel";
            this.currentSizeLabel.Size = new System.Drawing.Size(61, 25);
            this.currentSizeLabel.TabIndex = 7;
            this.currentSizeLabel.Text = "[0x0]";
            // 
            // resizeButton
            // 
            this.resizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeButton.BackColor = System.Drawing.Color.Gold;
            this.resizeButton.FlatAppearance.BorderSize = 0;
            this.resizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resizeButton.Location = new System.Drawing.Point(105, 261);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(156, 38);
            this.resizeButton.TabIndex = 3;
            this.resizeButton.Text = "Resize";
            this.resizeButton.UseVisualStyleBackColor = false;
            this.resizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // pxLabel2
            // 
            this.pxLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pxLabel2.AutoSize = true;
            this.pxLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pxLabel2.Location = new System.Drawing.Point(275, 198);
            this.pxLabel2.Name = "pxLabel2";
            this.pxLabel2.Size = new System.Drawing.Size(35, 25);
            this.pxLabel2.TabIndex = 6;
            this.pxLabel2.Text = "px";
            // 
            // pxLabel1
            // 
            this.pxLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pxLabel1.AutoSize = true;
            this.pxLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pxLabel1.Location = new System.Drawing.Point(275, 144);
            this.pxLabel1.Name = "pxLabel1";
            this.pxLabel1.Size = new System.Drawing.Size(35, 25);
            this.pxLabel1.TabIndex = 5;
            this.pxLabel1.Text = "px";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightTextBox.BackColor = System.Drawing.Color.Black;
            this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightTextBox.ForeColor = System.Drawing.Color.White;
            this.heightTextBox.Location = new System.Drawing.Point(130, 192);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(119, 35);
            this.heightTextBox.TabIndex = 4;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthTextBox.BackColor = System.Drawing.Color.Black;
            this.widthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthTextBox.ForeColor = System.Drawing.Color.White;
            this.widthTextBox.Location = new System.Drawing.Point(130, 138);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(119, 35);
            this.widthTextBox.TabIndex = 3;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.heightLabel.Location = new System.Drawing.Point(15, 198);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 25);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.widthLabel.Location = new System.Drawing.Point(15, 144);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(75, 25);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel.ForeColor = System.Drawing.Color.Gold;
            this.sizeLabel.Location = new System.Drawing.Point(147, 90);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(60, 25);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "SIZE";
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.drawPanel.Controls.Add(this.drawPictureBox);
            this.drawPanel.Controls.Add(this.texturePictureBox);
            this.drawPanel.Location = new System.Drawing.Point(406, 90);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(970, 837);
            this.drawPanel.TabIndex = 3;
            this.drawPanel.Resize += new System.EventHandler(this.DrawPanel_Resize);
            // 
            // drawPictureBox
            // 
            this.drawPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.drawPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPictureBox.Location = new System.Drawing.Point(0, 0);
            this.drawPictureBox.Name = "drawPictureBox";
            this.drawPictureBox.Size = new System.Drawing.Size(970, 837);
            this.drawPictureBox.TabIndex = 1;
            this.drawPictureBox.TabStop = false;
            this.drawPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPictureBox_Paint);
            this.drawPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPictureBox_MouseDown);
            this.drawPictureBox.MouseLeave += new System.EventHandler(this.DrawPictureBox_MouseLeave);
            this.drawPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPictureBox_MouseMove);
            this.drawPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPictureBox_MouseUp);
            // 
            // texturePictureBox
            // 
            this.texturePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.texturePictureBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.texturePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("texturePictureBox.Image")));
            this.texturePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("texturePictureBox.InitialImage")));
            this.texturePictureBox.Location = new System.Drawing.Point(0, 0);
            this.texturePictureBox.Name = "texturePictureBox";
            this.texturePictureBox.Size = new System.Drawing.Size(124, 115);
            this.texturePictureBox.TabIndex = 0;
            this.texturePictureBox.TabStop = false;
            this.texturePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.TexturePictureBox_Paint);
            this.texturePictureBox.Resize += new System.EventHandler(this.TexturePictureBox_Resize);
            // 
            // namePanel
            // 
            this.namePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.namePanel.Controls.Add(this.createNewPictureButton);
            this.namePanel.Controls.Add(this.pictureNameLabel);
            this.namePanel.Controls.Add(this.ProjectNameLabel);
            this.namePanel.Location = new System.Drawing.Point(0, 0);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(1745, 76);
            this.namePanel.TabIndex = 4;
            // 
            // createNewPictureButton
            // 
            this.createNewPictureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewPictureButton.BackColor = System.Drawing.Color.Gold;
            this.createNewPictureButton.FlatAppearance.BorderSize = 0;
            this.createNewPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewPictureButton.Location = new System.Drawing.Point(1504, 12);
            this.createNewPictureButton.Name = "createNewPictureButton";
            this.createNewPictureButton.Size = new System.Drawing.Size(189, 54);
            this.createNewPictureButton.TabIndex = 2;
            this.createNewPictureButton.Text = "Create Sprite";
            this.createNewPictureButton.UseVisualStyleBackColor = false;
            // 
            // pictureNameLabel
            // 
            this.pictureNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureNameLabel.AutoSize = true;
            this.pictureNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pictureNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.pictureNameLabel.Location = new System.Drawing.Point(779, 20);
            this.pictureNameLabel.Name = "pictureNameLabel";
            this.pictureNameLabel.Size = new System.Drawing.Size(189, 37);
            this.pictureNameLabel.TabIndex = 1;
            this.pictureNameLabel.Text = "New Picture";
            this.pictureNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectNameLabel.ForeColor = System.Drawing.Color.White;
            this.ProjectNameLabel.Location = new System.Drawing.Point(54, 12);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(290, 46);
            this.ProjectNameLabel.TabIndex = 0;
            this.ProjectNameLabel.Text = "Graphic Editor";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1745, 980);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "MainForm";
            this.Text = "Graphic Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeColorPictureBox)).EndInit();
            this.drawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturePictureBox)).EndInit();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.PictureBox texturePictureBox;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label pictureNameLabel;
        private System.Windows.Forms.Button createNewPictureButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label pxLabel2;
        private System.Windows.Forms.Label pxLabel1;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Label currentSizeLabel;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.Button pipetteButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button curveButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button fillPatternButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button quadrupleModeButton;
        private System.Windows.Forms.Button tripleModeButton;
        private System.Windows.Forms.Button doubleModeButton;
        private System.Windows.Forms.Button singleModeButton;
        private System.Windows.Forms.PictureBox removeColorPictureBox;
        private System.Windows.Forms.PictureBox currentColorPictureBox;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox gTextBox;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.PictureBox drawPictureBox;
    }
}

