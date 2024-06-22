namespace Gym_Management_System
{
    partial class ScheduleUC
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
            this.lstbShedule = new System.Windows.Forms.ListBox();
            this.cmbEx = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSelectedDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEx1 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMemID = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbShedule
            // 
            this.lstbShedule.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lstbShedule.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbShedule.ForeColor = System.Drawing.Color.White;
            this.lstbShedule.FormattingEnabled = true;
            this.lstbShedule.ItemHeight = 17;
            this.lstbShedule.Location = new System.Drawing.Point(526, 42);
            this.lstbShedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstbShedule.Name = "lstbShedule";
            this.lstbShedule.Size = new System.Drawing.Size(372, 412);
            this.lstbShedule.TabIndex = 0;
            // 
            // cmbEx
            // 
            this.cmbEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbEx.FormattingEnabled = true;
            this.cmbEx.Items.AddRange(new object[] {
            "Leg curl",
            "Smith machine wide stance squat",
            "Leg extention",
            "Standing calf",
            "Reverce grip pull down",
            "Wide grip pull down",
            "Wide grip seated rowing",
            "Close grip spider rowing"});
            this.cmbEx.Location = new System.Drawing.Point(83, 274);
            this.cmbEx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEx.Name = "cmbEx";
            this.cmbEx.Size = new System.Drawing.Size(385, 26);
            this.cmbEx.TabIndex = 1;
            this.cmbEx.SelectedIndexChanged += new System.EventHandler(this.cmbEx_SelectedIndexChanged_1);
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Items.AddRange(new object[] {
            "#. Day 01",
            "#. Day 02",
            "#. Day 03",
            "#. Day 04",
            "#. Day 05",
            "#. Day 06",
            "#. Day 07"});
            this.cmbDate.Location = new System.Drawing.Point(83, 197);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 26);
            this.cmbDate.TabIndex = 3;
            this.cmbDate.SelectedIndexChanged += new System.EventHandler(this.cmbDate_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(786, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add  ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(656, 469);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 34);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print  ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSelectedDelete
            // 
            this.btnSelectedDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSelectedDelete.FlatAppearance.BorderSize = 0;
            this.btnSelectedDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelectedDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSelectedDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedDelete.ForeColor = System.Drawing.Color.White;
            this.btnSelectedDelete.Location = new System.Drawing.Point(526, 469);
            this.btnSelectedDelete.Name = "btnSelectedDelete";
            this.btnSelectedDelete.Size = new System.Drawing.Size(112, 34);
            this.btnSelectedDelete.TabIndex = 7;
            this.btnSelectedDelete.Text = "Delete  ";
            this.btnSelectedDelete.UseVisualStyleBackColor = false;
            this.btnSelectedDelete.Click += new System.EventHandler(this.btnSelectedDelete_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Exersices";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 35);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = " Schedule Management";
            // 
            // cmbEx1
            // 
            this.cmbEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbEx1.FormattingEnabled = true;
            this.cmbEx1.Items.AddRange(new object[] {
            "Leg curl",
            "Smith machine wide stance squat",
            "Leg extention",
            "Standing calf",
            "Reverce grip pull down",
            "Wide grip pull down",
            "Wide grip seated rowing",
            "Close grip spider rowing"});
            this.cmbEx1.Location = new System.Drawing.Point(83, 328);
            this.cmbEx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEx1.Name = "cmbEx1";
            this.cmbEx1.Size = new System.Drawing.Size(385, 26);
            this.cmbEx1.TabIndex = 13;
            this.cmbEx1.SelectedIndexChanged += new System.EventHandler(this.cmbEx1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Leg curl",
            "Smith machine wide stance squat",
            "Leg extention",
            "Standing calf",
            "Reverce grip pull down",
            "Wide grip pull down",
            "Wide grip seated rowing",
            "Close grip spider rowing"});
            this.comboBox1.Location = new System.Drawing.Point(83, 378);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(385, 26);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cmbEx1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "List01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "List02";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "List02";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(79, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Member ID";
            // 
            // cmbMemID
            // 
            this.cmbMemID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMemID.FormattingEnabled = true;
            this.cmbMemID.Location = new System.Drawing.Point(83, 122);
            this.cmbMemID.Name = "cmbMemID";
            this.cmbMemID.Size = new System.Drawing.Size(121, 20);
            this.cmbMemID.TabIndex = 16;
            this.cmbMemID.Text = "MemberID";
            this.cmbMemID.SelectedIndexChanged += new System.EventHandler(this.cmbMemID_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkCyan;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShow.Location = new System.Drawing.Point(284, 114);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 34);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show Schedule";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClearAll.Location = new System.Drawing.Point(526, 512);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(112, 34);
            this.btnClearAll.TabIndex = 18;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(656, 512);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(112, 34);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdate.Location = new System.Drawing.Point(786, 512);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ScheduleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbMemID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbEx1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectedDelete);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.cmbEx);
            this.Controls.Add(this.lstbShedule);
            this.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScheduleUC";
            this.Size = new System.Drawing.Size(910, 553);
            this.Load += new System.EventHandler(this.ScheduleUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbShedule;
        private System.Windows.Forms.ComboBox cmbEx;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSelectedDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEx1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMemID;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnUpdate;
    }
}
