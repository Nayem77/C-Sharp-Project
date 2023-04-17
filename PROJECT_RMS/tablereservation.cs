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
    public partial class tablereservation : Form
    {
        public tablereservation()
        {
            InitializeComponent();
        }

        private void lbBookTable_Click(object sender, EventArgs e)
        {
            booktable bt = new booktable();
            bt.Show();
            this.Hide();
        }

        private void lbBookingInfo_Click(object sender, EventArgs e)
        {
            BOOKINGinfo bi = new BOOKINGinfo();
            bi.Show();
            this.Hide();
        }
    }
}
