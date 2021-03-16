using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.MathMorphology
{
    class BlackHat : Filters
    {
        MMCoreCreationForm.MMCore mmCore;
        protected BlackHat() { }
        public BlackHat(MMCoreCreationForm.MMCore mmCore)
        {
            this.mmCore = mmCore;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            //Opening opn = new Opening(mmCore); // = black screen
            Dilation opn = new Dilation(mmCore); // = result as in lectures
            //Closing opn = new Closing(mmCore); // = interesting reaction
            //Erosion opn = new Erosion(mmCore); // = black screen
            Bitmap openedImage = opn.processImage(sourceImage, worker);
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color openedImPixel = openedImage.GetPixel(i, j);
                    Color sourceImPixel = sourceImage.GetPixel(i, j);
                    int R = Clamp(openedImPixel.R - sourceImPixel.R, 0, 255);
                    int G = Clamp(openedImPixel.G - sourceImPixel.G, 0, 255);
                    int B = Clamp(openedImPixel.B - sourceImPixel.B, 0, 255);
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
