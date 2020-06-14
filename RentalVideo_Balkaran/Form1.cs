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

namespace RentalVideo_Balkaran
{
    public partial class Form1 : Form
    {
        string str = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ToString();//Here i make a connection string through App.config

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Login Validation and enter into the system by entering userName , password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);//Sql connection class from ado.net for connectivity
            SqlDataAdapter da = new SqlDataAdapter("userLogin", con);//this is also from ado.net for fetching the data
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@userid", SqlDbType.VarChar).Value = txtUsername.Text;
            da.SelectCommand.Parameters.Add("@pwd", SqlDbType.VarChar).Value = txtPassword.Text;
            DataTable dt = new DataTable();//this is data table represented by ado.net for getting the the data into rows and columns form
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {

                    this.Hide();
                    RentVideo _VideoRent = new RentVideo();
                    _VideoRent.ShowDialog();

                }

            }
            else
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Login ID and Password is not correct.");
            }
        }
    }
}
