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
    public partial class menu : Form
    {
        menu1 item = new menu1();
        string queryADD;


        public menu()
        {
            InitializeComponent();
        }

       

        private void btadditem_Click(object sender, EventArgs e)
        {
            
             queryADD = " insert into MENU (ITEM_NAME , CATACORY , PRICE) values('"+txtitem.Text+"' , '"+txtcategory.Text+ "' ,'"+ txtprice.Text + "' )";
            item.itemdata(queryADD);

            txtcategory.SelectedIndex = -1;
            txtitem.Clear();
            txtprice.Clear();
        }

        private void lbmenuback_Click(object sender, EventArgs e)
        {
            customerChoicePage mt = new customerChoicePage();
            mt.Show();
            this.Hide();
        }
    }
}
