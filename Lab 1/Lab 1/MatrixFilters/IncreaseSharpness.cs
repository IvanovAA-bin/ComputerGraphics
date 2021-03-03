﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class IncreaseSharpness : MatrixFilter
    {
        public IncreaseSharpness()
        {
            kernel = new float[3, 3];
            kernel[0, 0] = kernel[0, 2] = kernel[2, 0] = kernel[2, 2] = 0;
            kernel[0, 1] = kernel[1, 0] = kernel[1, 2] = kernel[2, 1] = -1;
            kernel[1, 1] = 5;
        }
    }
}
