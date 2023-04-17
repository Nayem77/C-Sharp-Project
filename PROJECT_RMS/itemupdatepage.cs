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
    public partial class itemupdatepage : Form
    {
        menu1 om2 = new menu1();
        public itemupdatepage()
        {
            InitializeComponent();
        }

        private void itemupdatepage_Load(object sender, EventArgs e)
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
            dgvUpDate.AutoGenerateColumns = false;
            dgvUpDate.DataSource = infodt;
            dgvUpDate.Refresh();
            sinfo.Close();
        }

        private void lbudSearchITEM_Click(object sender, EventArgs e)
        {
            if (txtudSearchITEM.Text == "")
            {
                MessageBox.Show(" Please write something");
            }
            else
            {
                SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                sinfo.Open();
                string queryS = " select * from MENU where ITEM_NAME  like'%" + txtudSearchITEM.Text + "%'";
                SqlCommand sinfoS = new SqlCommand(queryS, sinfo);
                sinfoS.ExecuteNonQuery();
                SqlDataAdapter sinfoadtS = new SqlDataAdapter(sinfoS);
                DataSet sinfodsS = new DataSet();
                sinfoadtS.Fill(sinfodsS);
                DataTable sinfodt = sinfodsS.Tables[0];
                dgvUpDate.AutoGenerateColumns = false;
                dgvUpDate.DataSource = sinfodt;
                dgvUpDate.Refresh();
                sinfo.Close();
            }
        }

        int itemNO;
        private void dgvUpDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                 itemNO = Convert.ToInt32(dgvUpDate.Rows[e.RowIndex].Cells[0].Value.ToString());

                SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
                sinfo.Open();
                string query = " select * from MENU where ITEM_NO=" + itemNO;
                SqlCommand infocd = new SqlCommand(query, sinfo);
                infocd.ExecuteNonQuery();
                SqlDataAdapter infoadt = new SqlDataAdapter(infocd);
                DataSet infods = new DataSet();
                infoadt.Fill(infods);
                DataTable infodt = infods.Tables[0];
                txtudCATEGORY.Text = infodt.Rows[0]["CATACORY"].ToString();
                txtUDitemName.Text = infodt.Rows[0]["ITEM_NAME"].ToString();
                txtudPRICE.Text = infodt.Rows[0]["PRICE"].ToString();
                sinfo.Close();
            }
        }

        private void btUPDATE_Click(object sender, EventArgs e)
        {
            
            string query = " update MENU set CATACORY = '" + txtudCATEGORY.Text + "', ITEM_NAME = '"+txtUDitemName.Text+"' , PRICE = '"+txtudPRICE.Text+"' where ITEM_NO = "+itemNO+"";
            om2.itemdata(query);
            MessageBox.Show("UPDATE SUCCESSFULL");
            SqlConnection sinfo = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            sinfo.Open();
            string queryR = " select * from MENU";
            SqlCommand infocdR = new SqlCommand(queryR, sinfo);
            infocdR.ExecuteNonQuery();
            SqlDataAdapter infoadtR = new SqlDataAdapter(infocdR);
            DataSet infodsR = new DataSet();
            infoadtR.Fill(infodsR);
            DataTable infodtR = infodsR.Tables[0];
            dgvUpDate.AutoGenerateColumns = false;
            dgvUpDate.DataSource = infodtR;
            dgvUpDate.Refresh();
            txtudSearchITEM.Clear();
            txtudCATEGORY.Clear();
            txtUDitemName.Clear();
            txtudPRICE.Clear();
            sinfo.Close();

        }

        private void lbSlogout_Click(object sender, EventArgs e)
        {
            staffloginpage slo = new staffloginpage();
            slo.Show();
            this.Hide();
        }

        private void lb_BACK_Click(object sender, EventArgs e)
        {
            customerChoicePage ccp = new customerChoicePage();
            ccp.Show();
            this.Hide();
        }
    }
}
