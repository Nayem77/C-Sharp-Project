
namespace PROJECT_RMS
{
    partial class booktable
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
            this.txtCNTR = new System.Windows.Forms.TextBox();
            this.lbCNTR = new System.Windows.Forms.Label();
            this.lbtableNOTR = new System.Windows.Forms.Label();
            this.lbTIMETR = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.lbDATETR = new System.Windows.Forms.Label();
            this.dtpTRdate = new System.Windows.Forms.DateTimePicker();
            this.btBOOK = new System.Windows.Forms.Button();
            this.lbTRlogout = new System.Windows.Forms.Label();
            this.cbTableNO = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 83);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(-1, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 43);
            this.panel2.TabIndex = 1;
            // 
            // txtCNTR
            // 
            this.txtCNTR.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtCNTR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCNTR.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNTR.Location = new System.Drawing.Point(202, 120);
            this.txtCNTR.Multiline = true;
            this.txtCNTR.Name = "txtCNTR";
            this.txtCNTR.Size = new System.Drawing.Size(188, 20);
            this.txtCNTR.TabIndex = 11;
            // 
            // lbCNTR
            // 
            this.lbCNTR.AutoSize = true;
            this.lbCNTR.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNTR.Location = new System.Drawing.Point(12, 118);
            this.lbCNTR.Name = "lbCNTR";
            this.lbCNTR.Size = new System.Drawing.Size(184, 22);
            this.lbCNTR.TabIndex = 10;
            this.lbCNTR.Text = "CUSTOMER NAME :";
            // 
            // lbtableNOTR
            // 
            this.lbtableNOTR.AutoSize = true;
            this.lbtableNOTR.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtableNOTR.Location = new System.Drawing.Point(83, 167);
            this.lbtableNOTR.Name = "lbtableNOTR";
            this.lbtableNOTR.Size = new System.Drawing.Size(113, 22);
            this.lbtableNOTR.TabIndex = 12;
            this.lbtableNOTR.Text = "TABLE NO :";
            // 
            // lbTIMETR
            // 
            this.lbTIMETR.AutoSize = true;
            this.lbTIMETR.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTIMETR.Location = new System.Drawing.Point(126, 219);
            this.lbTIMETR.Name = "lbTIMETR";
            this.lbTIMETR.Size = new System.Drawing.Size(70, 22);
            this.lbTIMETR.TabIndex = 14;
            this.lbTIMETR.Text = "TIME :";
            // 
            // cbTime
            // 
            this.cbTime.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTime.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "12-1",
            "1-2",
            "2-3",
            "3-4",
            "4-5",
            "5-6",
            "6-7",
            "7-8"});
            this.cbTime.Location = new System.Drawing.Point(202, 217);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(188, 23);
            this.cbTime.TabIndex = 15;
            // 
            // lbDATETR
            // 
            this.lbDATETR.AutoSize = true;
            this.lbDATETR.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDATETR.Location = new System.Drawing.Point(126, 265);
            this.lbDATETR.Name = "lbDATETR";
            this.lbDATETR.Size = new System.Drawing.Size(72, 22);
            this.lbDATETR.TabIndex = 16;
            this.lbDATETR.Text = "DATE :";
            // 
            // dtpTRdate
            // 
            this.dtpTRdate.Location = new System.Drawing.Point(204, 267);
            this.dtpTRdate.Name = "dtpTRdate";
            this.dtpTRdate.Size = new System.Drawing.Size(200, 20);
            this.dtpTRdate.TabIndex = 17;
            // 
            // btBOOK
            // 
            this.btBOOK.BackColor = System.Drawing.Color.LightGreen;
            this.btBOOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBOOK.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBOOK.ForeColor = System.Drawing.Color.Teal;
            this.btBOOK.Location = new System.Drawing.Point(204, 335);
            this.btBOOK.Name = "btBOOK";
            this.btBOOK.Size = new System.Drawing.Size(75, 23);
            this.btBOOK.TabIndex = 18;
            this.btBOOK.Text = "BOOK";
            this.btBOOK.UseVisualStyleBackColor = false;
            this.btBOOK.Click += new System.EventHandler(this.btBOOK_Click);
            // 
            // lbTRlogout
            // 
            this.lbTRlogout.AutoSize = true;
            this.lbTRlogout.BackColor = System.Drawing.Color.DarkGreen;
            this.lbTRlogout.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTRlogout.Location = new System.Drawing.Point(12, 432);
            this.lbTRlogout.Name = "lbTRlogout";
            this.lbTRlogout.Size = new System.Drawing.Size(69, 15);
            this.lbTRlogout.TabIndex = 19;
            this.lbTRlogout.Text = "LOG OUT";
            this.lbTRlogout.Click += new System.EventHandler(this.lbTRlogout_Click);
            // 
            // cbTableNO
            // 
            this.cbTableNO.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.cbTableNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableNO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTableNO.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTableNO.FormattingEnabled = true;
            this.cbTableNO.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbTableNO.Location = new System.Drawing.Point(202, 167);
            this.cbTableNO.Name = "cbTableNO";
            this.cbTableNO.Size = new System.Drawing.Size(188, 23);
            this.cbTableNO.TabIndex = 20;
            // 
            // booktable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.cbTableNO);
            this.Controls.Add(this.lbTRlogout);
            this.Controls.Add(this.btBOOK);
            this.Controls.Add(this.dtpTRdate);
            this.Controls.Add(this.lbDATETR);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.lbTIMETR);
            this.Controls.Add(this.lbtableNOTR);
            this.Controls.Add(this.txtCNTR);
            this.Controls.Add(this.lbCNTR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "booktable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "booktable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCNTR;
        private System.Windows.Forms.Label lbCNTR;
        private System.Windows.Forms.Label lbtableNOTR;
        private System.Windows.Forms.Label lbTIMETR;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label lbDATETR;
        private System.Windows.Forms.DateTimePicker dtpTRdate;
        private System.Windows.Forms.Button btBOOK;
        private System.Windows.Forms.Label lbTRlogout;
        private System.Windows.Forms.ComboBox cbTableNO;
    }
}