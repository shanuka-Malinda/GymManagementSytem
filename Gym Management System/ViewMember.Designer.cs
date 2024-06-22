namespace Gym_Management_System
{
    partial class ViewMember
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.btnMemAttendance = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnTrainAttend = new System.Windows.Forms.Button();
            this.pnlNavi = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetail
            // 
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(12, 55);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(982, 447);
            this.dgvDetail.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(698, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(215, 26);
            this.txtID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(919, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btnMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Location = new System.Drawing.Point(23, 15);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(75, 23);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnTrainer
            // 
            this.btnTrainer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTrainer.FlatAppearance.BorderSize = 0;
            this.btnTrainer.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btnTrainer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnTrainer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainer.ForeColor = System.Drawing.Color.White;
            this.btnTrainer.Location = new System.Drawing.Point(104, 15);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(75, 23);
            this.btnTrainer.TabIndex = 4;
            this.btnTrainer.Text = "Trainer";
            this.btnTrainer.UseVisualStyleBackColor = false;
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // btnMemAttendance
            // 
            this.btnMemAttendance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMemAttendance.FlatAppearance.BorderSize = 0;
            this.btnMemAttendance.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btnMemAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMemAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMemAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemAttendance.ForeColor = System.Drawing.Color.White;
            this.btnMemAttendance.Location = new System.Drawing.Point(266, 15);
            this.btnMemAttendance.Name = "btnMemAttendance";
            this.btnMemAttendance.Size = new System.Drawing.Size(112, 23);
            this.btnMemAttendance.TabIndex = 5;
            this.btnMemAttendance.Text = "Member Attendance";
            this.btnMemAttendance.UseVisualStyleBackColor = false;
            this.btnMemAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(185, 15);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnTrainAttend
            // 
            this.btnTrainAttend.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTrainAttend.FlatAppearance.BorderSize = 0;
            this.btnTrainAttend.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.btnTrainAttend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnTrainAttend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnTrainAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainAttend.ForeColor = System.Drawing.Color.White;
            this.btnTrainAttend.Location = new System.Drawing.Point(384, 15);
            this.btnTrainAttend.Name = "btnTrainAttend";
            this.btnTrainAttend.Size = new System.Drawing.Size(120, 23);
            this.btnTrainAttend.TabIndex = 7;
            this.btnTrainAttend.Text = "Trainer Attendance";
            this.btnTrainAttend.UseVisualStyleBackColor = false;
            this.btnTrainAttend.Click += new System.EventHandler(this.btnTrainAttend_Click);
            // 
            // pnlNavi
            // 
            this.pnlNavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlNavi.Location = new System.Drawing.Point(23, 38);
            this.pnlNavi.Name = "pnlNavi";
            this.pnlNavi.Size = new System.Drawing.Size(75, 11);
            this.pnlNavi.TabIndex = 8;
            // 
            // ViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1006, 514);
            this.Controls.Add(this.pnlNavi);
            this.Controls.Add(this.btnTrainAttend);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnMemAttendance);
            this.Controls.Add(this.btnTrainer);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Details";
            this.Load += new System.EventHandler(this.ViewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnTrainer;
        private System.Windows.Forms.Button btnMemAttendance;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnTrainAttend;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnlNavi;
    }
}