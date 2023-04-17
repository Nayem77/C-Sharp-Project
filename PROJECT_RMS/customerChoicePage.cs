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
    public partial class customerChoicePage : Form
    {
        public customerChoicePage()
        {
            InitializeComponent();
            lbOrder.Hide();
            lbTR.Hide();
            lbBack.Hide();
        }

        public customerChoicePage( string user)
        {
            InitializeComponent();
            if( user == "CUSTOMER")
            {
                lbUpdateItem.Hide();
                lbADDitem.Hide();
                lbremove.Hide();
                lbSinfo.Hide();
                lbBOOKINGinfo.Hide();
                lbSLPback.Hide();
            }
        }

        public customerChoicePage(int guest)
        {
            InitializeComponent();
            if (guest == 1)
            {
                lbTR.Hide();
                lbUpdateItem.Hide();
                lbADDitem.Hide();
                lbremove.Hide();
                lbSinfo.Hide();
                lbBOOKINGinfo.Hide();
                lbSLPback.Hide();
            }
        }



        private void lbBack_Click(object sender, EventArgs e)
        {
            customerloginpage clp1 = new customerloginpage();
            clp1.Show();
            this.Hide();
        }

        private void lbSLPback_Click(object sender, EventArgs e)
        {
            staffloginpage slp1 = new staffloginpage();
            slp1.Show();
            this.Hide();
        }

        private void customerChoicePage_Load(object sender, EventArgs e)
        {

        }

        private void lbSinfo_Click(object sender, EventArgs e)
        {
            staffinfo2 st = new staffinfo2();
            st.Show();
            this.Hide();

        }

        private void lbADDitem_Click(object sender, EventArgs e)
        {
            menu atm = new menu();
            atm.Show();
            this.Hide();

        }

        private void lbOrder_Click(object sender, EventArgs e)
        {
            ORDER O = new ORDER();
            O.Show();
            this.Hide();
        }

        private void lbremove_Click(object sender, EventArgs e)
        {
            removepage rt = new removepage();
            rt.Show();
            this.Hide();
        }

        private void lbUpdateItem_Click(object sender, EventArgs e)
        {
            itemupdatepage iup = new itemupdatepage();
            iup.Show();
            this.Hide();
        }

        private void lbTR_Click(object sender, EventArgs e)
        {
            booktable tr = new booktable();
            tr.Show();
            this.Hide();
        }

        private void lbBOOKINGinfo_Click(object sender, EventArgs e)
        {
            reservationINFO ri = new reservationINFO();
            ri.Show();
            this.Hide();
        }
    }
}
