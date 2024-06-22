 
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
using ZXing;
using ZXing.Common;
using System.Drawing.Printing;



namespace Gym_Management_System
{
    public partial class RegistrationUC : UserControl
    {
        string connectionString = "Data Source=DESKTOP-AVCB5J8\\SQLEXPRESS;Initial Catalog = GymManagementSystem; Integrated Security = True";
        bool isMem;

        public RegistrationUC()
        {
            InitializeComponent();
        }
        public static Bitmap GenerateQRCode(string content, int width, int height)
        {
            BarcodeWriter QRcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Width = width,
                    Height = height,
                    Margin = 0
                }
            };

            Bitmap qrcodeBitmap = QRcodeWriter.Write(content);
            return qrcodeBitmap;
        }
        private void clearAllTextBoxes()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtId.Clear();
            txtRegFee.Clear();
            cmbGender.SelectedValue = "";
            pictureBoxQRCode.Image = null;
        }
        private void textBoxDisable()
        {
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            txtId.Enabled = false;
            txtRegFee.Enabled = false;
            picDob.Enabled = false;
            cmbDuration.Enabled = false;
            cmbGender.Enabled = false;
        }
        private void textBoxEnable()
        {
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            txtId.ReadOnly = false;
            txtRegFee.Enabled = true;
            picDob.Enabled = true;
            cmbDuration.Enabled = true;
            cmbGender.Enabled = true;

        }

        private void selectMem()
        {
            btnMemReg.BackColor = Color.DarkOrange;
            btnMemReg.ForeColor = Color.Black;
            btnTrainerReg.BackColor = Color.FromArgb(12, 14, 13);
            btnTrainerReg.ForeColor = Color.White;
            clearAllTextBoxes();
            textBoxDisable();
            btnUpdate.Enabled = false;
        }
        private void selectTrain()
        {
            btnMemReg.BackColor = Color.FromArgb(12, 14, 13);
            btnMemReg.ForeColor = Color.White;
            btnTrainerReg.BackColor = Color.DarkOrange;
            btnTrainerReg.ForeColor = Color.Black;
            clearAllTextBoxes();
            textBoxDisable();
            btnUpdate.Enabled = false;
        }
        private void getMemData()
        {
            dbManager dbM = new dbManager(connectionString);
            DataTable dataTable = dbM.GetMember();
            dgvReg.DataSource = dataTable;

            /* int firstColumnIndex = 0;


             int lastRowIndex = dgvReg.Rows.Count - 1;
             string lastValue = dgvReg.Rows[lastRowIndex].Cells[firstColumnIndex].Value.ToString();
             txtId.Text = lastValue;


             */
        }
        private void getTrainerData()
        {
            dbManager dbM = new dbManager(connectionString);
            DataTable dataTable = dbM.GetTrainer();
            dgvReg.DataSource = dataTable;
        }

        /***************************************************************************************************************/
        public string GenerateMemberId()
        {
            string lastId = GetLastMemberId();
            int numericPart = ExtractNumericPart(lastId);
            string newNumericPart = (numericPart + 1).ToString().PadLeft(4, '0');
            string newId = "M" + newNumericPart;
            txtId.Text = newId;
            return newId;

        }

        private string GetLastMemberId()
        {
            string query = "SELECT TOP 1 ID FROM tblMember ORDER BY ID DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string lastId = command.ExecuteScalar()?.ToString();
                    return lastId;
                }
            }
        }

        public string GenerateTrainerId()
        {
            string lastId = GetLastTrainerId();
            int numericPart = ExtractNumericPart(lastId);
            string newNumericPart = (numericPart + 1).ToString().PadLeft(4, '0');
            string newId = "T" + newNumericPart;
            txtId.Text = newId;
            return newId;

        }

        private string GetLastTrainerId()
        {
            string query = "SELECT TOP 1 t_ID FROM tblTrainer ORDER BY t_ID DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string lastId = command.ExecuteScalar()?.ToString();
                    return lastId;
                }
            }
        }

        private int ExtractNumericPart(string id)
        {
            if (string.IsNullOrEmpty(id) || id.Length < 2)
                return 0;

            string numericPart = id.Substring(1);
            if (int.TryParse(numericPart, out int result))
                return result;

            return 0;
        }

        /***************************************************************************************************************/
        /*
           private void GetMemID()
           {
               if (isMem == true)
               {
                   // SQL query to retrieve the last ID from the tblMember table
                   string query = "SELECT TOP 1 ID FROM tblMember ORDER BY ID DESC";

                   using (SqlConnection connection = new SqlConnection(connectionString))
                   {
                       connection.Open();

                       using (SqlCommand command = new SqlCommand(query, connection))
                       {
                           // Execute the SQL query and retrieve the last ID
                           string lastId = command.ExecuteScalar()?.ToString();

                           // Show the last ID in the textbox
                           txtId.Text = lastId;
                       }
                   }
               }
               else
               {
                   // SQL query to retrieve the last ID from the tblMember table
                   string query = "SELECT TOP 1 t_ID FROM tblTrainer ORDER BY t_ID DESC";

                   using (SqlConnection connection = new SqlConnection(connectionString))
                   {
                       connection.Open();

                       using (SqlCommand command = new SqlCommand(query, connection))
                       {
                           // Execute the SQL query and retrieve the last ID
                           string lastId = command.ExecuteScalar()?.ToString();

                           // Show the last ID in the textbox
                           txtId.Text = lastId;
                       }
                   }
               }

           }
        */
        private void RegistrationUC_Load(object sender, EventArgs e)
        {
            isMem = true;
            selectMem();
            BackColor = Color.FromArgb(20, 40, 55);
            //label name when load
            designCls dc = new designCls();
            lblName.Text = dc.mName;
            lblAddress.Text = dc.mAddress;
            lblPhone.Text = dc.mPhone;
            lblID.Text = dc.mId;


            //Get Member Data FormLoad
            dbManager dbM = new dbManager(connectionString);
            DataTable dataTable = dbM.GetMember();
            dgvReg.DataSource = dataTable;

            textBoxDisable();
        }
        private void btnMemReg_Click(object sender, EventArgs e)
        {
            selectMem();
            isMem = true;

            designCls dc = new designCls();
            lblID.Text = dc.mId;
            lblName.Text = dc.mName;
            lblAddress.Text = dc.mAddress;
            lblPhone.Text = dc.mPhone;

            //Get Member Data memReg_btnClick
            getMemData();

        }

        private void btnTrainerReg_Click(object sender, EventArgs e)
        {
            selectTrain();
            isMem = false;

            designCls dc = new designCls();
            lblID.Text = dc.tId;
            lblName.Text = dc.tName;
            lblAddress.Text = dc.tAddress;
            lblPhone.Text = dc.tPhone;

            //Get Trainer Data btnTrainer_Click
            getTrainerData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllTextBoxes();
        }


        /***********************Data base *******Insert*****Update*********Delete*********************************/
        /*  public void CheckID()
          {

              using (SqlConnection connection = new SqlConnection(connectionString))
              {
                  try
                  {
                      connection.Open();
                      string query = "SELECT *FROM tblMember ID=@ID";

                      using (SqlCommand command = new SqlCommand(query, connection))
                      {
                          command.Parameters.AddWithValue("@ID", txtId.Text);
                          MessageBox.Show("Error: ");
                      }
                  }
                  catch (Exception)
                  {

                  }
              }
          }*/
        private void btnReg_Click(object sender, EventArgs e)
        {
            textBoxDisable();


            if (txtAddress.Text == "" || txtId.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtRegFee.Text == "" || cmbGender.Text == "" || picDob.Text == "")
            {
                MessageBox.Show("Fill All Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (isMem == true)

                {

                    dbManager dbManager = new dbManager(connectionString);

                    // Retrieve data from form's controls
                    string id = txtId.Text;
                    string name = txtName.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;
                    string gender = cmbGender.Text;
                    int regFee = int.Parse(txtRegFee.Text);
                    string dob = this.picDob.Text;

                    // Create a new person
                    Person person = new Person
                    {
                        Id = id,
                        Name = name,
                        Address = address,
                        Phone = phone,
                        Gender = gender,
                        RegFee = regFee,
                        Dob = dob,
                    };

                    // Insert the person into the database
                    dbManager.RegisterMember(person);

                    MessageBox.Show("Data inserted successfully.");

                    //Get Member Data with Register
                    getMemData();
                    clearAllTextBoxes();
                }

                else
                {
                    dbManager dbManager = new dbManager(connectionString);

                    // Retrieve data from form's controls
                    string id = txtId.Text;
                    string name = txtName.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;
                    string gender = cmbGender.Text;
                    int regFee = int.Parse(txtRegFee.Text);
                    string dob = this.picDob.Text;

                    // Create a new person
                    Person person = new Person
                    {
                        Id = id,
                        Name = name,
                        Address = address,
                        Phone = phone,
                        Gender = gender,
                        RegFee = regFee,
                        Dob = dob,
                    };

                    // Insert the person into the database
                    dbManager.RegisterTrainer(person);

                    MessageBox.Show("Data inserted successfully.");

                    //Get Trainer Data with Register
                    getTrainerData();
                    clearAllTextBoxes();


                }
            }
        }

        private void cmbDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDuration.SelectedIndex == 0)
            {
                txtRegFee.Text = "2000";
            }
            if (cmbDuration.SelectedIndex == 1)
            {
                txtRegFee.Text = "3500";
            }
            if (cmbDuration.SelectedIndex == 2)
            {
                txtRegFee.Text = "4500";
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtAddress.Text == "" || txtId.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtRegFee.Text == "" || cmbGender.Text == "")
            {
                MessageBox.Show("Can't Update! Please Select Member or Trainer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isMem == true)
                {

                    if (dgvReg.SelectedRows.Count > 0)
                    {
                        string id = dgvReg.SelectedRows[0].Cells[0].Value.ToString();
                        // string id = txtId.Text;
                        string name = txtName.Text;
                        string address = txtAddress.Text;
                        string phone = txtPhone.Text;
                        string gender = cmbGender.Text;
                        int regFee = int.Parse(txtRegFee.Text);
                        string dob = this.picDob.Text;

                        dbManager dbManager = new dbManager(connectionString);
                        Person person = new Person
                        {
                            Id = id,
                            Name = name,
                            Address = address,
                            Phone = phone,
                            Gender = gender,
                            RegFee = regFee,
                            Dob = dob,
                        };
                        dbManager.UpdateMember(person);

                        getMemData(); // Reload data after updating the record
                        clearAllTextBoxes();
                        MessageBox.Show("Succussfully Updated", "Update member details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }




                else
                {
                    if (dgvReg.SelectedRows.Count > 0)
                    {
                        string id = dgvReg.SelectedRows[0].Cells[0].Value.ToString();
                        // string id = txtId.Text;
                        string name = txtName.Text;
                        string address = txtAddress.Text;
                        string phone = txtPhone.Text;
                        string gender = cmbGender.Text;
                        int regFee = int.Parse(txtRegFee.Text);
                        string dob = this.picDob.Text;

                        dbManager dbManager = new dbManager(connectionString);
                        Person person = new Person
                        {
                            Id = id,
                            Name = name,
                            Address = address,
                            Phone = phone,
                            Gender = gender,
                            RegFee = regFee,
                            Dob = dob,
                        };
                        dbManager.UpdateTrainer(person);

                        getTrainerData(); // Reload data after updating the record
                        clearAllTextBoxes();
                        MessageBox.Show("Succussfully Updated", "Update trainer details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (isMem == true)
            {
                if (dgvReg.SelectedRows.Count > 0)
                {
                    string id = dgvReg.SelectedRows[0].Cells[0].Value.ToString();
                    dbManager dbManager = new dbManager(connectionString);
                    Person person = new Person
                    {
                        Id = id,
                    };
                    dbManager.DeleteMember(person);
                    getMemData();
                    MessageBox.Show("Succussfully Removed", "Remove member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (dgvReg.SelectedRows.Count > 0)
                {
                    string id = dgvReg.SelectedRows[0].Cells[0].Value.ToString();
                    dbManager dbManager = new dbManager(connectionString);
                    Person person = new Person
                    {
                        Id = id,
                    };
                    dbManager.DeleteTrainer(person);
                    getTrainerData();
                    MessageBox.Show("Succussfully Removed", "Remove trainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void dgvReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxEnable();
            btnReg.Enabled = false;
            btnUpdate.Enabled = true;
            txtId.ReadOnly = true;
            string id = dgvReg.SelectedRows[0].Cells[0].Value.ToString();
            txtId.Text = id;
            txtName.Text = dgvReg.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dgvReg.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = dgvReg.SelectedRows[0].Cells[3].Value.ToString();
            txtRegFee.Text = dgvReg.SelectedRows[0].Cells[5].Value.ToString();
            cmbGender.Text = dgvReg.SelectedRows[0].Cells[4].Value.ToString();
            this.picDob.Text = dgvReg.SelectedRows[0].Cells[6].Value.ToString();
            if (txtRegFee.Text == "4500")
            {
                cmbDuration.SelectedIndex = 2;
            }
            if (txtRegFee.Text == "3500")
            {
                cmbDuration.SelectedIndex = 1;
            }
            if (txtRegFee.Text == "2000")
            {
                cmbDuration.SelectedIndex = 0;
            }

            /**********************QRCodeGen***************************/
            string qrcodeContent = id; // The content you want to encode in the QR code
            int qrcodeWidth = 200; // The desired width of the QR code image in pixels
            int qrcodeHeight = 200; // The desired height of the QR code image in pixels

            Bitmap qrcode = GenerateQRCode(qrcodeContent, qrcodeWidth, qrcodeHeight);

            // Set the generated QR code image to the image control on the form
            pictureBoxQRCode.Image = qrcode;

        }

        private void dgvReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Focused)
            {
                textBoxEnable();
                clearAllTextBoxes();
                btnReg.Enabled = true;
            }
            else
            {
                textBoxDisable();
            }
        }

        private void btnGenID_Click(object sender, EventArgs e)
        {
            if (isMem == true)
            {
                GenerateMemberId();
            }
            else
            {
                GenerateTrainerId();
            }


            /*----------------------------QR-CODE--------------------------------------------------------------*/
            string qrcodeContent = txtId.Text; // The content you want to encode in the QR code
            int qrcodeWidth = 200; // The desired width of the QR code image in pixels
            int qrcodeHeight = 200; // The desired height of the QR code image in pixels

            Bitmap qrcode = GenerateQRCode(qrcodeContent, qrcodeWidth, qrcodeHeight);

            // Set the generated QR code image to the image control on the form
            pictureBoxQRCode.Image = qrcode;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Get the image from the PictureBox
            Image image = pictureBoxQRCode.Image;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if the PictureBox has an image
            if (pictureBoxQRCode.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpg";
                saveFileDialog.Title = "Save QR Code Image";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path selected by the user
                    string filePath = saveFileDialog.FileName;

                    // Save the image to the selected path
                    pictureBoxQRCode.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("QR Code image saved successfully!");
                }
            }
            else
            {
                MessageBox.Show("No QR Code image available to save.");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (pictureBoxQRCode.Image != null)
            {
                Clipboard.SetImage(pictureBoxQRCode.Image);
                MessageBox.Show("QR Code image copied to clipboard!");
            }
            else
            {
                MessageBox.Show("No QR Code image available to copy.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isMem == true)
            {
                searchMember();
            }
            else
            {
                searchTrainer();
            }

        }
        private void searchMember()
        {
            string memberId = txtSearchID.Text;

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
                            dgvReg.DataSource = memberTable;
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
            string trainerId = txtSearchID.Text;

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
                            dgvReg.DataSource = memberTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



    }
    }
