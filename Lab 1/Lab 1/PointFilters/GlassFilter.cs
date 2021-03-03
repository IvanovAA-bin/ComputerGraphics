using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class GlassFilter : Filters
    {
        private Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color resClr = sourceImage.GetPixel(Clamp((int)(x + (rand.NextDouble() - 0.5) * 10), 0, sourceImage.Width - 1),
                                                Clamp((int)(y + (rand.NextDouble() - 0.5) * 10), 0, sourceImage.Height - 1));
            return resClr;
        }
    }
}
