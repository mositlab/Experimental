namespace OpenGL_lesson_CSharp
{
    partial class SharpGLForm
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
            this.openGLControl = new SharpGL.OpenGLControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonYm = new System.Windows.Forms.Button();
            this.buttonXm = new System.Windows.Forms.Button();
            this.buttonYp = new System.Windows.Forms.Button();
            this.buttonXp = new System.Windows.Forms.Button();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonFile = new System.Windows.Forms.Button();
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownLine = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button3D = new System.Windows.Forms.Button();
            this.numericUpDownYadro = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPix = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownSume = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSdvig = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYadro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSdvig)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.FrameRate = 50;
            this.openGLControl.Location = new System.Drawing.Point(3, 3);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(4);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(962, 552);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openGLControl_KeyDown);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SharpGLForm_MouseMove);
            this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 584);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.openGLControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OpenGL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonYm);
            this.tabPage2.Controls.Add(this.buttonXm);
            this.tabPage2.Controls.Add(this.buttonYp);
            this.tabPage2.Controls.Add(this.buttonXp);
            this.tabPage2.Controls.Add(this.pictureBoxStop);
            this.tabPage2.Controls.Add(this.pictureBoxStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Img";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonYm
            // 
            this.buttonYm.Location = new System.Drawing.Point(89, 35);
            this.buttonYm.Name = "buttonYm";
            this.buttonYm.Size = new System.Drawing.Size(75, 23);
            this.buttonYm.TabIndex = 6;
            this.buttonYm.Text = "Y-";
            this.buttonYm.UseVisualStyleBackColor = true;
            this.buttonYm.Click += new System.EventHandler(this.buttonYm_Click);
            // 
            // buttonXm
            // 
            this.buttonXm.Location = new System.Drawing.Point(8, 35);
            this.buttonXm.Name = "buttonXm";
            this.buttonXm.Size = new System.Drawing.Size(75, 23);
            this.buttonXm.TabIndex = 5;
            this.buttonXm.Text = "X-";
            this.buttonXm.UseVisualStyleBackColor = true;
            this.buttonXm.Click += new System.EventHandler(this.buttonXm_Click);
            // 
            // buttonYp
            // 
            this.buttonYp.Location = new System.Drawing.Point(89, 6);
            this.buttonYp.Name = "buttonYp";
            this.buttonYp.Size = new System.Drawing.Size(75, 23);
            this.buttonYp.TabIndex = 4;
            this.buttonYp.Text = "Y+";
            this.buttonYp.UseVisualStyleBackColor = true;
            this.buttonYp.Click += new System.EventHandler(this.buttonYp_Click);
            // 
            // buttonXp
            // 
            this.buttonXp.Location = new System.Drawing.Point(8, 6);
            this.buttonXp.Name = "buttonXp";
            this.buttonXp.Size = new System.Drawing.Size(75, 23);
            this.buttonXp.TabIndex = 3;
            this.buttonXp.Text = "X+";
            this.buttonXp.UseVisualStyleBackColor = true;
            this.buttonXp.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxStop.Location = new System.Drawing.Point(581, 3);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(384, 552);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStop.TabIndex = 2;
            this.pictureBoxStop.TabStop = false;
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxStart.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(384, 552);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStart.TabIndex = 1;
            this.pictureBoxStart.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(968, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Params";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(962, 552);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 29;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonFile);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownX1);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownY1);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownX2);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownY2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.buttonSize);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownLine);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.button3D);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownYadro);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownPix);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownSume);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownSdvig);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Size = new System.Drawing.Size(394, 552);
            this.splitContainer2.SplitterDistance = 165;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(3, 3);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(193, 23);
            this.buttonFile.TabIndex = 1;
            this.buttonFile.Text = "Файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.Location = new System.Drawing.Point(76, 32);
            this.numericUpDownX1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX1.TabIndex = 2;
            // 
            // numericUpDownY1
            // 
            this.numericUpDownY1.Location = new System.Drawing.Point(76, 58);
            this.numericUpDownY1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY1.Name = "numericUpDownY1";
            this.numericUpDownY1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY1.TabIndex = 3;
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.Location = new System.Drawing.Point(259, 32);
            this.numericUpDownX2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX2.TabIndex = 4;
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.Location = new System.Drawing.Point(259, 58);
            this.numericUpDownY2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y2";
            // 
            // buttonSize
            // 
            this.buttonSize.Location = new System.Drawing.Point(205, 3);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(174, 23);
            this.buttonSize.TabIndex = 10;
            this.buttonSize.Text = "Размер";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Visible = false;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Толщина";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Автоцентровка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownLine
            // 
            this.numericUpDownLine.Location = new System.Drawing.Point(76, 0);
            this.numericUpDownLine.Name = "numericUpDownLine";
            this.numericUpDownLine.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLine.TabIndex = 13;
            this.numericUpDownLine.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ядро";
            // 
            // button3D
            // 
            this.button3D.Location = new System.Drawing.Point(205, 74);
            this.button3D.Name = "button3D";
            this.button3D.Size = new System.Drawing.Size(174, 49);
            this.button3D.TabIndex = 14;
            this.button3D.Text = "3D";
            this.button3D.UseVisualStyleBackColor = true;
            this.button3D.Click += new System.EventHandler(this.button3D_Click);
            // 
            // numericUpDownYadro
            // 
            this.numericUpDownYadro.Location = new System.Drawing.Point(259, 0);
            this.numericUpDownYadro.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownYadro.Name = "numericUpDownYadro";
            this.numericUpDownYadro.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYadro.TabIndex = 24;
            this.numericUpDownYadro.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownPix
            // 
            this.numericUpDownPix.DecimalPlaces = 2;
            this.numericUpDownPix.Location = new System.Drawing.Point(76, 77);
            this.numericUpDownPix.Name = "numericUpDownPix";
            this.numericUpDownPix.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPix.TabIndex = 15;
            this.numericUpDownPix.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Сдвиг";
            // 
            // numericUpDownSume
            // 
            this.numericUpDownSume.DecimalPlaces = 2;
            this.numericUpDownSume.Location = new System.Drawing.Point(76, 103);
            this.numericUpDownSume.Name = "numericUpDownSume";
            this.numericUpDownSume.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSume.TabIndex = 16;
            this.numericUpDownSume.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDownSdvig
            // 
            this.numericUpDownSdvig.Location = new System.Drawing.Point(76, 26);
            this.numericUpDownSdvig.Name = "numericUpDownSdvig";
            this.numericUpDownSdvig.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSdvig.TabIndex = 22;
            this.numericUpDownSdvig.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Размер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Множетель";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(968, 558);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Настройки настроек";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.zedGraphControl1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(968, 558);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Граф";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(968, 558);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // SharpGLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 584);
            this.Controls.Add(this.tabControl1);
            this.Name = "SharpGLForm";
            this.Text = "Test";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SharpGLForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYadro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSdvig)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxStop;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownLine;
        private System.Windows.Forms.Button button3D;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSume;
        private System.Windows.Forms.NumericUpDown numericUpDownPix;
        private System.Windows.Forms.Button buttonYp;
        private System.Windows.Forms.Button buttonXp;
        private System.Windows.Forms.Button buttonYm;
        private System.Windows.Forms.Button buttonXm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownSdvig;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownYadro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

