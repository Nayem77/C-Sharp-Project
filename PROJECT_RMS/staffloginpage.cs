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
    public partial class staffloginpage : Form
    {
        public staffloginpage()
        {
            InitializeComponent();
        }

        private void lbSback_Click(object sender, EventArgs e)
        {
            RMS R1 = new RMS();
            R1.Show();
            this.Hide();
        }

        private void lbSNRY_Click(object sender, EventArgs e)
        {
            staffResistrationPage srp = new staffResistrationPage();
            srp.Show();
            this.Hide();
        }

        private void btSLogin_Click(object sender, EventArgs e)
        {
            SqlConnection CONN = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            CONN.Open();
            
                if ( txtSUN.Text == " ")
                {
                    MessageBox.Show(" Please Enter User Name");
                }
                else if (txtSPASSWORD.Text == " ")
                {
                    MessageBox.Show(" Please Enter PASSWORD");
                }
                else
                {
                    string query = " Select USERNAME,PASSWORD from STAFF_TABLE where USERNAME = '" + txtSUN.Text.Trim() + "'" +
                " AND PASSWORD = '" + txtSPASSWORD.Text.Trim() + "' ";
                    SqlDataAdapter sda1 = new SqlDataAdapter(query, CONN);
                    DataTable dtb1 = new DataTable();
                    sda1.Fill(dtb1);
                    if (dtb1.Rows.Count == 1)
                    {
                        Usertype ut = new Usertype();
                    ut.Show();
                    this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(" Invalid User Name and PassWord");
                    }

                }

            
            CONN.Close();
        }
    }
}
