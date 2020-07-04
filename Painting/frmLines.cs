using Painting.UserControls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Painting
{
    public partial class frmLines : Form
    {
        const int ImageWidth = 1920;
        const int ImageHeight = 1080;
        public Color ImageBackColor { get; set; }
        public frmLines()
        {
            InitializeComponent();
            lblBackColor.Paint += LblBackColor_Paint;
            lblBackColor.Click += LblBackColor_Click;
            ImageBackColor = Color.White;
        }

        private void LblBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImageBackColor = colorDialog.Color;
            }
            lblBackColor.BackColor = ImageBackColor;
        }

        private void LblBackColor_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Label)sender).DisplayRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(ImageWidth, ImageHeight);
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(new SolidBrush(ImageBackColor), 0, 0, ImageWidth, ImageHeight);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.InterpolationMode = InterpolationMode.High;
            Point centerPoint = new Point(ImageWidth / 2, ImageHeight / 2);
            pictureBox1.BackgroundImage = bitmap;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            foreach (var c in flowLayoutPanel1.Controls.OfType<PatternControl>())
            {
                g.DrawPattern(centerPoint, c);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new PatternControl());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                var path = $@"{folderBrowser.SelectedPath}\{DateTime.Now.ToString("yyyy - MM - dd hh - mm - ss tt")}.jpeg";
                pictureBox1.BackgroundImage.Save(path);
            }
        }
    }
}
