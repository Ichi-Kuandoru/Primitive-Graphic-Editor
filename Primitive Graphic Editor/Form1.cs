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
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
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

        /*Brush DefaultBrush;
        {
            get { return _selectedBrush = QuadBrush(SelectedColor, SelectedSize); }
        }*/

        void CreateBlank(int width, int height)
        {
            //сохраняем старую картинку
            var oldImage = pictureBox1.Image;
            //Создаем новый Bitmap
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //производим попиксельное закрашивание
            //Битмап - обычный двумерный массив точек, поэтому проходим его за 2 цикла:
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
                oldImage.Dispose(); //освобождаем ресурсы, занятые старой картинкой
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

        private void button8_Click(object sender, EventArgs e)
        {
            _selectedBrush = new BubleBrush(SelectedColor, SelectedSize);
        }

        // Обработчик события при нажатии кнопки мыши
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
            // закрываем мышь в границах области, отсекаем отрицательные координаты

            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                // Мышь зажата? значит рисуем
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(Color.Black, SelectedSize);
            }
            _selectedBrush.BrushColor = Color.Black;
        }



        private void button9_Click(object sender, EventArgs e)
        {
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(Color.White, SelectedSize); 
            }
            _selectedBrush.BrushColor = Color.White;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(Color.Red, SelectedSize);
            }
            _selectedBrush.BrushColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(Color.Blue, SelectedSize);
            }
            _selectedBrush.BrushColor = Color.Blue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(Color.Gray, SelectedSize);
            }
            _selectedBrush.BrushColor = Color.Gray;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(Color.LightGray, SelectedSize);
            }
            _selectedBrush.BrushColor = Color.LightGray;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(Color.Orange, SelectedSize);
            }
            _selectedBrush.BrushColor = Color.Orange;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(Color.Green, SelectedSize);
            }
            _selectedBrush.BrushColor = Color.Green;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Изображение (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
                saveFileDialog.FileName = "Безыменный";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    pictureBox1.Image.Save(filePath);
                }
            }
            else
            {
                MessageBox.Show("В picturebox нет изображения для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Спросить пользователя, действительно ли он хочет выйти
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Если пользователь подтвердил выход, закрыть форму
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

