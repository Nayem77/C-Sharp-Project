using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_RMS
{
    public partial class Usertype : Form
    {

        private string uname = "MANAGER";
        private string password = "0000";
        public Usertype()
        {
            InitializeComponent();
        }

        private void btaccess_Click(object sender, EventArgs e)
        {
           if( uname == txtUSER.Text && password == txtUSERpassword.Text)
            {
                customerChoicePage ccp = new customerChoicePage();
                ccp.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show(" ACCESS NOT ALLOW");
            }
        }
    }
}
