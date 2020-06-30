namespace Painting.UserControls
{
    partial class PatternControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLinesColor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAxiesCount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbAxiesCount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtStep);
            this.panel1.Controls.Add(this.txtD2);
            this.panel1.Controls.Add(this.txtD1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblLinesColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 159);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "مسافة المستوى الأول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "مسافة المستوى الثاني";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "الخطوة";
            // 
            // lblLinesColor
            // 
            this.lblLinesColor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblLinesColor.Location = new System.Drawing.Point(218, 117);
            this.lblLinesColor.Name = "lblLinesColor";
            this.lblLinesColor.Padding = new System.Windows.Forms.Padding(5);
            this.lblLinesColor.Size = new System.Drawing.Size(38, 29);
            this.lblLinesColor.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "عدد المحاور";
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(59, 9);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(125, 27);
            this.txtD1.TabIndex = 1;
            this.txtD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(59, 41);
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(125, 27);
            this.txtD2.TabIndex = 1;
            this.txtD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(218, 74);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(79, 27);
            this.txtStep.TabIndex = 1;
            this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "لون الخطوط";
            // 
            // cmbAxiesCount
            // 
            this.cmbAxiesCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAxiesCount.FormattingEnabled = true;
            this.cmbAxiesCount.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.cmbAxiesCount.Location = new System.Drawing.Point(11, 73);
            this.cmbAxiesCount.Name = "cmbAxiesCount";
            this.cmbAxiesCount.Size = new System.Drawing.Size(73, 28);
            this.cmbAxiesCount.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "سمك الخط";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 118);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 27);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PatternControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PatternControl";
            this.Size = new System.Drawing.Size(396, 181);
            this.Load += new System.EventHandler(this.Control_Loaded);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLinesColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAxiesCount;
        private System.Windows.Forms.Label label4;
    }
}
