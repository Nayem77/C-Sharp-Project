
namespace PROJECT_RMS
{
    partial class BOOKINGinfo
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
            this.lbinfoIntro = new System.Windows.Forms.Label();
            this.lbTableNO = new System.Windows.Forms.Label();
            this.lbfree = new System.Windows.Forms.Label();
            this.txttableNO = new System.Windows.Forms.TextBox();
            this.rbYES = new System.Windows.Forms.RadioButton();
            this.rbNO = new System.Windows.Forms.RadioButton();
            this.dgvTI = new System.Windows.Forms.DataGridView();
            this.btADD = new System.Windows.Forms.Button();
            this.btEDIT = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.t_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_free = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtrBACK = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.lbinfoIntro);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 92);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(1, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 30);
            this.panel2.TabIndex = 1;
            // 
            // lbinfoIntro
            // 
            this.lbinfoIntro.AutoSize = true;
            this.lbinfoIntro.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfoIntro.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbinfoIntro.Location = new System.Drawing.Point(70, 29);
            this.lbinfoIntro.Name = "lbinfoIntro";
            this.lbinfoIntro.Size = new System.Drawing.Size(304, 33);
            this.lbinfoIntro.TabIndex = 0;
            this.lbinfoIntro.Text = "TABLE INFORMATION";
            // 
            // lbTableNO
            // 
            this.lbTableNO.AutoSize = true;
            this.lbTableNO.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableNO.Location = new System.Drawing.Point(25, 121);
            this.lbTableNO.Name = "lbTableNO";
            this.lbTableNO.Size = new System.Drawing.Size(147, 24);
            this.lbTableNO.TabIndex = 2;
            this.lbTableNO.Text = "TABLE NO :";
            // 
            // lbfree
            // 
            this.lbfree.AutoSize = true;
            this.lbfree.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfree.Location = new System.Drawing.Point(85, 168);
            this.lbfree.Name = "lbfree";
            this.lbfree.Size = new System.Drawing.Size(87, 24);
            this.lbfree.TabIndex = 3;
            this.lbfree.Text = "FREE :";
            // 
            // txttableNO
            // 
            this.txttableNO.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txttableNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttableNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttableNO.Location = new System.Drawing.Point(178, 124);
            this.txttableNO.Multiline = true;
            this.txttableNO.Name = "txttableNO";
            this.txttableNO.Size = new System.Drawing.Size(110, 20);
            this.txttableNO.TabIndex = 4;
            // 
            // rbYES
            // 
            this.rbYES.AutoSize = true;
            this.rbYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYES.Location = new System.Drawing.Point(178, 175);
            this.rbYES.Name = "rbYES";
            this.rbYES.Size = new System.Drawing.Size(49, 17);
            this.rbYES.TabIndex = 5;
            this.rbYES.TabStop = true;
            this.rbYES.Text = "YES";
            this.rbYES.UseVisualStyleBackColor = true;
            // 
            // rbNO
            // 
            this.rbNO.AutoSize = true;
            this.rbNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNO.Location = new System.Drawing.Point(239, 175);
            this.rbNO.Name = "rbNO";
            this.rbNO.Size = new System.Drawing.Size(43, 17);
            this.rbNO.TabIndex = 6;
            this.rbNO.TabStop = true;
            this.rbNO.Text = "NO";
            this.rbNO.UseVisualStyleBackColor = true;
            // 
            // dgvTI
            // 
            this.dgvTI.AllowUserToAddRows = false;
            this.dgvTI.AllowUserToDeleteRows = false;
            this.dgvTI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t_NO,
            this.t_free,
            this.t_f});
            this.dgvTI.Location = new System.Drawing.Point(29, 211);
            this.dgvTI.Name = "dgvTI";
            this.dgvTI.ReadOnly = true;
            this.dgvTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTI.Size = new System.Drawing.Size(322, 150);
            this.dgvTI.TabIndex = 7;
            this.dgvTI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTI_CellClick);
            // 
            // btADD
            // 
            this.btADD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btADD.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btADD.Location = new System.Drawing.Point(152, 373);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 8;
            this.btADD.Text = "ADD";
            this.btADD.UseVisualStyleBackColor = false;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btEDIT
            // 
            this.btEDIT.BackColor = System.Drawing.Color.LightGreen;
            this.btEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEDIT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEDIT.ForeColor = System.Drawing.Color.LightGreen;
            this.btEDIT.Location = new System.Drawing.Point(152, 402);
            this.btEDIT.Name = "btEDIT";
            this.btEDIT.Size = new System.Drawing.Size(75, 23);
            this.btEDIT.TabIndex = 9;
            this.btEDIT.Text = "EDIT";
            this.btEDIT.UseVisualStyleBackColor = false;
            this.btEDIT.Click += new System.EventHandler(this.btEDIT_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.LightGreen;
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.Color.LightGreen;
            this.btdelete.Location = new System.Drawing.Point(266, 402);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(85, 23);
            this.btdelete.TabIndex = 10;
            this.btdelete.Text = "DELETE";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // t_NO
            // 
            this.t_NO.DataPropertyName = "NO";
            this.t_NO.HeaderText = "NO";
            this.t_NO.Name = "t_NO";
            this.t_NO.ReadOnly = true;
            // 
            // t_free
            // 
            this.t_free.DataPropertyName = "TABLE_NO";
            this.t_free.HeaderText = "TABLE_NO";
            this.t_free.Name = "t_free";
            this.t_free.ReadOnly = true;
            // 
            // t_f
            // 
            this.t_f.DataPropertyName = "FREE";
            this.t_f.HeaderText = "FREE";
            this.t_f.Name = "t_f";
            this.t_f.ReadOnly = true;
            // 
            // lbtrBACK
            // 
            this.lbtrBACK.AutoSize = true;
            this.lbtrBACK.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrBACK.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbtrBACK.Location = new System.Drawing.Point(26, 450);
            this.lbtrBACK.Name = "lbtrBACK";
            this.lbtrBACK.Size = new System.Drawing.Size(55, 18);
            this.lbtrBACK.TabIndex = 11;
            this.lbtrBACK.Text = "BACK";
            this.lbtrBACK.Click += new System.EventHandler(this.lbtrBACK_Click);
            // 
            // BOOKINGinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.lbtrBACK);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btEDIT);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.dgvTI);
            this.Controls.Add(this.rbNO);
            this.Controls.Add(this.rbYES);
            this.Controls.Add(this.txttableNO);
            this.Controls.Add(this.lbfree);
            this.Controls.Add(this.lbTableNO);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BOOKINGinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOKINGinfo";
            this.Load += new System.EventHandler(this.BOOKINGinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbinfoIntro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTableNO;
        private System.Windows.Forms.Label lbfree;
        private System.Windows.Forms.TextBox txttableNO;
        private System.Windows.Forms.RadioButton rbYES;
        private System.Windows.Forms.RadioButton rbNO;
        private System.Windows.Forms.DataGridView dgvTI;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button btEDIT;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_free;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_f;
        private System.Windows.Forms.Label lbtrBACK;
    }
}