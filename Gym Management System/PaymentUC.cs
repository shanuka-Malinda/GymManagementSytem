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
using AForge.Video.DirectShow;
using ZXing;
using AForge.Video;
using System.Xml.Linq;
using ZXing.OneD;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text.RegularExpressions;


namespace Gym_Management_System
{
    public partial class PaymentUC : UserControl
    {
        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";

        private FilterInfoCollection videoDevices; // Collection of available video devices
        private VideoCaptureDevice videoSource; // The selected video source
        private BarcodeReader barcodeReader; // QR code reader
        private string qrCodeContent;

        private Panel panelToPrint;
        private Panel panelToSave;
        public PaymentUC()
        {
            InitializeComponent();
            PopulateMemberIds();
            panelToPrint = pnlPayment;
            panelToSave = pnlPayment;

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
            picBoxQRScan.Image = videoFrame;
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
            videoSource.SignalToStop();
            videoSource.WaitForStop();
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
        private void btnPay_Click(object sender, EventArgs e)
        {


            if (cmbID.Text == "" ||  txtAmount.Text=="" || cmbPaymentMethod.Text=="" || dateTimePicker1.Text=="")
            {
                MessageBox.Show("Enter all values !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string memberId = cmbID.Text;
                decimal amount = decimal.Parse(txtAmount.Text);
                DateTime paymentDate = DateTime.Now;
                string paymentMethod = cmbPaymentMethod.Text;
                string paidMonthYear = dateTimePicker1.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = @"INSERT INTO tblPayment (MemberID, Amount, PaymentDate, PaymentMethod, PaidMonthYear) 
                                     VALUES (@MemberID, @Amount, @PaymentDate, @PaymentMethod, @PaidMonthYear)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MemberID", memberId);
                            command.Parameters.AddWithValue("@Amount", amount);
                            command.Parameters.AddWithValue("@PaymentDate", paymentDate);
                            command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                            command.Parameters.AddWithValue("@PaidMonthYear", paidMonthYear);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment data inserted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert payment data.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                CheckPayment();
            }
        }




        private void ClearForm()
        {
            // Clear the textboxes and reset the combobox to default value
            cmbID.Text = string.Empty;
            txtAmount.Clear();
            txtCash.Clear();
            cmbPaymentMethod.SelectedIndex = -1;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //
            Bitmap bitmap = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            e.Graphics.DrawImage(bitmap, 0, 0);


           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog())
            {
                using (PrintPreviewDialog PrintPreviewDialog = new PrintPreviewDialog())
                {
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += printDocument_PrintPage;

                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.ShowDialog();
                }
            }
        }


        private void printDocumentSave_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Bitmap bitmap = new Bitmap(panelToSave.Width, panelToSave.Height))
            {
                panelToSave.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToSave.Width, panelToSave.Height));

                e.Graphics.DrawImage(bitmap, new Point(0, 0));
            }

        }

        private void PaymentUC_Load(object sender, EventArgs e)
        {
            timer.Start();
            lblBillPaidMonth.Text = dateTimePicker1.Text;
            lblInvoicePaymentMethod.Text = "Cash";
            cmbPaymentMethod.SelectedIndex = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblInvoiceDate.Text = DateTime.Now.ToShortDateString();
            lblInvoicetime.Text = DateTime.Now.ToLongTimeString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblBillPaidMonth.Text = dateTimePicker1.Text;
        }
        private void cmbID_TextUpdate(object sender, EventArgs e)
        {
            lblInvoiceMemID.Text = cmbID.Text;
        }

        private void cmbID_TextChanged(object sender, EventArgs e)
        {
            lblInvoiceMemID.Text = cmbID.Text;
            CheckPayment();
            
        }

        private void cmbPaymentMethod_TextChanged(object sender, EventArgs e)
        {
            lblInvoicePaymentMethod.Text = cmbPaymentMethod.Text;
        }


        private void txtAmount_TextChanged(object sender, EventArgs e)
        {


            if (int.TryParse(txtAmount.Text, out _))
            {
                lblAmount.Text = txtAmount.Text;
            }
            else
            {
                MessageBox.Show("Enter Amount as numeric.");
                txtAmount.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtCash.Text, out _))
            {

                lblCash.Text = txtCash.Text;
                decimal amount = decimal.Parse(txtAmount.Text);
                decimal cash = decimal.Parse(txtCash.Text);
                decimal bal = cash - amount;
                string b = bal.ToString();
                lblBalance.Text = b;
            }
            else
            {
                MessageBox.Show("Enter Amount as numeric.");
                txtAmount.Clear();
            }

        }




        private void cmbID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string memberId = cmbID.Text;

            string query = "SELECT Name FROM tblMember WHERE  ID = @MemberId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberId", memberId);

                connection.Open();
                string memberName = command.ExecuteScalar()?.ToString();
                connection.Close();

                lblName.Text = memberName;
            }
        }

        private void CheckPayment()
        {
            string memberId = cmbID.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT DISTINCT PaidMonthYear 
                                     FROM tblPayment 
                                     WHERE MemberID = @MemberID 
                                     AND PaidMonthYear >= CONVERT(VARCHAR(7), DATEADD(MONTH, -4, GETDATE()), 120) 
                                     ORDER BY PaidMonthYear DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Get the current year and month
                            string currentYearMonth = DateTime.Now.ToString("yyyy-MM");

                            // Get the previous year and month
                            string previousYearMonth = DateTime.Now.AddMonths(-1).ToString("yyyy-MM");

                            // Create a list to store paid months
                            List<string> paidMonths = new List<string>();

                            while (reader.Read())
                            {
                                string paidMonthYear = reader.GetString(0);
                                paidMonths.Add(paidMonthYear);
                            }

                            lblThisMonthStatus.Text = paidMonths.Contains(currentYearMonth) ? "Paid" : "Not Paid";
                            lblLastMonthStatus.Text = paidMonths.Contains(previousYearMonth) ? "Paid" : "Not Paid";
                            lblTwoMonthsAgoStatus.Text = paidMonths.Contains(DateTime.Now.AddMonths(-2).ToString("yyyy-MM")) ? "Paid" : "Not Paid";
                            lblThreeMonthsAgoStatus.Text = paidMonths.Contains(DateTime.Now.AddMonths(-3).ToString("yyyy-MM")) ? "Paid" : "Not Paid";
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
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }


    }
 