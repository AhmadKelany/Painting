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

    }
}
