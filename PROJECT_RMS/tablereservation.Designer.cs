
namespace PROJECT_RMS
{
    partial class tablereservation
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
            this.lbBookTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbBookingInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBookTable
            // 
            this.lbBookTable.AutoSize = true;
            this.lbBookTable.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookTable.Location = new System.Drawing.Point(131, 169);
            this.lbBookTable.Name = "lbBookTable";
            this.lbBookTable.Size = new System.Drawing.Size(165, 24);
            this.lbBookTable.TabIndex = 0;
            this.lbBookTable.Text = "BOOK TABLE";
            this.lbBookTable.Click += new System.EventHandler(this.lbBookTable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 97);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 97);
            this.panel2.TabIndex = 2;
            // 
            // lbBookingInfo
            // 
            this.lbBookingInfo.AutoSize = true;
            this.lbBookingInfo.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingInfo.Location = new System.Drawing.Point(112, 243);
            this.lbBookingInfo.Name = "lbBookingInfo";
            this.lbBookingInfo.Size = new System.Drawing.Size(194, 24);
            this.lbBookingInfo.TabIndex = 3;
            this.lbBookingInfo.Text = "BOOKING INFO";
            this.lbBookingInfo.Click += new System.EventHandler(this.lbBookingInfo_Click);
            // 
            // tablereservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.lbBookingInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbBookTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tablereservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tablereservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBookTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbBookingInfo;
    }
}