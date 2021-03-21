using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1.LinearHystogramStretching
{
    public partial class LinHystView : Form
    {
        Bitmap im;
        Bitmap resIm;

        protected LinHystView()
        {
            InitializeComponent();
        }

        public LinHystView(Bitmap image)
        {
            InitializeComponent();
            im = new Bitmap(image);
            resIm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            backgroundWorker1.RunWorkerAsync();
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] mas = new int[256];
            for (int i = 0; i < 256; i++)
                mas[i] = 0;

            //Bitmap showImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(resIm);

            int maxIntensValues = 0;
            for (int i = 0; i < im.Width; i++)
            {
                backgroundWorker1.ReportProgress((int)((float)i / im.Width * 100));
                for (int j = 0; j < im.Height; j++)
                {
                    Color sourceColor = im.GetPixel(i, j);
                    int intensity = (int)((float)sourceColor.R * 0.299F + sourceColor.G * 0.587F + sourceColor.B * 0.114);
                    intensity = Clamp(intensity, 0, 255);
                    mas[intensity]++;
                    if (mas[intensity] > maxIntensValues)
                        maxIntensValues = mas[intensity];
                }
            }

            double dx = (double)resIm.Width / 256.0;
            SolidBrush brush = new SolidBrush(Color.Blue);
            for (int i = 0; i < 256; i++)
            {
                double height = (double)mas[i] * resIm.Height / maxIntensValues;
                Rectangle rect = new Rectangle((int)((double)i * dx), resIm.Height - (int)height, (int)dx, (int)height);
                g.FillRectangle(brush, rect);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            pictureBox1.Image = resIm;
            pictureBox1.Refresh();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
