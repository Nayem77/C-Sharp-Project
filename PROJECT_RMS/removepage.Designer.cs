
namespace PROJECT_RMS
{
    partial class removepage
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
            this.dgvRemove = new System.Windows.Forms.DataGridView();
            this.i_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtITEMNAME = new System.Windows.Forms.TextBox();
            this.txtitemNO = new System.Windows.Forms.TextBox();
            this.lbITEMname = new System.Windows.Forms.Label();
            this.lbitemNO = new System.Windows.Forms.Label();
            this.lbrefreshMenu = new System.Windows.Forms.Label();
            this.lbREMOVE = new System.Windows.Forms.Label();
            this.lbRlogout = new System.Windows.Forms.Label();
            this.lbSLPback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRemove
            // 
            this.dgvRemove.AllowUserToAddRows = false;
            this.dgvRemove.AllowUserToDeleteRows = false;
            this.dgvRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i_id,
            this.i_category,
            this.i_name,
            this.i_price});
            this.dgvRemove.Location = new System.Drawing.Point(0, 107);
            this.dgvRemove.Name = "dgvRemove";
            this.dgvRemove.ReadOnly = true;
            this.dgvRemove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemove.Size = new System.Drawing.Size(434, 285);
            this.dgvRemove.TabIndex = 0;
            this.dgvRemove.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemove_CellClick);
            // 
            // i_id
            // 
            this.i_id.DataPropertyName = "ITEM_NO";
            this.i_id.HeaderText = "ITEM NO";
            this.i_id.Name = "i_id";
            this.i_id.ReadOnly = true;
            // 
            // i_category
            // 
            this.i_category.DataPropertyName = "CATACORY";
            this.i_category.HeaderText = "CATEGORY";
            this.i_category.Name = "i_category";
            this.i_category.ReadOnly = true;
            // 
            // i_name
            // 
            this.i_name.DataPropertyName = "ITEM_NAME";
            this.i_name.HeaderText = "ITEM NAME";
            this.i_name.Name = "i_name";
            this.i_name.ReadOnly = true;
            // 
            // i_price
            // 
            this.i_price.DataPropertyName = "PRICE";
            this.i_price.HeaderText = "PRICE";
            this.i_price.Name = "i_price";
            this.i_price.ReadOnly = true;
            // 
            // txtITEMNAME
            // 
            this.txtITEMNAME.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITEMNAME.Location = new System.Drawing.Point(139, 49);
            this.txtITEMNAME.Name = "txtITEMNAME";
            this.txtITEMNAME.Size = new System.Drawing.Size(131, 21);
            this.txtITEMNAME.TabIndex = 8;
            // 
            // txtitemNO
            // 
            this.txtitemNO.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemNO.Location = new System.Drawing.Point(139, 16);
            this.txtitemNO.Name = "txtitemNO";
            this.txtitemNO.Size = new System.Drawing.Size(73, 21);
            this.txtitemNO.TabIndex = 7;
            // 
            // lbITEMname
            // 
            this.lbITEMname.AutoSize = true;
            this.lbITEMname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbITEMname.ForeColor = System.Drawing.Color.Teal;
            this.lbITEMname.Location = new System.Drawing.Point(3, 52);
            this.lbITEMname.Name = "lbITEMname";
            this.lbITEMname.Size = new System.Drawing.Size(122, 18);
            this.lbITEMname.TabIndex = 6;
            this.lbITEMname.Text = "ITEM NAME :";
            // 
            // lbitemNO
            // 
            this.lbitemNO.AutoSize = true;
            this.lbitemNO.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitemNO.ForeColor = System.Drawing.Color.Teal;
            this.lbitemNO.Location = new System.Drawing.Point(33, 19);
            this.lbitemNO.Name = "lbitemNO";
            this.lbitemNO.Size = new System.Drawing.Size(94, 18);
            this.lbitemNO.TabIndex = 5;
            this.lbitemNO.Text = "ITEM NO :";
            // 
            // lbrefreshMenu
            // 
            this.lbrefreshMenu.AutoSize = true;
            this.lbrefreshMenu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefreshMenu.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbrefreshMenu.Location = new System.Drawing.Point(332, 405);
            this.lbrefreshMenu.Name = "lbrefreshMenu";
            this.lbrefreshMenu.Size = new System.Drawing.Size(90, 18);
            this.lbrefreshMenu.TabIndex = 9;
            this.lbrefreshMenu.Text = "REFRESH";
            this.lbrefreshMenu.Click += new System.EventHandler(this.lbrefreshMenu_Click);
            // 
            // lbREMOVE
            // 
            this.lbREMOVE.AutoSize = true;
            this.lbREMOVE.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbREMOVE.ForeColor = System.Drawing.Color.Red;
            this.lbREMOVE.Location = new System.Drawing.Point(12, 405);
            this.lbREMOVE.Name = "lbREMOVE";
            this.lbREMOVE.Size = new System.Drawing.Size(82, 18);
            this.lbREMOVE.TabIndex = 10;
            this.lbREMOVE.Text = "REMOVE";
            this.lbREMOVE.Click += new System.EventHandler(this.lbREMOVE_Click);
            // 
            // lbRlogout
            // 
            this.lbRlogout.AutoSize = true;
            this.lbRlogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRlogout.ForeColor = System.Drawing.Color.Black;
            this.lbRlogout.Location = new System.Drawing.Point(12, 484);
            this.lbRlogout.Name = "lbRlogout";
            this.lbRlogout.Size = new System.Drawing.Size(83, 18);
            this.lbRlogout.TabIndex = 11;
            this.lbRlogout.Text = "LOG OUT";
            this.lbRlogout.Click += new System.EventHandler(this.lbRlogout_Click);
            // 
            // lbSLPback
            // 
            this.lbSLPback.AutoSize = true;
            this.lbSLPback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLPback.Location = new System.Drawing.Point(357, 484);
            this.lbSLPback.Name = "lbSLPback";
            this.lbSLPback.Size = new System.Drawing.Size(55, 18);
            this.lbSLPback.TabIndex = 12;
            this.lbSLPback.Text = "BACK";
            this.lbSLPback.Click += new System.EventHandler(this.lbSLPback_Click);
            // 
            // removepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.lbSLPback);
            this.Controls.Add(this.lbRlogout);
            this.Controls.Add(this.lbREMOVE);
            this.Controls.Add(this.lbrefreshMenu);
            this.Controls.Add(this.txtITEMNAME);
            this.Controls.Add(this.txtitemNO);
            this.Controls.Add(this.lbITEMname);
            this.Controls.Add(this.lbitemNO);
            this.Controls.Add(this.dgvRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "removepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "removepage";
            this.Load += new System.EventHandler(this.removepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_price;
        private System.Windows.Forms.TextBox txtITEMNAME;
        private System.Windows.Forms.TextBox txtitemNO;
        private System.Windows.Forms.Label lbITEMname;
        private System.Windows.Forms.Label lbitemNO;
        private System.Windows.Forms.Label lbrefreshMenu;
        private System.Windows.Forms.Label lbREMOVE;
        private System.Windows.Forms.Label lbRlogout;
        private System.Windows.Forms.Label lbSLPback;
    }
}