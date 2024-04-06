namespace Primitive_Graphic_Editor
{
    partial class ImageSizeForm
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
            tbFileName = new TextBox();
            tbWidth = new TextBox();
            tbHeight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbFileName
            // 
            tbFileName.Location = new Point(110, 47);
            tbFileName.Name = "tbFileName";
            tbFileName.Size = new Size(177, 23);
            tbFileName.TabIndex = 0;
            // 
            // tbWidth
            // 
            tbWidth.Location = new Point(110, 76);
            tbWidth.Name = "tbWidth";
            tbWidth.Size = new Size(177, 23);
            tbWidth.TabIndex = 1;
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(110, 105);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(177, 23);
            tbHeight.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 50);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Имя Файла:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Ширина:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 108);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Высота:";
            // 
            // button1
            // 
            button1.Location = new Point(32, 177);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(212, 177);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // ImageSizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 227);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbHeight);
            Controls.Add(tbWidth);
            Controls.Add(tbFileName);
            Name = "ImageSizeForm";
            Text = "Создание изображения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFileName;
        private TextBox tbWidth;
        private TextBox tbHeight;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}