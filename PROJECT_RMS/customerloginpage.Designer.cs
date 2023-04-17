
namespace PROJECT_RMS
{
    partial class customerloginpage
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
            this.lbCUN = new System.Windows.Forms.Label();
            this.lbCPASSWORD = new System.Windows.Forms.Label();
            this.txtCUN = new System.Windows.Forms.TextBox();
            this.txtCPASSWORD = new System.Windows.Forms.TextBox();
            this.btCLogin = new System.Windows.Forms.Button();
            this.lbCNRY = new System.Windows.Forms.Label();
            this.lbcback = new System.Windows.Forms.Label();
            this.lbCLP = new System.Windows.Forms.Label();
            this.lbGUEST = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 121);
            this.panel1.TabIndex = 0;
            // 
            // lbCUN
            // 
            this.lbCUN.AutoSize = true;
            this.lbCUN.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUN.Location = new System.Drawing.Point(23, 204);
            this.lbCUN.Name = "lbCUN";
            this.lbCUN.Size = new System.Drawing.Size(145, 24);
            this.lbCUN.TabIndex = 1;
            this.lbCUN.Text = "USER NAME :";
            // 
            // lbCPASSWORD
            // 
            this.lbCPASSWORD.AutoSize = true;
            this.lbCPASSWORD.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPASSWORD.Location = new System.Drawing.Point(23, 246);
            this.lbCPASSWORD.Name = "lbCPASSWORD";
            this.lbCPASSWORD.Size = new System.Drawing.Size(139, 24);
            this.lbCPASSWORD.TabIndex = 2;
            this.lbCPASSWORD.Text = "PASSWORD :";
            // 
            // txtCUN
            // 
            this.txtCUN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCUN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCUN.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUN.Location = new System.Drawing.Point(174, 208);
            this.txtCUN.Name = "txtCUN";
            this.txtCUN.Size = new System.Drawing.Size(212, 14);
            this.txtCUN.TabIndex = 3;
            // 
            // txtCPASSWORD
            // 
            this.txtCPASSWORD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPASSWORD.Location = new System.Drawing.Point(174, 249);
            this.txtCPASSWORD.Name = "txtCPASSWORD";
            this.txtCPASSWORD.PasswordChar = '*';
            this.txtCPASSWORD.Size = new System.Drawing.Size(212, 13);
            this.txtCPASSWORD.TabIndex = 4;
            // 
            // btCLogin
            // 
            this.btCLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.btCLogin.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCLogin.Location = new System.Drawing.Point(202, 319);
            this.btCLogin.Name = "btCLogin";
            this.btCLogin.Size = new System.Drawing.Size(89, 34);
            this.btCLogin.TabIndex = 5;
            this.btCLogin.Text = "LOGIN";
            this.btCLogin.UseVisualStyleBackColor = false;
            this.btCLogin.Click += new System.EventHandler(this.btCLogin_Click);
            // 
            // lbCNRY
            // 
            this.lbCNRY.AutoSize = true;
            this.lbCNRY.BackColor = System.Drawing.Color.LimeGreen;
            this.lbCNRY.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNRY.Location = new System.Drawing.Point(170, 370);
            this.lbCNRY.Name = "lbCNRY";
            this.lbCNRY.Size = new System.Drawing.Size(161, 21);
            this.lbCNRY.TabIndex = 6;
            this.lbCNRY.Text = "RESISTRATION";
            this.lbCNRY.Click += new System.EventHandler(this.lbCNRY_Click);
            // 
            // lbcback
            // 
            this.lbcback.AutoSize = true;
            this.lbcback.BackColor = System.Drawing.Color.OliveDrab;
            this.lbcback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcback.Location = new System.Drawing.Point(285, 441);
            this.lbcback.Name = "lbcback";
            this.lbcback.Size = new System.Drawing.Size(55, 18);
            this.lbcback.TabIndex = 7;
            this.lbcback.Text = "BACK";
            this.lbcback.Click += new System.EventHandler(this.lbcback_Click);
            // 
            // lbCLP
            // 
            this.lbCLP.AutoSize = true;
            this.lbCLP.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbCLP.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCLP.Location = new System.Drawing.Point(131, 122);
            this.lbCLP.Name = "lbCLP";
            this.lbCLP.Size = new System.Drawing.Size(132, 31);
            this.lbCLP.TabIndex = 8;
            this.lbCLP.Text = "CUSTOMER LOGIN";
            // 
            // lbGUEST
            // 
            this.lbGUEST.AutoSize = true;
            this.lbGUEST.BackColor = System.Drawing.Color.YellowGreen;
            this.lbGUEST.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGUEST.Location = new System.Drawing.Point(157, 441);
            this.lbGUEST.Name = "lbGUEST";
            this.lbGUEST.Size = new System.Drawing.Size(64, 18);
            this.lbGUEST.TabIndex = 9;
            this.lbGUEST.Text = "GUEST";
            this.lbGUEST.Click += new System.EventHandler(this.lbGUEST_Click);
            // 
            // customerloginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.lbGUEST);
            this.Controls.Add(this.lbCLP);
            this.Controls.Add(this.lbcback);
            this.Controls.Add(this.lbCNRY);
            this.Controls.Add(this.btCLogin);
            this.Controls.Add(this.txtCPASSWORD);
            this.Controls.Add(this.txtCUN);
            this.Controls.Add(this.lbCPASSWORD);
            this.Controls.Add(this.lbCUN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerloginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerloginpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCUN;
        private System.Windows.Forms.Label lbCPASSWORD;
        private System.Windows.Forms.TextBox txtCUN;
        private System.Windows.Forms.TextBox txtCPASSWORD;
        private System.Windows.Forms.Button btCLogin;
        private System.Windows.Forms.Label lbCNRY;
        private System.Windows.Forms.Label lbcback;
        private System.Windows.Forms.Label lbCLP;
        private System.Windows.Forms.Label lbGUEST;
    }
}