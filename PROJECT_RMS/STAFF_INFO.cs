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
    public partial class STAFF_INFO : Form
    {
        public STAFF_INFO()
        {
            InitializeComponent();
        }

        private void STAFF_INFO_Load(object sender, EventArgs e)
        {
            SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            sinfo.Open();
            string query = " select * from STAFF_TABLE";
            SqlCommand infocd = new SqlCommand(query, sinfo);
            infocd.ExecuteNonQuery();
            SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
            DataSet infods = new DataSet();
            infoadt.Fill(infods);
            DataTable infodt = infods.Tables[0];
            dgvSinfo.AutoGenerateColumns = false;
            dgvSinfo.DataSource = infodt;
            dgvSinfo.Refresh();
            sinfo.Close();


        }

        private void lbEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbviewback_Click(object sender, EventArgs e)
        {
            customerChoicePage view = new customerChoicePage();
            view.Show();
            this.Hide();
        }

        private void lbDELETE_Click(object sender, EventArgs e)
        {
            if(txtSID.Text == "")
            {
                MessageBox.Show(" No Data is Select");
            }
            else
            {
                SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                sinfo.Open();
                string queryd = " delete from STAFF_TABLE where ID=" +txtSID.Text ;
                SqlCommand sinfod = new SqlCommand(queryd, sinfo);
                int row1 = sinfod.ExecuteNonQuery();
                if( row1>0)
                {
                    MessageBox.Show(" Delete Successfull");
                }
                string queryDA = " select * from STAFF_TABLE ";
                SqlCommand sinfoDA = new SqlCommand(queryDA, sinfo);
                sinfoDA.ExecuteNonQuery();
                SqlDataAdapter sinfoadt = new SqlDataAdapter(sinfoDA);
                DataSet sinfods = new DataSet();
                sinfoadt.Fill(sinfods);
                DataTable sinfodt = sinfods.Tables[0];
                dgvSinfo.AutoGenerateColumns = false;
                dgvSinfo.DataSource = sinfodt;
                dgvSinfo.Refresh();
                txtSID.Text = " ";
                txtsNAME.Text = " ";
                sinfo.Close();



            }
           
                

            
        }


        private void dgvSinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>= 0)
            {
                int staffid = Convert.ToInt32(dgvSinfo.Rows[e.RowIndex].Cells[0].Value.ToString());
               
                SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                sinfo.Open();
                string query = " select * from STAFF_TABLE where ID="+staffid;
                SqlCommand infocd = new SqlCommand(query, sinfo);
                infocd.ExecuteNonQuery();
                SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
                DataSet infods = new DataSet();
                infoadt.Fill(infods);
                DataTable infodt = infods.Tables[0];
                txtSID.Text = infodt.Rows[0]["ID"].ToString();
                txtsNAME.Text = infodt.Rows[0]["NAME"].ToString();
                sinfo.Close();
            }
        }

        private void lbrefresh_Click(object sender, EventArgs e)
        {
            
            SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            sinfo.Open();
            string queryR = " select * from STAFF_TABLE";
            SqlCommand infocdR = new SqlCommand(queryR, sinfo);
            infocdR.ExecuteNonQuery();
            SqlDataAdapter infoadtR = new SqlDataAdapter(infocdR);
            DataSet infodsR = new DataSet();
            infoadtR.Fill(infodsR);
            DataTable infodtR = infodsR.Tables[0];
            dgvSinfo.AutoGenerateColumns = false;
            dgvSinfo.DataSource = infodtR;
            dgvSinfo.Refresh();
            txtSID.Text = " ";
            txtsNAME.Text = " ";
            txtSEARCH.Text = " ";
            
        }

        private void lbSEARCH_Click(object sender, EventArgs e)
        {
            if(txtSEARCH.Text == "")
            {
                MessageBox.Show(" Please write something");
            }
            else
            {
                SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                sinfo.Open();
                string queryS = " select * from STAFF_TABLE where NAME  like'%" +txtSEARCH.Text+ "%'" ;
                SqlCommand sinfoS = new SqlCommand(queryS, sinfo );
                sinfoS.ExecuteNonQuery();
                SqlDataAdapter sinfoadtS = new SqlDataAdapter(sinfoS);
                DataSet sinfodsS = new DataSet();
                sinfoadtS.Fill(sinfodsS);
                DataTable sinfodt = sinfodsS.Tables[0];
                dgvSinfo.AutoGenerateColumns = false;
                dgvSinfo.DataSource = sinfodt;
                dgvSinfo.Refresh();
                sinfo.Close();
            }
            
        }
    }
}
