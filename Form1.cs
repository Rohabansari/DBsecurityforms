using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static string username = ""; public static string password = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new(@"Data Source=DESKTOP-2NK6KUB\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True");
            username = textBox1.Text;
            password = textBox2.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else
            {
                var datasource = @"DESKTOP-2NK6KUB\SQLEXPRESS"; var database = "Northwind"; var thisUsername = username; var thisPassword = password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password + ";TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    conn.Open();
                    //MessageBox.Show("Connection Successful"); 
                    Form2 frm1 = new Form2();
                    frm1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}