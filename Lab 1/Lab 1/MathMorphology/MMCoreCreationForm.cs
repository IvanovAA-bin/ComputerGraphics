using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1.MathMorphology
{
    public partial class MMCoreCreationForm : Form
    {
        public class MMCore
        {
            public float[,] core { get; set; }
            public int coreSize { get; set; }
        }

        private static int gridPenSize = 4;
        //private float[,] core;
        //private int coreSize;
        MMCore mmCore;
        private Bitmap buf;
        private Graphics graphics;

        protected MMCoreCreationForm()
        {
            InitializeComponent();
        }

        public MMCoreCreationForm(MMCore mmCore)
        {
            InitializeComponent();
            this.mmCore = mmCore;
            this.mmCore.core = null;
            this.mmCore.coreSize = 0;
            buf = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = buf;
            graphics = Graphics.FromImage(buf);
        }

        private void drawGrid()
        {
            Pen gridPen = new Pen(Color.Gray, gridPenSize / 2);
            float dx = (float)pictureBox1.Width / mmCore.coreSize;
            float dy = (float)pictureBox1.Height / mmCore.coreSize;
            for (int i = 0; i <= mmCore.coreSize; i++)
            {
                graphics.DrawLine(gridPen, 0, dy * i, buf.Width, dy * i);
                graphics.DrawLine(gridPen, dx * i, 0, dx * i, buf.Height);
            }
            pictureBox1.Refresh();
        }

        private void regenCoreAndBitmap(int coreSize)
        {
            this.mmCore.coreSize = coreSize;
            mmCore.core = new float[coreSize, coreSize];
            for (int i = 0; i < coreSize; i++)
                for (int j = 0; j < coreSize; j++)
                    mmCore.core[i, j] = 0.0F;

            graphics.Clear(Color.White); // Clearing surface
            drawGrid();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            regenCoreAndBitmap(3);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            regenCoreAndBitmap(5);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            regenCoreAndBitmap(7);
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mmCore.coreSize == 0)
            {
                MessageBox.Show("Set core size first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MouseEventArgs mouseEventArgs = e as MouseEventArgs; // https://stackoverflow.com/questions/19200288/getting-mouse-click-position-in-picturebox-c-sharp
            if (mouseEventArgs != null)
            {
                int X = mouseEventArgs.X;
                int Y = mouseEventArgs.Y;

                float dX = (float)pictureBox1.Width / mmCore.coreSize;
                float dY = (float)pictureBox1.Height / mmCore.coreSize;

                int indexX = Clamp((int)((float)X / dX), 0, mmCore.coreSize - 1);
                int indexY = Clamp((int)((float)Y / dY), 0, mmCore.coreSize - 1);

                if (mmCore.core[indexX,indexY] < 0.5F)
                {
                    mmCore.core[indexX, indexY] = 1.0F;
                    Rectangle rect = new Rectangle((int)Math.Round(indexX * dX),
                                                   (int)Math.Round(indexY * dY),
                                                   (int)(dX ),
                                                   (int)(dY ));
                    SolidBrush brush = new SolidBrush(Color.Black);
                    graphics.FillRectangle(brush, rect);
                }
                else
                {
                    mmCore.core[indexX, indexY] = 0.0F;
                    Rectangle rect = new Rectangle((int)Math.Round(indexX * dX),
                                                   (int)Math.Round(indexY * dY),
                                                   (int)(dX ),
                                                   (int)(dY ));
                    SolidBrush brush = new SolidBrush(Color.White);
                    graphics.FillRectangle(brush, rect);
                }
                drawGrid();
            }

        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
