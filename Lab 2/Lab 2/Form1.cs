using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Lab_2.Helpers;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        private Bin bin;
        private MyView view;
        private bool loaded;
        private bool needReload = false;
        private int currentLayer = 0;
        private int FrameCount;
        private bool renderByTextures = false;
        private DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        public Form1()
        {
            InitializeComponent();
            renderByTextures = checkBox1.Checked;
            loaded = false;
            bin = new Bin();
            view = new MyView();
            Application.Idle += Application_Idle1;
        }

        private void Application_Idle1(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps={0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                //trackBar1.Value = Bin.Z;
                trackBar1.Maximum = Bin.Z;
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
            }
        }

        
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (renderByTextures)
                {
                    if (needReload)
                    {
                        view.generateTextureImage(currentLayer);
                        view.Load2DTexture();
                        needReload = false;
                    }
                    view.DrawTexture();
                    glControl1.SwapBuffers();
                }
                else
                {
                    view.DrawQuads(currentLayer);
                    glControl1.SwapBuffers();
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            needReload = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            renderByTextures = checkBox1.Checked;
        }
    }
}
