
namespace PROJECT_RMS
{
    partial class staffloginpage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSback = new System.Windows.Forms.Label();
            this.lbSNRY = new System.Windows.Forms.Label();
            this.btSLogin = new System.Windows.Forms.Button();
            this.txtSPASSWORD = new System.Windows.Forms.TextBox();
            this.txtSUN = new System.Windows.Forms.TextBox();
            this.lbSPASSWORD = new System.Windows.Forms.Label();
            this.lbSUN = new System.Windows.Forms.Label();
            this.lbStaffLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 118);
            this.panel1.TabIndex = 0;
            // 
            // lbSback
            // 
            this.lbSback.AutoSize = true;
            this.lbSback.BackColor = System.Drawing.Color.OliveDrab;
            this.lbSback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSback.Location = new System.Drawing.Point(204, 399);
            this.lbSback.Name = "lbSback";
            this.lbSback.Size = new System.Drawing.Size(55, 18);
            this.lbSback.TabIndex = 14;
            this.lbSback.Text = "BACK";
            this.lbSback.Click += new System.EventHandler(this.lbSback_Click);
            // 
            // lbSNRY
            // 
            this.lbSNRY.AutoSize = true;
            this.lbSNRY.BackColor = System.Drawing.Color.SpringGreen;
            this.lbSNRY.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSNRY.Location = new System.Drawing.Point(157, 357);
            this.lbSNRY.Name = "lbSNRY";
            this.lbSNRY.Size = new System.Drawing.Size(161, 21);
            this.lbSNRY.TabIndex = 13;
            this.lbSNRY.Text = "RESISTRATION";
            this.lbSNRY.Click += new System.EventHandler(this.lbSNRY_Click);
            // 
            // btSLogin
            // 
            this.btSLogin.BackColor = System.Drawing.Color.YellowGreen;
            this.btSLogin.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSLogin.Location = new System.Drawing.Point(188, 303);
            this.btSLogin.Name = "btSLogin";
            this.btSLogin.Size = new System.Drawing.Size(89, 34);
            this.btSLogin.TabIndex = 12;
            this.btSLogin.Text = "LOGIN";
            this.btSLogin.UseVisualStyleBackColor = false;
            this.btSLogin.Click += new System.EventHandler(this.btSLogin_Click);
            // 
            // txtSPASSWORD
            // 
            this.txtSPASSWORD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSPASSWORD.Location = new System.Drawing.Point(188, 238);
            this.txtSPASSWORD.Name = "txtSPASSWORD";
            this.txtSPASSWORD.PasswordChar = '*';
            this.txtSPASSWORD.Size = new System.Drawing.Size(212, 13);
            this.txtSPASSWORD.TabIndex = 11;
            // 
            // txtSUN
            // 
            this.txtSUN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSUN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSUN.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUN.Location = new System.Drawing.Point(188, 197);
            this.txtSUN.Name = "txtSUN";
            this.txtSUN.Size = new System.Drawing.Size(212, 14);
            this.txtSUN.TabIndex = 10;
            // 
            // lbSPASSWORD
            // 
            this.lbSPASSWORD.AutoSize = true;
            this.lbSPASSWORD.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSPASSWORD.Location = new System.Drawing.Point(37, 235);
            this.lbSPASSWORD.Name = "lbSPASSWORD";
            this.lbSPASSWORD.Size = new System.Drawing.Size(139, 24);
            this.lbSPASSWORD.TabIndex = 9;
            this.lbSPASSWORD.Text = "PASSWORD :";
            // 
            // lbSUN
            // 
            this.lbSUN.AutoSize = true;
            this.lbSUN.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSUN.Location = new System.Drawing.Point(37, 193);
            this.lbSUN.Name = "lbSUN";
            this.lbSUN.Size = new System.Drawing.Size(145, 24);
            this.lbSUN.TabIndex = 8;
            this.lbSUN.Text = "USER NAME :";
            // 
            // lbStaffLogin
            // 
            this.lbStaffLogin.AutoSize = true;
            this.lbStaffLogin.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffLogin.Location = new System.Drawing.Point(120, 131);
            this.lbStaffLogin.Name = "lbStaffLogin";
            this.lbStaffLogin.Size = new System.Drawing.Size(198, 29);
            this.lbStaffLogin.TabIndex = 15;
            this.lbStaffLogin.Text = "STAFF LOGIN";
            // 
            // staffloginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.lbStaffLogin);
            this.Controls.Add(this.lbSback);
            this.Controls.Add(this.lbSNRY);
            this.Controls.Add(this.btSLogin);
            this.Controls.Add(this.txtSPASSWORD);
            this.Controls.Add(this.txtSUN);
            this.Controls.Add(this.lbSPASSWORD);
            this.Controls.Add(this.lbSUN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffloginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffloginpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSback;
        private System.Windows.Forms.Label lbSNRY;
        private System.Windows.Forms.Button btSLogin;
        private System.Windows.Forms.TextBox txtSPASSWORD;
        private System.Windows.Forms.TextBox txtSUN;
        private System.Windows.Forms.Label lbSPASSWORD;
        private System.Windows.Forms.Label lbSUN;
        private System.Windows.Forms.Label lbStaffLogin;
    }
}