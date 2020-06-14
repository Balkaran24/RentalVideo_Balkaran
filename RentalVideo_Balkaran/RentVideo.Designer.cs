namespace RentalVideo_Balkaran
{
    partial class RentVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdbAllRented = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbOutRented = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtCustFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRental.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.Size = new System.Drawing.Size(774, 226);
            this.dataGridViewRental.TabIndex = 0;
            this.dataGridViewRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRental_CellContentClick);
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(774, 226);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(781, 226);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdbAllRented
            // 
            this.rdbAllRented.AutoSize = true;
            this.rdbAllRented.Location = new System.Drawing.Point(3, 38);
            this.rdbAllRented.Name = "rdbAllRented";
            this.rdbAllRented.Size = new System.Drawing.Size(74, 17);
            this.rdbAllRented.TabIndex = 1;
            this.rdbAllRented.TabStop = true;
            this.rdbAllRented.Text = "All Rented";
            this.rdbAllRented.UseVisualStyleBackColor = true;
            this.rdbAllRented.CheckedChanged += new System.EventHandler(this.rdbAllRented_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rented Movies";
            // 
            // rdbOutRented
            // 
            this.rdbOutRented.AutoSize = true;
            this.rdbOutRented.Location = new System.Drawing.Point(120, 38);
            this.rdbOutRented.Name = "rdbOutRented";
            this.rdbOutRented.Size = new System.Drawing.Size(80, 17);
            this.rdbOutRented.TabIndex = 2;
            this.rdbOutRented.TabStop = true;
            this.rdbOutRented.Text = "Out Rented";
            this.rdbOutRented.UseVisualStyleBackColor = true;
            this.rdbOutRented.CheckedChanged += new System.EventHandler(this.rdbOutRented_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewRental);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 223);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 249);
            this.tabControl1.TabIndex = 44;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(473, 345);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(107, 20);
            this.txtPlot.TabIndex = 43;
            this.txtPlot.Text = "Plot......";
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.Location = new System.Drawing.Point(110, 306);
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.Size = new System.Drawing.Size(115, 20);
            this.txtCustFirstName.TabIndex = 42;
            this.txtCustFirstName.Text = "First Name......";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(352, 306);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(115, 20);
            this.txtAddress.TabIndex = 41;
            this.txtAddress.Text = "Address......";
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(231, 306);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(115, 20);
            this.txtCustLastName.TabIndex = 40;
            this.txtCustLastName.Text = "Last Name......";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.rdbAllRented);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdbOutRented);
            this.panel1.Location = new System.Drawing.Point(551, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 64);
            this.panel1.TabIndex = 39;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(586, 346);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(37, 20);
            this.txtRentalID.TabIndex = 38;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(275, 345);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(95, 20);
            this.txtGenre.TabIndex = 37;
            this.txtGenre.Text = "Genre......";
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(376, 345);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(91, 20);
            this.txtRentalCost.TabIndex = 36;
            this.txtRentalCost.Text = "Rental Cost......";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(173, 345);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(96, 20);
            this.txtTitle.TabIndex = 35;
            this.txtTitle.Text = "Title......";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(110, 345);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(57, 20);
            this.txtMovieID.TabIndex = 34;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(110, 386);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(100, 54);
            this.btnUpdateMovie.TabIndex = 33;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(8, 386);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(96, 54);
            this.btnDeleteMovie.TabIndex = 32;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(8, 333);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(96, 51);
            this.btnAddMovie.TabIndex = 31;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.ForeColor = System.Drawing.Color.Green;
            this.btnIssueMovie.Location = new System.Drawing.Point(713, 265);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(80, 86);
            this.btnIssueMovie.TabIndex = 30;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReturnMovie.Location = new System.Drawing.Point(629, 265);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(78, 86);
            this.btnReturnMovie.TabIndex = 29;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(440, 265);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(183, 35);
            this.btnDeleteCustomer.TabIndex = 28;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(266, 265);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(168, 35);
            this.btnUpdateCustomer.TabIndex = 27;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(473, 306);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(115, 20);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.Text = "Phone......";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(110, 265);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(57, 20);
            this.txtCustID.TabIndex = 25;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(8, 265);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(96, 68);
            this.btnCustomer.TabIndex = 24;
            this.btnCustomer.Text = "Add Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // RentVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCustFirstName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustLastName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtRentalCost);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.btnCustomer);
            this.Name = "RentVideo";
            this.Text = "RentVideo";
            this.Load += new System.EventHandler(this.RentVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRental;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rdbAllRented;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbOutRented;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtCustFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button btnCustomer;
    }
}