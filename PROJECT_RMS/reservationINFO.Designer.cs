
namespace PROJECT_RMS
{
    partial class reservationINFO
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
            this.dgvBinfo = new System.Windows.Forms.DataGridView();
            this.txtTRSEARCH = new System.Windows.Forms.TextBox();
            this.lbTRsearch = new System.Windows.Forms.Label();
            this.txtCTRname = new System.Windows.Forms.TextBox();
            this.txtBOOKNO = new System.Windows.Forms.TextBox();
            this.lbCtrname = new System.Windows.Forms.Label();
            this.lbbookNO = new System.Windows.Forms.Label();
            this.lbTRlogout = new System.Windows.Forms.Label();
            this.b_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSLPback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBinfo
            // 
            this.dgvBinfo.AllowUserToAddRows = false;
            this.dgvBinfo.AllowUserToDeleteRows = false;
            this.dgvBinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b_no,
            this.b_customer,
            this.b_table,
            this.b_time,
            this.b_date});
            this.dgvBinfo.Location = new System.Drawing.Point(0, 123);
            this.dgvBinfo.Name = "dgvBinfo";
            this.dgvBinfo.ReadOnly = true;
            this.dgvBinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBinfo.Size = new System.Drawing.Size(529, 320);
            this.dgvBinfo.TabIndex = 0;
            this.dgvBinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBinfo_CellClick);
            // 
            // txtTRSEARCH
            // 
            this.txtTRSEARCH.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRSEARCH.Location = new System.Drawing.Point(337, 65);
            this.txtTRSEARCH.Name = "txtTRSEARCH";
            this.txtTRSEARCH.Size = new System.Drawing.Size(131, 21);
            this.txtTRSEARCH.TabIndex = 12;
            // 
            // lbTRsearch
            // 
            this.lbTRsearch.AutoSize = true;
            this.lbTRsearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTRsearch.ForeColor = System.Drawing.Color.Teal;
            this.lbTRsearch.Location = new System.Drawing.Point(380, 32);
            this.lbTRsearch.Name = "lbTRsearch";
            this.lbTRsearch.Size = new System.Drawing.Size(88, 18);
            this.lbTRsearch.TabIndex = 11;
            this.lbTRsearch.Text = "SEARCH :";
            this.lbTRsearch.Click += new System.EventHandler(this.lbTRsearch_Click);
            // 
            // txtCTRname
            // 
            this.txtCTRname.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTRname.Location = new System.Drawing.Point(166, 65);
            this.txtCTRname.Name = "txtCTRname";
            this.txtCTRname.Size = new System.Drawing.Size(131, 21);
            this.txtCTRname.TabIndex = 10;
            // 
            // txtBOOKNO
            // 
            this.txtBOOKNO.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBOOKNO.Location = new System.Drawing.Point(166, 32);
            this.txtBOOKNO.Name = "txtBOOKNO";
            this.txtBOOKNO.Size = new System.Drawing.Size(73, 21);
            this.txtBOOKNO.TabIndex = 9;
            // 
            // lbCtrname
            // 
            this.lbCtrname.AutoSize = true;
            this.lbCtrname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCtrname.ForeColor = System.Drawing.Color.Teal;
            this.lbCtrname.Location = new System.Drawing.Point(-3, 68);
            this.lbCtrname.Name = "lbCtrname";
            this.lbCtrname.Size = new System.Drawing.Size(169, 18);
            this.lbCtrname.TabIndex = 8;
            this.lbCtrname.Text = "CUSROMER NAME :";
            // 
            // lbbookNO
            // 
            this.lbbookNO.AutoSize = true;
            this.lbbookNO.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbookNO.ForeColor = System.Drawing.Color.Teal;
            this.lbbookNO.Location = new System.Drawing.Point(45, 35);
            this.lbbookNO.Name = "lbbookNO";
            this.lbbookNO.Size = new System.Drawing.Size(121, 18);
            this.lbbookNO.TabIndex = 7;
            this.lbbookNO.Text = "BOOKING NO:";
            // 
            // lbTRlogout
            // 
            this.lbTRlogout.AutoSize = true;
            this.lbTRlogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTRlogout.ForeColor = System.Drawing.Color.Black;
            this.lbTRlogout.Location = new System.Drawing.Point(9, 478);
            this.lbTRlogout.Name = "lbTRlogout";
            this.lbTRlogout.Size = new System.Drawing.Size(83, 18);
            this.lbTRlogout.TabIndex = 14;
            this.lbTRlogout.Text = "LOG OUT";
            this.lbTRlogout.Click += new System.EventHandler(this.lbTRlogout_Click);
            // 
            // b_no
            // 
            this.b_no.DataPropertyName = "BOOKING_NO";
            this.b_no.HeaderText = "RESERVATION NO";
            this.b_no.Name = "b_no";
            this.b_no.ReadOnly = true;
            // 
            // b_customer
            // 
            this.b_customer.DataPropertyName = "CUSTOMER_NAME";
            this.b_customer.HeaderText = "CUSTOMER NAME";
            this.b_customer.Name = "b_customer";
            this.b_customer.ReadOnly = true;
            // 
            // b_table
            // 
            this.b_table.DataPropertyName = "TABLE_NO";
            this.b_table.HeaderText = "TABLE NO";
            this.b_table.Name = "b_table";
            this.b_table.ReadOnly = true;
            // 
            // b_time
            // 
            this.b_time.DataPropertyName = "TIME";
            this.b_time.HeaderText = "TIME";
            this.b_time.Name = "b_time";
            this.b_time.ReadOnly = true;
            // 
            // b_date
            // 
            this.b_date.DataPropertyName = "DATE";
            this.b_date.HeaderText = "BOOKING DATE";
            this.b_date.Name = "b_date";
            this.b_date.ReadOnly = true;
            // 
            // lbSLPback
            // 
            this.lbSLPback.AutoSize = true;
            this.lbSLPback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLPback.Location = new System.Drawing.Point(463, 478);
            this.lbSLPback.Name = "lbSLPback";
            this.lbSLPback.Size = new System.Drawing.Size(55, 18);
            this.lbSLPback.TabIndex = 15;
            this.lbSLPback.Text = "BACK";
            this.lbSLPback.Click += new System.EventHandler(this.lbSLPback_Click);
            // 
            // reservationINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(530, 511);
            this.Controls.Add(this.lbSLPback);
            this.Controls.Add(this.lbTRlogout);
            this.Controls.Add(this.txtTRSEARCH);
            this.Controls.Add(this.lbTRsearch);
            this.Controls.Add(this.txtCTRname);
            this.Controls.Add(this.txtBOOKNO);
            this.Controls.Add(this.lbCtrname);
            this.Controls.Add(this.lbbookNO);
            this.Controls.Add(this.dgvBinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reservationINFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reservationINFO";
            this.Load += new System.EventHandler(this.reservationINFO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBinfo;
        private System.Windows.Forms.TextBox txtTRSEARCH;
        private System.Windows.Forms.Label lbTRsearch;
        private System.Windows.Forms.TextBox txtCTRname;
        private System.Windows.Forms.TextBox txtBOOKNO;
        private System.Windows.Forms.Label lbCtrname;
        private System.Windows.Forms.Label lbbookNO;
        private System.Windows.Forms.Label lbTRlogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_date;
        private System.Windows.Forms.Label lbSLPback;
    }
}