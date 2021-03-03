using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class MotionBlurFilter : MatrixFilter
    {
        int coreSize = 1;
        protected MotionBlurFilter() { }
        public MotionBlurFilter(int coreRadius)
        {
            this.coreSize = coreRadius * 2 + 1;
            this.createCore(coreRadius);
        }
        private void createCore(int coreRadius)
        {
            kernel = new float[coreSize, coreSize];
            for (int i = 0; i < coreSize; i++)
            {
                for (int j = 0; j < coreSize; j++)
                {
                    if (i == j)
                        kernel[i, j] = 1;
                    else
                        kernel[i, j] = 0;
                }
            }
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0.0F;
            float resultG = 0.0F;
            float resultB = 0.0F;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            }
            return Color.FromArgb(Clamp((int)resultR / coreSize, 0, 255),
                                  Clamp((int)resultG / coreSize, 0, 255),
                                  Clamp((int)resultB / coreSize, 0, 255));
        }
    }
}
