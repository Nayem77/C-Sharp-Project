using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGVPrinterHelper;
using System.Windows.Forms;

namespace PROJECT_RMS
{
    public partial class ORDER : Form
    {
        menu1 odm = new menu1();
        public ORDER()
        {
            InitializeComponent();
        }

        private void comboCATEGORY_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbItem.Items.Clear();

            string query = " select ITEM_NAME from MENU where CATACORY = '"+comboCATEGORY.Text+"'";
            DataSet dsod = odm.dsorder(query);

            for(int i=0; i<dsod.Tables[0].Rows.Count; i++)
            {
                listbItem.Items.Add(dsod.Tables[0].Rows[i][0].ToString());
            }

           
        }

        private void listbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
          txtquantity.ResetText();
          txttotal.Clear();

            string text = listbItem.GetItemText(listbItem.SelectedItem);
            txtorderitem.Text = text;

            string query = " select PRICE from MENU where ITEM_NAME = '"+text+"'";
            DataSet ds = odm.dsorder(query);

            txtorderprice.Text = ds.Tables[0].Rows[0][0].ToString();


        }

        private void txtquantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 qun = Convert.ToInt64(txtquantity.Value.ToString());
            Int64 price = Convert.ToInt64(txtorderprice.Text);
            txttotal.Text = (qun * price).ToString();
        }

        int amount;

        private void dgvorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dgvorder.Rows[e.RowIndex].Cells[3].Value.ToString()); 

            }
            catch { }
        }


        public int p, total = 0;

        private void lbremove_Click(object sender, EventArgs e)
        {
            try
            {
                dgvorder.Rows.RemoveAt(this.dgvorder.SelectedRows[0].Index);
            }
            catch { }

            total = total - amount;
            lbtaka.Text = " TAKA - " + total; 
        }

        private void lbprimt_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = " CUSTOMER ORDER RECEIPT";
            print.SubTitle = string.Format("DATE : {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = " TOTAL BILL : " + lbtaka.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dgvorder);

            total = 0;
            dgvorder.Rows.Clear();
            txtorderitem.Clear();
            txtorderprice.Clear();
            txtquantity.ResetText();
            txttotal.Clear();
            lbtaka.Text = " TAKA : " + total;
        }

        private void lblogout_Click(object sender, EventArgs e)
        {
            customerloginpage clo = new customerloginpage();
            clo.Show();
            this.Hide();
        }

        private void lbcLPback_Click(object sender, EventArgs e)
        {
            customerChoicePage cc = new customerChoicePage("CUSTOMER");
            cc.Show();
            this.Hide();
        }

        private void btatc_Click(object sender, EventArgs e)
        {
           
         
            p = dgvorder.Rows.Add();
            dgvorder.Rows[p].Cells[0].Value = txtorderitem.Text;
            dgvorder.Rows[p].Cells[1].Value = txtquantity.Value;
            dgvorder.Rows[p].Cells[2].Value = txtorderprice.Text;
            dgvorder.Rows[p].Cells[3].Value = txttotal.Text;

            total = total + int.Parse(txttotal.Text);
            lbtaka.Text = " TAKA : " + total;

            txtorderitem.Clear();
            txtorderprice.Clear();
            txtquantity.ResetText();



        }
    }
}
