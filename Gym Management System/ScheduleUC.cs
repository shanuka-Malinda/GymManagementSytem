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
using System.Drawing.Printing;
 

namespace Gym_Management_System
{
    public partial class ScheduleUC : UserControl
    {

        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";
        
        private PrintDocument printDocument;
        public ScheduleUC()
        {
            InitializeComponent();
            PopulateMemberIds();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }
        private void ScheduleUC_Load(object sender, EventArgs e)
        {
             
        }

        private void PopulateMemberIds()
        {
            string query = "SELECT id FROM tblMember";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string memberId = reader["id"].ToString();
                        cmbMemID.Items.Add(memberId);
                    }

                    reader.Close();
                }
            }
        }






        private void txtID_Click(object sender, EventArgs e)
        {
             
        }
        private void cmbMemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            object item=cmbMemID.SelectedItem;
            lstbShedule.Items.Add(item);
        }
        private void cmbDate_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            object item = cmbDate.SelectedItem;
            lstbShedule.Items.Add(item);
        }

        private void cmbEx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            object item = cmbEx.SelectedItem;
            lstbShedule.Items.Add(item);
        }
        private void cmbEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object item = cmbEx1.SelectedItem;
            lstbShedule.Items.Add(item);
        }

        private void btnSelectedDelete_Click_1(object sender, EventArgs e)
        {
            if (lstbShedule.SelectedIndex != -1)
            {
                lstbShedule.Items.RemoveAt(lstbShedule.SelectedIndex);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Start the printing process
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get the ListBox items
            ListBox.ObjectCollection items = lstbShedule.Items;

            // Set the font and margin settings
            Font font = new Font("Arial", 12);
            int margin = 50;
            int yPos = margin;

            // Print each item
            foreach (var item in items)
            {
                e.Graphics.DrawString(item.ToString(), font, Brushes.Black, margin, yPos);
                yPos += (int)font.GetHeight() + 5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string memberId = cmbMemID.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append("INSERT INTO tblShedule (MemberID, Description) VALUES ");

            List<SqlParameter> parameters = new List<SqlParameter>();

            for (int i = 0; i < lstbShedule.Items.Count; i++)
            {
                // Retrieve the data from the ListBox item
                string data = lstbShedule.Items[i].ToString();

                // Add parameter placeholders for each item
                queryBuilder.Append($"(@MemberID{i}, @Data{i}), ");

                // Create parameters for MemberID and Description
                parameters.Add(new SqlParameter($"@MemberID{i}", memberId));
                parameters.Add(new SqlParameter($"@Data{i}", data));
            }

            // Remove the trailing comma and space
            queryBuilder.Remove(queryBuilder.Length - 2, 2);

            // Execute the batch insert query
            string insertQuery = queryBuilder.ToString();
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddRange(parameters.ToArray());

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Schedule Update Successfully !");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string memberId = cmbMemID.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT Description FROM tblShedule WHERE MemberID = @MemberID", connection);
            command.Parameters.AddWithValue("@MemberID", memberId);

            lstbShedule.Items.Clear(); // Clear the ListBox before populating with new data

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string description = reader["Description"].ToString();
                lstbShedule.Items.Add(description);
            }

            connection.Close();
             MessageBox.Show("Schedule Retrieved Successfully!");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Create a StringBuilder to store the items
            StringBuilder sb = new StringBuilder();

            // Append each item to the StringBuilder
            foreach (var item in lstbShedule.Items)
            {
                sb.AppendLine(item.ToString());
            }

            // Copy the StringBuilder content to the clipboard
            Clipboard.SetText(sb.ToString());

            MessageBox.Show("Schedule Copied to Clipboard Successfully!");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstbShedule.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstbShedule.Items.Count > 0) // Check if there are items in the ListBox
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand updateCommand = new SqlCommand("UPDATE tblShedule SET Description = @NewSchedule WHERE Description = @OldSchedule", connection);

                connection.Open();

                foreach (var item in lstbShedule.Items)
                {
                    string newSchedule = item.ToString();

                    updateCommand.Parameters.Clear();
                    updateCommand.Parameters.AddWithValue("@NewSchedule", newSchedule);
                    updateCommand.Parameters.AddWithValue("@OldSchedule", newSchedule);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Update any necessary UI or perform additional actions
                    }
                }

                connection.Close();

                MessageBox.Show("All schedule items updated successfully!");
            }
            else
            {
                MessageBox.Show("There are no schedule items to update.");
            }

        }
    }
}

 