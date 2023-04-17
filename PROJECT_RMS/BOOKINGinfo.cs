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
    public partial class BOOKINGinfo : Form
    {
        public BOOKINGinfo()
        {
            InitializeComponent();
        }

        private void BOOKINGinfo_Load(object sender, EventArgs e)
        {
            SqlConnection tinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            tinfo.Open();
            string queryt = " select * from TABLE_INFO ";
            SqlCommand infocd = new SqlCommand(queryt, tinfo);
            infocd.ExecuteNonQuery();
            SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
            DataSet infods = new DataSet();
            infoadt.Fill(infods);
            DataTable infodt = infods.Tables[0];
            dgvTI.AutoGenerateColumns = false;
            dgvTI.DataSource = infodt;
            dgvTI.Refresh();
            tinfo.Close();
        }

        string table, free;
        private void btADD_Click(object sender, EventArgs e)
        {
            
            table = txttableNO.Text;
            

            if( rbYES.Checked)
            {
                free = " YES ";
            }

            else if(rbNO.Checked)
            {
                free = " NO ";
            }

            else
            {
                free = " ";
            }

            SqlConnection tinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            tinfo.Open();
            string queryt = " insert into TABLE_INFO (TABLE_NO, FREE) values('"+table+"' ,'" + free + "')";
            SqlCommand tscd = new SqlCommand(queryt, tinfo);
            int rowt = tscd.ExecuteNonQuery();
            if( rowt>0)
            {
                MessageBox.Show(" ADD SUCCESSFULL");

            }
            tinfo.Close();

            
            tinfo.Open();
            string query = " select * from TABLE_INFO ";
            SqlCommand infocd = new SqlCommand(query, tinfo);
            infocd.ExecuteNonQuery();
            SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
            DataSet infods = new DataSet();
            infoadt.Fill(infods);
            DataTable infodt = infods.Tables[0];
            dgvTI.AutoGenerateColumns = false;
            dgvTI.DataSource = infodt;
            dgvTI.Refresh();
            txttableNO.Text = " ";
            tinfo.Close();


        }

        private void dgvTI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int no = Convert.ToInt32(dgvTI.Rows[e.RowIndex].Cells[0].Value.ToString());

                SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                sinfo.Open();
                string query = " select * from TABLE_INFO where NO =" + no;
                SqlCommand infocd = new SqlCommand(query, sinfo);
                infocd.ExecuteNonQuery();
                SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
                DataSet infods = new DataSet();
                infoadt.Fill(infods);
                DataTable infodt = infods.Tables[0];
                txttableNO.Text = infodt.Rows[0]["TABLE_NO"].ToString();
               
                sinfo.Close();
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
           if(txttableNO.Text == "")
            {
                MessageBox.Show(" SELECT A ROW ");
            }
           else
            { 
                SqlConnection tinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                tinfo.Open();
                string queryt = " delete from TABLE_INFO where TABLE_NO = " + txttableNO.Text + "";
                SqlCommand tscd = new SqlCommand(queryt, tinfo);
                 tscd.ExecuteNonQuery();
               
                    MessageBox.Show(" DELETE SUCCESSFULL");


                tinfo.Close();
                tinfo.Open();
                string query = " select * from TABLE_INFO ";
                SqlCommand infocd = new SqlCommand(query, tinfo);
                infocd.ExecuteNonQuery();
                SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
                DataSet infods = new DataSet();
                infoadt.Fill(infods);
                DataTable infodt = infods.Tables[0];
                dgvTI.AutoGenerateColumns = false;
                dgvTI.DataSource = infodt;
                dgvTI.Refresh();
                txttableNO.Text = " ";
                tinfo.Close();


            }
        }

        private void lbtrBACK_Click(object sender, EventArgs e)
        {
            tablereservation trback = new tablereservation();
            trback.Show();
            this.Hide();
                 
        }

        private void btEDIT_Click(object sender, EventArgs e)
        {
            if (txttableNO.Text == "")
            {
                MessageBox.Show(" SELECT A ROW ");
            }
            else
            {
                if (rbYES.Checked)
                {
                    free = " YES ";
                }

                else if (rbNO.Checked)
                {
                    free = " NO ";
                }

                else
                {
                    free = " ";
                }
                SqlConnection tinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                tinfo.Open();
                string queryt = " update TABLE_INFO set  FREE = '" + free + "' where TABLE_NO = '" + txttableNO + "'";
                SqlCommand tscd = new SqlCommand(queryt, tinfo);
                tscd.ExecuteNonQuery();

                MessageBox.Show(" EDIT SUCCESSFULL");


                tinfo.Close();

                tinfo.Open();
                string query = " select * from TABLE_INFO ";
                SqlCommand infocd = new SqlCommand(query, tinfo);
                infocd.ExecuteNonQuery();
                SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
                DataSet infods = new DataSet();
                infoadt.Fill(infods);
                DataTable infodt = infods.Tables[0];
                dgvTI.AutoGenerateColumns = false;
                dgvTI.DataSource = infodt;
                dgvTI.Refresh();
                txttableNO.Text = " ";
                tinfo.Close();
            }

            }
    }
}
