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
    public partial class customerloginpage : Form
    {
        public customerloginpage()
        {
            InitializeComponent();
        }

        private void lbcback_Click(object sender, EventArgs e)
        {
            RMS R = new RMS();
            R.Show();
            this.Hide();
        }

        private void lbCNRY_Click(object sender, EventArgs e)
        {
            customerResistrationPage crp = new customerResistrationPage();
            crp.Show();
            this.Hide();
        }

       

        private void btCLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            con.Open();
           if( txtCUN.Text == " ")
            {
                MessageBox.Show(" Please Enter User Name");
            }

           else if ( txtCPASSWORD.Text == " ")
            {
                MessageBox.Show(" Please Enter PASSWORD");
            }

            else
            {
                string query = " Select USERNAME,PASSWORD from CUSTOMER_TABLE where USERNAME = '" + txtCUN.Text.Trim() + "'" +
                " AND PASSWORD = '" + txtCPASSWORD.Text.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count == 1)
                {
                    customerChoicePage ccp = new customerChoicePage("CUSTOMER");
                    ccp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Invalid User Name and PassWord");
                }
            }
            con.Close();
        }

        private void lbGUEST_Click(object sender, EventArgs e)
        {
            customerChoicePage ccp = new customerChoicePage(1);
            ccp.Show();
            this.Hide();
        }
    }
}
