using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Painting.UserControls
{
    public partial class PatternControl : UserControl
    {
        public int Diagonal1 { get; set; } 
        public int Diagonal2 { get; set; }
        public int Step { get; set; }
        public int AxiesCount { get; set; }
        public Color LinesColor { get; set; }
        public int LineThickness { get; set; }
        public PatternControl()
        {
            InitializeComponent();
        }

        private void Control_Loaded(object sender, EventArgs e)
        {
            cmbAxiesCount.SelectedIndex = 0;
            txtD1.Text = "100";
            txtD2.Text = "200";
            txtStep.Text = "1";
            numericUpDown1.Value = 1;
            lblLinesColor.BackColor = Color.Black;
            this.LinesColor = Color.Black;
            this.Diagonal1 = 100;
            this.Diagonal2 = 200;
            this.Step = 1;
            this.LineThickness = 1;
            this.AxiesCount = 8;
        }

        private void txtD1_TextChanged(object sender, EventArgs e)
        {
            int d1 = 100;
            int.TryParse(txtD1.Text,out d1);
            this.Diagonal1 = d1;
        }

        private void txtD2_TextChanged(object sender, EventArgs e)
        {
            int d2 = 100;
            int.TryParse(txtD2.Text, out d2);
            this.Diagonal2 = d2;
        }

        private void cmbAxiesCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAxiesCount.SelectedIndex >= 0)
            {
                this.AxiesCount = Convert.ToInt32(cmbAxiesCount.Text);
            }
        }

        private void txtStep_TextChanged(object sender, EventArgs e)
        {
            var s = 1;
            int.TryParse(txtStep.Text, out s);
            this.Step = s;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.LineThickness = (int)numericUpDown1.Value;
        }

        private void lblLinesColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.LinesColor = colorDialog.Color;
                lblLinesColor.BackColor = this.LinesColor;
            }
        }
    }
}
