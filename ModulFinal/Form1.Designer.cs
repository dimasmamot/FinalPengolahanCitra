namespace ModulFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelOutput4 = new System.Windows.Forms.Label();
            this.labelOutput3 = new System.Windows.Forms.Label();
            this.labelOutput2 = new System.Windows.Forms.Label();
            this.labelOuput1 = new System.Windows.Forms.Label();
            this.pictureBoxOutput4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModeRGB = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModeHSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModeCMYK = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModeGrayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModeBW = new System.Windows.Forms.ToolStripMenuItem();
            this.filterLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLayerRGB = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLayerGrayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripSplitButton();
            this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFlipVertikal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFlipHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRotateClockwise = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRotateCounterClockwise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxBrightness = new System.Windows.Forms.ToolStripTextBox();
            this.btnBrightness = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxContrast = new System.Windows.Forms.ToolStripTextBox();
            this.btnContrast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnBangkitkanNoiseGaussian = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBangkitkanSpeckleNoise = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBangkitkanSaltPepperNoise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnReduksiRataNoise = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReduksiGaussianNoise = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReduksiMedianNoise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdgeDetection = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnKuantisasiCitra8 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKuantisasiCitra16 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKuantisasiCitra32 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKuantisasiCitra64 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKuantisasiCitra128 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCDF = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSharpening = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInvers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.groupBox2);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(1224, 385);
            this.toolStripContainer2.Location = new System.Drawing.Point(12, 12);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(1224, 410);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelOutput4);
            this.groupBox2.Controls.Add(this.labelOutput3);
            this.groupBox2.Controls.Add(this.labelOutput2);
            this.groupBox2.Controls.Add(this.labelOuput1);
            this.groupBox2.Controls.Add(this.pictureBoxOutput4);
            this.groupBox2.Controls.Add(this.pictureBoxOutput2);
            this.groupBox2.Controls.Add(this.pictureBoxOutput3);
            this.groupBox2.Controls.Add(this.pictureBoxOutput1);
            this.groupBox2.Location = new System.Drawing.Point(618, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 365);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Citra Output";
            // 
            // labelOutput4
            // 
            this.labelOutput4.AutoSize = true;
            this.labelOutput4.Location = new System.Drawing.Point(423, 350);
            this.labelOutput4.Name = "labelOutput4";
            this.labelOutput4.Size = new System.Drawing.Size(35, 13);
            this.labelOutput4.TabIndex = 8;
            this.labelOutput4.Text = "label4";
            // 
            // labelOutput3
            // 
            this.labelOutput3.AutoSize = true;
            this.labelOutput3.Location = new System.Drawing.Point(129, 350);
            this.labelOutput3.Name = "labelOutput3";
            this.labelOutput3.Size = new System.Drawing.Size(35, 13);
            this.labelOutput3.TabIndex = 7;
            this.labelOutput3.Text = "label3";
            // 
            // labelOutput2
            // 
            this.labelOutput2.AutoSize = true;
            this.labelOutput2.Location = new System.Drawing.Point(423, 168);
            this.labelOutput2.Name = "labelOutput2";
            this.labelOutput2.Size = new System.Drawing.Size(35, 13);
            this.labelOutput2.TabIndex = 6;
            this.labelOutput2.Text = "label2";
            // 
            // labelOuput1
            // 
            this.labelOuput1.AutoSize = true;
            this.labelOuput1.Location = new System.Drawing.Point(129, 168);
            this.labelOuput1.Name = "labelOuput1";
            this.labelOuput1.Size = new System.Drawing.Size(35, 13);
            this.labelOuput1.TabIndex = 5;
            this.labelOuput1.Text = "label1";
            // 
            // pictureBoxOutput4
            // 
            this.pictureBoxOutput4.Location = new System.Drawing.Point(296, 200);
            this.pictureBoxOutput4.Name = "pictureBoxOutput4";
            this.pictureBoxOutput4.Size = new System.Drawing.Size(269, 147);
            this.pictureBoxOutput4.TabIndex = 4;
            this.pictureBoxOutput4.TabStop = false;
            // 
            // pictureBoxOutput2
            // 
            this.pictureBoxOutput2.Location = new System.Drawing.Point(296, 19);
            this.pictureBoxOutput2.Name = "pictureBoxOutput2";
            this.pictureBoxOutput2.Size = new System.Drawing.Size(269, 147);
            this.pictureBoxOutput2.TabIndex = 3;
            this.pictureBoxOutput2.TabStop = false;
            // 
            // pictureBoxOutput3
            // 
            this.pictureBoxOutput3.Location = new System.Drawing.Point(15, 200);
            this.pictureBoxOutput3.Name = "pictureBoxOutput3";
            this.pictureBoxOutput3.Size = new System.Drawing.Size(269, 147);
            this.pictureBoxOutput3.TabIndex = 2;
            this.pictureBoxOutput3.TabStop = false;
            // 
            // pictureBoxOutput1
            // 
            this.pictureBoxOutput1.Location = new System.Drawing.Point(15, 19);
            this.pictureBoxOutput1.Name = "pictureBoxOutput1";
            this.pictureBoxOutput1.Size = new System.Drawing.Size(269, 147);
            this.pictureBoxOutput1.TabIndex = 1;
            this.pictureBoxOutput1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartHistogram);
            this.groupBox1.Controls.Add(this.pictureBoxInput);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citra Input";
            // 
            // chartHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            this.chartHistogram.Location = new System.Drawing.Point(355, 19);
            this.chartHistogram.Margin = new System.Windows.Forms.Padding(0);
            this.chartHistogram.Name = "chartHistogram";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartHistogram.Series.Add(series1);
            this.chartHistogram.Size = new System.Drawing.Size(206, 115);
            this.chartHistogram.TabIndex = 1;
            this.chartHistogram.Text = "chart1";
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(20, 19);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(541, 328);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoad,
            this.btnSave,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.toolStripButton7,
            this.toolStripSeparator2,
            this.btnZoomIn,
            this.btnZoomOut,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.textBoxBrightness,
            this.btnBrightness,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.textBoxContrast,
            this.btnContrast,
            this.toolStripSeparator5,
            this.toolStripDropDownButton1,
            this.toolStripSplitButton2,
            this.toolStripSeparator6,
            this.btnEdgeDetection,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1207, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(23, 22);
            this.btnLoad.Text = "btnLoad";
            this.btnLoad.ToolTipText = "Load Gambar";
            this.btnLoad.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "toolStripButton6";
            this.btnSave.ToolTipText = "Save Gambar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.filterLayerToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModeRGB,
            this.btnModeHSV,
            this.btnModeCMYK,
            this.btnModeGrayscale,
            this.btnModeBW});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.menu1ToolStripMenuItem.Text = "Mode Warna";
            // 
            // btnModeRGB
            // 
            this.btnModeRGB.Name = "btnModeRGB";
            this.btnModeRGB.Size = new System.Drawing.Size(161, 22);
            this.btnModeRGB.Text = "RGB";
            // 
            // btnModeHSV
            // 
            this.btnModeHSV.Name = "btnModeHSV";
            this.btnModeHSV.Size = new System.Drawing.Size(161, 22);
            this.btnModeHSV.Text = "HSV";
            // 
            // btnModeCMYK
            // 
            this.btnModeCMYK.Name = "btnModeCMYK";
            this.btnModeCMYK.Size = new System.Drawing.Size(161, 22);
            this.btnModeCMYK.Text = "CMYK";
            // 
            // btnModeGrayscale
            // 
            this.btnModeGrayscale.Name = "btnModeGrayscale";
            this.btnModeGrayscale.Size = new System.Drawing.Size(161, 22);
            this.btnModeGrayscale.Text = "Grayscale";
            // 
            // btnModeBW
            // 
            this.btnModeBW.Name = "btnModeBW";
            this.btnModeBW.Size = new System.Drawing.Size(161, 22);
            this.btnModeBW.Text = "Black And White";
            // 
            // filterLayerToolStripMenuItem
            // 
            this.filterLayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLayerRGB,
            this.btnLayerGrayscale});
            this.filterLayerToolStripMenuItem.Name = "filterLayerToolStripMenuItem";
            this.filterLayerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.filterLayerToolStripMenuItem.Text = "Filter Layer";
            // 
            // btnLayerRGB
            // 
            this.btnLayerRGB.Name = "btnLayerRGB";
            this.btnLayerRGB.Size = new System.Drawing.Size(124, 22);
            this.btnLayerRGB.Text = "RGB";
            // 
            // btnLayerGrayscale
            // 
            this.btnLayerGrayscale.Name = "btnLayerGrayscale";
            this.btnLayerGrayscale.Size = new System.Drawing.Size(124, 22);
            this.btnLayerGrayscale.Text = "Grayscale";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipToolStripMenuItem,
            this.rotateToolStripMenuItem});
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // flipToolStripMenuItem
            // 
            this.flipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFlipVertikal,
            this.btnFlipHorizontal});
            this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.flipToolStripMenuItem.Text = "Flip";
            // 
            // btnFlipVertikal
            // 
            this.btnFlipVertikal.Name = "btnFlipVertikal";
            this.btnFlipVertikal.Size = new System.Drawing.Size(129, 22);
            this.btnFlipVertikal.Text = "Vertikal";
            // 
            // btnFlipHorizontal
            // 
            this.btnFlipHorizontal.Name = "btnFlipHorizontal";
            this.btnFlipHorizontal.Size = new System.Drawing.Size(129, 22);
            this.btnFlipHorizontal.Text = "Horizontal";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRotateClockwise,
            this.btnRotateCounterClockwise});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // btnRotateClockwise
            // 
            this.btnRotateClockwise.Name = "btnRotateClockwise";
            this.btnRotateClockwise.Size = new System.Drawing.Size(222, 22);
            this.btnRotateClockwise.Text = "Searah Jarum Jam";
            // 
            // btnRotateCounterClockwise
            // 
            this.btnRotateCounterClockwise.Name = "btnRotateCounterClockwise";
            this.btnRotateCounterClockwise.Size = new System.Drawing.Size(222, 22);
            this.btnRotateCounterClockwise.Text = "Berlawanan Arah Jarum Jam";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.btnZoomIn.Text = "toolStripButton8";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.btnZoomOut.Text = "toolStripButton9";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "Brightness";
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.Size = new System.Drawing.Size(100, 25);
            // 
            // btnBrightness
            // 
            this.btnBrightness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrightness.Image = ((System.Drawing.Image)(resources.GetObject("btnBrightness.Image")));
            this.btnBrightness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(23, 22);
            this.btnBrightness.Text = "toolStripButton10";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel2.Text = "Contrast";
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.Size = new System.Drawing.Size(100, 25);
            // 
            // btnContrast
            // 
            this.btnContrast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnContrast.Image = ((System.Drawing.Image)(resources.GetObject("btnContrast.Image")));
            this.btnContrast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(23, 22);
            this.btnContrast.Text = "toolStripButton11";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBangkitkanNoiseGaussian,
            this.btnBangkitkanSpeckleNoise,
            this.btnBangkitkanSaltPepperNoise});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(131, 22);
            this.toolStripDropDownButton1.Text = "Bangkitkan Noise";
            // 
            // btnBangkitkanNoiseGaussian
            // 
            this.btnBangkitkanNoiseGaussian.Name = "btnBangkitkanNoiseGaussian";
            this.btnBangkitkanNoiseGaussian.Size = new System.Drawing.Size(169, 22);
            this.btnBangkitkanNoiseGaussian.Text = "Gaussian Noise";
            // 
            // btnBangkitkanSpeckleNoise
            // 
            this.btnBangkitkanSpeckleNoise.Name = "btnBangkitkanSpeckleNoise";
            this.btnBangkitkanSpeckleNoise.Size = new System.Drawing.Size(169, 22);
            this.btnBangkitkanSpeckleNoise.Text = "Speckle Noise";
            // 
            // btnBangkitkanSaltPepperNoise
            // 
            this.btnBangkitkanSaltPepperNoise.Name = "btnBangkitkanSaltPepperNoise";
            this.btnBangkitkanSaltPepperNoise.Size = new System.Drawing.Size(169, 22);
            this.btnBangkitkanSaltPepperNoise.Text = "Salt & Pepper Noise";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReduksiRataNoise,
            this.btnReduksiGaussianNoise,
            this.btnReduksiMedianNoise});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(113, 22);
            this.toolStripSplitButton2.Text = "Reduksi Noise";
            // 
            // btnReduksiRataNoise
            // 
            this.btnReduksiRataNoise.Name = "btnReduksiRataNoise";
            this.btnReduksiRataNoise.Size = new System.Drawing.Size(154, 22);
            this.btnReduksiRataNoise.Text = "Filter Rata-Rata";
            // 
            // btnReduksiGaussianNoise
            // 
            this.btnReduksiGaussianNoise.Name = "btnReduksiGaussianNoise";
            this.btnReduksiGaussianNoise.Size = new System.Drawing.Size(154, 22);
            this.btnReduksiGaussianNoise.Text = "Filter Gaussian";
            // 
            // btnReduksiMedianNoise
            // 
            this.btnReduksiMedianNoise.Name = "btnReduksiMedianNoise";
            this.btnReduksiMedianNoise.Size = new System.Drawing.Size(154, 22);
            this.btnReduksiMedianNoise.Text = "Filter Median";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEdgeDetection
            // 
            this.btnEdgeDetection.Image = ((System.Drawing.Image)(resources.GetObject("btnEdgeDetection.Image")));
            this.btnEdgeDetection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdgeDetection.Name = "btnEdgeDetection";
            this.btnEdgeDetection.Size = new System.Drawing.Size(107, 22);
            this.btnEdgeDetection.Text = "Edge Detection";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKuantisasiCitra8,
            this.btnKuantisasiCitra16,
            this.btnKuantisasiCitra32,
            this.btnKuantisasiCitra64,
            this.btnKuantisasiCitra128});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(117, 22);
            this.toolStripDropDownButton2.Text = "Kuantisasi Citra";
            // 
            // btnKuantisasiCitra8
            // 
            this.btnKuantisasiCitra8.Name = "btnKuantisasiCitra8";
            this.btnKuantisasiCitra8.Size = new System.Drawing.Size(109, 22);
            this.btnKuantisasiCitra8.Text = "KC 8";
            // 
            // btnKuantisasiCitra16
            // 
            this.btnKuantisasiCitra16.Name = "btnKuantisasiCitra16";
            this.btnKuantisasiCitra16.Size = new System.Drawing.Size(109, 22);
            this.btnKuantisasiCitra16.Text = "KC 16";
            // 
            // btnKuantisasiCitra32
            // 
            this.btnKuantisasiCitra32.Name = "btnKuantisasiCitra32";
            this.btnKuantisasiCitra32.Size = new System.Drawing.Size(109, 22);
            this.btnKuantisasiCitra32.Text = "KC 32";
            // 
            // btnKuantisasiCitra64
            // 
            this.btnKuantisasiCitra64.Name = "btnKuantisasiCitra64";
            this.btnKuantisasiCitra64.Size = new System.Drawing.Size(109, 22);
            this.btnKuantisasiCitra64.Text = "KC 64";
            // 
            // btnKuantisasiCitra128
            // 
            this.btnKuantisasiCitra128.Name = "btnKuantisasiCitra128";
            this.btnKuantisasiCitra128.Size = new System.Drawing.Size(109, 22);
            this.btnKuantisasiCitra128.Text = "KC 128";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCDF,
            this.btnSharpening,
            this.btnInvers,
            this.btnAutoLevel});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(108, 22);
            this.toolStripDropDownButton3.Text = "Tools Lainnya";
            this.toolStripDropDownButton3.Click += new System.EventHandler(this.toolStripDropDownButton3_Click);
            // 
            // btnCDF
            // 
            this.btnCDF.Name = "btnCDF";
            this.btnCDF.Size = new System.Drawing.Size(134, 22);
            this.btnCDF.Text = "CDF";
            // 
            // btnSharpening
            // 
            this.btnSharpening.Name = "btnSharpening";
            this.btnSharpening.Size = new System.Drawing.Size(134, 22);
            this.btnSharpening.Text = "Sharpening";
            // 
            // btnInvers
            // 
            this.btnInvers.Name = "btnInvers";
            this.btnInvers.Size = new System.Drawing.Size(134, 22);
            this.btnInvers.Text = "Invers";
            // 
            // btnAutoLevel
            // 
            this.btnAutoLevel.Name = "btnAutoLevel";
            this.btnAutoLevel.Size = new System.Drawing.Size(134, 22);
            this.btnAutoLevel.Text = "Auto Level";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1248, 438);
            this.Controls.Add(this.toolStripContainer2);
            this.Name = "Form1";
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnModeRGB;
        private System.Windows.Forms.ToolStripMenuItem btnModeHSV;
        private System.Windows.Forms.ToolStripMenuItem btnModeCMYK;
        private System.Windows.Forms.ToolStripMenuItem btnModeGrayscale;
        private System.Windows.Forms.ToolStripMenuItem btnModeBW;
        private System.Windows.Forms.ToolStripMenuItem filterLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLayerRGB;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton7;
        private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnFlipVertikal;
        private System.Windows.Forms.ToolStripMenuItem btnFlipHorizontal;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRotateClockwise;
        private System.Windows.Forms.ToolStripMenuItem btnRotateCounterClockwise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox textBoxBrightness;
        private System.Windows.Forms.ToolStripButton btnBrightness;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox textBoxContrast;
        private System.Windows.Forms.ToolStripButton btnContrast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSplitButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnBangkitkanNoiseGaussian;
        private System.Windows.Forms.ToolStripMenuItem btnBangkitkanSpeckleNoise;
        private System.Windows.Forms.ToolStripMenuItem btnBangkitkanSaltPepperNoise;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem btnReduksiRataNoise;
        private System.Windows.Forms.ToolStripMenuItem btnReduksiGaussianNoise;
        private System.Windows.Forms.ToolStripMenuItem btnReduksiMedianNoise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnEdgeDetection;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnKuantisasiCitra8;
        private System.Windows.Forms.ToolStripMenuItem btnKuantisasiCitra16;
        private System.Windows.Forms.ToolStripMenuItem btnKuantisasiCitra32;
        private System.Windows.Forms.ToolStripMenuItem btnKuantisasiCitra64;
        private System.Windows.Forms.ToolStripMenuItem btnKuantisasiCitra128;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.PictureBox pictureBoxOutput1;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.ToolStripMenuItem btnCDF;
        private System.Windows.Forms.ToolStripMenuItem btnSharpening;
        private System.Windows.Forms.ToolStripMenuItem btnInvers;
        private System.Windows.Forms.ToolStripMenuItem btnAutoLevel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxOutput4;
        private System.Windows.Forms.PictureBox pictureBoxOutput2;
        private System.Windows.Forms.PictureBox pictureBoxOutput3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem btnLayerGrayscale;
        private System.Windows.Forms.Label labelOutput4;
        private System.Windows.Forms.Label labelOutput3;
        private System.Windows.Forms.Label labelOutput2;
        private System.Windows.Forms.Label labelOuput1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
    }
}

