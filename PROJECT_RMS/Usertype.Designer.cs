
namespace PROJECT_RMS
{
    partial class Usertype
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbuserPassword = new System.Windows.Forms.Label();
            this.txtUSER = new System.Windows.Forms.TextBox();
            this.txtUSERpassword = new System.Windows.Forms.TextBox();
            this.btaccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 80);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 80);
            this.panel2.TabIndex = 1;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Niagara Engraved", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(102, 138);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(50, 23);
            this.lbuser.TabIndex = 2;
            this.lbuser.Text = "USER :";
            // 
            // lbuserPassword
            // 
            this.lbuserPassword.AutoSize = true;
            this.lbuserPassword.Font = new System.Drawing.Font("Niagara Engraved", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuserPassword.Location = new System.Drawing.Point(68, 198);
            this.lbuserPassword.Name = "lbuserPassword";
            this.lbuserPassword.Size = new System.Drawing.Size(84, 23);
            this.lbuserPassword.TabIndex = 3;
            this.lbuserPassword.Text = "PASSWORD :";
            // 
            // txtUSER
            // 
            this.txtUSER.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtUSER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUSER.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSER.Location = new System.Drawing.Point(158, 141);
            this.txtUSER.Multiline = true;
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(153, 20);
            this.txtUSER.TabIndex = 4;
            // 
            // txtUSERpassword
            // 
            this.txtUSERpassword.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtUSERpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUSERpassword.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSERpassword.Location = new System.Drawing.Point(158, 201);
            this.txtUSERpassword.Multiline = true;
            this.txtUSERpassword.Name = "txtUSERpassword";
            this.txtUSERpassword.PasswordChar = '*';
            this.txtUSERpassword.Size = new System.Drawing.Size(153, 20);
            this.txtUSERpassword.TabIndex = 5;
            // 
            // btaccess
            // 
            this.btaccess.BackColor = System.Drawing.Color.LightGreen;
            this.btaccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btaccess.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaccess.Location = new System.Drawing.Point(158, 275);
            this.btaccess.Name = "btaccess";
            this.btaccess.Size = new System.Drawing.Size(75, 23);
            this.btaccess.TabIndex = 6;
            this.btaccess.Text = "ACCESS";
            this.btaccess.UseVisualStyleBackColor = false;
            this.btaccess.Click += new System.EventHandler(this.btaccess_Click);
            // 
            // Usertype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.btaccess);
            this.Controls.Add(this.txtUSERpassword);
            this.Controls.Add(this.txtUSER);
            this.Controls.Add(this.lbuserPassword);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usertype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usertype";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbuserPassword;
        private System.Windows.Forms.TextBox txtUSER;
        private System.Windows.Forms.TextBox txtUSERpassword;
        private System.Windows.Forms.Button btaccess;
    }
}