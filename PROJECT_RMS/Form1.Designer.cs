
namespace PROJECT_RMS
{
    partial class RMS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMS));
            this.plwelcome = new System.Windows.Forms.Panel();
            this.lbexit = new System.Windows.Forms.Label();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRMS = new System.Windows.Forms.Label();
            this.lbcustomer = new System.Windows.Forms.Label();
            this.lbstaff = new System.Windows.Forms.Label();
            this.plwelcome.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plwelcome
            // 
            this.plwelcome.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.plwelcome.Controls.Add(this.lbexit);
            this.plwelcome.Controls.Add(this.lbwelcome);
            this.plwelcome.Location = new System.Drawing.Point(0, 1);
            this.plwelcome.Name = "plwelcome";
            this.plwelcome.Size = new System.Drawing.Size(436, 100);
            this.plwelcome.TabIndex = 0;
            // 
            // lbexit
            // 
            this.lbexit.AutoSize = true;
            this.lbexit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbexit.Location = new System.Drawing.Point(411, 0);
            this.lbexit.Name = "lbexit";
            this.lbexit.Size = new System.Drawing.Size(20, 19);
            this.lbexit.TabIndex = 1;
            this.lbexit.Text = "X";
            this.lbexit.Click += new System.EventHandler(this.lbexit_Click);
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwelcome.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbwelcome.Location = new System.Drawing.Point(117, 7);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(174, 39);
            this.lbwelcome.TabIndex = 0;
            this.lbwelcome.Text = "WELCOME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 410);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "FOOD WORLD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbRMS
            // 
            this.lbRMS.AutoSize = true;
            this.lbRMS.BackColor = System.Drawing.Color.PaleGreen;
            this.lbRMS.Font = new System.Drawing.Font("Vineta BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRMS.Location = new System.Drawing.Point(233, 126);
            this.lbRMS.Name = "lbRMS";
            this.lbRMS.Size = new System.Drawing.Size(152, 26);
            this.lbRMS.TabIndex = 2;
            this.lbRMS.Text = "Login As";
            // 
            // lbcustomer
            // 
            this.lbcustomer.AutoSize = true;
            this.lbcustomer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbcustomer.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcustomer.Location = new System.Drawing.Point(230, 187);
            this.lbcustomer.Name = "lbcustomer";
            this.lbcustomer.Size = new System.Drawing.Size(155, 27);
            this.lbcustomer.TabIndex = 3;
            this.lbcustomer.Text = "CUSTOMER";
            this.lbcustomer.Click += new System.EventHandler(this.lbcustomer_Click);
            // 
            // lbstaff
            // 
            this.lbstaff.AutoSize = true;
            this.lbstaff.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbstaff.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstaff.Location = new System.Drawing.Point(248, 247);
            this.lbstaff.Name = "lbstaff";
            this.lbstaff.Size = new System.Drawing.Size(96, 27);
            this.lbstaff.TabIndex = 4;
            this.lbstaff.Text = "STAFF";
            this.lbstaff.Click += new System.EventHandler(this.lbstaff_Click);
            // 
            // RMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.lbstaff);
            this.Controls.Add(this.lbcustomer);
            this.Controls.Add(this.lbRMS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plwelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RMS";
            this.plwelcome.ResumeLayout(false);
            this.plwelcome.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plwelcome;
        private System.Windows.Forms.Label lbexit;
        private System.Windows.Forms.Label lbwelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbRMS;
        private System.Windows.Forms.Label lbcustomer;
        private System.Windows.Forms.Label lbstaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

