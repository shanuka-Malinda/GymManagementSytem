using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    public partial class SettingsUC : UserControl
    {
        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";

        public SettingsUC()
        {
            InitializeComponent();
        }

        private void btnClearMem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Truncate the tblMember table to remove all records
                        string truncateQuery = "TRUNCATE TABLE tblMember";

                        using (SqlCommand command = new SqlCommand(truncateQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("All member details have been cleared.");



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnClearTrain_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Truncate the tblMember table to remove all records
                        string truncateQuery = "TRUNCATE TABLE tblTrainer";

                        using (SqlCommand command = new SqlCommand(truncateQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("All trainer details have been cleared.");



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnClearMemAtt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Truncate the tblMember table to remove all records
                        string truncateQuery = "TRUNCATE TABLE tblMemAttend";

                        using (SqlCommand command = new SqlCommand(truncateQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("All member attendance details have been cleared.");



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnClearTrainAtt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Truncate the tblMember table to remove all records
                        string truncateQuery = "TRUNCATE TABLE tblTrainAttend";

                        using (SqlCommand command = new SqlCommand(truncateQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("All trainer attendance details have been cleared.");



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnClearPayment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Truncate the tblMember table to remove all records
                        string truncateQuery = "TRUNCATE TABLE tblPayment";

                        using (SqlCommand command = new SqlCommand(truncateQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("All payment details have been cleared.");



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnConform_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string currentPassword = txtCurrentPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmNewPassword = txtConfirmNewPassword.Text;

                // Check if the new password and confirm password match
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("New password and confirm password do not match. Please try again.");
                    return;
                }

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Construct the SQL query
                    string query = "SELECT Password FROM tblLogin WHERE Username = @Username";

                    // Create a command with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter value
                        command.Parameters.AddWithValue("@Username", username);

                        // Open the database connection
                        connection.Open();

                        // Execute the query and get the result (existing password)
                        string storedPassword = command.ExecuteScalar()?.ToString();

                        // Check if the stored password matches the current password entered
                        if (storedPassword != currentPassword)
                        {
                            MessageBox.Show("Invalid current password. Please try again.");
                            return;
                        }
                    }

                    // Construct the SQL query to update the password
                    string updateQuery = "UPDATE tblLogin SET Password = @NewPassword WHERE Username = @Username";

                    // Create another command with the update query and connection
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        // Set the parameter values for the new password and username
                        updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCommand.Parameters.AddWithValue("@Username", username);

                        // Execute the update query
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        // Check if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to change the password. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirmNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirmNewPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
