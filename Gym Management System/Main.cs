using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            homeUC1.Show();
            registrationUC1.Hide();
            attendancyUC1.Hide();
            paymentUC1.Hide();
            scheduleUC1.Hide();
            reportUC1.Hide();
            settingsUC1.Hide();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNavi.Location = new Point(3,btnHome.Location.Y);
            homeUC1.Show();
            registrationUC1.Hide();
            attendancyUC1.Hide();
            paymentUC1.Hide();
            scheduleUC1.Hide();
            reportUC1.Hide();
            settingsUC1.Hide();
            
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            pnlNavi.Location=new Point(3,btnRegistration.Location.Y);
            homeUC1.Hide();
            registrationUC1.Show();
            attendancyUC1.Hide();
            paymentUC1.Hide();
            scheduleUC1.Hide();
            reportUC1.Hide();
            settingsUC1.Hide();

        }

        private void btnAttendancy_Click(object sender, EventArgs e)
        {
            pnlNavi.Location=new Point(3, btnAttendancy.Location.Y);
            homeUC1.Hide();
            registrationUC1.Hide();
            attendancyUC1.Show();
            paymentUC1.Hide();
            scheduleUC1.Hide();
            reportUC1.Hide();
            settingsUC1.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlNavi.Location=new Point(3,btnPayment.Location.Y);
            homeUC1.Hide();
            registrationUC1.Hide();
            attendancyUC1.Hide();
            paymentUC1.Show();
            scheduleUC1.Hide();
            reportUC1.Hide();
            settingsUC1.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            pnlNavi.Location = new Point(3, btnSchedule.Location.Y);
            homeUC1.Hide();
            registrationUC1.Hide();
            attendancyUC1.Hide();
            paymentUC1.Hide();
            scheduleUC1.Show();
            reportUC1.Hide();
            settingsUC1.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlNavi.Location=new Point(3,btnReport.Location.Y);
            homeUC1.Hide();
            registrationUC1.Hide();
            attendancyUC1.Hide();
            paymentUC1.Hide();
            scheduleUC1.Hide();
            reportUC1.Show();
            settingsUC1.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNavi.Location=new Point(3,btnSettings.Location.Y);
            homeUC1.Hide();
            registrationUC1.Hide();
            attendancyUC1.Hide();
            paymentUC1.Hide();
            scheduleUC1.Hide();
            reportUC1.Hide();
            settingsUC1.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
