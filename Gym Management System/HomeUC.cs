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

namespace Gym_Management_System
{
    public partial class HomeUC : UserControl
    {
        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";

        public HomeUC()
        {
            InitializeComponent();
        }
        public void getCount()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM tblMember";

                    SqlCommand command = new SqlCommand(query, connection); 

                    int count = (int)command.ExecuteScalar();
                    lblTotMem.Text = count.ToString();
                     
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
           
                using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //SELECT COUNT(*) FROM Attendance WHERE StudentID = @StudentID AND AttendanceDate = @AttendanceDate
                    //SELECT COUNT(*) FROM tblTrainer WHERE t_ID = T0002 AND t_Gender = Male
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM tblTrainer";
                  // string query = "SELECT Name FROM tblMember ID = @ID ";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        int count = (int)command.ExecuteScalar();
                        lblTotTrainer.Text = count.ToString();
                       /* if (count < 10)
                        {
                            lblTotTrainer.ForeColor = Color.Red;
                        }*/
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateAttendanceCountM()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tblMemAttend WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE)", connection);

            connection.Open();
            int attendanceCount = (int)command.ExecuteScalar();
            connection.Close();
            lblTdyMem.Text = attendanceCount.ToString();
        }
        private void UpdateAttendanceCountT()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tblTrainAttend WHERE CAST(Date AS DATE) = CAST(GETDATE() AS DATE)", connection);

            connection.Open();
            int attendanceCount = (int)command.ExecuteScalar();
            connection.Close();
            lblTdyTrain.Text = attendanceCount.ToString();
        }

        private void HomeUC_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(20, 40, 55);
            timer.Start();

            UpdateAttendanceCountM();
            UpdateAttendanceCountT();
            getCount();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

 
        private void btnBMIcal_Click(object sender, EventArgs e)
        {
 
                // Validate input
                if (string.IsNullOrEmpty(txtWeight.Text) || string.IsNullOrEmpty(txtHeight.Text))
                {
                    MessageBox.Show("Please enter valid weight and height values.");
                    return;
                }

                // Get the user input
                if (!float.TryParse(txtWeight.Text, out float weight) || !float.TryParse(txtHeight.Text, out float height))
                {
                    MessageBox.Show("Please enter valid numeric weight and height values.");
                    return;
                }

                // Calculate BMI
                float bmi = CalculateBMI(weight, height);

                // Display the result
                lblBMI.Text = $"Your BMI: {bmi:F2}";
             
 
        }
        private float CalculateBMI(float weight, float height)
        {
            // Calculate BMI using the formula: BMI = weight (kg) / (height (m) * height (m))
            float heightInMeters = height / 100; // Convert height from centimeters to meters
            float bmi = weight / (heightInMeters * heightInMeters);
            return bmi;
        }

        private void btnViewMem_Click(object sender, EventArgs e)
        {
            ViewMember Vmem= new ViewMember();
            Vmem.Show();
        }

 

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getCount();
            UpdateAttendanceCountM();
            UpdateAttendanceCountT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCount();
        }

 
    }
}
