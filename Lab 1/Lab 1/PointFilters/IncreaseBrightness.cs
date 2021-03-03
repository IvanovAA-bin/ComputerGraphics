using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class IncreaseBrightness : Filters
    {
        protected int coeff = 0;
        private IncreaseBrightness()
        { }
        public IncreaseBrightness(int coeff)
        {
            this.coeff = coeff;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(Clamp(sourceColor.R + coeff, 0, 255),
                                               Clamp(sourceColor.G + coeff, 0, 255),
                                               Clamp(sourceColor.B + coeff, 0, 255));
            return resultColor;
        }
    }
}
