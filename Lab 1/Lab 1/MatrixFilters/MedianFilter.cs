using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class MedianFilter : Filters
    {
        int coreRad;
        private MedianFilter()
        { }

        public MedianFilter(int coreRadius)
        {
            coreRad = coreRadius;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            GrayScaleFilter gsf = new GrayScaleFilter();
            Bitmap grayIMG = gsf.processImage(sourceImage, worker);
            Bitmap resultImage = new Bitmap(sourceImage);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                worker.ReportProgress((int)((float)x / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int y = 0; y < sourceImage.Height; y++)
                {

                    int sortSize = (coreRad * 2 + 1) * (coreRad * 2 + 1);
                    sortData[] sMas = new sortData[sortSize];
                    for (int i = 0; i < sortSize; i++)
                        sMas[i] = new sortData();
                    for (int i = -coreRad; i <= coreRad; i++)
                    {
                        for (int j = -coreRad; j <= coreRad; j++)
                        {
                            int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                            int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                            Color sortColor = grayIMG.GetPixel(idX, idY);
                            int index = (i + coreRad) * (coreRad * 2 + 1) + (j + coreRad);
                            sMas[index].value = sortColor.R;
                            sMas[index].posX = idX;
                            sMas[index].posY = idY;
                        }
                    }

                    sortMas(sMas, sortSize);

                    int posX = sMas[sortSize / 2].posX;
                    int posY = sMas[sortSize / 2].posY;
                    resultImage.SetPixel(x, y, sourceImage.GetPixel(posX, posY));

                }
            }
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException();
        }



        private class sortData
        {
            public int value;
            public int posX;
            public int posY;
            public sortData()
            {
                value = posX = posY = 0;
            }
        }

        private void swap(ref sortData d1, ref sortData d2)
        {
            sortData temp = new sortData();
            temp.value = d1.value;
            temp.posX = d1.posX;
            temp.posY = d1.posY;
            d1.value = d2.value;
            d1.posX = d2.posX;
            d1.posY = d2.posY;
            d2.value = temp.value;
            d2.posX = temp.posX;
            d2.posY = temp.posY;
        }

        private void sortMas(sortData[] mas, int size)
        {
            for (int i = 1; i < size; i++)
            {
                int key = mas[i].value;
                int j = i;
                while ((j > 1) && (mas[j - 1].value > key))
                {
                    swap(ref mas[j - 1], ref mas[j]);
                    j--;
                }
                mas[j].value = key;
            }
        }


    }

}
