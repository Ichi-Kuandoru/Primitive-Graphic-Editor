namespace Primitive_Graphic_Editor
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            ToolsPanel = new Panel();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button7 = new Button();
            groupBox1 = new GroupBox();
            button8 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            trackBar1 = new TrackBar();
            DrawPanel = new Panel();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            ToolsPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(929, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, сохранитьToolStripMenuItem, открытьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(133, 22);
            создатьToolStripMenuItem.Text = "Создать";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(133, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // ToolsPanel
            // 
            ToolsPanel.Controls.Add(button12);
            ToolsPanel.Controls.Add(button13);
            ToolsPanel.Controls.Add(button14);
            ToolsPanel.Controls.Add(button15);
            ToolsPanel.Controls.Add(button11);
            ToolsPanel.Controls.Add(button10);
            ToolsPanel.Controls.Add(button9);
            ToolsPanel.Controls.Add(button7);
            ToolsPanel.Controls.Add(groupBox1);
            ToolsPanel.Dock = DockStyle.Left;
            ToolsPanel.Location = new Point(0, 24);
            ToolsPanel.Name = "ToolsPanel";
            ToolsPanel.Size = new Size(165, 462);
            ToolsPanel.TabIndex = 1;
            // 
            // button12
            // 
            button12.BackColor = Color.Green;
            button12.Location = new Point(127, 283);
            button12.Name = "button12";
            button12.Size = new Size(32, 31);
            button12.TabIndex = 8;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Orange;
            button13.Location = new Point(89, 283);
            button13.Name = "button13";
            button13.Size = new Size(32, 31);
            button13.TabIndex = 7;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.LightGray;
            button14.Location = new Point(51, 283);
            button14.Name = "button14";
            button14.Size = new Size(32, 31);
            button14.TabIndex = 6;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click_1;
            // 
            // button15
            // 
            button15.BackColor = Color.Gray;
            button15.Location = new Point(13, 283);
            button15.Name = "button15";
            button15.Size = new Size(32, 31);
            button15.TabIndex = 5;
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Blue;
            button11.Location = new Point(127, 246);
            button11.Name = "button11";
            button11.Size = new Size(32, 31);
            button11.TabIndex = 4;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Red;
            button10.Location = new Point(89, 246);
            button10.Name = "button10";
            button10.Size = new Size(32, 31);
            button10.TabIndex = 3;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Location = new Point(51, 246);
            button9.Name = "button9";
            button9.Size = new Size(32, 31);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Location = new Point(13, 246);
            button7.Name = "button7";
            button7.Size = new Size(32, 31);
            button7.TabIndex = 1;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор кисти";
            // 
            // button8
            // 
            button8.Location = new Point(87, 128);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "Пузырь";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Location = new Point(6, 211);
            button6.Name = "button6";
            button6.Size = new Size(153, 23);
            button6.TabIndex = 6;
            button6.Text = "Ластик";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(6, 128);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "прозрач";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(87, 99);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Zvezda";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 99);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Круг";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(87, 70);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Сердце";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 70);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Квадрат";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.Dock = DockStyle.Top;
            trackBar1.LargeChange = 50;
            trackBar1.Location = new Point(3, 19);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 25;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(159, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 25;
            // 
            // DrawPanel
            // 
            DrawPanel.AutoScroll = true;
            DrawPanel.Controls.Add(pictureBox1);
            DrawPanel.Dock = DockStyle.Fill;
            DrawPanel.Location = new Point(165, 24);
            DrawPanel.Name = "DrawPanel";
            DrawPanel.Size = new Size(764, 462);
            DrawPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(728, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseDown;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 486);
            Controls.Add(DrawPanel);
            Controls.Add(ToolsPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Примитивный Графический Редактор";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ToolsPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            DrawPanel.ResumeLayout(false);
            DrawPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Panel ToolsPanel;
        private Panel DrawPanel;
        private GroupBox groupBox1;
        private TrackBar trackBar1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button6;
        private Button button7;
        private ColorDialog colorDialog1;
        private Button button8;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
    }
}
