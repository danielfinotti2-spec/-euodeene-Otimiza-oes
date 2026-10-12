namespace Optimizer
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.LinkLabel();
            this.l3 = new System.Windows.Forms.LinkLabel();
            this.l4 = new System.Windows.Forms.LinkLabel();
            this.l5 = new System.Windows.Forms.LinkLabel();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Optimizer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(102, 10);
            this.l1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 28);
            this.l1.TabIndex = 3;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.Gainsboro;
            this.l2.Location = new System.Drawing.Point(104, 44);
            this.l2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(210, 15);
            this.l2.TabIndex = 35;
            this.l2.Tag = "themeable";
            this.l2.Text = "Documentação e atualização: @euodeene";
            this.l2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l2_LinkClicked);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.Gainsboro;
            this.l3.Location = new System.Drawing.Point(104, 68);
            this.l3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(134, 15);
            this.l3.TabIndex = 36;
            this.l3.Tag = "themeable";
            this.l3.Text = "Instagram: @euodeene";
            this.l3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l3_LinkClicked);
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.ForeColor = System.Drawing.Color.Gainsboro;
            this.l4.Location = new System.Drawing.Point(104, 91);
            this.l4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(119, 15);
            this.l4.TabIndex = 37;
            this.l4.Tag = "themeable";
            this.l4.Text = "Discord: servidor";
            this.l4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l4_LinkClicked);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.ForeColor = System.Drawing.Color.Gainsboro;
            this.l5.Location = new System.Drawing.Point(104, 114);
            this.l5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(148, 15);
            this.l5.TabIndex = 38;
            this.l5.Tag = "themeable";
            this.l5.Text = "X / Twitter: @euodeene";
            this.l5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l5_LinkClicked);
            // 
            // t1
            // 
            this.t1.Interval = 350;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(470, 146);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer | @euodeene";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.LinkLabel l2;
        private System.Windows.Forms.LinkLabel l3;
        private System.Windows.Forms.LinkLabel l4;
        private System.Windows.Forms.LinkLabel l5;
        private System.Windows.Forms.Timer t1;
    }
}
