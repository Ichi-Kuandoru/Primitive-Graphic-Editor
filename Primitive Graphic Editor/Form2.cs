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
    public partial class Form2 : Form
    {

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
                string text = tbWidth.Text; //tb Width - TextBox for entering width
                int value = Convert.ToInt32(text);//Convert - static class for converting basic types
                return value;
            }
        }

        public int H
        {
            get
            {
                string text = tbHeight.Text; //tb Height - TextBox for entering Height
                int value = Convert.ToInt32(text);//Convert - static class for converting basic types
                return value;
            }
        }

        bool _canceled = false;
        public bool Canceled
        {
            get { return _canceled; }
        }

    public Form2()
        {
            InitializeComponent();
        }
    }
}
