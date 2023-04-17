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
    public partial class customerResistrationPage : Form
    {
        public customerResistrationPage()
        {
            InitializeComponent();
        }

        private void lbCRback_Click(object sender, EventArgs e)
        {
            customerloginpage clp1 = new customerloginpage();
            clp1.Show();
            this.Hide();
        }

        private void btCsignUP_Click(object sender, EventArgs e)
        {
            string name, username, password, email, addesss, gender;
            DateTime dob;
            name = txtCRN.Text;
            username = txtCRUN.Text;
            password = txtCRPASSWORD.Text;
            email = txtCmail.Text;
            addesss = txtCaddress.Text;
            dob = Convert.ToDateTime(dtpDOB.Text);

            if(rbCMALE.Checked)
            {
                gender = "MALE";
            }
            else if(rbCFEMALE.Checked)
            {
                gender = "FEMALE";
            }
            else
            {
                gender = " ";
            }
            
            SqlConnection rcon = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            rcon.Open();
            string query = " insert into CUSTOMER_TABLE (NAME, USERNAME, PASSWORD,EMAIL,ADDRESS,GENDER,DOB) values( '"+name+"','"+username+"', '"+password+"', '"+email+"', '"+addesss+"', '"+gender+"', '"+dob+"' )";
            SqlCommand rscd = new SqlCommand(query, rcon);
            int row = rscd.ExecuteNonQuery();
            MessageBox.Show(" Sign Up SUCCESSFULL");
            rcon.Close();


            
        }
    }
}
