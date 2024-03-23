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
        public override void Draw(Bitmap image,int x,int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    image.SetPixel(x0,y0, BrushColor);
                }
            }
        }
    }
}
