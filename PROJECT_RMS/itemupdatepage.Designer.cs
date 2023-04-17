
namespace PROJECT_RMS
{
    partial class itemupdatepage
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
            this.lbudSearchITEM = new System.Windows.Forms.Label();
            this.txtudSearchITEM = new System.Windows.Forms.TextBox();
            this.dgvUpDate = new System.Windows.Forms.DataGridView();
            this.i_upItemNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_upCATEGOTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_upItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_upPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtudCATEGORY = new System.Windows.Forms.TextBox();
            this.lbCATEGORY = new System.Windows.Forms.Label();
            this.txtUDitemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtudPRICE = new System.Windows.Forms.TextBox();
            this.lbprice = new System.Windows.Forms.Label();
            this.btUPDATE = new System.Windows.Forms.Button();
            this.lbSlogout = new System.Windows.Forms.Label();
            this.lb_BACK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lbudSearchITEM
            // 
            this.lbudSearchITEM.AutoSize = true;
            this.lbudSearchITEM.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbudSearchITEM.Location = new System.Drawing.Point(25, 43);
            this.lbudSearchITEM.Name = "lbudSearchITEM";
            this.lbudSearchITEM.Size = new System.Drawing.Size(164, 21);
            this.lbudSearchITEM.TabIndex = 0;
            this.lbudSearchITEM.Text = "SEARCH ITEM :";
            this.lbudSearchITEM.Click += new System.EventHandler(this.lbudSearchITEM_Click);
            // 
            // txtudSearchITEM
            // 
            this.txtudSearchITEM.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtudSearchITEM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtudSearchITEM.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtudSearchITEM.Location = new System.Drawing.Point(195, 43);
            this.txtudSearchITEM.Multiline = true;
            this.txtudSearchITEM.Name = "txtudSearchITEM";
            this.txtudSearchITEM.Size = new System.Drawing.Size(128, 20);
            this.txtudSearchITEM.TabIndex = 1;
            // 
            // dgvUpDate
            // 
            this.dgvUpDate.AllowUserToAddRows = false;
            this.dgvUpDate.AllowUserToDeleteRows = false;
            this.dgvUpDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUpDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i_upItemNO,
            this.i_upCATEGOTY,
            this.i_upItemName,
            this.i_upPRICE});
            this.dgvUpDate.Location = new System.Drawing.Point(0, 86);
            this.dgvUpDate.Name = "dgvUpDate";
            this.dgvUpDate.ReadOnly = true;
            this.dgvUpDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpDate.Size = new System.Drawing.Size(434, 233);
            this.dgvUpDate.TabIndex = 2;
            this.dgvUpDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpDate_CellClick);
            // 
            // i_upItemNO
            // 
            this.i_upItemNO.DataPropertyName = "ITEM_NO";
            this.i_upItemNO.HeaderText = "ITEM NO";
            this.i_upItemNO.Name = "i_upItemNO";
            this.i_upItemNO.ReadOnly = true;
            // 
            // i_upCATEGOTY
            // 
            this.i_upCATEGOTY.DataPropertyName = "CATACORY";
            this.i_upCATEGOTY.HeaderText = "CATEGOTY";
            this.i_upCATEGOTY.Name = "i_upCATEGOTY";
            this.i_upCATEGOTY.ReadOnly = true;
            // 
            // i_upItemName
            // 
            this.i_upItemName.DataPropertyName = "ITEM_NAME";
            this.i_upItemName.HeaderText = "ITEM NAME";
            this.i_upItemName.Name = "i_upItemName";
            this.i_upItemName.ReadOnly = true;
            // 
            // i_upPRICE
            // 
            this.i_upPRICE.DataPropertyName = "PRICE";
            this.i_upPRICE.HeaderText = "PRICE";
            this.i_upPRICE.Name = "i_upPRICE";
            this.i_upPRICE.ReadOnly = true;
            // 
            // txtudCATEGORY
            // 
            this.txtudCATEGORY.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtudCATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtudCATEGORY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtudCATEGORY.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtudCATEGORY.Location = new System.Drawing.Point(167, 352);
            this.txtudCATEGORY.Multiline = true;
            this.txtudCATEGORY.Name = "txtudCATEGORY";
            this.txtudCATEGORY.Size = new System.Drawing.Size(128, 20);
            this.txtudCATEGORY.TabIndex = 4;
            // 
            // lbCATEGORY
            // 
            this.lbCATEGORY.AutoSize = true;
            this.lbCATEGORY.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCATEGORY.Location = new System.Drawing.Point(12, 352);
            this.lbCATEGORY.Name = "lbCATEGORY";
            this.lbCATEGORY.Size = new System.Drawing.Size(131, 21);
            this.lbCATEGORY.TabIndex = 3;
            this.lbCATEGORY.Text = "CATEGORY :";
            // 
            // txtUDitemName
            // 
            this.txtUDitemName.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtUDitemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUDitemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUDitemName.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUDitemName.Location = new System.Drawing.Point(167, 405);
            this.txtUDitemName.Multiline = true;
            this.txtUDitemName.Name = "txtUDitemName";
            this.txtUDitemName.Size = new System.Drawing.Size(128, 20);
            this.txtUDitemName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "ITEM NAME :";
            // 
            // txtudPRICE
            // 
            this.txtudPRICE.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtudPRICE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtudPRICE.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtudPRICE.Location = new System.Drawing.Point(167, 448);
            this.txtudPRICE.Multiline = true;
            this.txtudPRICE.Name = "txtudPRICE";
            this.txtudPRICE.Size = new System.Drawing.Size(128, 20);
            this.txtudPRICE.TabIndex = 8;
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.Location = new System.Drawing.Point(12, 448);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(82, 21);
            this.lbprice.TabIndex = 7;
            this.lbprice.Text = "PRICE :";
            // 
            // btUPDATE
            // 
            this.btUPDATE.BackColor = System.Drawing.Color.LightGreen;
            this.btUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUPDATE.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUPDATE.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btUPDATE.Location = new System.Drawing.Point(336, 352);
            this.btUPDATE.Name = "btUPDATE";
            this.btUPDATE.Size = new System.Drawing.Size(75, 23);
            this.btUPDATE.TabIndex = 9;
            this.btUPDATE.Text = "UPDATE";
            this.btUPDATE.UseVisualStyleBackColor = false;
            this.btUPDATE.Click += new System.EventHandler(this.btUPDATE_Click);
            // 
            // lbSlogout
            // 
            this.lbSlogout.AutoSize = true;
            this.lbSlogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlogout.ForeColor = System.Drawing.Color.Black;
            this.lbSlogout.Location = new System.Drawing.Point(13, 484);
            this.lbSlogout.Name = "lbSlogout";
            this.lbSlogout.Size = new System.Drawing.Size(83, 18);
            this.lbSlogout.TabIndex = 10;
            this.lbSlogout.Text = "LOG OUT";
            this.lbSlogout.Click += new System.EventHandler(this.lbSlogout_Click);
            // 
            // lb_BACK
            // 
            this.lb_BACK.AutoSize = true;
            this.lb_BACK.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BACK.ForeColor = System.Drawing.Color.Black;
            this.lb_BACK.Location = new System.Drawing.Point(356, 484);
            this.lb_BACK.Name = "lb_BACK";
            this.lb_BACK.Size = new System.Drawing.Size(55, 18);
            this.lb_BACK.TabIndex = 11;
            this.lb_BACK.Text = "BACK";
            this.lb_BACK.Click += new System.EventHandler(this.lb_BACK_Click);
            // 
            // itemupdatepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.lb_BACK);
            this.Controls.Add(this.lbSlogout);
            this.Controls.Add(this.btUPDATE);
            this.Controls.Add(this.txtudPRICE);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.txtUDitemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtudCATEGORY);
            this.Controls.Add(this.lbCATEGORY);
            this.Controls.Add(this.dgvUpDate);
            this.Controls.Add(this.txtudSearchITEM);
            this.Controls.Add(this.lbudSearchITEM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "itemupdatepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "itemupdatepage";
            this.Load += new System.EventHandler(this.itemupdatepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbudSearchITEM;
        private System.Windows.Forms.TextBox txtudSearchITEM;
        private System.Windows.Forms.DataGridView dgvUpDate;
        private System.Windows.Forms.TextBox txtudCATEGORY;
        private System.Windows.Forms.Label lbCATEGORY;
        private System.Windows.Forms.TextBox txtUDitemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtudPRICE;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Button btUPDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_upItemNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_upCATEGOTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_upItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_upPRICE;
        private System.Windows.Forms.Label lbSlogout;
        private System.Windows.Forms.Label lb_BACK;
    }
}