namespace Gym_Management_System
{
    partial class PaymentUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.picBoxQRScan = new System.Windows.Forms.PictureBox();
            this.btnScanQR = new System.Windows.Forms.Button();
            this.lblThreeMonthsAgoStatus = new System.Windows.Forms.Label();
            this.lblTwoMonthsAgoStatus = new System.Windows.Forms.Label();
            this.lblLastMonthStatus = new System.Windows.Forms.Label();
            this.lblThisMonthStatus = new System.Windows.Forms.Label();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBillPaidMonth = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInvoicePaymentMethod = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInvoiceMemID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInvoicetime = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDocumentSave = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblpaidMonth = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRScan)).BeginInit();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(800, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(528, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 50);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter/Select Member ID";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(655, 438);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(243, 31);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cmbID
            // 
            this.cmbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.cmbID.DisplayMember = "ID";
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(528, 120);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 21);
            this.cmbID.TabIndex = 10;
            this.cmbID.ValueMember = "ID";
            this.cmbID.SelectionChangeCommitted += new System.EventHandler(this.cmbID_SelectionChangeCommitted);
            this.cmbID.TextUpdate += new System.EventHandler(this.cmbID_TextUpdate);
            this.cmbID.TextChanged += new System.EventHandler(this.cmbID_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnStopScan);
            this.panel3.Controls.Add(this.picBoxQRScan);
            this.panel3.Controls.Add(this.btnScanQR);
            this.panel3.Location = new System.Drawing.Point(3, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 455);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Scan the QR code to get the ID";
            // 
            // btnStopScan
            // 
            this.btnStopScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.btnStopScan.FlatAppearance.BorderSize = 0;
            this.btnStopScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopScan.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.btnStopScan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopScan.Location = new System.Drawing.Point(182, 60);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(86, 32);
            this.btnStopScan.TabIndex = 13;
            this.btnStopScan.Text = "Stop Scan";
            this.btnStopScan.UseVisualStyleBackColor = false;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // picBoxQRScan
            // 
            this.picBoxQRScan.Location = new System.Drawing.Point(3, 105);
            this.picBoxQRScan.Name = "picBoxQRScan";
            this.picBoxQRScan.Size = new System.Drawing.Size(336, 347);
            this.picBoxQRScan.TabIndex = 11;
            this.picBoxQRScan.TabStop = false;
            // 
            // btnScanQR
            // 
            this.btnScanQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.btnScanQR.FlatAppearance.BorderSize = 0;
            this.btnScanQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanQR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanQR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnScanQR.Location = new System.Drawing.Point(59, 60);
            this.btnScanQR.Name = "btnScanQR";
            this.btnScanQR.Size = new System.Drawing.Size(86, 32);
            this.btnScanQR.TabIndex = 12;
            this.btnScanQR.Text = "Scan QR";
            this.btnScanQR.UseVisualStyleBackColor = false;
            this.btnScanQR.Click += new System.EventHandler(this.btnScanQR_Click);
            // 
            // lblThreeMonthsAgoStatus
            // 
            this.lblThreeMonthsAgoStatus.AccessibleName = "PmntStatus";
            this.lblThreeMonthsAgoStatus.AutoSize = true;
            this.lblThreeMonthsAgoStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeMonthsAgoStatus.ForeColor = System.Drawing.Color.White;
            this.lblThreeMonthsAgoStatus.Location = new System.Drawing.Point(511, 416);
            this.lblThreeMonthsAgoStatus.Name = "lblThreeMonthsAgoStatus";
            this.lblThreeMonthsAgoStatus.Size = new System.Drawing.Size(106, 19);
            this.lblThreeMonthsAgoStatus.TabIndex = 29;
            this.lblThreeMonthsAgoStatus.Text = "Payment Status";
            // 
            // lblTwoMonthsAgoStatus
            // 
            this.lblTwoMonthsAgoStatus.AccessibleName = "PmntStatus";
            this.lblTwoMonthsAgoStatus.AutoSize = true;
            this.lblTwoMonthsAgoStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoMonthsAgoStatus.ForeColor = System.Drawing.Color.White;
            this.lblTwoMonthsAgoStatus.Location = new System.Drawing.Point(511, 388);
            this.lblTwoMonthsAgoStatus.Name = "lblTwoMonthsAgoStatus";
            this.lblTwoMonthsAgoStatus.Size = new System.Drawing.Size(106, 19);
            this.lblTwoMonthsAgoStatus.TabIndex = 28;
            this.lblTwoMonthsAgoStatus.Text = "Payment Status";
            // 
            // lblLastMonthStatus
            // 
            this.lblLastMonthStatus.AccessibleName = "PmntStatus";
            this.lblLastMonthStatus.AutoSize = true;
            this.lblLastMonthStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMonthStatus.ForeColor = System.Drawing.Color.White;
            this.lblLastMonthStatus.Location = new System.Drawing.Point(511, 360);
            this.lblLastMonthStatus.Name = "lblLastMonthStatus";
            this.lblLastMonthStatus.Size = new System.Drawing.Size(106, 19);
            this.lblLastMonthStatus.TabIndex = 27;
            this.lblLastMonthStatus.Text = "Payment Status";
            // 
            // lblThisMonthStatus
            // 
            this.lblThisMonthStatus.AccessibleName = "PmntStatus";
            this.lblThisMonthStatus.AutoSize = true;
            this.lblThisMonthStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisMonthStatus.ForeColor = System.Drawing.Color.White;
            this.lblThisMonthStatus.Location = new System.Drawing.Point(511, 333);
            this.lblThisMonthStatus.Name = "lblThisMonthStatus";
            this.lblThisMonthStatus.Size = new System.Drawing.Size(106, 19);
            this.lblThisMonthStatus.TabIndex = 26;
            this.lblThisMonthStatus.Text = "Payment Status";
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.White;
            this.pnlPayment.Controls.Add(this.label20);
            this.pnlPayment.Controls.Add(this.label19);
            this.pnlPayment.Controls.Add(this.lblBillPaidMonth);
            this.pnlPayment.Controls.Add(this.label18);
            this.pnlPayment.Controls.Add(this.lblName);
            this.pnlPayment.Controls.Add(this.label13);
            this.pnlPayment.Controls.Add(this.lblBalance);
            this.pnlPayment.Controls.Add(this.lblCash);
            this.pnlPayment.Controls.Add(this.lblAmount);
            this.pnlPayment.Controls.Add(this.label11);
            this.pnlPayment.Controls.Add(this.label10);
            this.pnlPayment.Controls.Add(this.label9);
            this.pnlPayment.Controls.Add(this.lblInvoicePaymentMethod);
            this.pnlPayment.Controls.Add(this.label7);
            this.pnlPayment.Controls.Add(this.lblInvoiceMemID);
            this.pnlPayment.Controls.Add(this.label6);
            this.pnlPayment.Controls.Add(this.lblInvoicetime);
            this.pnlPayment.Controls.Add(this.lblInvoiceDate);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.label2);
            this.pnlPayment.Location = new System.Drawing.Point(655, 49);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(244, 378);
            this.pnlPayment.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 343);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(235, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "*********************************************************";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(235, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "*********************************************************";
            // 
            // lblBillPaidMonth
            // 
            this.lblBillPaidMonth.AutoSize = true;
            this.lblBillPaidMonth.Location = new System.Drawing.Point(71, 143);
            this.lblBillPaidMonth.Name = "lblBillPaidMonth";
            this.lblBillPaidMonth.Size = new System.Drawing.Size(0, 13);
            this.lblBillPaidMonth.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Paid Month :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(10, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Name :";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(174, 302);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(19, 13);
            this.lblBalance.TabIndex = 13;
            this.lblBalance.Text = "00";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(174, 265);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(19, 13);
            this.lblCash.TabIndex = 12;
            this.lblCash.Text = "00";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(174, 226);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(19, 13);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "BALANCE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "CASH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "MONTHLY AMOUNT";
            // 
            // lblInvoicePaymentMethod
            // 
            this.lblInvoicePaymentMethod.AutoSize = true;
            this.lblInvoicePaymentMethod.Location = new System.Drawing.Point(92, 93);
            this.lblInvoicePaymentMethod.Name = "lblInvoicePaymentMethod";
            this.lblInvoicePaymentMethod.Size = new System.Drawing.Size(10, 13);
            this.lblInvoicePaymentMethod.TabIndex = 7;
            this.lblInvoicePaymentMethod.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payment Method :";
            // 
            // lblInvoiceMemID
            // 
            this.lblInvoiceMemID.AutoSize = true;
            this.lblInvoiceMemID.Location = new System.Drawing.Point(68, 71);
            this.lblInvoiceMemID.Name = "lblInvoiceMemID";
            this.lblInvoiceMemID.Size = new System.Drawing.Size(10, 13);
            this.lblInvoiceMemID.TabIndex = 5;
            this.lblInvoiceMemID.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Member ID :";
            // 
            // lblInvoicetime
            // 
            this.lblInvoicetime.AutoSize = true;
            this.lblInvoicetime.Location = new System.Drawing.Point(159, 93);
            this.lblInvoicetime.Name = "lblInvoicetime";
            this.lblInvoicetime.Size = new System.Drawing.Size(74, 13);
            this.lblInvoicetime.TabIndex = 3;
            this.lblInvoicetime.Text = "Payment Time";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(169, 71);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(74, 13);
            this.lblInvoiceDate.TabIndex = 2;
            this.lblInvoiceDate.Text = "Payment Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "PAYMENT INVOICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titan Fitness Center";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(780, 481);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 23);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(655, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save And Preview";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // printDocumentSave
            // 
            this.printDocumentSave.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentSave_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(528, 159);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbPaymentMethod.TabIndex = 19;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            this.cmbPaymentMethod.TextChanged += new System.EventHandler(this.cmbPaymentMethod_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(357, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select Payment Method";
            // 
            // txtAmount
            // 
            this.txtAmount.AutoCompleteCustomSource.AddRange(new string[] {
            "800",
            "500",
            "1000",
            "1500"});
            this.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAmount.Location = new System.Drawing.Point(528, 202);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 21;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(357, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Monthly Amount";
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(528, 243);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(121, 20);
            this.txtCash.TabIndex = 23;
            this.txtCash.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(357, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Cash";
            // 
            // lblpaidMonth
            // 
            this.lblpaidMonth.AutoSize = true;
            this.lblpaidMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblpaidMonth.ForeColor = System.Drawing.Color.White;
            this.lblpaidMonth.Location = new System.Drawing.Point(357, 75);
            this.lblpaidMonth.Name = "lblpaidMonth";
            this.lblpaidMonth.Size = new System.Drawing.Size(98, 18);
            this.lblpaidMonth.TabIndex = 30;
            this.lblpaidMonth.Text = "Paying Month";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(382, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 19);
            this.label14.TabIndex = 31;
            this.label14.Text = "Current Month";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(382, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "Last Month";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(382, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 19);
            this.label16.TabIndex = 33;
            this.label16.Text = "Last Two Month";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(382, 417);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 19);
            this.label17.TabIndex = 34;
            this.label17.Text = "Last Three Month";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(339, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(183, 27);
            this.label21.TabIndex = 13;
            this.label21.Text = "Payment Handling";
            // 
            // PaymentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblpaidMonth);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblThreeMonthsAgoStatus);
            this.Controls.Add(this.lblLastMonthStatus);
            this.Controls.Add(this.lblThisMonthStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTwoMonthsAgoStatus);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentUC";
            this.Size = new System.Drawing.Size(910, 563);
            this.Load += new System.EventHandler(this.PaymentUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRScan)).EndInit();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxQRScan;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Button btnScanQR;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Drawing.Printing.PrintDocument printDocumentSave;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label lblInvoicetime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInvoiceMemID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInvoicePaymentMethod;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblThisMonthStatus;
        private System.Windows.Forms.Label lblLastMonthStatus;
        private System.Windows.Forms.Label lblTwoMonthsAgoStatus;
        private System.Windows.Forms.Label lblThreeMonthsAgoStatus;
        private System.Windows.Forms.Label lblpaidMonth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBillPaidMonth;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
    }
}
