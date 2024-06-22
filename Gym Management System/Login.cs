using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    public partial class Login : Form
    {

        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
             
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "SELECT COUNT(*) FROM tblLogin WHERE Username = @Username AND Password = @Password";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@Username", enteredUsername);
                    command.Parameters.AddWithValue("@Password", enteredPassword);

                    // Open the database connection
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // Check if the login is successful
                    if (count > 0)
                    {

                        MessageBox.Show("Login successful!");
                        Main main = new Main();
                        main.Show();
                        this.Hide();

                    }
                    else
                    {
                        // Invalid credentials
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }



                }





            }      
          /*  Main main = new Main();
            main.Show();
            this.Hide();*/
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar=true;
            }
        }
    }
}
