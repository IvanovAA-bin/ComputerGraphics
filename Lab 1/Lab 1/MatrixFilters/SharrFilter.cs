﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class SharrFilter : DCMatrixFilter
    {
        public SharrFilter()
        {
            kernel = new float[3, 3];
            kernel[0, 0] = kernel[0, 2] = 3;
            kernel[0, 1] = 10;
            kernel[2, 0] = kernel[2, 2] = -3;
            kernel[2, 1] = -10;
            kernel[1, 0] = kernel[1, 1] = kernel[1, 2] = 0;
        }
    }
}
