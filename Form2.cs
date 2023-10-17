using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1_Load() called..."); txtMessageText.Text = "Startup..."; try
            {
                /* 
                System.Diagnostics.Debug.WriteLine("within the try"); 
                SqlConnection connection = new SqlConnection(@"Data 
Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");                 connection.Open(); 
                txtMessageText.Text = "Connection Successful";                 connection.Close(); 
                */
                var datasource = @"DESKTOP-2NK6KUB\SQLEXPRESS"; var database = "Northwind";
                var thisUsername = Form1.username; var thisPassword = Form1.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword + ";TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                txtMessageText.Text = "Connection Successful on Startup"; conn.Close();

            }

            catch (Exception ex)
            {
                txtMessageText.Text = "Error, " + ex;
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            string currentTable = ""; if (radCustomers.Checked)
            {
                currentTable = "Customers";
            }
            else if (radEmployee.Checked)
            {
                currentTable = "Employees";
            }
            else if (radOrders.Checked)
            {
                currentTable = "Orders";
            }

            dataGridView1.DataSource = null;
            try
            {
                SqlCommand command = new SqlCommand();
                var datasource = @"DESKTOP-2NK6KUB\SQLEXPRESS"; var database = "Northwind"; var thisUsername = Form1.username; var thisPassword = Form1.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword + ";TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                txtMessageText.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                dataGridView1.DataSource = dt;
                txtMessageText.Text = "Retrieval Successful!"; conn.Close();
            }
            catch (Exception ex)
            {
                txtMessageText.Text = "Error, " + ex;
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new(@"Data Source=DESKTOP-2NK6KUB\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True"); connection.Open();
            txtMessageText.Text = "Inserting Record..."; command.Connection = connection;
            command.CommandText = "insert into Customers (ID, Company) values('" + txtID.Text + "','" + txtCompanyName.Text + "')"; command.ExecuteNonQuery();
            txtMessageText.Text = "Record Inserted..."; connection.Close();
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new(@"Data Source=DESKTOP-2NK6KUB\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True"); connection.Open();
            txtMessageText.Text = "Counting Records..."; command.Connection = connection;
            command.CommandText = "select count(*) from Customers"; int count = (int)command.ExecuteScalar(); txtMessageText.Text = "Number of records: " + count; connection.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}




