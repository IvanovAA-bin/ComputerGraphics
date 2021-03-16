using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.MathMorphology
{
    class TopHat : Filters
    {
        MMCoreCreationForm.MMCore mmCore;
        protected TopHat() { }
        public TopHat(MMCoreCreationForm.MMCore mmCore)
        {
            this.mmCore = mmCore;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            //Closing cls = new Closing(mmCore); // = black screen 
            Erosion cls = new Erosion(mmCore);
            //Dilation cls = new Dilation(mmCore); // = black screen
            Bitmap closedImage = cls.processImage(sourceImage, worker);
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color closedImPixel = closedImage.GetPixel(i, j);
                    Color sourceImPixel = sourceImage.GetPixel(i, j);
                    int R = Clamp(sourceImPixel.R - closedImPixel.R, 0, 255);
                    int G = Clamp(sourceImPixel.G - closedImPixel.G, 0, 255);
                    int B = Clamp(sourceImPixel.B - closedImPixel.B, 0, 255);
                    resultImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
