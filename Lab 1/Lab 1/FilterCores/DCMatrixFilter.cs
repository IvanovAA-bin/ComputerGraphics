using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class DCMatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected DCMatrixFilter() { }
        public DCMatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR_Y = 0.0F, resultR_X = 0.0F;
            float resultG_Y = 0.0F, resultG_X = 0.0F;
            float resultB_Y = 0.0F, resultB_X = 0.0F;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR_Y += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG_Y += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB_Y += neighborColor.B * kernel[k + radiusX, l + radiusY];
                    resultR_X += neighborColor.R * kernel[l + radiusY, k + radiusX];
                    resultG_X += neighborColor.G * kernel[l + radiusY, k + radiusX];
                    resultB_X += neighborColor.B * kernel[l + radiusY, k + radiusX];
                }
            }
            return Color.FromArgb(Clamp((int)Math.Sqrt((float)resultR_X * resultR_X + resultR_Y * resultR_Y), 0, 255),
                                  Clamp((int)Math.Sqrt((float)resultG_X * resultG_X + resultG_Y * resultG_Y), 0, 255),
                                  Clamp((int)Math.Sqrt((float)resultB_X * resultB_X + resultB_Y * resultB_Y), 0, 255));
        }
    }
}
