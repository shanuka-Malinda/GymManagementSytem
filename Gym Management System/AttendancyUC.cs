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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Globalization;

namespace Gym_Management_System
{
    public partial class AttendancyUC : UserControl
    {
        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";

        private FilterInfoCollection videoDevices; // Collection of available video devices
        private VideoCaptureDevice videoSource; // The selected video source
        private BarcodeReader barcodeReader; // QR code reader
        private string qrCodeContent;

        public AttendancyUC()
        {
            InitializeComponent();
            PopulateMemberIds();

            barcodeReader = new BarcodeReader();
            barcodeReader.Options.TryHarder = true;

            // Initialize video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                // Use the first video device by default
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
            }
            else
            {
                // No video devices found
                MessageBox.Show("No video devices found.");
            }
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap videoFrame = (Bitmap)eventArgs.Frame.Clone();

            // Process the video frame and decode QR codes
            Result result = barcodeReader.Decode(videoFrame);
            if (result != null)
            {
                // QR code successfully decoded
                qrCodeContent = result.Text;

                // Display the QR code content
                cmbID.Invoke((MethodInvoker)(() => cmbID.Text = qrCodeContent));
            }

            // Display the video frame in a picture box or perform further processing
            pictureBoxQRScan.Image = videoFrame;

        }
        private void btnScanQR_Click(object sender, EventArgs e)
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                videoSource.Start();
            }
        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private bool IsIdValidMem(string checkid)
        {

            string query = "SELECT COUNT(*) FROM tblMember WHERE ID = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", checkid);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        private bool IsIdValidTrainer(string checkid)
        {

            string query = "SELECT COUNT(*) FROM tblTrainer WHERE t_ID = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", checkid);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
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
                        cmbID.Items.Add(memberId);
                    }

                    reader.Close();
                }
            }
        }

        private void PopulateTrainerIds()
        {
            string query = "SELECT t_id FROM tblTrainer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string trainerId = reader["t_id"].ToString();
                        cmbID.Items.Add(trainerId);
                    }

                    reader.Close();
                }
            }
        }
        public void DisplayMonthlyAttendanceMember()
        {
            string memberID= cmbID.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT  AttendanceID,Date FROM tblMemAttend WHERE MemberID = @MemberID AND MONTH(Date) = @Month";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter values for the member ID and month
                        command.Parameters.AddWithValue("@MemberID", memberID);
                        command.Parameters.AddWithValue("@Month", DateTime.Today.Month);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridViewAttendance.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void DisplayMonthlyAttendanceTrainer()
        {
            string memberID = cmbID.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT AttendanceID,Date FROM tblTrainAttend WHERE TrainerID = @MemberID AND MONTH(Date) = @Month";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter values for the member ID and month
                        command.Parameters.AddWithValue("@MemberID", memberID);
                        command.Parameters.AddWithValue("@Month", DateTime.Today.Month);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridViewAttendance.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.Text == "Member")
            {
                cmbID.Items.Clear();
                PopulateMemberIds();
            }
            else
            {
                cmbID.Items.Clear();
                PopulateTrainerIds();
            }
        }
        private void AttendancyUC_Load(object sender, EventArgs e)
        {
            timer.Start();
            cmbSelect.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
 
            string selectedMemberID = cmbID.SelectedItem.ToString();
            if (cmbSelect.Text == "Member")
            {
                 
                GetAttendanceCountPerMonth(selectedMemberID);
                DisplayMonthlyAttendanceMember();
            }
            else
            {
                
                GetTAttendanceCountPerMonth(selectedMemberID);
                DisplayMonthlyAttendanceTrainer();
            }

            string checkid = cmbID.Text;
            bool isValidMem = IsIdValidMem(checkid);
            bool isValidTrain = IsIdValidTrainer(checkid);


            if (cmbSelect.Text == null || cmbID.Text == null)
            {
                MessageBox.Show(null, "Fill ID or Type", "Quick Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cmbSelect.Text == "Member")
                {
                    if (isValidMem)
                    {
                        dbManager dbManager = new dbManager(connectionString);

                        // Retrieve data from form's controls    
                        string id = cmbID.Text;
                        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        int month = DateTime.Now.Month;


                        // Create a new person
                        Person person = new Person
                        {
                            Date = date,
                            Id = id,
                            Month = month,

                        };

                        // Insert the Attendance into the database
                        dbManager.memAttendance(person);
                        MessageBox.Show("Attendance Updated !");
                    }

                    else
                    {
                        MessageBox.Show(null, "ID is not valid", "Quick Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (isValidTrain)
                    {
                        dbManager dbManager = new dbManager(connectionString);

                        // Retrieve data from form's controls    
                        string id = cmbID.Text;
                        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        int month = DateTime.Now.Month;


                        // Create a new person
                        Person person = new Person
                        {
                            Date = date,
                            Id = id,
                            Month = month,

                        };

                        // Insert the Attendance into the database
                        dbManager.trainAttendance(person);
                        MessageBox.Show("Attendance Updated !");
                    }
                    else
                    {
                        MessageBox.Show(null, "ID is not valid", "Quick Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void GetAttendanceCountPerMonth(string selectedMemberID)
        {
            string query = "SELECT MONTH(Date) AS Month, COUNT(*) AS AttendanceCount FROM tblMemAttend WHERE MemberID = @MemberID GROUP BY MONTH(Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberID", selectedMemberID);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                StringBuilder labelText = new StringBuilder();

                while (reader.Read())
                {
                    int month = Convert.ToInt32(reader["Month"]);
                    int attendanceCount = Convert.ToInt32(reader["AttendanceCount"]);

                    // Append the attendance count to the label text
                    labelText.AppendLine($"Month: {month}, Attendance Count: {attendanceCount}");

                    if (attendanceCount >= 4)
                    {
                        btnMarkAttendance.Enabled = false;
                        btnMarkAttendance.BackColor = Color.Red;
                        MessageBox.Show("You can't attend");
                    }
                    else
                    {
                        btnMarkAttendance.Enabled = true;
                    }
                }

                reader.Close();

                // Update the label text with the new content
                lblAttendCount.Text = labelText.ToString();
            }
        }


        private void GetTAttendanceCountPerMonth(string selectedMemberID)
        {
            string query = "SELECT MONTH(Date) AS Month, COUNT(*) AS AttendanceCount FROM tblTrainAttend WHERE TrainerID = @TrainerID GROUP BY MONTH(Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TrainerID", selectedMemberID);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                StringBuilder labelText = new StringBuilder();

                while (reader.Read())
                {
                    int month = Convert.ToInt32(reader["Month"]);
                    int attendanceCount = Convert.ToInt32(reader["AttendanceCount"]);

                    // Append the attendance count to the label text
                    labelText.AppendLine($"Month: {month}, Attendance Count: {attendanceCount}");
                }

                reader.Close();

                // Update the label text with the new content
                lblAttendCount.Text = labelText.ToString();
            }
        }





        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  CheckMemDetail();
            lblAttendCount.Text = "";
            btnMarkAttendance.Enabled = true;
            btnMarkAttendance.BackColor = Color.ForestGreen;
            // Retrieve the selected MemberID from the combo box
            string selectedMemberID = cmbID.SelectedItem.ToString();

            // Retrieve and display the attendance count for the selected MemberID

            if (cmbSelect.Text == "Member")
            {
                CheckMemDetail();
                GetAttendanceCountPerMonth(selectedMemberID);
                DisplayMonthlyAttendanceMember();
            }
            else
            {
                CheckTrainDetail();
                GetTAttendanceCountPerMonth(selectedMemberID);
                DisplayMonthlyAttendanceTrainer();
            }
        }


        private void  CheckMemDetail()
        {
            string memberId = cmbID.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve member details
                    string memberQuery = @"SELECT Name, Phone 
                                           FROM tblMember 
                                           WHERE ID = @MemberID";

                    // Query to retrieve payment details
                    string paymentQuery = @"SELECT DISTINCT PaidMonthYear 
                                            FROM tblPayment 
                                            WHERE MemberID = @MemberID 
                                            AND PaidMonthYear >= CONVERT(VARCHAR(7), DATEADD(MONTH, -4, GETDATE()), 120) 
                                            ORDER BY PaidMonthYear DESC";

                    using (SqlCommand memberCommand = new SqlCommand(memberQuery, connection))
                    {
                        memberCommand.Parameters.AddWithValue("@MemberID", memberId);

                        using (SqlDataReader memberReader = memberCommand.ExecuteReader())
                        {
                            if (memberReader.Read())
                            {
                                // Retrieve member details
                                string memberName = memberReader.GetString(0);
                                string contactNumber = memberReader.GetString(1);

                                // Display member details
                                lblMemberName.Text = memberName;
                                lblContactNumber.Text = contactNumber;
                            }
                            else
                            {
                                // Member not found
                                lblMemberName.Text = "N/A";
                                lblContactNumber.Text = "N/A";
                            }
                        }
                    }

                    using (SqlCommand paymentCommand = new SqlCommand(paymentQuery, connection))
                    {
                        paymentCommand.Parameters.AddWithValue("@MemberID", memberId);

                        using (SqlDataReader paymentReader = paymentCommand.ExecuteReader())
                        {
                            // Get the current year and month
                            string currentYearMonth = DateTime.Now.ToString("yyyy/MM");

                            // Get the previous year and month
                            string previousYearMonth = DateTime.Now.AddMonths(-1).ToString("yyyy/MM");

                            // Create a list to store paid months
                            List<string> paidMonths = new List<string>();

                            while (paymentReader.Read())
                            {
                                string paidMonthYear = paymentReader.GetString(0);
                                paidMonths.Add(paidMonthYear);
                            }

                            lblThisMonthStatus.Text = paidMonths.Contains(currentYearMonth) ? "Paid" : "Not Paid";
                            lblLastMonthStatus.Text = paidMonths.Contains(previousYearMonth) ? "Paid" : "Not Paid";
                            lblTwoMonthsAgoStatus.Text = paidMonths.Contains(DateTime.Now.AddMonths(-2).ToString("yyyy/MM")) ? "Paid" : "Not Paid";
                            lblThreeMonthsAgoStatus.Text = paidMonths.Contains(DateTime.Now.AddMonths(-3).ToString("yyyy/MM")) ? "Paid" : "Not Paid";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void  CheckTrainDetail()
        {
            string trainerId = cmbID.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to retrieve member details from tblTrainer table
                    string memberQuery = @"SELECT t_Name, t_Phone 
                                           FROM tblTrainer 
                                           WHERE t_ID = @trainerId";

                    using (SqlCommand memberCommand = new SqlCommand(memberQuery, connection))
                    {
                        memberCommand.Parameters.AddWithValue("@trainerId", trainerId);

                        using (SqlDataReader memberReader = memberCommand.ExecuteReader())
                        {
                            if (memberReader.Read())
                            {
                                // Retrieve member details
                                string memberName = memberReader.GetString(0);
                                string contactNumber = memberReader.GetString(1);

                                // Display member details
                                lblMemberName.Text = memberName;
                                lblContactNumber.Text = contactNumber;
                            }
                            else
                            {
                                // Member not found
                                lblMemberName.Text = "N/A";
                                lblContactNumber.Text = "N/A";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateMemberIds();
            PopulateTrainerIds();
        }
    }
}
