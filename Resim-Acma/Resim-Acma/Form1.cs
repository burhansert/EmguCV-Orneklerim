using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Resim_Acma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resimAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    Image<Bgr, byte> resim = new Image<Bgr, byte>(dosya.FileName);
                    pictureBox1.Image = resim.Bitmap;
                }
            }
            catch 
            {

            }
        }
    }
}
