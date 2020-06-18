using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMakePainting_Click(object sender, EventArgs e)
        {
            decimal radius = decimal.Parse(txtRadius.Text);
            decimal distance = decimal.Parse(txtDistance.Text);

            Pen p = new Pen(Brushes.Goldenrod,1);
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.InterpolationMode = InterpolationMode.High;
            pictureBox1.Image = bitmap;
            for (int w = 10; w < pictureBox1.Width -(int )radius- 10; w += (int)distance)
            {
                for (int h = 10; h < pictureBox1.Height-(int)radius - 10; h += (int)distance)
                {
                    g.DrawEllipse(p, w, h,  (int)radius,  (int)radius);
                }
            }
        }
    }
}
