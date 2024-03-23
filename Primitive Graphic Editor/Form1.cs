using System.Security.Cryptography;
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
            get { return Color.Black; }
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
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        // ���������� ������� ��� ������� ������ ����
        private void pictureBox1_Click(object sender, MouseEventArgs e)
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
    }
}
