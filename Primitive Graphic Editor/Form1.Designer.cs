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
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            trackBar1 = new TrackBar();
            DrawPanel = new Panel();
            pictureBox1 = new PictureBox();
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
            menuStrip1.Size = new Size(577, 24);
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
            ToolsPanel.Controls.Add(groupBox1);
            ToolsPanel.Dock = DockStyle.Left;
            ToolsPanel.Location = new Point(0, 24);
            ToolsPanel.Name = "ToolsPanel";
            ToolsPanel.Size = new Size(165, 255);
            ToolsPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
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
            trackBar1.LargeChange = 3;
            trackBar1.Location = new Point(3, 19);
            trackBar1.Maximum = 200;
            trackBar1.Minimum = 5;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(159, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 5;
            // 
            // DrawPanel
            // 
            DrawPanel.Controls.Add(pictureBox1);
            DrawPanel.Dock = DockStyle.Fill;
            DrawPanel.Location = new Point(165, 24);
            DrawPanel.Name = "DrawPanel";
            DrawPanel.Size = new Size(412, 255);
            DrawPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 255);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_Click;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 279);
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
    }
}
