using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Painting
{
    public partial class Form1 : Form
    {
        const int ImageWidth = 1920;
        const int ImageHeight = 1080;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(ImageWidth, ImageHeight);
            ImageBackColor = Color.White;
            LinesColor = Color.Black;
            lblBackColor.BackColor = Color.White;
            lblLinesColor.BackColor = Color.Black;
            lblBackColor.Paint += label_paint;
            lblLinesColor.Paint += label_paint;
            btnDraw.Click += BtnDraw_Click;
            btnSave.Click += BtnSave_Click;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var path = $@"{dialog.SelectedPath}\{DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss tt")}.jpeg";
                bitmap.Save(path, ImageFormat.Jpeg);
            }
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            DrawCarbet();
        }

        private void label_paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,((Label)sender).DisplayRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        public Color ImageBackColor { get; set; } 
        public Color LinesColor { get; set; } 

        private void DrawCarbet()
        {
            decimal radius = decimal.Parse(txtRadius.Text);
            decimal distance = decimal.Parse(txtDistance.Text);

            Pen pen = new Pen(LinesColor, (int)numericUpDown1.Value);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(new SolidBrush(ImageBackColor), 0, 0, ImageWidth, ImageHeight);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            graphics.InterpolationMode = InterpolationMode.High;
            pictureBox1.BackgroundImage = bitmap;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;


            for (int w = 10; w < ImageWidth - (int)radius - 10; w += (int)distance)
            {
                for (int h = 10; h < ImageHeight - (int)radius - 10; h += (int)distance)
                {
                    graphics.DrawEllipse(pen, w, h, (int)radius, (int)radius);
                }
            }
        }

        private void lblBackColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImageBackColor = colorDialog1.Color;
            }
            lblBackColor.BackColor = ImageBackColor;
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
