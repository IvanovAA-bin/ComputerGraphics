using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.MathMorphology
{
    class Dilation : Filters // Расширение
    {
        protected MMCoreCreationForm.MMCore mmCore;

        protected Dilation() { }

        public Dilation(MMCoreCreationForm.MMCore mmCore)
        {
            this.mmCore = mmCore;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            //Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Bitmap resultImage = new Bitmap(sourceImage);
            int halfCoreSize = mmCore.coreSize / 2;
            for (int x = halfCoreSize; x < sourceImage.Width - halfCoreSize; x++)
            {
                worker.ReportProgress((int)((float)x / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int y = halfCoreSize; y < sourceImage.Height - halfCoreSize; y++)
                {
                    //Color maxIntensity = Color.FromArgb(0, 0, 0);
                    //Color maxIntensity = sourceImage.GetPixel(x, y);
                    Color maxIntensity = calculateNewPixelColor(sourceImage, x, y);
                    int maxX = x, maxY = y; 
                    for (int i = -halfCoreSize; i <= halfCoreSize; i++)
                    {
                        for (int j = -halfCoreSize; j <= halfCoreSize; j++)
                        {
                            Color currentIntensity = calculateNewPixelColor(sourceImage, x + i, y + j);
                            if (mmCore.core[i + halfCoreSize, j + halfCoreSize] > 0.5F && currentIntensity.R > maxIntensity.R)
                            {
                                maxX = x + i;
                                maxY = y + j;
                                maxIntensity = currentIntensity;
                            }
                        }
                    }
                    resultImage.SetPixel(x, y, sourceImage.GetPixel(maxX, maxY));
                }
            }
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)((float)sourceColor.R * 0.299F + sourceColor.G * 0.587F + sourceColor.B * 0.114);
            intensity = Clamp(intensity, 0, 255);
            Color resultColor = Color.FromArgb(intensity, intensity, intensity);
            return resultColor;
        }
    }
}
