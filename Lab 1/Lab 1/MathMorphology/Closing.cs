using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.MathMorphology
{
    class Closing : Filters
    {
        MMCoreCreationForm.MMCore mmCore;
        protected Closing() { }
        public Closing(MMCoreCreationForm.MMCore mmCore)
        {
            this.mmCore = mmCore;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Erosion erosion = new Erosion(mmCore);
            Dilation dilation = new Dilation(mmCore);
            return erosion.processImage(dilation.processImage(sourceImage, worker), worker);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
