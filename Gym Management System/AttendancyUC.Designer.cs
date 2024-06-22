namespace Gym_Management_System
{
    partial class AttendancyUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendancyUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.calender = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.pictureBoxQRScan = new System.Windows.Forms.PictureBox();
            this.btnScanQR = new System.Windows.Forms.Button();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblAttendCount = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblThreeMonthsAgoStatus = new System.Windows.Forms.Label();
            this.lblLastMonthStatus = new System.Windows.Forms.Label();
            this.lblThisMonthStatus = new System.Windows.Forms.Label();
            this.lblTwoMonthsAgoStatus = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRScan)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.calender);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 43);
            this.panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(625, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 19);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            // 
            // calender
            // 
            this.calender.CustomFormat = "MM";
            this.calender.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calender.Location = new System.Drawing.Point(16, 10);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(74, 20);
            this.calender.TabIndex = 0;
            this.calender.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(429, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 19);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMarkAttendance.FlatAppearance.BorderSize = 0;
            this.btnMarkAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAttendance.Location = new System.Drawing.Point(255, 86);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(100, 26);
            this.btnMarkAttendance.TabIndex = 6;
            this.btnMarkAttendance.Text = "Mark";
            this.btnMarkAttendance.UseVisualStyleBackColor = false;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter/Select ID";
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(255, 54);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(100, 21);
            this.cmbID.TabIndex = 10;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // pictureBoxQRScan
            // 
            this.pictureBoxQRScan.Location = new System.Drawing.Point(3, 50);
            this.pictureBoxQRScan.Name = "pictureBoxQRScan";
            this.pictureBoxQRScan.Size = new System.Drawing.Size(336, 299);
            this.pictureBoxQRScan.TabIndex = 11;
            this.pictureBoxQRScan.TabStop = false;
            // 
            // btnScanQR
            // 
            this.btnScanQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.btnScanQR.FlatAppearance.BorderSize = 0;
            this.btnScanQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanQR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanQR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnScanQR.Location = new System.Drawing.Point(73, 17);
            this.btnScanQR.Name = "btnScanQR";
            this.btnScanQR.Size = new System.Drawing.Size(86, 32);
            this.btnScanQR.TabIndex = 12;
            this.btnScanQR.Text = "Scan QR";
            this.btnScanQR.UseVisualStyleBackColor = false;
            this.btnScanQR.Click += new System.EventHandler(this.btnScanQR_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.btnStopScan.FlatAppearance.BorderSize = 0;
            this.btnStopScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopScan.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.btnStopScan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopScan.Location = new System.Drawing.Point(182, 17);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(86, 32);
            this.btnStopScan.TabIndex = 13;
            this.btnStopScan.Text = "Stop Scan";
            this.btnStopScan.UseVisualStyleBackColor = false;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.pictureBoxQRScan);
            this.panel3.Controls.Add(this.btnStopScan);
            this.panel3.Controls.Add(this.btnScanQR);
            this.panel3.Location = new System.Drawing.Point(13, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 352);
            this.panel3.TabIndex = 14;
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "Member",
            "Trainer"});
            this.cmbSelect.Location = new System.Drawing.Point(63, 52);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(67, 21);
            this.cmbSelect.TabIndex = 15;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Type";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAttendCount
            // 
            this.lblAttendCount.AutoSize = true;
            this.lblAttendCount.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendCount.Location = new System.Drawing.Point(456, 85);
            this.lblAttendCount.Name = "lblAttendCount";
            this.lblAttendCount.Size = new System.Drawing.Size(131, 27);
            this.lblAttendCount.TabIndex = 17;
            this.lblAttendCount.Text = "Attendance Count";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(457, 140);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(65, 24);
            this.lblMemberName.TabIndex = 20;
            this.lblMemberName.Text = "Name";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(458, 174);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(65, 20);
            this.lblContactNumber.TabIndex = 21;
            this.lblContactNumber.Text = "Contact";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(458, 457);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 19);
            this.label17.TabIndex = 42;
            this.label17.Text = "Last Three Month";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(458, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 19);
            this.label16.TabIndex = 41;
            this.label16.Text = "Last Two Month";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(458, 400);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 19);
            this.label15.TabIndex = 40;
            this.label15.Text = "Last Month";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(458, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 19);
            this.label14.TabIndex = 39;
            this.label14.Text = "Current Month";
            // 
            // lblThreeMonthsAgoStatus
            // 
            this.lblThreeMonthsAgoStatus.AccessibleName = "PmntStatus";
            this.lblThreeMonthsAgoStatus.AutoSize = true;
            this.lblThreeMonthsAgoStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeMonthsAgoStatus.ForeColor = System.Drawing.Color.White;
            this.lblThreeMonthsAgoStatus.Location = new System.Drawing.Point(587, 456);
            this.lblThreeMonthsAgoStatus.Name = "lblThreeMonthsAgoStatus";
            this.lblThreeMonthsAgoStatus.Size = new System.Drawing.Size(106, 19);
            this.lblThreeMonthsAgoStatus.TabIndex = 38;
            this.lblThreeMonthsAgoStatus.Text = "Payment Status";
            // 
            // lblLastMonthStatus
            // 
            this.lblLastMonthStatus.AccessibleName = "PmntStatus";
            this.lblLastMonthStatus.AutoSize = true;
            this.lblLastMonthStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMonthStatus.ForeColor = System.Drawing.Color.White;
            this.lblLastMonthStatus.Location = new System.Drawing.Point(587, 400);
            this.lblLastMonthStatus.Name = "lblLastMonthStatus";
            this.lblLastMonthStatus.Size = new System.Drawing.Size(106, 19);
            this.lblLastMonthStatus.TabIndex = 36;
            this.lblLastMonthStatus.Text = "Payment Status";
            // 
            // lblThisMonthStatus
            // 
            this.lblThisMonthStatus.AccessibleName = "PmntStatus";
            this.lblThisMonthStatus.AutoSize = true;
            this.lblThisMonthStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisMonthStatus.ForeColor = System.Drawing.Color.White;
            this.lblThisMonthStatus.Location = new System.Drawing.Point(587, 373);
            this.lblThisMonthStatus.Name = "lblThisMonthStatus";
            this.lblThisMonthStatus.Size = new System.Drawing.Size(106, 19);
            this.lblThisMonthStatus.TabIndex = 35;
            this.lblThisMonthStatus.Text = "Payment Status";
            // 
            // lblTwoMonthsAgoStatus
            // 
            this.lblTwoMonthsAgoStatus.AccessibleName = "PmntStatus";
            this.lblTwoMonthsAgoStatus.AutoSize = true;
            this.lblTwoMonthsAgoStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoMonthsAgoStatus.ForeColor = System.Drawing.Color.White;
            this.lblTwoMonthsAgoStatus.Location = new System.Drawing.Point(587, 428);
            this.lblTwoMonthsAgoStatus.Name = "lblTwoMonthsAgoStatus";
            this.lblTwoMonthsAgoStatus.Size = new System.Drawing.Size(106, 19);
            this.lblTwoMonthsAgoStatus.TabIndex = 37;
            this.lblTwoMonthsAgoStatus.Text = "Payment Status";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(415, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 395);
            this.panel4.TabIndex = 43;
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(461, 207);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAttendance.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewAttendance.TabIndex = 44;
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
            this.btnRefresh.Location = new System.Drawing.Point(800, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 34);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AttendancyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.dataGridViewAttendance);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblThreeMonthsAgoStatus);
            this.Controls.Add(this.lblLastMonthStatus);
            this.Controls.Add(this.lblThisMonthStatus);
            this.Controls.Add(this.lblTwoMonthsAgoStatus);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblAttendCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMarkAttendance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "AttendancyUC";
            this.Size = new System.Drawing.Size(910, 559);
            this.Load += new System.EventHandler(this.AttendancyUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRScan)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calender;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.PictureBox pictureBoxQRScan;
        private System.Windows.Forms.Button btnScanQR;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblAttendCount;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblThreeMonthsAgoStatus;
        private System.Windows.Forms.Label lblLastMonthStatus;
        private System.Windows.Forms.Label lblThisMonthStatus;
        private System.Windows.Forms.Label lblTwoMonthsAgoStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.Button btnRefresh;
    }
}
