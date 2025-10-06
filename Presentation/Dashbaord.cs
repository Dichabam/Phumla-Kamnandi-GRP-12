using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class Dashbaord : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]



        private static extern IntPtr CreateRountRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private bool isFullScreen = false;
        public Dashbaord()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRountRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = HomeButton.Height;
            PnlNav.Top = HomeButton.Top;
            PnlNav.Left = HomeButton.Left;
            HomeButton.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Home";
            this.PnlFormLoader.Controls.Clear();
            FrmHome frmHome = new FrmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmHome);
            frmHome.Show();
        }

        private void PnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = HomeButton.Height;
            PnlNav.Top = HomeButton.Top;
            PnlNav.Left = HomeButton.Left;
            HomeButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "HOME";
            this.PnlFormLoader.Controls.Clear();
            FrmHome frmHome = new FrmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmHome);
            frmHome.Show();
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BookingButton.Height;
            PnlNav.Top = BookingButton.Top;
  
            BookingButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "BOOKINGS";
            this.PnlFormLoader.Controls.Clear();
            FrmBookings frmBook = new FrmBookings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBook.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmBook);
            frmBook.Show();
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = GuestButton.Height;
            PnlNav.Top = GuestButton.Top;

            GuestButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "GUESTS";
            this.PnlFormLoader.Controls.Clear();
            FrmGuests frmGuest = new FrmGuests() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGuest.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmGuest);
            frmGuest.Show();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = ReportsButton.Height;
            PnlNav.Top = ReportsButton.Top;

            ReportsButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "REPORTS";
            this.PnlFormLoader.Controls.Clear();
            FrmReports frmReport = new FrmReports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReport.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmReport);
            frmReport.Show();
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = RoomsButton.Height;
            PnlNav.Top = RoomsButton.Top;

            RoomsButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "ROOMS";
            this.PnlFormLoader.Controls.Clear();
            FrmRooms frmRoom = new FrmRooms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmRoom.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmRoom);
            frmRoom.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = SettingsButton.Height;
            PnlNav.Top = SettingsButton.Top;

            SettingsButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "SETTINGS";
            this.PnlFormLoader.Controls.Clear();
            FrmSettings frmSet = new FrmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSet.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmSet);
            frmSet.Show();
        }

        private void HomeButton_Leave(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void BookingButton_Leave(object sender, EventArgs e)
        {
            BookingButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void GuestButton_Leave(object sender, EventArgs e)
        {
            GuestButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ReportsButton_Leave(object sender, EventArgs e)
        {
            ReportsButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void RoomsButton_Leave(object sender, EventArgs e)
        {
            RoomsButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void SettingsButton_Leave(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Confirm logout
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // TODO: Add any cleanup logic here (clear session, etc.)

                // Close dashboard and show login
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
                
                
            }
           
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void WelcomLabel_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = EmployeesButton.Height;
            PnlNav.Top = EmployeesButton.Top;

            EmployeesButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "EMPLOYEES";
            this.PnlFormLoader.Controls.Clear();
            FrmEmployees frmEmp = new FrmEmployees() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmEmp.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmEmp);
            frmEmp.Show();
        }

        private void EmployeesButton_Leave(object sender, EventArgs e)
        {
            EmployeesButton.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
