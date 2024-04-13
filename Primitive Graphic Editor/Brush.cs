using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitive_Graphic_Editor
{
    abstract class Brush
    {
        public Color BrushColor { get; set; }
        public int Size { get; set; }
        public Brush(Color brushColor, int size) 
        {
            BrushColor = brushColor;
            Size = size;
        }
        public abstract void Draw(Bitmap image,int x,int y);
    }

    class QuadBrush : Brush
    {
        public QuadBrush(Color brushColor, int size)
            : base(brushColor, size) 
        { 
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            int startX = Math.Max(0, x - Size);
            int endX = Math.Min(image.Width - 1, x + Size);
            int startY = Math.Max(0, y - Size);
            int endY = Math.Min(image.Height - 1, y + Size);

            for (int y0 = startY; y0 <= endY; ++y0)
            {
                for (int x0 = startX; x0 <= endX; ++x0)
                {
                    image.SetPixel(x0, y0, BrushColor);
                }
            }
        }

    }

    class CircleBrush : Brush
    {
        public CircleBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            int startX = Math.Max(0, x - Size);
            int endX = Math.Min(image.Width - 1, x + Size);
            int startY = Math.Max(0, y - Size);
            int endY = Math.Min(image.Height - 1, y + Size);

            for (int i = startX; i <= endX; i++)
            {
                for (int j = startY; j <= endY; j++)
                {
                    if ((i - x) * (i - x) + (j - y) * (j - y) <= Size * Size)
                    {
                        image.SetPixel(i, j, BrushColor);
                    }
                }
            }
        }

    }

    class BubleBrush : Brush
    {
        public BubleBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            int startX = Math.Max(0, x - Size);
            int endX = Math.Min(image.Width - 1, x + Size);
            int startY = Math.Max(0, y - Size);
            int endY = Math.Min(image.Height - 1, y + Size);

            for (int y0 = startY; y0 <= endY; y0++)
            {
                double x1 = Math.Sqrt(Size * Size - Math.Pow(y0 - y, 2));
                image.SetPixel((int)(x + x1), y0, BrushColor);
                image.SetPixel((int)(x - x1), y0, BrushColor);
            }
            for (int x0 = startX; x0 <= endX; x0++)
            {
                double y1 = Math.Sqrt(Size * Size - Math.Pow(x0 - x, 2));
                image.SetPixel(x0, (int)(y + y1), BrushColor);
                image.SetPixel(x0, (int)(y - y1), BrushColor);
            }
        }

    }


    class StarBrush : Brush
    {
        public StarBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
//=========================================================================================================================================================      
            int vertices = 5; // Количество вершин звезды
              double angleIncrement = Math.PI * 2 / vertices; // Угол между вершинами

              List<PointF> starPoints = new List<PointF>();

              double currentAngle = -Math.PI / 2; // Начальный угол

              for (int i = 0; i < vertices * 2; i++)
              {
                  double radius = (i % 2 == 0) ? Size : Size / 2; // Чередование радиусов для вершин

                  float px = x + (float)(radius * Math.Cos(currentAngle)); // Преобразование в декартовы координаты
                  float py = y + (float)(radius * Math.Sin(currentAngle));

                  starPoints.Add(new PointF(px, py));

                  currentAngle += angleIncrement;
              }

              using (Graphics g = Graphics.FromImage(image))
              {
                  g.FillPolygon(new SolidBrush(BrushColor), starPoints.ToArray()); // Рисование звезды
              }
//=========================================================================================================================================================      
 


        }
    }

    class HeartBrush : Brush
    {
        public HeartBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            List<PointF> heartPoints = new List<PointF>();

            for (double theta = -Math.PI; theta <= 0; theta += 0.01)
            {
                double r = 1 - Math.Sin(theta);
                float px = x + (float)(r * Math.Cos(theta) * Size); // Преобразование в декартовы координаты
                float py = y - (float)(r * Math.Sin(theta) * Size);
                heartPoints.Add(new PointF(px, py));
            }

            for (double theta = 0; theta <= Math.PI; theta += 0.01)
            {
                double r = 1 - Math.Sin(theta);
                float px = x + (float)(r * Math.Cos(theta) * Size); // Преобразование в декартовы координаты
                float py = y - (float)(r * Math.Sin(theta) * Size);
                heartPoints.Add(new PointF(px, py));
            }

            using (Graphics g = Graphics.FromImage(image))
            {
                g.FillPolygon(new SolidBrush(BrushColor), heartPoints.ToArray()); // Рисование сердца
            }
        }
    }

    class TransparentQuadBrush : Brush
    {
        public TransparentQuadBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            int startX = Math.Max(0, x - Size);
            int endX = Math.Min(image.Width - 1, x + Size);
            int startY = Math.Max(0, y - Size);
            int endY = Math.Min(image.Height - 1, y + Size);

            for (int y0 = startY; y0 <= endY; ++y0)
            {
                for (int x0 = startX; x0 <= endX; ++x0)
                {
                    if (x0 >= 0 && x0 < image.Width && y0 >= 0 && y0 < image.Height)
                    {
                        Color currentColor = image.GetPixel(x0, y0);
                        int newR = (currentColor.R + BrushColor.R) / 2; // Пример прозрачности: усреднение значений красного
                        int newG = (currentColor.G + BrushColor.G) / 2; // Пример прозрачности: усреднение значений зеленого
                        int newB = (currentColor.B + BrushColor.B) / 2; // Пример прозрачности: усреднение значений синего
                        Color newColor = Color.FromArgb(newR, newG, newB);
                        image.SetPixel(x0, y0, newColor);
                    }
                }
            }
        }

    }

    /*class EraserBrush : Brush
    {
        public EraserBrush(int size)
            : base(Color.Transparent, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    image.SetPixel(x0, y0, Color.Transparent); // Устанавливаем прозрачный цвет для "стирания"
                }
            }
        }
    }*/



}
