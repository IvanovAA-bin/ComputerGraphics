using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class LinHysSt : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)((float)sourceColor.R * 0.299F + sourceColor.G * 0.587F + sourceColor.B * 0.114);
            intensity = Clamp(intensity, 0, 255);
            Color resultColor = Color.FromArgb(intensity, intensity, intensity);
            return resultColor;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap intermediateImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            byte maxIntens = 0, minIntens = 255;
            int firstPartLvl = 0, secPartLvl = 0;

            /* First part - calculating min and max of intensity and creating helper gray image*/
            for (int i = 0; i < sourceImage.Width; i++)
            {
                firstPartLvl = (int)((float)i / resultImage.Width * 100 / 2);
                worker.ReportProgress(firstPartLvl);
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color intense = calculateNewPixelColor(sourceImage, i, j);
                    if (intense.R > maxIntens)
                        maxIntens = intense.R;
                    if (intense.R < minIntens)
                        minIntens = intense.R;
                    intermediateImage.SetPixel(i, j, intense);
                }
            }

            /* Second part - calculating result image */
            for (int i = 0; i < sourceImage.Width; i++)
            {
                secPartLvl = firstPartLvl + (int)((float)i / resultImage.Width * 100 / 2);
                worker.ReportProgress(secPartLvl);
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color sourceIntensity = intermediateImage.GetPixel(i, j);
                    int newIntensity = (int)((float)(sourceIntensity.R - minIntens) / (maxIntens - minIntens) * 255);
                    float coeff = (float)newIntensity / sourceIntensity.R;
                    Color sourceColor = sourceImage.GetPixel(i, j);
                    int R = Clamp((int)((float)sourceColor.R * coeff), 0, 255);
                    int G = Clamp((int)((float)sourceColor.G * coeff), 0, 255);
                    int B = Clamp((int)((float)sourceColor.B * coeff), 0, 255);
                    resultImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return resultImage;
        }
    }
}
