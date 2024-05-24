namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            trackBar3 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            trackBar4 = new TrackBar();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Images|*.bpm;*.png;*.jpg";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(checkBox1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(trackBar3);
            splitContainer1.Panel2.Controls.Add(trackBar2);
            splitContainer1.Panel2.Controls.Add(trackBar1);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1131, 693);
            splitContainer1.SplitterDistance = 634;
            splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(10, 657);
            button1.Name = "button1";
            button1.Size = new Size(610, 29);
            button1.TabIndex = 13;
            button1.Text = "было/стало";
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += button1_MouseDown;
            button1.MouseUp += button1_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 689);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 480);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 12;
            label6.Text = "(в процентах)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 480);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 11;
            label5.Text = "(в процентах)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(344, 249);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(114, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Тонировать";
            toolTip1.SetToolTip(checkBox1, "Придать фотографии общий оттенок");
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 18);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Яркость";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 18);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 5;
            label2.Text = "Насыщенность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 17);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Оттенок";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(44, 41);
            trackBar3.Maximum = 360;
            trackBar3.Minimum = 1;
            trackBar3.Name = "trackBar3";
            trackBar3.Orientation = Orientation.Vertical;
            trackBar3.Size = new Size(56, 436);
            trackBar3.TabIndex = 3;
            trackBar3.TickStyle = TickStyle.Both;
            trackBar3.Value = 1;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(158, 41);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Orientation = Orientation.Vertical;
            trackBar2.Size = new Size(56, 436);
            trackBar2.TabIndex = 2;
            trackBar2.TickStyle = TickStyle.Both;
            trackBar2.Value = 1;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(273, 41);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(56, 436);
            trackBar1.TabIndex = 1;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(13, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 523);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 479);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 10;
            label4.Text = "(в градусах)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(trackBar4);
            groupBox2.Location = new Point(13, 535);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 144);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Режим рисования";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(429, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(22, 10);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(18, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 40);
            panel1.TabIndex = 16;
            panel1.Click += panel1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(387, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 22);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 16;
            label7.Text = "ширина";
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(18, 45);
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(423, 56);
            trackBar4.TabIndex = 15;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1131, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(266, 26);
            openToolStripMenuItem.Text = "Oткрыть изображение";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(266, 26);
            saveToolStripMenuItem.Text = "Сохранить изображение";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(118, 24);
            aboutToolStripMenuItem.Text = "О программе";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1131, 721);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Фоторедактор ТОНЯ";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private TrackBar trackBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private ToolStripMenuItem saveToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private CheckBox checkBox1;
        private ToolTip toolTip1;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TrackBar trackBar4;
        private Panel panel1;
        private ColorDialog colorDialog1;
        private Label label7;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}