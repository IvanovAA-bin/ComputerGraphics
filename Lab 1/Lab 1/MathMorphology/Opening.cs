using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.MathMorphology
{
    class Opening : Filters
    {
        MMCoreCreationForm.MMCore mmCore;
        protected Opening() { }
        public Opening(MMCoreCreationForm.MMCore mmCore)
        {
            this.mmCore = mmCore;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Erosion erosion = new Erosion(mmCore);
            Dilation dilation = new Dilation(mmCore);
            return dilation.processImage(erosion.processImage(sourceImage, worker), worker);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
