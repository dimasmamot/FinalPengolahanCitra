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
        Bitmap objBitmapSwap;
        String mode = "RGB";

        public Form1()
        {
            InitializeComponent();
            disableButtonAwal();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            flushImageObject();
            flushPictureBox();

            DialogResult d = openFileDialog1.ShowDialog();
            if(d == DialogResult.OK)
            {
                objBitmapInput = new Bitmap(openFileDialog1.FileName);
                pictureBoxInput.Image = objBitmapInput;
            }
            if (objBitmapInput != null)
            {
                cetakHistogram();
                enableButtonAwal();
            }            
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

        private void btnFlipHorizontal_Click(object sender, EventArgs e)
        {
            flushImageObject();

            objBitmapOutput1 = new Bitmap(objBitmapInput);
            for (int x = 0; x < objBitmapInput.Width; x++)
            {
                for(int y = 0; y< objBitmapInput.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    objBitmapOutput1.SetPixel(objBitmapInput.Width - 1 - x, y, w);
                }
            }
            pictureBoxOutput1.Image = objBitmapOutput1;
            labelOutput1.Text = "Flip Horizontal";
            btnSwap.Enabled = true;

            objBitmapSwap = objBitmapOutput1;
        }

        private void btnFlipVertikal_Click(object sender, EventArgs e)
        {
            flushImageObject();

            objBitmapOutput1 = new Bitmap(objBitmapInput);
            for (int x = 0; x < objBitmapInput.Width; x++)
            {
                for (int y = 0; y < objBitmapInput.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    objBitmapOutput1.SetPixel(x,objBitmapInput.Height - 1 - y, w);
                }
            }
            pictureBoxOutput1.Image = objBitmapOutput1;
            labelOutput1.Text = "Flip Vertikal";
            btnSwap.Enabled = true;

            objBitmapSwap = objBitmapOutput1;
        }

        private void btnLayerRGB_Click(object sender, EventArgs e)
        {
            flushImageObject();
            flushPictureBox();
            objBitmapOutput2 = new Bitmap(objBitmapInput);
            objBitmapOutput3 = new Bitmap(objBitmapInput);
            objBitmapOutput4 = new Bitmap(objBitmapInput);

            for (int x = 0; x<objBitmapInput.Width; x++)
                for(int y =0; y<objBitmapOutput2.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int r = w.R;
                    Color wb = Color.FromArgb(r, 0, 0);
                    objBitmapOutput2.SetPixel(x, y, wb);
                }

            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput3.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int g = w.G;
                    Color wb = Color.FromArgb(0, g, 0);
                    objBitmapOutput3.SetPixel(x, y, wb);
                }

            for(int x = 0; x<objBitmapInput.Width; x++)
                for(int y = 0; y<objBitmapOutput4.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int b = w.B;
                    Color wb = Color.FromArgb(0, 0, b);
                    objBitmapOutput4.SetPixel(x, y, wb);
                }

            pictureBoxOutput2.Image = objBitmapOutput2;
            labelOutput2.Text = "Filtered Red";
            pictureBoxOutput3.Image = objBitmapOutput3;
            labelOutput3.Text = "Filtered Green";
            pictureBoxOutput4.Image = objBitmapOutput4;
            labelOutput4.Text = "FIltered Blue";
        }

        private void btnLayerGrayscale_Click(object sender, EventArgs e)
        {
            flushImageObject();
            flushPictureBox();
            objBitmapOutput2 = new Bitmap(objBitmapInput);
            objBitmapOutput3 = new Bitmap(objBitmapInput);
            objBitmapOutput4 = new Bitmap(objBitmapInput);

            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput2.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int r = w.R;
                    Color wb = Color.FromArgb(r, r, r);
                    objBitmapOutput2.SetPixel(x, y, wb);
                }

            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput3.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int g = w.G;
                    Color wb = Color.FromArgb(g, g, g);
                    objBitmapOutput3.SetPixel(x, y, wb);
                }

            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput4.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int b = w.B;
                    Color wb = Color.FromArgb(b, b, b);
                    objBitmapOutput4.SetPixel(x, y, wb);
                }

            pictureBoxOutput2.Image = objBitmapOutput2;
            labelOutput2.Text = "Grayscale Filtered Red";
            pictureBoxOutput3.Image = objBitmapOutput3;
            labelOutput3.Text = "Grayscale Filtered Green";
            pictureBoxOutput4.Image = objBitmapOutput4;
            labelOutput4.Text = "Grayscale FIltered Blue";
        }

        private void btnKuantisasiCitra8_Click(object sender, EventArgs e)
        {
            flushImageObject();
            flushPictureBox();
            objBitmapOutput1 = new Bitmap(objBitmapInput);
            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput1.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xk = 8 * (int)(xg / 8);
                    Color wb = Color.FromArgb(xk, xk, xk);
                    objBitmapOutput1.SetPixel(x, y, wb);
                }
            pictureBoxOutput1.Image = objBitmapOutput1;
            labelOutput1.Text = "Kuantisasi Citra 8";
            btnSwap.Enabled = true;
            objBitmapSwap = objBitmapOutput1;
        }
        
        private void flushPictureBox()
        {
            pictureBoxOutput1.Image = null;
            labelOutput1.Text = "";
            pictureBoxOutput2.Image = null;
            labelOutput2.Text = "";
            pictureBoxOutput3.Image = null;
            labelOutput3.Text = "";
            pictureBoxOutput4.Image = null;
            labelOutput4.Text = "";
        }

        private void btnKuantisasiCitra16_Click(object sender, EventArgs e)
        {
            flushImageObject();
            flushPictureBox();
            objBitmapOutput1 = new Bitmap(objBitmapInput);
            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput1.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xk = 16 * (int)(xg / 16);
                    Color wb = Color.FromArgb(xk, xk, xk);
                    objBitmapOutput1.SetPixel(x, y, wb);
                }
            pictureBoxOutput1.Image = objBitmapOutput1;
            labelOutput1.Text = "Kuantisasi Citra 16";
            btnSwap.Enabled = true;
            objBitmapSwap = objBitmapOutput1;
        }

        private void btnKuantisasiCitra32_Click(object sender, EventArgs e)
        {
            flushImageObject();
            flushPictureBox();
            objBitmapOutput1 = new Bitmap(objBitmapInput);
            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput1.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xk = 32 * (int)(xg / 32);
                    Color wb = Color.FromArgb(xk, xk, xk);
                    objBitmapOutput1.SetPixel(x, y, wb);
                }
            pictureBoxOutput1.Image = objBitmapOutput1;
            labelOutput1.Text = "Kuantisasi Citra 32";
            btnSwap.Enabled = true;
            objBitmapSwap = objBitmapOutput1;
        }

        private void btnKuantisasiCitra64_Click(object sender, EventArgs e)
        {
            flushImageObject();
            flushPictureBox();
            objBitmapOutput1 = new Bitmap(objBitmapInput);
            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput1.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xk = 64 * (int)(xg / 64);
                    Color wb = Color.FromArgb(xk, xk, xk);
                    objBitmapOutput1.SetPixel(x, y, wb);
                }
            pictureBoxOutput1.Image = objBitmapOutput1;
            labelOutput1.Text = "Kuantisasi Citra 64";
            btnSwap.Enabled = true;
            objBitmapSwap = objBitmapOutput1;
        }

        private void btnKuantisasiCitra128_Click(object sender, EventArgs e)
        {
            flushImageObject();
            flushPictureBox();
            objBitmapOutput1 = new Bitmap(objBitmapInput);
            for (int x = 0; x < objBitmapInput.Width; x++)
                for (int y = 0; y < objBitmapOutput1.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    int xk = 128 * (int)(xg / 128);
                    Color wb = Color.FromArgb(xk, xk, xk);
                    objBitmapOutput1.SetPixel(x, y, wb);
                }
            pictureBoxOutput1.Image = objBitmapOutput1;
            labelOutput1.Text = "Kuantisasi Citra 128";
            btnSwap.Enabled = true;
            objBitmapSwap = objBitmapOutput1;
        }

        private void disableButtonAwal()
        {
            btnSave.Enabled = false;
            toolStripModeWarna.Enabled = false;
            toolStripModifikasiPosisi.Enabled = false;
            btnZoomIn.Enabled = false;
            btnZoomOut.Enabled = false;
            textBoxBrightness.Enabled = false;
            btnBrightness.Enabled = false;
            textBoxContrast.Enabled = false;
            btnContrast.Enabled = false;
            toolStripBangkitkanNoise.Enabled = false;
            toolStripReduksiNoise.Enabled = false;
            btnEdgeDetection.Enabled = false;
            toolStripKuantisasiCitra.Enabled = false;
            toolStripToolsLainnya.Enabled = false;
            btnSwap.Enabled = false;

            labelOutput1.Text = "";
            labelOutput2.Text = "";
            labelOutput3.Text = "";
            labelOutput4.Text = "";
        }

        private void enableButtonAwal()
        {
            btnSave.Enabled = true;
            toolStripModeWarna.Enabled = true;
            toolStripModifikasiPosisi.Enabled = true;
            btnZoomIn.Enabled = true;
            btnZoomOut.Enabled = true;
            textBoxBrightness.Enabled = true;
            btnBrightness.Enabled = true;
            textBoxContrast.Enabled = true;
            btnContrast.Enabled = true;
            toolStripBangkitkanNoise.Enabled = true;
            toolStripReduksiNoise.Enabled = true;
            btnEdgeDetection.Enabled = true;
            toolStripKuantisasiCitra.Enabled = true;
            toolStripToolsLainnya.Enabled = true;
        }

        private void btnModeGrayscale_Click(object sender, EventArgs e)
        {
            flushImageObject();
            mode = "GRAYSCALE";
            objBitmapOutput1 = new Bitmap(objBitmapInput);
            for(int x = 0; x < objBitmapInput.Width; x++)
                for(int y = 0; y < objBitmapOutput1.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    Color wb = Color.FromArgb(xg, xg, xg);
                    objBitmapOutput1.SetPixel(x, y, wb);
                }
            pictureBoxOutput1.Image = objBitmapOutput1;
            btnSwap.Enabled = true;
            labelOutput1.Text = "Grayscale";
            objBitmapSwap = objBitmapOutput1;
        }

        private void btnModeBW_Click(object sender, EventArgs e)
        {
            flushImageObject();
            objBitmapOutput1 = new Bitmap(objBitmapInput);
        for (int x = 0; x < objBitmapInput.Width; x++)
            for(int y = 0; y<objBitmapOutput1.Height; y++)
            {
                Color w = objBitmapInput.GetPixel(x, y);
                int r = w.R;
                int g = w.G;
                int b = w.B;
                int xg = (int)((r + g + b) / 3);
                int xbw = 0;
                if (xg >= 128) xbw = 255;
                Color wb = Color.FromArgb(xbw, xbw, xbw);
                objBitmapOutput1.SetPixel(x, y, wb);
            }
            pictureBoxOutput1.Image = objBitmapOutput1;
            btnSwap.Enabled = true;
            labelOutput1.Text = "Black & White";
            objBitmapSwap = objBitmapOutput1;
        }

        private void flushImageObject()
        {
            objBitmapOutput1 = null;
            objBitmapOutput2 = null;
            objBitmapOutput3 = null;
            objBitmapOutput4 = null;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            flushImageObject();

            objBitmapInput = new Bitmap(objBitmapSwap);
            for(int x = 0; x < objBitmapSwap.Width; x++)
                for(int y = 0; y < objBitmapInput.Height; y++)
                {
                    Color w = objBitmapSwap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    Color wb = Color.FromArgb(r, g, b);
                    objBitmapInput.SetPixel(x, y, wb);
                }
            pictureBoxInput.Image = objBitmapInput;
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            flushImageObject();
            objBitmapOutput1 = new Bitmap(objBitmapInput);
            int a = Convert.ToInt16(textBoxBrightness.Text);

            for(int x = 0; x < objBitmapInput.Width; x++)
            {
                for(int y = 0; y < objBitmapInput.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);
                    int xr = w.R; int xrBaru = xr + a;
                    int xg = w.G; int xgBaru = xg + a;
                    int xb = w.B; int xbBaru = xg + a;

                    if (xrBaru < 0) xrBaru = 0;
                    if (xrBaru > 255) xrBaru = 255;

                    if (xgBaru < 0) xgBaru = 0;
                    if (xgBaru > 255) xgBaru = 255;

                    if (xbBaru < 0) xbBaru = 0;
                    if (xbBaru > 255) xbBaru = 255;

                    Color wb = Color.FromArgb(xrBaru, xgBaru, xbBaru);
                    objBitmapOutput1.SetPixel(x, y, wb);
                }
            }
            pictureBoxOutput1.Image = objBitmapOutput1;
            btnSwap.Enabled = true;
            labelOutput1.Text = "Brightness + "+textBoxBrightness.Text;
            objBitmapSwap = objBitmapOutput1;
        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            flushImageObject();
            objBitmapOutput1 = new Bitmap(objBitmapInput);
            float c = Convert.ToSingle(textBoxContrast.Text);

            if (c < -100) c = -100;
            if (c > 100) c = 100;

            c = (100.0f + c) / 100.0f;

            for(int x = 0; x < objBitmapInput.Width; x++)
            {
                for(int y = 0; y<objBitmapInput.Height; y++)
                {
                    Color w = objBitmapInput.GetPixel(x, y);

                    float xr = w.R/255.0f;
                    xr -= 0.5f;
                    xr *= c;
                    xr += 0.5f;
                    xr *= 255;
                    if (xr < 0) xr = 0;
                    if (xr > 255) xr = 255;

                    float xg = w.G/255.0f;
                    xg -= 0.5f;
                    xg *= c;
                    xg += 0.5f;
                    xg *= 255;
                    if (xg < 0) xg = 0;
                    if (xg > 255) xg = 255;

                    float xb = w.B/255.0f;
                    xb -= 0.5f;
                    xb *= c;
                    xb += 0.5f;
                    xb *= 255;
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;

                    Color wb = Color.FromArgb((byte)xr, (byte)xg, (byte)xb);
                    objBitmapOutput1.SetPixel(x, y, wb);
                }
            }

            pictureBoxOutput1.Image = objBitmapOutput1;
            btnSwap.Enabled = true;
            labelOutput1.Text = "Contrast + " + textBoxContrast.Text;
            objBitmapSwap = objBitmapOutput1;
        }
    }
}
