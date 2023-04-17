using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_RMS
{
    public partial class booktable : Form
    {
        public booktable()
        {
            InitializeComponent();
        }

        private void lbTRlogout_Click(object sender, EventArgs e)
        {
            customerloginpage trlo = new customerloginpage();
            trlo.Show();
            this.Hide();

        }

        private void btBOOK_Click(object sender, EventArgs e)
        {
            string customer, tableNO, time;
            DateTime date;

            customer = txtCNTR.Text;
            tableNO = cbTableNO.Text.Trim();
            time = cbTime.Text.Trim();
            date = Convert.ToDateTime(dtpTRdate.Text.Trim());

            SqlConnection trcon = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            trcon.Open();
            string querytr = " insert into BOOKING_INFO( CUSTOMER_NAME, TABLE_NO, TIME, DATE) values ( '" + customer + "', '" + tableNO + "' ,'" + time + "', '" + date + "' )";
            SqlCommand trscd = new SqlCommand(querytr, trcon);
            trscd.ExecuteNonQuery();
            MessageBox.Show(" TABLE BOOKING SUCCESSFULL");
            trcon.Close();
        }
    }
}
