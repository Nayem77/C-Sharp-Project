
namespace PROJECT_RMS
{
    partial class STAFF_INFO
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
            this.dgvSinfo = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbEXIT = new System.Windows.Forms.Label();
            this.lbviewback = new System.Windows.Forms.Label();
            this.lbDELETE = new System.Windows.Forms.Label();
            this.lbSEARCH = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.lbSID = new System.Windows.Forms.Label();
            this.lbSNAME = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtsNAME = new System.Windows.Forms.TextBox();
            this.lbrefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinfo
            // 
            this.dgvSinfo.AllowUserToAddRows = false;
            this.dgvSinfo.AllowUserToDeleteRows = false;
            this.dgvSinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.sanme,
            this.smail,
            this.saddress,
            this.sposition,
            this.sjd});
            this.dgvSinfo.Location = new System.Drawing.Point(-32768, 77);
            this.dgvSinfo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dgvSinfo.Name = "dgvSinfo";
            this.dgvSinfo.ReadOnly = true;
            this.dgvSinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinfo.Size = new System.Drawing.Size(0, 363);
            this.dgvSinfo.TabIndex = 0;
            this.dgvSinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinfo_CellClick);
            // 
            // sid
            // 
            this.sid.DataPropertyName = "ID";
            this.sid.HeaderText = "STAFF ID";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            // 
            // sanme
            // 
            this.sanme.DataPropertyName = "NAME";
            this.sanme.HeaderText = "STAFF_NAME";
            this.sanme.Name = "sanme";
            this.sanme.ReadOnly = true;
            // 
            // smail
            // 
            this.smail.DataPropertyName = "EMAIL";
            this.smail.HeaderText = "EMAIL";
            this.smail.Name = "smail";
            this.smail.ReadOnly = true;
            // 
            // saddress
            // 
            this.saddress.DataPropertyName = "ADDRESS";
            this.saddress.HeaderText = "ADDRESS";
            this.saddress.Name = "saddress";
            this.saddress.ReadOnly = true;
            // 
            // sposition
            // 
            this.sposition.DataPropertyName = "POSITION";
            this.sposition.HeaderText = "POSITON";
            this.sposition.Name = "sposition";
            this.sposition.ReadOnly = true;
            // 
            // sjd
            // 
            this.sjd.DataPropertyName = "JD";
            this.sjd.HeaderText = "JOINING DATE";
            this.sjd.Name = "sjd";
            this.sjd.ReadOnly = true;
            // 
            // lbEXIT
            // 
            this.lbEXIT.AutoSize = true;
            this.lbEXIT.BackColor = System.Drawing.Color.Red;
            this.lbEXIT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEXIT.Location = new System.Drawing.Point(-32768, 0);
            this.lbEXIT.Margin = new System.Windows.Forms.Padding(0);
            this.lbEXIT.Name = "lbEXIT";
            this.lbEXIT.Size = new System.Drawing.Size(21, 18);
            this.lbEXIT.TabIndex = 1;
            this.lbEXIT.Text = "X";
            this.lbEXIT.Click += new System.EventHandler(this.lbEXIT_Click);
            // 
            // lbviewback
            // 
            this.lbviewback.AutoSize = true;
            this.lbviewback.BackColor = System.Drawing.Color.LightGreen;
            this.lbviewback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbviewback.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbviewback.Location = new System.Drawing.Point(-32768, 462);
            this.lbviewback.Margin = new System.Windows.Forms.Padding(0);
            this.lbviewback.Name = "lbviewback";
            this.lbviewback.Size = new System.Drawing.Size(55, 18);
            this.lbviewback.TabIndex = 2;
            this.lbviewback.Text = "BACK";
            this.lbviewback.Click += new System.EventHandler(this.lbviewback_Click);
            // 
            // lbDELETE
            // 
            this.lbDELETE.AutoSize = true;
            this.lbDELETE.BackColor = System.Drawing.Color.LightGreen;
            this.lbDELETE.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDELETE.ForeColor = System.Drawing.Color.Red;
            this.lbDELETE.Location = new System.Drawing.Point(-32768, 462);
            this.lbDELETE.Margin = new System.Windows.Forms.Padding(0);
            this.lbDELETE.Name = "lbDELETE";
            this.lbDELETE.Size = new System.Drawing.Size(80, 18);
            this.lbDELETE.TabIndex = 3;
            this.lbDELETE.Text = "DELETE";
            this.lbDELETE.Click += new System.EventHandler(this.lbDELETE_Click);
            // 
            // lbSEARCH
            // 
            this.lbSEARCH.AutoSize = true;
            this.lbSEARCH.BackColor = System.Drawing.Color.LightGreen;
            this.lbSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSEARCH.ForeColor = System.Drawing.Color.Teal;
            this.lbSEARCH.Location = new System.Drawing.Point(-32768, 56);
            this.lbSEARCH.Margin = new System.Windows.Forms.Padding(0);
            this.lbSEARCH.Name = "lbSEARCH";
            this.lbSEARCH.Size = new System.Drawing.Size(86, 18);
            this.lbSEARCH.TabIndex = 4;
            this.lbSEARCH.Text = "SEARCH :";
            this.lbSEARCH.Click += new System.EventHandler(this.lbSEARCH_Click);
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.Location = new System.Drawing.Point(-32768, 53);
            this.txtSEARCH.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(0, 21);
            this.txtSEARCH.TabIndex = 5;
            // 
            // lbSID
            // 
            this.lbSID.AutoSize = true;
            this.lbSID.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbSID.Location = new System.Drawing.Point(-32768, 9);
            this.lbSID.Margin = new System.Windows.Forms.Padding(0);
            this.lbSID.Name = "lbSID";
            this.lbSID.Size = new System.Drawing.Size(82, 15);
            this.lbSID.TabIndex = 6;
            this.lbSID.Text = "STAFF ID :";
            // 
            // lbSNAME
            // 
            this.lbSNAME.AutoSize = true;
            this.lbSNAME.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSNAME.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbSNAME.Location = new System.Drawing.Point(-32768, 40);
            this.lbSNAME.Margin = new System.Windows.Forms.Padding(0);
            this.lbSNAME.Name = "lbSNAME";
            this.lbSNAME.Size = new System.Drawing.Size(108, 15);
            this.lbSNAME.TabIndex = 7;
            this.lbSNAME.Text = "STAFF NAME :";
            // 
            // txtSID
            // 
            this.txtSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSID.Location = new System.Drawing.Point(-32768, 3);
            this.txtSID.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtSID.Name = "txtSID";
            this.txtSID.ReadOnly = true;
            this.txtSID.Size = new System.Drawing.Size(0, 20);
            this.txtSID.TabIndex = 8;
            // 
            // txtsNAME
            // 
            this.txtsNAME.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsNAME.Location = new System.Drawing.Point(-32768, 34);
            this.txtsNAME.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtsNAME.Name = "txtsNAME";
            this.txtsNAME.ReadOnly = true;
            this.txtsNAME.Size = new System.Drawing.Size(0, 19);
            this.txtsNAME.TabIndex = 9;
            // 
            // lbrefresh
            // 
            this.lbrefresh.AutoSize = true;
            this.lbrefresh.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefresh.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbrefresh.Location = new System.Drawing.Point(-32768, 34);
            this.lbrefresh.Margin = new System.Windows.Forms.Padding(0);
            this.lbrefresh.Name = "lbrefresh";
            this.lbrefresh.Size = new System.Drawing.Size(76, 15);
            this.lbrefresh.TabIndex = 10;
            this.lbrefresh.Text = "REFRESH";
            this.lbrefresh.Click += new System.EventHandler(this.lbrefresh_Click);
            // 
            // STAFF_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(443, 500);
            this.Controls.Add(this.lbrefresh);
            this.Controls.Add(this.txtsNAME);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.lbSNAME);
            this.Controls.Add(this.lbSID);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.lbSEARCH);
            this.Controls.Add(this.lbDELETE);
            this.Controls.Add(this.lbviewback);
            this.Controls.Add(this.lbEXIT);
            this.Controls.Add(this.dgvSinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "STAFF_INFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STAFF_INFO";
            this.Load += new System.EventHandler(this.STAFF_INFO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinfo;
        private System.Windows.Forms.Label lbEXIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanme;
        private System.Windows.Forms.DataGridViewTextBoxColumn smail;
        private System.Windows.Forms.DataGridViewTextBoxColumn saddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn sposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjd;
        private System.Windows.Forms.Label lbviewback;
        private System.Windows.Forms.Label lbDELETE;
        private System.Windows.Forms.Label lbSEARCH;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Label lbSID;
        private System.Windows.Forms.Label lbSNAME;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.TextBox txtsNAME;
        private System.Windows.Forms.Label lbrefresh;
    }
}