
namespace PROJECT_RMS
{
    partial class staffinfo2
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
            this.dgvSINFO2 = new System.Windows.Forms.DataGridView();
            this.s_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_jd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsid = new System.Windows.Forms.Label();
            this.lbSname = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtsNAME = new System.Windows.Forms.TextBox();
            this.lbsearch = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.lbrefresh = new System.Windows.Forms.Label();
            this.lbdelete = new System.Windows.Forms.Label();
            this.lbSlogout = new System.Windows.Forms.Label();
            this.lbSLPback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSINFO2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSINFO2
            // 
            this.dgvSINFO2.AllowUserToAddRows = false;
            this.dgvSINFO2.AllowUserToDeleteRows = false;
            this.dgvSINFO2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSINFO2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_ID,
            this.s_name,
            this.s_mail,
            this.s_position,
            this.s_jd});
            this.dgvSINFO2.Location = new System.Drawing.Point(1, 112);
            this.dgvSINFO2.Name = "dgvSINFO2";
            this.dgvSINFO2.ReadOnly = true;
            this.dgvSINFO2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSINFO2.Size = new System.Drawing.Size(545, 288);
            this.dgvSINFO2.TabIndex = 0;
            this.dgvSINFO2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSINFO2_CellClick);
            // 
            // s_ID
            // 
            this.s_ID.DataPropertyName = "ID";
            this.s_ID.HeaderText = "STAFF ID";
            this.s_ID.Name = "s_ID";
            this.s_ID.ReadOnly = true;
            // 
            // s_name
            // 
            this.s_name.DataPropertyName = "NAME";
            this.s_name.HeaderText = "STAFF_NAME";
            this.s_name.Name = "s_name";
            this.s_name.ReadOnly = true;
            // 
            // s_mail
            // 
            this.s_mail.DataPropertyName = "EMAIL";
            this.s_mail.HeaderText = "EMAIL";
            this.s_mail.Name = "s_mail";
            this.s_mail.ReadOnly = true;
            // 
            // s_position
            // 
            this.s_position.DataPropertyName = "POSITION";
            this.s_position.HeaderText = "POSITION";
            this.s_position.Name = "s_position";
            this.s_position.ReadOnly = true;
            // 
            // s_jd
            // 
            this.s_jd.DataPropertyName = "JD";
            this.s_jd.HeaderText = "JOINING DATE";
            this.s_jd.Name = "s_jd";
            this.s_jd.ReadOnly = true;
            // 
            // lbsid
            // 
            this.lbsid.AutoSize = true;
            this.lbsid.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsid.ForeColor = System.Drawing.Color.Teal;
            this.lbsid.Location = new System.Drawing.Point(28, 22);
            this.lbsid.Name = "lbsid";
            this.lbsid.Size = new System.Drawing.Size(100, 18);
            this.lbsid.TabIndex = 1;
            this.lbsid.Text = "STAFF ID :";
            // 
            // lbSname
            // 
            this.lbSname.AutoSize = true;
            this.lbSname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSname.ForeColor = System.Drawing.Color.Teal;
            this.lbSname.Location = new System.Drawing.Point(-2, 55);
            this.lbSname.Name = "lbSname";
            this.lbSname.Size = new System.Drawing.Size(130, 18);
            this.lbSname.TabIndex = 2;
            this.lbSname.Text = "STAFF NAME :";
            // 
            // txtSID
            // 
            this.txtSID.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtSID.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSID.Location = new System.Drawing.Point(134, 19);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(73, 21);
            this.txtSID.TabIndex = 3;
            // 
            // txtsNAME
            // 
            this.txtsNAME.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtsNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsNAME.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsNAME.Location = new System.Drawing.Point(134, 52);
            this.txtsNAME.Name = "txtsNAME";
            this.txtsNAME.Size = new System.Drawing.Size(131, 21);
            this.txtsNAME.TabIndex = 4;
            // 
            // lbsearch
            // 
            this.lbsearch.AutoSize = true;
            this.lbsearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsearch.ForeColor = System.Drawing.Color.Teal;
            this.lbsearch.Location = new System.Drawing.Point(293, 19);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(88, 18);
            this.lbsearch.TabIndex = 5;
            this.lbsearch.Text = "SEARCH :";
            this.lbsearch.Click += new System.EventHandler(this.lbsearch_Click);
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtSEARCH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSEARCH.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.Location = new System.Drawing.Point(296, 52);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(131, 21);
            this.txtSEARCH.TabIndex = 6;
            // 
            // lbrefresh
            // 
            this.lbrefresh.AutoSize = true;
            this.lbrefresh.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefresh.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbrefresh.Location = new System.Drawing.Point(416, 412);
            this.lbrefresh.Name = "lbrefresh";
            this.lbrefresh.Size = new System.Drawing.Size(90, 18);
            this.lbrefresh.TabIndex = 7;
            this.lbrefresh.Text = "REFRESH";
            this.lbrefresh.Click += new System.EventHandler(this.lbrefresh_Click);
            // 
            // lbdelete
            // 
            this.lbdelete.AutoSize = true;
            this.lbdelete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdelete.ForeColor = System.Drawing.Color.Red;
            this.lbdelete.Location = new System.Drawing.Point(15, 412);
            this.lbdelete.Name = "lbdelete";
            this.lbdelete.Size = new System.Drawing.Size(80, 18);
            this.lbdelete.TabIndex = 8;
            this.lbdelete.Text = "DELETE";
            this.lbdelete.Click += new System.EventHandler(this.lbdelete_Click);
            // 
            // lbSlogout
            // 
            this.lbSlogout.AutoSize = true;
            this.lbSlogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlogout.ForeColor = System.Drawing.Color.Black;
            this.lbSlogout.Location = new System.Drawing.Point(12, 484);
            this.lbSlogout.Name = "lbSlogout";
            this.lbSlogout.Size = new System.Drawing.Size(83, 18);
            this.lbSlogout.TabIndex = 9;
            this.lbSlogout.Text = "LOG OUT";
            this.lbSlogout.Click += new System.EventHandler(this.lbSlogout_Click);
            // 
            // lbSLPback
            // 
            this.lbSLPback.AutoSize = true;
            this.lbSLPback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLPback.Location = new System.Drawing.Point(451, 484);
            this.lbSLPback.Name = "lbSLPback";
            this.lbSLPback.Size = new System.Drawing.Size(55, 18);
            this.lbSLPback.TabIndex = 10;
            this.lbSLPback.Text = "BACK";
            this.lbSLPback.Click += new System.EventHandler(this.lbSLPback_Click);
            // 
            // staffinfo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(548, 511);
            this.Controls.Add(this.lbSLPback);
            this.Controls.Add(this.lbSlogout);
            this.Controls.Add(this.lbdelete);
            this.Controls.Add(this.lbrefresh);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.txtsNAME);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.lbSname);
            this.Controls.Add(this.lbsid);
            this.Controls.Add(this.dgvSINFO2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "staffinfo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffinfo2";
            this.Load += new System.EventHandler(this.staffinfo2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSINFO2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSINFO2;
        private System.Windows.Forms.Label lbsid;
        private System.Windows.Forms.Label lbSname;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.TextBox txtsNAME;
        private System.Windows.Forms.Label lbsearch;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_jd;
        private System.Windows.Forms.Label lbrefresh;
        private System.Windows.Forms.Label lbdelete;
        private System.Windows.Forms.Label lbSlogout;
        private System.Windows.Forms.Label lbSLPback;
    }
}