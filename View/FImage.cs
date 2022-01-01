using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FImage : Form
    {
        public FImage(String fileName)
        {
            InitializeComponent();
            this.Text = fileName;
            btnPb.SizeMode = PictureBoxSizeMode.AutoSize;
            btnPb.Image = new Bitmap(fileName);
        }
    }
}
