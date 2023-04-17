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
    public partial class removepage : Form
    {
        public removepage()
        {
            InitializeComponent();
        }

        private void dgvRemove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int itemno = Convert.ToInt32(dgvRemove.Rows[e.RowIndex].Cells[0].Value.ToString());

                SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                sinfo.Open();
                string query = " select * from MENU where ITEM_NO=" + itemno;
                SqlCommand infocd = new SqlCommand(query, sinfo);
                infocd.ExecuteNonQuery();
                SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
                DataSet infods = new DataSet();
                infoadt.Fill(infods);
                DataTable infodt = infods.Tables[0];
                txtitemNO.Text = infodt.Rows[0]["ITEM_NO"].ToString();
                txtITEMNAME.Text = infodt.Rows[0]["ITEM_NAME"].ToString();
                sinfo.Close();
            }
        }

        private void removepage_Load(object sender, EventArgs e)
        {
            SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            sinfo.Open();
            string query = " select * from MENU";
            SqlCommand infocd = new SqlCommand(query, sinfo);
            infocd.ExecuteNonQuery();
            SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
            DataSet infods = new DataSet();
            infoadt.Fill(infods);
            DataTable infodt = infods.Tables[0];
            dgvRemove.AutoGenerateColumns = false;
            dgvRemove.DataSource = infodt;
            dgvRemove.Refresh();
            sinfo.Close();
        }

        private void lbrefreshMenu_Click(object sender, EventArgs e)
        {
            SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            sinfo.Open();
            string queryR = " select * from MENU ";
            SqlCommand infocdR = new SqlCommand(queryR, sinfo);
            infocdR.ExecuteNonQuery();
            SqlDataAdapter infoadtR = new SqlDataAdapter(infocdR);
            DataSet infodsR = new DataSet();
            infoadtR.Fill(infodsR);
            DataTable infodtR = infodsR.Tables[0];
            dgvRemove.AutoGenerateColumns = false;
            dgvRemove.DataSource = infodtR;
            dgvRemove.Refresh();
            txtitemNO.Text = " ";
            txtITEMNAME.Text = " ";
        }

        private void lbREMOVE_Click(object sender, EventArgs e)
        {
            if (txtitemNO.Text == "")
            {
                MessageBox.Show(" No Data is Select");
            }
            else
            {
                SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                sinfo.Open();
                string queryd = " delete from MENU where ITEM_NO=" + txtitemNO.Text;
                SqlCommand sinfod = new SqlCommand(queryd, sinfo);
                int row1 = sinfod.ExecuteNonQuery();
                if (row1 > 0)
                {
                    MessageBox.Show(" REMOVE Successfull");
                }
                string queryDA = " select * from MENU ";
                SqlCommand sinfoDA = new SqlCommand(queryDA, sinfo);
                sinfoDA.ExecuteNonQuery();
                SqlDataAdapter sinfoadt = new SqlDataAdapter(sinfoDA);
                DataSet sinfods = new DataSet();
                sinfoadt.Fill(sinfods);
                DataTable sinfodt = sinfods.Tables[0];
                dgvRemove.AutoGenerateColumns = false;
                dgvRemove.DataSource = sinfodt;
                dgvRemove.Refresh();
                txtitemNO.Text = " ";
                txtITEMNAME.Text = " ";
                sinfo.Close();
            }
        }

        private void lbRlogout_Click(object sender, EventArgs e)
        {
            staffloginpage slo1 = new staffloginpage();
            slo1.Show();
            this.Hide();
        }

        private void lbSLPback_Click(object sender, EventArgs e)
        {
            customerChoicePage rp = new customerChoicePage();
            rp.Show();
            this.Hide();
        }
    }
}
