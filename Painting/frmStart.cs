using System;
using System.Windows.Forms;

namespace Painting
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnCarbet_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLines frm = new frmLines();
            frm.Show();
        }
    }
}
