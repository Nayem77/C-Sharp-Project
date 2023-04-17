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
    public partial class RMS : Form
    {
        public RMS()
        {
            InitializeComponent();
        }

        private void lbcustomer_Click(object sender, EventArgs e)
        {
            customerloginpage clp = new customerloginpage();
            clp.Show();
            this.Hide();
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbstaff_Click(object sender, EventArgs e)
        {
            staffloginpage slp = new staffloginpage();
            slp.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
