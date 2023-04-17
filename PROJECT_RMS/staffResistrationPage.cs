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
    public partial class staffResistrationPage : Form
    {
        public staffResistrationPage()
        {
            InitializeComponent();
        }

        private void lbSRback_Click(object sender, EventArgs e)
        {
            staffloginpage slp = new staffloginpage();
            slp.Show();
            this.Hide();
        }

        private void btSsignUP_Click(object sender, EventArgs e)
        {
            string name, username, password, email, addesss, gender, position;
            DateTime jd;
            name = txtSRN.Text;
            username = txtSRUN.Text;
            password = txtSRPASSWORD.Text;
            email = txtSmail.Text;
            addesss = txtSaddress.Text;
            jd = Convert.ToDateTime(dtpSJD.Text);

            if (rbSMALE.Checked)
            {
                gender = "MALE";
            }
            else if (rbSFEMALE.Checked)
            {
                gender = "FEMALE";
            }
            else
            {
                gender = " ";
            }

            if(rbMANGER.Checked)
            {
                position = " Manager";
            }
            else if(rbCHEF.Checked)
            {
                position = " CHEF ";
            }
            else if(rbWAITER.Checked)
            {
                position = " WAITER ";
            }
            else if( rbCLEANER.Checked)
            {
                position = " CLEANER ";
            }
            else
            {
                position = " ";
            }


            SqlConnection rcon = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            rcon.Open();
            string query = " insert into STAFF_TABLE (NAME, USERNAME, PASSWORD,EMAIL,ADDRESS,GENDER,POSITION,JD) values( '"+name+"','"+username+"', '"+password+"', '"+email+"', '"+addesss+"', '"+gender+"', '"+position+"', '"+jd+"' )";
            SqlCommand rscd = new SqlCommand(query, rcon);
            int row = rscd.ExecuteNonQuery();
            if( row>0)
            {
                MessageBox.Show(" Sign Up SUCCESSFULL");
            }
            rcon.Close();
        }

        private void txtSaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
