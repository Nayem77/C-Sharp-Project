
namespace PROJECT_RMS
{
    partial class ORDER
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
            this.lbmenu = new System.Windows.Forms.Label();
            this.lbcategory = new System.Windows.Forms.Label();
            this.comboCATEGORY = new System.Windows.Forms.ComboBox();
            this.listbItem = new System.Windows.Forms.ListBox();
            this.lborderitem = new System.Windows.Forms.Label();
            this.txtorderitem = new System.Windows.Forms.TextBox();
            this.lborderprice = new System.Windows.Forms.Label();
            this.txtorderprice = new System.Windows.Forms.TextBox();
            this.lbquantity = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.lbtotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btatc = new System.Windows.Forms.Button();
            this.dgvorder = new System.Windows.Forms.DataGridView();
            this.i_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_quantiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbremove = new System.Windows.Forms.Label();
            this.lbprimt = new System.Windows.Forms.Label();
            this.lbta = new System.Windows.Forms.Label();
            this.lbtaka = new System.Windows.Forms.Label();
            this.lblogout = new System.Windows.Forms.Label();
            this.lbcLPback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmenu
            // 
            this.lbmenu.AutoSize = true;
            this.lbmenu.Font = new System.Drawing.Font("Script MT Bold", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbmenu.Location = new System.Drawing.Point(183, 9);
            this.lbmenu.Name = "lbmenu";
            this.lbmenu.Size = new System.Drawing.Size(79, 25);
            this.lbmenu.TabIndex = 0;
            this.lbmenu.Text = "MENU";
            // 
            // lbcategory
            // 
            this.lbcategory.AutoSize = true;
            this.lbcategory.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcategory.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbcategory.Location = new System.Drawing.Point(12, 48);
            this.lbcategory.Name = "lbcategory";
            this.lbcategory.Size = new System.Drawing.Size(133, 29);
            this.lbcategory.TabIndex = 1;
            this.lbcategory.Text = "CATEGORY :";
            // 
            // comboCATEGORY
            // 
            this.comboCATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboCATEGORY.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCATEGORY.FormattingEnabled = true;
            this.comboCATEGORY.Items.AddRange(new object[] {
            "SOFT DRINK",
            "FAST FOOD ",
            "BANGLADESHI FOOD",
            "PIZZA",
            "INDIAN FOOD",
            "DESERT"});
            this.comboCATEGORY.Location = new System.Drawing.Point(17, 89);
            this.comboCATEGORY.Name = "comboCATEGORY";
            this.comboCATEGORY.Size = new System.Drawing.Size(152, 23);
            this.comboCATEGORY.TabIndex = 2;
            this.comboCATEGORY.SelectedIndexChanged += new System.EventHandler(this.comboCATEGORY_SelectedIndexChanged);
            // 
            // listbItem
            // 
            this.listbItem.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbItem.FormattingEnabled = true;
            this.listbItem.ItemHeight = 15;
            this.listbItem.Location = new System.Drawing.Point(17, 118);
            this.listbItem.Name = "listbItem";
            this.listbItem.Size = new System.Drawing.Size(152, 124);
            this.listbItem.TabIndex = 3;
            this.listbItem.SelectedIndexChanged += new System.EventHandler(this.listbItem_SelectedIndexChanged);
            // 
            // lborderitem
            // 
            this.lborderitem.AutoSize = true;
            this.lborderitem.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborderitem.ForeColor = System.Drawing.Color.DarkGreen;
            this.lborderitem.Location = new System.Drawing.Point(263, 48);
            this.lborderitem.Name = "lborderitem";
            this.lborderitem.Size = new System.Drawing.Size(138, 29);
            this.lborderitem.TabIndex = 4;
            this.lborderitem.Text = "ITEM NAME";
            // 
            // txtorderitem
            // 
            this.txtorderitem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtorderitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtorderitem.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderitem.Location = new System.Drawing.Point(268, 80);
            this.txtorderitem.Name = "txtorderitem";
            this.txtorderitem.Size = new System.Drawing.Size(133, 14);
            this.txtorderitem.TabIndex = 5;
            // 
            // lborderprice
            // 
            this.lborderprice.AutoSize = true;
            this.lborderprice.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborderprice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lborderprice.Location = new System.Drawing.Point(263, 118);
            this.lborderprice.Name = "lborderprice";
            this.lborderprice.Size = new System.Drawing.Size(77, 29);
            this.lborderprice.TabIndex = 6;
            this.lborderprice.Text = "PRICE";
            // 
            // txtorderprice
            // 
            this.txtorderprice.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtorderprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtorderprice.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderprice.Location = new System.Drawing.Point(268, 150);
            this.txtorderprice.Multiline = true;
            this.txtorderprice.Name = "txtorderprice";
            this.txtorderprice.Size = new System.Drawing.Size(133, 23);
            this.txtorderprice.TabIndex = 7;
            // 
            // lbquantity
            // 
            this.lbquantity.AutoSize = true;
            this.lbquantity.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbquantity.Location = new System.Drawing.Point(263, 185);
            this.lbquantity.Name = "lbquantity";
            this.lbquantity.Size = new System.Drawing.Size(123, 29);
            this.lbquantity.TabIndex = 8;
            this.lbquantity.Text = "QUANTITY";
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtquantity.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(268, 217);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(120, 21);
            this.txtquantity.TabIndex = 9;
            this.txtquantity.ValueChanged += new System.EventHandler(this.txtquantity_ValueChanged);
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbtotal.Location = new System.Drawing.Point(263, 251);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(83, 29);
            this.lbtotal.TabIndex = 10;
            this.lbtotal.Text = "TOTAL ";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(268, 283);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(133, 31);
            this.txttotal.TabIndex = 11;
            // 
            // btatc
            // 
            this.btatc.BackColor = System.Drawing.Color.LightGreen;
            this.btatc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btatc.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatc.ForeColor = System.Drawing.Color.ForestGreen;
            this.btatc.Location = new System.Drawing.Point(44, 270);
            this.btatc.Name = "btatc";
            this.btatc.Size = new System.Drawing.Size(110, 23);
            this.btatc.TabIndex = 12;
            this.btatc.Text = "ADD TO CART";
            this.btatc.UseVisualStyleBackColor = false;
            this.btatc.Click += new System.EventHandler(this.btatc_Click);
            // 
            // dgvorder
            // 
            this.dgvorder.AllowUserToAddRows = false;
            this.dgvorder.AllowUserToDeleteRows = false;
            this.dgvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i_name,
            this.i_quantiry,
            this.i_price,
            this.i_total});
            this.dgvorder.Location = new System.Drawing.Point(44, 320);
            this.dgvorder.Name = "dgvorder";
            this.dgvorder.ReadOnly = true;
            this.dgvorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvorder.Size = new System.Drawing.Size(445, 121);
            this.dgvorder.TabIndex = 13;
            this.dgvorder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorder_CellClick);
            // 
            // i_name
            // 
            this.i_name.HeaderText = "ITEM NAME";
            this.i_name.Name = "i_name";
            this.i_name.ReadOnly = true;
            // 
            // i_quantiry
            // 
            this.i_quantiry.HeaderText = "QUANTITY";
            this.i_quantiry.Name = "i_quantiry";
            this.i_quantiry.ReadOnly = true;
            // 
            // i_price
            // 
            this.i_price.HeaderText = "PRICE";
            this.i_price.Name = "i_price";
            this.i_price.ReadOnly = true;
            // 
            // i_total
            // 
            this.i_total.HeaderText = "TOTAL PRICE";
            this.i_total.Name = "i_total";
            this.i_total.ReadOnly = true;
            // 
            // lbremove
            // 
            this.lbremove.AutoSize = true;
            this.lbremove.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbremove.ForeColor = System.Drawing.Color.Red;
            this.lbremove.Location = new System.Drawing.Point(12, 444);
            this.lbremove.Name = "lbremove";
            this.lbremove.Size = new System.Drawing.Size(82, 18);
            this.lbremove.TabIndex = 14;
            this.lbremove.Text = "REMOVE";
            this.lbremove.Click += new System.EventHandler(this.lbremove_Click);
            // 
            // lbprimt
            // 
            this.lbprimt.AutoSize = true;
            this.lbprimt.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprimt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbprimt.Location = new System.Drawing.Point(452, 444);
            this.lbprimt.Name = "lbprimt";
            this.lbprimt.Size = new System.Drawing.Size(62, 18);
            this.lbprimt.TabIndex = 15;
            this.lbprimt.Text = "PRINT";
            this.lbprimt.Click += new System.EventHandler(this.lbprimt_Click);
            // 
            // lbta
            // 
            this.lbta.AutoSize = true;
            this.lbta.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbta.Location = new System.Drawing.Point(227, 444);
            this.lbta.Name = "lbta";
            this.lbta.Size = new System.Drawing.Size(144, 18);
            this.lbta.TabIndex = 16;
            this.lbta.Text = "TOTAL AMOUNT";
            // 
            // lbtaka
            // 
            this.lbtaka.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaka.ForeColor = System.Drawing.Color.Teal;
            this.lbtaka.Location = new System.Drawing.Point(243, 471);
            this.lbtaka.Name = "lbtaka";
            this.lbtaka.Size = new System.Drawing.Size(113, 18);
            this.lbtaka.TabIndex = 17;
            this.lbtaka.Text = "TAKA : 00";
            this.lbtaka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblogout
            // 
            this.lblogout.AutoSize = true;
            this.lblogout.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogout.ForeColor = System.Drawing.Color.Black;
            this.lblogout.Location = new System.Drawing.Point(14, 480);
            this.lblogout.Name = "lblogout";
            this.lblogout.Size = new System.Drawing.Size(83, 18);
            this.lblogout.TabIndex = 18;
            this.lblogout.Text = "LOG OUT";
            this.lblogout.Click += new System.EventHandler(this.lblogout_Click);
            // 
            // lbcLPback
            // 
            this.lbcLPback.AutoSize = true;
            this.lbcLPback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcLPback.Location = new System.Drawing.Point(459, 480);
            this.lbcLPback.Name = "lbcLPback";
            this.lbcLPback.Size = new System.Drawing.Size(55, 18);
            this.lbcLPback.TabIndex = 19;
            this.lbcLPback.Text = "BACK";
            this.lbcLPback.Click += new System.EventHandler(this.lbcLPback_Click);
            // 
            // ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(546, 507);
            this.Controls.Add(this.lbcLPback);
            this.Controls.Add(this.lblogout);
            this.Controls.Add(this.lbtaka);
            this.Controls.Add(this.lbta);
            this.Controls.Add(this.lbprimt);
            this.Controls.Add(this.lbremove);
            this.Controls.Add(this.dgvorder);
            this.Controls.Add(this.btatc);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.lbquantity);
            this.Controls.Add(this.txtorderprice);
            this.Controls.Add(this.lborderprice);
            this.Controls.Add(this.txtorderitem);
            this.Controls.Add(this.lborderitem);
            this.Controls.Add(this.listbItem);
            this.Controls.Add(this.comboCATEGORY);
            this.Controls.Add(this.lbcategory);
            this.Controls.Add(this.lbmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ORDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDER";
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmenu;
        private System.Windows.Forms.Label lbcategory;
        private System.Windows.Forms.ComboBox comboCATEGORY;
        private System.Windows.Forms.ListBox listbItem;
        private System.Windows.Forms.Label lborderitem;
        private System.Windows.Forms.TextBox txtorderitem;
        private System.Windows.Forms.Label lborderprice;
        private System.Windows.Forms.TextBox txtorderprice;
        private System.Windows.Forms.Label lbquantity;
        private System.Windows.Forms.NumericUpDown txtquantity;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btatc;
        private System.Windows.Forms.DataGridView dgvorder;
        private System.Windows.Forms.Label lbremove;
        private System.Windows.Forms.Label lbprimt;
        private System.Windows.Forms.Label lbta;
        private System.Windows.Forms.Label lbtaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_quantiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_total;
        private System.Windows.Forms.Label lblogout;
        private System.Windows.Forms.Label lbcLPback;
    }
}