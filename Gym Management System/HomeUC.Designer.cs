namespace Gym_Management_System
{
    partial class HomeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBmi = new System.Windows.Forms.Panel();
            this.lblBMI = new System.Windows.Forms.Label();
            this.btnBMIcal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnViewMem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotMem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotTrainer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTdyMem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTdyTrain = new System.Windows.Forms.Label();
            this.train = new System.Windows.Forms.Label();
            this.mem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlBmi.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 43);
            this.panel1.TabIndex = 12;
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
            this.btnRefresh.Location = new System.Drawing.Point(797, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(710, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.DarkOrange;
            this.lblDate.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(48, 123);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 37);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Time";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.DarkOrange;
            this.lblTime.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(44, 86);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 37);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Date";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Location = new System.Drawing.Point(709, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 168);
            this.panel2.TabIndex = 17;
            // 
            // pnlBmi
            // 
            this.pnlBmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.pnlBmi.Controls.Add(this.label9);
            this.pnlBmi.Controls.Add(this.label7);
            this.pnlBmi.Controls.Add(this.lblBMI);
            this.pnlBmi.Controls.Add(this.btnBMIcal);
            this.pnlBmi.Controls.Add(this.label3);
            this.pnlBmi.Controls.Add(this.txtHeight);
            this.pnlBmi.Controls.Add(this.label2);
            this.pnlBmi.Controls.Add(this.txtWeight);
            this.pnlBmi.Controls.Add(this.label1);
            this.pnlBmi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBmi.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlBmi.Location = new System.Drawing.Point(509, 210);
            this.pnlBmi.Name = "pnlBmi";
            this.pnlBmi.Size = new System.Drawing.Size(200, 346);
            this.pnlBmi.TabIndex = 18;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(35, 253);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 22);
            this.lblBMI.TabIndex = 24;
            // 
            // btnBMIcal
            // 
            this.btnBMIcal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnBMIcal.FlatAppearance.BorderSize = 0;
            this.btnBMIcal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBMIcal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMIcal.Location = new System.Drawing.Point(40, 197);
            this.btnBMIcal.Name = "btnBMIcal";
            this.btnBMIcal.Size = new System.Drawing.Size(133, 39);
            this.btnBMIcal.TabIndex = 23;
            this.btnBMIcal.Text = "Calculate";
            this.btnBMIcal.UseVisualStyleBackColor = false;
            this.btnBMIcal.Click += new System.EventHandler(this.btnBMIcal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(83, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.ForeColor = System.Drawing.SystemColors.Info;
            this.txtHeight.Location = new System.Drawing.Point(56, 151);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 29);
            this.txtHeight.TabIndex = 22;
            this.txtHeight.Text = " ";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(78, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.ForeColor = System.Drawing.SystemColors.Info;
            this.txtWeight.Location = new System.Drawing.Point(56, 84);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 29);
            this.txtWeight.TabIndex = 21;
            this.txtWeight.Text = " ";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "BMI Calculator";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.btnViewMem);
            this.panel4.Location = new System.Drawing.Point(509, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 168);
            this.panel4.TabIndex = 19;
            // 
            // btnViewMem
            // 
            this.btnViewMem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewMem.FlatAppearance.BorderSize = 0;
            this.btnViewMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMem.ForeColor = System.Drawing.Color.White;
            this.btnViewMem.Location = new System.Drawing.Point(39, 55);
            this.btnViewMem.Name = "btnViewMem";
            this.btnViewMem.Size = new System.Drawing.Size(134, 68);
            this.btnViewMem.TabIndex = 21;
            this.btnViewMem.Text = "View All Tables";
            this.btnViewMem.UseVisualStyleBackColor = false;
            this.btnViewMem.Click += new System.EventHandler(this.btnViewMem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total  Members";
            // 
            // lblTotMem
            // 
            this.lblTotMem.AutoSize = true;
            this.lblTotMem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotMem.ForeColor = System.Drawing.Color.White;
            this.lblTotMem.Location = new System.Drawing.Point(325, 53);
            this.lblTotMem.Name = "lblTotMem";
            this.lblTotMem.Size = new System.Drawing.Size(36, 28);
            this.lblTotMem.TabIndex = 21;
            this.lblTotMem.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total Trainers";
            // 
            // lblTotTrainer
            // 
            this.lblTotTrainer.AutoSize = true;
            this.lblTotTrainer.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotTrainer.ForeColor = System.Drawing.Color.White;
            this.lblTotTrainer.Location = new System.Drawing.Point(325, 108);
            this.lblTotTrainer.Name = "lblTotTrainer";
            this.lblTotTrainer.Size = new System.Drawing.Size(36, 28);
            this.lblTotTrainer.TabIndex = 23;
            this.lblTotTrainer.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Today Attendance";
            // 
            // lblTdyMem
            // 
            this.lblTdyMem.AutoSize = true;
            this.lblTdyMem.Location = new System.Drawing.Point(326, 275);
            this.lblTdyMem.Name = "lblTdyMem";
            this.lblTdyMem.Size = new System.Drawing.Size(30, 24);
            this.lblTdyMem.TabIndex = 25;
            this.lblTdyMem.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTdyTrain);
            this.groupBox1.Controls.Add(this.train);
            this.groupBox1.Controls.Add(this.mem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTdyMem);
            this.groupBox1.Controls.Add(this.lblTotMem);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTotTrainer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(34, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 407);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Status";
            // 
            // lblTdyTrain
            // 
            this.lblTdyTrain.AutoSize = true;
            this.lblTdyTrain.Location = new System.Drawing.Point(326, 323);
            this.lblTdyTrain.Name = "lblTdyTrain";
            this.lblTdyTrain.Size = new System.Drawing.Size(30, 24);
            this.lblTdyTrain.TabIndex = 28;
            this.lblTdyTrain.Text = "00";
            // 
            // train
            // 
            this.train.AutoSize = true;
            this.train.Location = new System.Drawing.Point(137, 323);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(79, 24);
            this.train.TabIndex = 27;
            this.train.Text = "Trainers";
            // 
            // mem
            // 
            this.mem.AutoSize = true;
            this.mem.Location = new System.Drawing.Point(137, 275);
            this.mem.Name = "mem";
            this.mem.Size = new System.Drawing.Size(90, 24);
            this.mem.TabIndex = 26;
            this.mem.Text = "Members";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(115, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 85);
            this.label5.TabIndex = 27;
            this.label5.Text = "WelCome !";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "cm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "kg";
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlBmi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(910, 559);
            this.Load += new System.EventHandler(this.HomeUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBmi.ResumeLayout(false);
            this.pnlBmi.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBmi;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBMIcal;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnViewMem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotMem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTdyMem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTdyTrain;
        private System.Windows.Forms.Label train;
        private System.Windows.Forms.Label mem;
        public System.Windows.Forms.Label lblTotTrainer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}
