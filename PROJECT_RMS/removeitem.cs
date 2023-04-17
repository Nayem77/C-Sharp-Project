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
    public partial class removeitem : Form
    {
        public removeitem()
        {
            InitializeComponent();
        }

        private void removeitem_Load(object sender, EventArgs e)
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
            dgvRemoveItem.AutoGenerateColumns = false;
            dgvRemoveItem.DataSource = infodt;
            dgvRemoveItem.Refresh();
            sinfo.Close();
        }
    }
}
