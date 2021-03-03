using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class SepiaFilter : Filters
    {
        float k = 0.0F;
        protected SepiaFilter()
        { }
        public SepiaFilter(float k)
        {
            this.k = k;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)((float)sourceColor.R * 0.299F + sourceColor.G * 0.587F + sourceColor.B * 0.114);
            intensity = Clamp(intensity, 0, 255);
            int R = Clamp((int)(intensity + 2 * k), 0, 255);
            int G = Clamp((int)(intensity + 0.5F * k), 0, 255);
            int B = Clamp((int)(intensity - 1 * k), 0, 255);
            Color resultColor = Color.FromArgb(R, G, B);
            return resultColor;
        }
    }
}
