using System.Security.Cryptography;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Primitive_Graphic_Editor
{
    public partial class Form1 : Form
    {

        int _x;
        int _y;
        bool _mouseClicked = false;

        Color SelectedColor
        {
            get { return colorDialog1.Color; }
        }
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageSizeForm form = new ImageSizeForm();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }
        }

        int SelectedSize
        {
            get { return trackBar1.Value; }
        }
        Brush _selectedBrush;

        Color DefaultColor
        {
            get { return Color.White; }
        }

        void CreateBlank(int width, int height)
        {
            //��������� ������ ��������
            var oldImage = pictureBox1.Image;
            //������� ����� Bitmap
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //���������� ������������ ������������
            //������ - ������� ��������� ������ �����, ������� �������� ��� �� 2 �����:
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose(); //����������� �������, ������� ������ ���������
            }
        }


        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width = 2000, pictureBox1.Height = 1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new HeartBrush(SelectedColor, SelectedSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _selectedBrush = new StarBrush(SelectedColor, SelectedSize);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _selectedBrush = new TransparentQuadBrush(SelectedColor, SelectedSize);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(Color.White, SelectedSize);
        }

        // ���������� ������� ��� ������� ������ ����
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }

            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();

            _mouseClicked = true;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // ��������� ���� � �������� �������, �������� ������������� ����������

            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                // ���� ������? ������ ������
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //���� ������������ ������ ����, ���������� ���:
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //��� ��������, ������������ ������ ��������� ������
                button7.BackColor = colorDialog1.Color;
            }
        }
    }
}

