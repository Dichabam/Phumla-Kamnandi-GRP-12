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
        }

        

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

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
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BookingButton.Height;
            PnlNav.Top = BookingButton.Top;
  
            BookingButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = GuestButton.Height;
            PnlNav.Top = GuestButton.Top;

            GuestButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = ReportsButton.Height;
            PnlNav.Top = ReportsButton.Top;

            ReportsButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = RoomsButton.Height;
            PnlNav.Top = RoomsButton.Top;

            RoomsButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            PnlNav.Height = SettingsButton.Height;
            PnlNav.Top = SettingsButton.Top;

            SettingsButton.BackColor = Color.FromArgb(46, 51, 73);
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

        private void CloseButtonDSHB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
     
    }
}
