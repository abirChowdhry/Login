using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (UsernametextBox.Text == "") { MessageBox.Show("Usename Can't Be Empty", "Error"); }
            else if (PasstextBox.Text == "") { MessageBox.Show("Password Can't Be Empty", "Error"); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "Select * from Users where username = '" + UsernametextBox.Text + "' and password = '" + PasstextBox.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    connection.Close();
                    Main_Menu mainMenu = new Main_Menu();
                    mainMenu.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("No User Found", "Error!");
                }
            }
        }
    }
}
