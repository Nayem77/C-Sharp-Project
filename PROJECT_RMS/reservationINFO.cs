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
    public partial class reservationINFO : Form
    {
        public reservationINFO()
        {
            InitializeComponent();
        }

        private void lbTRlogout_Click(object sender, EventArgs e)
        {
            staffloginpage bilo = new staffloginpage();
            bilo.Show();
            this.Hide();
        }

        private void reservationINFO_Load(object sender, EventArgs e)
        {
            SqlConnection rinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            rinfo.Open();
            string query = " select * from BOOKING_INFO";
            SqlCommand infocd = new SqlCommand(query, rinfo);
            infocd.ExecuteNonQuery();
            SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
            DataSet infods = new DataSet();
            infoadt.Fill(infods);
            DataTable infodt = infods.Tables[0];
            dgvBinfo.AutoGenerateColumns = false;
            dgvBinfo.DataSource = infodt;
            dgvBinfo.Refresh();
            rinfo.Close();
        }

        private void dgvBinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rno = Convert.ToInt32(dgvBinfo.Rows[e.RowIndex].Cells[0].Value.ToString());

                SqlConnection rinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                rinfo.Open();
                string query = " select * from BOOKING_INFO where BOOKING_NO=" + rno;
                SqlCommand infocd = new SqlCommand(query, rinfo);
                infocd.ExecuteNonQuery();
                SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
                DataSet infods = new DataSet();
                infoadt.Fill(infods);
                DataTable infodt = infods.Tables[0];
                txtBOOKNO.Text = infodt.Rows[0]["BOOKING_NO"].ToString();
                txtCTRname.Text = infodt.Rows[0]["CUSTOMER_NAME"].ToString();
                rinfo.Close();
            }
        }

        private void lbTRsearch_Click(object sender, EventArgs e)
        {
            if (txtTRSEARCH.Text == "")
            {
                MessageBox.Show(" Please write something");
            }
            else
            {
                SqlConnection rinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                rinfo.Open();
                string queryS = " select * from BOOKING_INFO where CUSTOMER_NAME  like'%" + txtTRSEARCH.Text + "%'";
                SqlCommand sinfoS = new SqlCommand(queryS, rinfo);
                sinfoS.ExecuteNonQuery();
                SqlDataAdapter sinfoadtS = new SqlDataAdapter(sinfoS);
                DataSet sinfodsS = new DataSet();
                sinfoadtS.Fill(sinfodsS);
                DataTable sinfodt = sinfodsS.Tables[0];
                dgvBinfo.AutoGenerateColumns = false;
                dgvBinfo.DataSource = sinfodt;
                dgvBinfo.Refresh();
                rinfo.Close();
            }
        }

        private void lbSLPback_Click(object sender, EventArgs e)
        {
            customerChoicePage rr = new customerChoicePage();
            rr.Show();
            this.Hide();
        }
    }
}
