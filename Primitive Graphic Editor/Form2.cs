using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitive_Graphic_Editor
{
    public partial class ImageSizeForm : Form
    {

        bool _canceled = false;
        public bool Canceled
        {
            get { return _canceled; }
        }

        public string N 
        {
            get
            {
                string text = tbFileName.Text;
                string value = (text);
                return value;
            }
        }

        public int W
        {
            get
            {
                string text = tbWidth.Text; 
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        public int H
        {
            get
            {
                string text = tbHeight.Text; 
                int value = Convert.ToInt32(text);
                return value;
            }
        }


        public ImageSizeForm()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }



    }
}

          /**/