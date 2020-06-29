using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
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
        public Color BackColor { get; set; } 
        public Color LinesColor { get; set; } 
        private void lblMakePainting_Click(object sender, EventArgs e)
        {
            decimal radius = decimal.Parse(txtRadius.Text);
            decimal distance = decimal.Parse(txtDistance.Text);

            Pen p = new Pen(LinesColor,(int)numericUpDown1.Value);
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(new SolidBrush(BackColor), 0, 0, pictureBox1.Width, pictureBox1.Height);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.InterpolationMode = InterpolationMode.High;
            pictureBox1.Image = bitmap;

            g.DrawPattern(new Point(bitmap.Width / 2, bitmap.Height / 2), p, 8, 1, 100, 200);
            //for (int w = 10; w < pictureBox1.Width -(int )radius- 10; w += (int)distance)
            //{
            //    for (int h = 10; h < pictureBox1.Height-(int)radius - 10; h += (int)distance)
            //    {
            //        g.DrawEllipse(p, w, h,  (int)radius,  (int)radius);
            //    }
            //}
            string path = @$"d:\{DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss tt")}.jpeg";
            bitmap.Save(path, ImageFormat.Jpeg);
        }

        private void lblBackColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
            lblBackColor.BackColor = BackColor;
        }

        private void lblLinesColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                LinesColor = colorDialog1.Color;
            }
            lblLinesColor.BackColor = LinesColor;
        }
    }
}
