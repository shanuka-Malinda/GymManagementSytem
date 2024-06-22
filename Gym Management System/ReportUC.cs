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
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace Gym_Management_System
{
    public partial class ReportUC : UserControl
    {

        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";
        private Panel panelToPrint;
        private Panel panelToCopy;

        public ReportUC()
        {
            InitializeComponent();
       
        }

        private void ReportUC_Load(object sender, EventArgs e)
        {
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            timer.Start();

            DisplayMemberAttendanceChart();
            DataTable paymentData = GetMonthlyPaymentData();
            // Bind the data to the Chart control
            BindDataToChart(paymentData);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblReportDate.Text = DateTime.Now.ToShortDateString();
            lblReportTme.Text = DateTime.Now.ToLongTimeString();
            lblReportDate1.Text = DateTime.Now.ToShortDateString();
            lblReportTime1.Text = DateTime.Now.ToLongTimeString();

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
             
            currentMonthIncome();
            paidMemberCount();
            notPaidMemberCount();
            regCountMem();
            regCountTrain();
            getCount();
            regFeeMem();
            regFeeTrain();

            decimal totFee = decimal.Parse(labelMonthlyTotal.Text);
            decimal totMregFee = decimal.Parse(lblMemRegFee.Text);
            decimal totTregFee = decimal.Parse(lblTrainRegFee.Text);

            decimal regIncome = totMregFee + totTregFee;
            lblRegIncome.Text = regIncome.ToString("0.00");

            decimal netIncome = totFee + regIncome;
            lblNetIncome.Text = netIncome.ToString("0.00");
            /*
            if (dateTimePicker.Text== DateTime.Now.ToString("yyyy-MM"))
            {
                decimal netIncome = totFee + regIncome;
                lblNetIncome.Text = netIncome.ToString("0.00");
            }
            else
            {
                decimal netIncome=totFee;
                lblNetIncome.Text = netIncome.ToString("0.00");
            }*/
        }
        public void getCount()
        {
            string year = DateTime.Now.Year.ToString();
            string day = DateTime.Now.Day.ToString();
            string targetMonthYear = year + "-" + cmbMonth.Text + "-" + day;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM tblMember WHERE RegDate <= @AdmissionDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter value for the admission date
                        command.Parameters.AddWithValue("@AdmissionDate", targetMonthYear);

                        int count = (int)command.ExecuteScalar();
                        lblTotMem.Text = count.ToString();
                    }
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
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM tblTrainer WHERE RegDate <= @AdmissionDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter value for the admission date
                        command.Parameters.AddWithValue("@AdmissionDate", targetMonthYear);

                        int count = (int)command.ExecuteScalar();
                        lblTotTrain.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void currentMonthIncome()
        {
            string year = DateTime.Now.Year.ToString();
            // string targetMonthYear = dateTimePicker.Text;
            string targetMonthYear = year + "-" + cmbMonth.Text;

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command object with the SQL query
                string query = $"SELECT PaidMonthYear, SUM(Amount) AS MonthlyTotal FROM tblPayment WHERE PaidMonthYear = '{targetMonthYear}' GROUP BY PaidMonthYear";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get the result
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Read the monthly total amount from the result
                        decimal monthlyTotal = reader.GetDecimal(reader.GetOrdinal("MonthlyTotal"));

                        // Assign the result to the label
                        labelMonthlyTotal.Text = monthlyTotal.ToString("0.00");
                    }
                    else
                    {
                        // No data found for the specified month and year
                        labelMonthlyTotal.Text = "0.00";
                    }

                    reader.Close();
                }
            }
        }

        private void paidMemberCount()
        {
            string year = DateTime.Now.Year.ToString();
            // string targetMonthYear = dateTimePicker.Text;
            string targetMonthYear = year + "-" + cmbMonth.Text;
            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command object with the SQL query
                string query = $"SELECT COUNT(DISTINCT MemberID) AS PaidMembersCount FROM tblPayment WHERE PaidMonthYear = '{targetMonthYear}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get the result
                    int paidMembersCount = (int)command.ExecuteScalar();

                    // Assign the result to the label
                    labelPaidMembersCount.Text = paidMembersCount.ToString();
                }
            }
        }

        private void notPaidMemberCount()
        {
            string year = DateTime.Now.Year.ToString();
            // string targetMonthYear = dateTimePicker.Text;
            string targetMonthYear = year + "-" + cmbMonth.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command object with the SQL query
                string query = $"SELECT COUNT(DISTINCT MemberID) AS NonPaidMembersCount FROM tblPayment WHERE PaidMonthYear <> '{targetMonthYear}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get the result
                    int nonPaidMembersCount = (int)command.ExecuteScalar();

                    // Assign the result to the label
                    labelNonPaidMembersCount.Text = nonPaidMembersCount.ToString();
                }
            }

        }
        private void regCountMem()
        {
            string year = DateTime.Now.Year.ToString();
            // string targetMonthYear = dateTimePicker.Text;
            string targetMonthYear = year + "-" + cmbMonth.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command object with the SQL query
                string query = $"SELECT COUNT(*) AS RegisteredMembersCount FROM tblMember WHERE RegDate LIKE '{targetMonthYear}%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get the result
                    int registeredMembersCount = (int)command.ExecuteScalar();

                    // Assign the result to the label
                    labelRegisteredMembersCount.Text = registeredMembersCount.ToString();
                }
            }
        }
        private void regCountTrain()
        {
            string year = DateTime.Now.Year.ToString();
            // string targetMonthYear = dateTimePicker.Text;
            string targetMonthYear = year + "-" + cmbMonth.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command object with the SQL query
                string query = $"SELECT COUNT(*) AS RegisteredMembersCount FROM tblTrainer WHERE RegDate LIKE '{targetMonthYear}%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get the result
                    int registeredMembersCount = (int)command.ExecuteScalar();

                    // Assign the result to the label
                    labelRegisteredTrainerCount.Text = registeredMembersCount.ToString();
                }
            }
        
        }

        private void regFeeMem()
        {

            string year = DateTime.Now.Year.ToString();
            string day = DateTime.Now.Day.ToString();
            int targetMonth = int.Parse(cmbMonth.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get the start and end dates of the current month
                DateTime startDate = new DateTime(DateTime.Now.Year, targetMonth, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                // Create a command object with the SQL query
                string query = $"SELECT SUM(RegFee) AS MonthlyTotal FROM tblMember WHERE RegDate >= @StartDate AND RegDate <= @EndDate";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        // Read the monthly total amount from the result
                        decimal monthlyTotal = Convert.ToDecimal(result);

                        // Assign the result to the label
                        lblMemRegFee.Text = monthlyTotal.ToString("0.00");
                    }
                    else
                    {
                        // No data found for the current month
                        lblMemRegFee.Text = "0.00";
                    }
                }
            }

            }
        private void regFeeTrain()
        {
            /*
            string year = DateTime.Now.Year.ToString();
            string day = DateTime.Now.Day.ToString();
            string targetMonthYear = year + "-" + cmbMonth.Text + "-" + day;

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command object with the SQL query
                string query = $"SELECT RegDate, SUM(t_RegFee) AS MonthlyTotal FROM tblTrainer WHERE RegDate = '{DateTime.Now.ToString("yyyy-MM-dd")}' GROUP BY RegDate";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get the result
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Read the monthly total amount from the result
                        int monthlyTotal = reader.GetInt32(reader.GetOrdinal("MonthlyTotal"));

                        // Assign the result to the label
                        lblTrainRegFee.Text = monthlyTotal.ToString();
                    }
                    else
                    {
                        // No data found for the specified month and year
                         lblTrainRegFee.Text = "0";
                    }

                    reader.Close();
                }
            }*/

            string year = DateTime.Now.Year.ToString();
            string day = DateTime.Now.Day.ToString();
            int targetMonth = int.Parse(cmbMonth.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get the start and end dates of the current month
                DateTime startDate = new DateTime(DateTime.Now.Year,  targetMonth, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                // Create a command object with the SQL query
                string query = $"SELECT SUM(t_RegFee) AS MonthlyTotal FROM tblTrainer WHERE RegDate >= @StartDate AND RegDate <= @EndDate";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        // Read the monthly total amount from the result
                        decimal monthlyTotal = Convert.ToDecimal(result);

                        // Assign the result to the label
                        lblTrainRegFee.Text = monthlyTotal.ToString("0.00");
                    }
                    else
                    {
                        // No data found for the current month
                        lblTrainRegFee.Text = "0.00";
                    }
                }
            }
            }
/**********************************************************chartPayment**********************************************/
        private DataTable GetMonthlyPaymentData()
        {
            DataTable paymentData = new DataTable();

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command object with the SQL query
                string query = "SELECT PaidMonthYear, SUM(Amount) AS MonthlyPaymentAmount FROM tblPayment GROUP BY PaidMonthYear";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Create a data adapter and fill the data into a DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(paymentData);
                }
            }

            return paymentData;
        }

        private void BindDataToChart(DataTable paymentData)
        {
            // Set the data source of the chart
            chartPayments.DataSource = paymentData;

            // Set the X and Y values of the chart series
            chartPayments.Series["PaymentAmount"].XValueMember = "PaidMonthYear";
            chartPayments.Series["PaymentAmount"].YValueMembers = "MonthlyPaymentAmount";

            // Set the chart series to use the "Bar" chart type
            chartPayments.Series["PaymentAmount"].ChartType = SeriesChartType.Column;

            // Refresh the chart to update the display
            chartPayments.DataBind();
        }
        /***************************************chartAttendance***************************************************************/
        public void DisplayMemberAttendanceChart()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Date, COUNT(*) AS AttendanceCount FROM tblMemAttend GROUP BY Date";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        // Clear any existing series from the chart
                        chartAttendance.Series.Clear();

                        // Add a new series to the chart
                        Series series = new Series("Attendance");
                        series.ChartType = SeriesChartType.Bar;

                        // Loop through the result set and add data points to the series
                        while (reader.Read())
                        {
                            string date = reader.GetString(reader.GetOrdinal("Date"));
                            int attendanceCount = reader.GetInt32(reader.GetOrdinal("AttendanceCount"));

                            series.Points.AddXY(date, attendanceCount);
                        }

                        // Add the series to the chart
                        chartAttendance.Series.Add(series);

                        // Set chart properties as desired
                        chartAttendance.ChartAreas[0].AxisX.Title = "Date";
                        chartAttendance.ChartAreas[0].AxisY.Title = "Attendance Count";
                        chartAttendance.Titles.Add("Member Attendance");

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void btnPrint_Click(object sender, EventArgs e)
        {
            panelToPrint = pnlReport; // Replace "yourPanel" with the name of your panel control

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            panelToCopy = pnlReport; // Replace "yourPanel" with the name of your panel control

            CopyPanelToClipboard();
        }
        private void CopyPanelToClipboard()
        {
            Bitmap bitmap = new Bitmap(panelToCopy.Width, panelToCopy.Height);
            panelToCopy.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToCopy.Width, panelToCopy.Height));

            Clipboard.SetImage(bitmap);
        }

 

        private void btnCopy1_Click(object sender, EventArgs e)
        {
            panelToCopy = pnlReport1; // Replace "yourPanel" with the name of your panel control

            CopyPanelToClipboard();
        }

        private void btnPrint1_Click(object sender, EventArgs e)
        {
            panelToPrint = pnlReport1; // Replace "yourPanel" with the name of your panel control

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}

