using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class WavesFilter : Filters
    {
        protected bool isHorisontal = true;
        protected WavesFilter() { }
        public WavesFilter(bool isHorisontal)
        {
            this.isHorisontal = isHorisontal;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            Color resClr;
            if (isHorisontal)
                resClr = sourceImage.GetPixel(Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * y / 60)), 0, sourceImage.Width - 1),
                                                                                           Clamp(y, 0, sourceImage.Height - 1));
            else
                resClr = sourceImage.GetPixel(Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * x / 30)), 0, sourceImage.Width - 1),
                                                                                           Clamp(y, 0, sourceImage.Height - 1));

            return resClr;
        }
    }
}
