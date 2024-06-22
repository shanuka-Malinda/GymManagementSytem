using Org.BouncyCastle.Asn1.Ocsp;
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
using ZXing;

namespace Gym_Management_System
{
    public partial class ViewMember : Form
    {
        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";
        bool Mem = true;
        bool Train = true;
        bool Attendance = true;
        bool TrainAttend = true;
        bool Payment = true;
        public ViewMember()
        {
            InitializeComponent();
        }
        private void getMemData()
        {
            dbManager dbM = new dbManager(connectionString);
            DataTable dataTable = dbM.GetMember();
            dgvDetail.DataSource = dataTable;
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            getMemData();
        }
        private void getTrainerData()
        {
            dbManager dbM = new dbManager(connectionString);
            DataTable dataTable = dbM.GetTrainer();
            dgvDetail.DataSource = dataTable;
        }
        private void getMemAttence()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblMemAttend";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dgvDetail.DataSource = dataTable;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private void getTrainAttence()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblTrainAttend";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dgvDetail.DataSource = dataTable;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private void getPayment()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM tblPayment";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dgvDetail.DataSource = dataTable;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private void searchMember()
        {
            string memberId = txtID.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve member details from tblMember table
                    string memberQuery = @"SELECT * 
                                           FROM tblMember 
                                           WHERE ID = @MemberID";

                    using (SqlCommand memberCommand = new SqlCommand(memberQuery, connection))
                    {
                        memberCommand.Parameters.AddWithValue("@MemberID", memberId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(memberCommand))
                        {
                            DataTable memberTable = new DataTable();
                            adapter.Fill(memberTable);

                            // Display member details in the DataGridView
                            dgvDetail.DataSource = memberTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void searchTrainer()
        {
            string trainerId = txtID.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve member details from tblMember table
                    string memberQuery = @"SELECT * 
                                           FROM tblTrainer 
                                           WHERE t_ID = @MemberID";

                    using (SqlCommand memberCommand = new SqlCommand(memberQuery, connection))
                    {
                        memberCommand.Parameters.AddWithValue("@MemberID", trainerId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(memberCommand))
                        {
                            DataTable memberTable = new DataTable();
                            adapter.Fill(memberTable);

                            // Display member details in the DataGridView
                            dgvDetail.DataSource = memberTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void searchMemAttend()
        {
            string trainerId = txtID.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve member details from tblMember table
                    string memberQuery = @"SELECT * 
                                           FROM tblMemAttend 
                                           WHERE MemberID = @MemberID";

                    using (SqlCommand memberCommand = new SqlCommand(memberQuery, connection))
                    {
                        memberCommand.Parameters.AddWithValue("@MemberID", trainerId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(memberCommand))
                        {
                            DataTable memberTable = new DataTable();
                            adapter.Fill(memberTable);

                            // Display member details in the DataGridView
                            dgvDetail.DataSource = memberTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void searchTrainAttend()
        {
            string trainerId = txtID.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve member details from tblMember table
                    string memberQuery = @"SELECT * 
                                           FROM tblTrainAttend 
                                           WHERE TrainerID = @MemberID";

                    using (SqlCommand memberCommand = new SqlCommand(memberQuery, connection))
                    {
                        memberCommand.Parameters.AddWithValue("@MemberID", trainerId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(memberCommand))
                        {
                            DataTable memberTable = new DataTable();
                            adapter.Fill(memberTable);

                            // Display member details in the DataGridView
                            dgvDetail.DataSource = memberTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void searchPayment()
        {
            string trainerId = txtID.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve member details from tblMember table
                    string memberQuery = @"SELECT * 
                                           FROM tblPayment 
                                           WHERE MemberID = @MemberID";

                    using (SqlCommand memberCommand = new SqlCommand(memberQuery, connection))
                    {
                        memberCommand.Parameters.AddWithValue("@MemberID", trainerId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(memberCommand))
                        {
                            DataTable memberTable = new DataTable();
                            adapter.Fill(memberTable);

                            // Display member details in the DataGridView
                            dgvDetail.DataSource = memberTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (pnlNavi.Location.X==btnMember.Location.X)
            {
                searchMember();
            }
            if(pnlNavi.Location.X == btnTrainer.Location.X)
            {
                searchTrainer();
            }
            if(pnlNavi.Location.X == btnMemAttendance.Location.X)
            {
                searchMemAttend();
            }
            if (pnlNavi.Location.X == btnTrainAttend.Location.X)
            {
                searchTrainAttend();
            }
            if (pnlNavi.Location.X == btnPayment.Location.X)
            {
                searchPayment();
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            pnlNavi.Location = new Point(btnMember.Location.X, 38);
            pnlNavi.Width = btnMember.Width;
            getMemData();
             Mem = true;
 
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            pnlNavi.Location = new Point(btnTrainer.Location.X, 38);
            pnlNavi.Width = btnTrainer.Width;
            getTrainerData();
             Train = true;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pnlNavi.Location = new Point(btnMemAttendance.Location.X, 38);
            pnlNavi.Width = btnMemAttendance.Width;
            Attendance=true;
        }

        private void btnTrainAttend_Click(object sender, EventArgs e)
        {
            pnlNavi.Location = new Point(btnTrainAttend.Location.X, 38);
            pnlNavi.Width = btnTrainAttend.Width;
            getTrainAttence();
             TrainAttend=true;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlNavi.Location = new Point(btnPayment.Location.X, 38);
            pnlNavi.Width = btnPayment.Width;
            getPayment();
             Payment=true;
        }
    }
}
