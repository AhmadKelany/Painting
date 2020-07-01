using Painting.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painting
{
    public partial class frmLines : Form
    {
        public frmLines()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(1920, 1080);
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, 1920, 1080);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.InterpolationMode = InterpolationMode.High;
            Point centerPoint = new Point(1920 / 2, 1080 / 2);
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
