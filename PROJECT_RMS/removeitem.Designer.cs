
namespace PROJECT_RMS
{
    partial class removeitem
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
            this.dgvRemoveItem = new System.Windows.Forms.DataGridView();
            this.i_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSlogout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRemoveItem
            // 
            this.dgvRemoveItem.AllowUserToAddRows = false;
            this.dgvRemoveItem.AllowUserToDeleteRows = false;
            this.dgvRemoveItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemoveItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i_NO,
            this.i_category,
            this.i_name,
            this.i_price});
            this.dgvRemoveItem.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRemoveItem.Location = new System.Drawing.Point(0, 100);
            this.dgvRemoveItem.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dgvRemoveItem.Name = "dgvRemoveItem";
            this.dgvRemoveItem.ReadOnly = true;
            this.dgvRemoveItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemoveItem.Size = new System.Drawing.Size(0, 309);
            this.dgvRemoveItem.TabIndex = 0;
            // 
            // i_NO
            // 
            this.i_NO.DataPropertyName = "ITEM_NO";
            this.i_NO.HeaderText = "ITEM_NO";
            this.i_NO.Name = "i_NO";
            this.i_NO.ReadOnly = true;
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
            // lbSlogout
            // 
            this.lbSlogout.AutoSize = true;
            this.lbSlogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlogout.ForeColor = System.Drawing.Color.Red;
            this.lbSlogout.Location = new System.Drawing.Point(0, 421);
            this.lbSlogout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lbSlogout.Name = "lbSlogout";
            this.lbSlogout.Size = new System.Drawing.Size(8, 16);
            this.lbSlogout.TabIndex = 1;
            this.lbSlogout.Text = "LOG OUT";
            // 
            // removeitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(0F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(409, 511);
            this.Controls.Add(this.lbSlogout);
            this.Controls.Add(this.dgvRemoveItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "removeitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "removeitem";
            this.Load += new System.EventHandler(this.removeitem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemoveItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRemoveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_price;
        private System.Windows.Forms.Label lbSlogout;
    }
}