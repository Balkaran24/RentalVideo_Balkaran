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
    public partial class RentVideo : Form
    {
        string str = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ToString();//Here i make a connection string through App.config

        public RentVideo()
        {
            InitializeComponent();
            CustomerList();
            MovieList();
            RentalList();
        }

        /// <summary>
        /// Function to get customer list details to bind in datagridViewSource
        /// </summary>
        private void CustomerList()
        {
            SqlConnection con = new SqlConnection(str);//this is sql connection Ado.net class. here i create the instance of this class.This is used for moaking the connection
            SqlDataAdapter da = new SqlDataAdapter("sp_GetCustomerList", con);//this is also ado.net class.which is used for getting the data
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCustomers.DataSource = dt;
        }

        /// <summary>
        /// Function to get movies list details to bind in datagridViewSource
        /// </summary>
        private void MovieList()
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("sp_GetMovieList", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMovies.DataSource = dt;

        }
        /// <summary>
        /// Function to get rental movie list details to bind in datagridViewSource
        /// </summary>
        private void RentalList()
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("sp_GetRentalList", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewRental.DataSource = dt;

        }

        /// <summary>
        /// Function to add customer details first
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("sp_InsertUpdateCustomer", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtCustFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtCustLastName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            CustomerList();
            MessageBox.Show("Record Inserted successfully");
        }

        /// <summary>
        /// Function to update customer details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("sp_InsertUpdateCustomer", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtCustFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtCustLastName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@CustID", txtCustID.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            txtCustFirstName.Text = "";
            txtCustLastName.Text = "";
            txtAddress.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            CustomerList();
            MessageBox.Show("Record Updated successfully");

        }
        /// <summary>
        /// Function to delete customer record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("sp_DeleteCustomers", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerID", txtCustID.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            CustomerList();
            MessageBox.Show("Record deleted successfully");
        }

        /// <summary>
        /// radio button to list  All Rented movies 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbAllRented_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("GetMoviesRentalList", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@rentalType", SqlDbType.VarChar).Value = "A";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewRental.DataSource = dt;

        }
        /// <summary>
        /// Function to add movies in screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("sp_InsertUpdateMovies", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Rental_Cost", txtRentalCost.Text);
            cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
            cmd.Parameters.AddWithValue("@Plot", txtPlot.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MovieList();
            txtTitle.Text = "";
            txtRentalCost.Text = "";
            txtGenre.Text = "";
            txtPlot.Text = "";
            MessageBox.Show("Record Inserted successfully");

        }
        /// <summary>
        /// Function to delete movies in screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("sp_DeleteMovies", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@movieID", txtMovieID.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MovieList();
            txtTitle.Text = "";
            txtRentalCost.Text = "";
            txtGenre.Text = "";
            txtPlot.Text = "";
            MessageBox.Show("Record deleted successfully");

        }
        /// <summary>
        /// Function to update movies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("sp_InsertUpdateMovies", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Rental_Cost", txtRentalCost.Text);
            cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
            cmd.Parameters.AddWithValue("@Plot", txtPlot.Text);
            cmd.Parameters.AddWithValue("@MovieID", txtMovieID.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MovieList();
            txtTitle.Text = "";
            txtRentalCost.Text = "";
            txtGenre.Text = "";
            txtPlot.Text = "";
            MessageBox.Show("Record Updated successfully");



        }
        /// <summary>
        /// Function to populate Customer Data in Textboxes of Customers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow rw = this.dataGridViewCustomers.Rows[e.RowIndex];
                txtCustID.Text = rw.Cells[0].Value.ToString();
                txtCustFirstName.Text = rw.Cells[1].Value.ToString();
                txtCustLastName.Text = rw.Cells[2].Value.ToString();
                txtAddress.Text = rw.Cells[3].Value.ToString();
                txtPhone.Text = rw.Cells[4].Value.ToString();
            }
        }

        
        /// <summary>
        /// Function to return Rental Movie from Customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("sp_UpdateRentalReturnMovie", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rentalID", txtRentalID.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            RentalList();
            MessageBox.Show("Record updated with Returned Date");
        }
        /// <summary>
        /// Function to Issue Movies on rent to customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("sp_InsertRentalIssueMovie", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerID", txtCustID.Text);
            cmd.Parameters.AddWithValue("@movieID", txtMovieID.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            RentalList();
            MessageBox.Show("Movie updated with Issue Date");
        }
        /// <summary>
        /// Function to show list of rental movies out if not return
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbOutRented_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("GetMoviesRentalList", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@rentalType", SqlDbType.VarChar).Value = "O";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewRental.DataSource = dt;

        }

        private void dataGridViewCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow rw = this.dataGridViewCustomers.Rows[e.RowIndex];
                txtCustID.Text = rw.Cells[0].Value.ToString();
                txtCustFirstName.Text = rw.Cells[1].Value.ToString();
                txtCustLastName.Text = rw.Cells[2].Value.ToString();
                txtAddress.Text = rw.Cells[3].Value.ToString();
                txtPhone.Text = rw.Cells[4].Value.ToString();
            }
        }

        /// <summary>
        /// Function to populate Movies Data in Textbox of Movies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rw = this.dataGridViewMovies.Rows[e.RowIndex];
                txtMovieID.Text = rw.Cells[0].Value.ToString();
                txtTitle.Text = rw.Cells[1].Value.ToString();
                txtGenre.Text = rw.Cells[2].Value.ToString();
                txtRentalCost.Text = rw.Cells[3].Value.ToString();
                txtPlot.Text = rw.Cells[4].Value.ToString();
            }
        }

        /// Function to populate Data according to Return Movie, Issue Movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rw = this.dataGridViewRental.Rows[e.RowIndex];
                txtRentalID.Text = rw.Cells[0].Value.ToString();
                txtCustFirstName.Text = rw.Cells[1].Value.ToString();
                txtCustLastName.Text = rw.Cells[2].Value.ToString();
                txtAddress.Text = rw.Cells[3].Value.ToString();
                txtPhone.Text = rw.Cells[4].Value.ToString();
                txtTitle.Text = rw.Cells[5].Value.ToString();
                txtGenre.Text = rw.Cells[6].Value.ToString();
                txtRentalCost.Text = rw.Cells[7].Value.ToString();
                txtPlot.Text = rw.Cells[8].Value.ToString();
            }
        }

        private void RentVideo_Load(object sender, EventArgs e)
        {

        }

        /// <summary>

    }
}
