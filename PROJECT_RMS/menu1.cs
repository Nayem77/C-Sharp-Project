using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_RMS
{
    class menu1
    {
        public void itemdata(string queryADD)
        {
            SqlConnection conadd = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            conadd.Open();
            SqlCommand addscd = new SqlCommand(queryADD, conadd);
            addscd.ExecuteNonQuery();
            conadd.Close();

            MessageBox.Show("ITEM ADD SUCCESSFULL");

        }

        public DataSet dsorder( string query)
        {
            SqlConnection conadd = new SqlConnection(@"Data Source=DESKTOP-70AGV93;Initial Catalog=ProjectRMS;Integrated Security=True");
            conadd.Open();

            SqlCommand orderscd = new SqlCommand(query, conadd);
            SqlDataAdapter ordersda = new SqlDataAdapter(orderscd);
            DataSet orderds = new DataSet();
            ordersda.Fill(orderds);
            return orderds;
        }
    }
}
