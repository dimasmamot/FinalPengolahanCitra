using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulFinal
{
    public partial class Form1 : Form
    {
        Bitmap objBitmapInput;
        Bitmap objBitmapOutput1;
        Bitmap objBitmapOutput2;
        Bitmap objBitmapOutput3;
        Bitmap objBitmapOutput4;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if(d == DialogResult.OK)
            {
                objBitmapInput = new Bitmap(openFileDialog1.FileName);
                pictureBoxInput.Image = objBitmapInput;
            }
            cetakHistogram();
        }

        private void cetakHistogram()
        {
            float[] h = new float[256];
            int i;
            for (i = 0; i < 256; i++) h[i] = 0;
            
            for(int x = 0;x<objBitmapInput.Width; x++)
            {
                for(int y = 0; y < objBitmapInput.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
                for(i = 0; i< 256; i++)
                {
                    chartHistogram.Series["Series1"].Points.AddXY(i, h[i]);
                }
            }
        }
    }
}
