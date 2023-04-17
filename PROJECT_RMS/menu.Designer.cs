
namespace PROJECT_RMS
{
    partial class menu
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
            this.lbcategory = new System.Windows.Forms.Label();
            this.lbitem = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btadditem = new System.Windows.Forms.Button();
            this.lbmenuback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbcategory
            // 
            this.lbcategory.AutoSize = true;
            this.lbcategory.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcategory.Location = new System.Drawing.Point(61, 95);
            this.lbcategory.Name = "lbcategory";
            this.lbcategory.Size = new System.Drawing.Size(118, 22);
            this.lbcategory.TabIndex = 0;
            this.lbcategory.Text = "CATEGORY :";
            // 
            // lbitem
            // 
            this.lbitem.AutoSize = true;
            this.lbitem.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitem.Location = new System.Drawing.Point(98, 223);
            this.lbitem.Name = "lbitem";
            this.lbitem.Size = new System.Drawing.Size(70, 22);
            this.lbitem.TabIndex = 1;
            this.lbitem.Text = "ITEM :";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.Location = new System.Drawing.Point(92, 267);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(76, 22);
            this.lbprice.TabIndex = 2;
            this.lbprice.Text = "PRICE :";
            // 
            // txtcategory
            // 
            this.txtcategory.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtcategory.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Items.AddRange(new object[] {
            "SOFT DRINK",
            "FAST FOOD ",
            "BANGLADESHI FOOD",
            "PIZZA",
            "INDIAN FOOD",
            "DESERT"});
            this.txtcategory.Location = new System.Drawing.Point(207, 95);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(199, 24);
            this.txtcategory.TabIndex = 3;
            // 
            // txtitem
            // 
            this.txtitem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtitem.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.Location = new System.Drawing.Point(207, 223);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(199, 14);
            this.txtitem.TabIndex = 4;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(207, 268);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(199, 14);
            this.txtprice.TabIndex = 5;
            // 
            // btadditem
            // 
            this.btadditem.BackColor = System.Drawing.Color.LightGreen;
            this.btadditem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btadditem.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadditem.ForeColor = System.Drawing.Color.CadetBlue;
            this.btadditem.Location = new System.Drawing.Point(207, 347);
            this.btadditem.Name = "btadditem";
            this.btadditem.Size = new System.Drawing.Size(89, 26);
            this.btadditem.TabIndex = 6;
            this.btadditem.Text = "ADD ITEM";
            this.btadditem.UseVisualStyleBackColor = false;
            this.btadditem.Click += new System.EventHandler(this.btadditem_Click);
            // 
            // lbmenuback
            // 
            this.lbmenuback.AutoSize = true;
            this.lbmenuback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmenuback.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbmenuback.Location = new System.Drawing.Point(225, 396);
            this.lbmenuback.Name = "lbmenuback";
            this.lbmenuback.Size = new System.Drawing.Size(55, 18);
            this.lbmenuback.TabIndex = 7;
            this.lbmenuback.Text = "BACK";
            this.lbmenuback.Click += new System.EventHandler(this.lbmenuback_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 509);
            this.Controls.Add(this.lbmenuback);
            this.Controls.Add(this.btadditem);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.lbitem);
            this.Controls.Add(this.lbcategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcategory;
        private System.Windows.Forms.Label lbitem;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btadditem;
        private System.Windows.Forms.Label lbmenuback;
    }
}