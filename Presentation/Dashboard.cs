/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRountRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        private ServiceLocator _services;
        private FrmRooms _currentRoomsForm;
        private FrmGuests _currentGuestsForm;
        private FrmBookings _currentBookingsForm;
        private FrmEmployees _currentEmployeeForm;
        private Form _currentForm; 

        public Dashboard()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            Region = System.Drawing.Region.FromHrgn(CreateRountRectRgn(0, 0, Width, Height, 25, 25));

            SetupUserInterface();

            PnlNav.Height = HomeButton.Height;
            PnlNav.Top = HomeButton.Top;
            PnlNav.Left = HomeButton.Left;
            HomeButton.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "HOME";
            LoadForm(new FrmHome());
            SearchBox.TextChanged += SearchBox_TextChanged;
            SearchBox.ReadOnly = true;
            //SearchBox.Visible = true;
            SearchBox.PlaceholderText = "";
            SearchBox.Visible = false;
            SearchBox.Clear();
        }

        private void SetupUserInterface()
        {
            if (!string.IsNullOrEmpty(_services.CurrentUserName))
            {
                WelcomLabel.Text = $"{_services.CurrentUserName.ToUpper()}";
                WelcomLabel.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                WelcomLabel.Text = "USER";
            }

            if (!_services.IsAdmin)
            {
                EmployeesButton.Visible = false;
                EmployeesButton.Enabled = false;
            }
            else
            {
                EmployeesButton.Visible = true;
                EmployeesButton.Enabled = true;
            }
        }

        #region Button Clicks
        private void HomeButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(HomeButton);
            lblTitle.Text = "HOME";
            LoadForm(new FrmHome());
            SearchBox.ReadOnly = true;
            SearchBox.Visible = false;
            SearchBox.PlaceholderText = "";
            SearchBox.Clear();
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(BookingButton);
            lblTitle.Text = "BOOKINGS";
            _currentBookingsForm = new FrmBookings();
            LoadForm(_currentBookingsForm);

            SearchBox.Visible = true;
            SearchBox.ReadOnly = false;
            SearchBox.PlaceholderText = "Search Bookings...";
            SearchBox.Clear();
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(GuestButton);
            lblTitle.Text = "GUESTS";
            _currentGuestsForm = new FrmGuests();
            LoadForm(_currentGuestsForm);

            SearchBox.ReadOnly = false;
            SearchBox.Visible = true;
            SearchBox.PlaceholderText = "Search Guests...";
            SearchBox.Clear();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(ReportsButton);
            lblTitle.Text = "REPORTS";
            LoadForm(new FrmReports());

            SearchBox.Visible = false;
            SearchBox.ReadOnly = true;
            SearchBox.PlaceholderText = "";
            SearchBox.Clear();
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(RoomsButton);
            lblTitle.Text = "ROOMS";
            _currentRoomsForm = new FrmRooms();
            LoadForm(_currentRoomsForm);

            SearchBox.ReadOnly = false;
            SearchBox.Visible = true;
            SearchBox.PlaceholderText = "Search Rooms...";
            SearchBox.Clear();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(SettingsButton);
            lblTitle.Text = "PROFILE";
            LoadForm(new FrmSettings());
            SearchBox.Visible = false;
            SearchBox.ReadOnly = true;
            SearchBox.PlaceholderText = "";
            SearchBox.Clear();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _services.ClearSession();
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            if (!_services.IsAdmin)
            {
                MessageBox.Show("Access Denied. This section is only available to administrators.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateNavigationPanel(EmployeesButton);
            lblTitle.Text = "EMPLOYEES";
            _currentEmployeeForm = new FrmEmployees();
            LoadForm(new FrmEmployees());
            SearchBox.Visible = false;
            //SearchBox.ReadOnly = false;
            //SearchBox.PlaceholderText = "Search Employees...";
            SearchBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Button Leave Events
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

        private void EmployeesButton_Leave(object sender, EventArgs e)
        {
            EmployeesButton.BackColor = Color.FromArgb(24, 30, 54);
        }
        #endregion

        #region Label Clicks
        private void WelcomLabel_Click(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void PnlFormLoader_Paint(object sender, PaintEventArgs e) { }
        #endregion

        #region Helper Methods
        private void LoadForm(Form form)
        {
            this.PnlFormLoader.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(form);
            form.Show();

      
            _currentForm = form;
        }

        private void UpdateNavigationPanel(Button button)
        {
            PnlNav.Height = button.Height;
            PnlNav.Top = button.Top;
            button.BackColor = Color.FromArgb(46, 51, 73);
        }

        public void NavigateToBookings()
        {
            BookingButton_Click(BookingButton, EventArgs.Empty);
        }

        public void NavigateToGuest()
        {
            GuestButton_Click(GuestButton, EventArgs.Empty);
        }
        #endregion

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchBox.Text.Trim();

      
            if (lblTitle.Text == "ROOMS" && _currentRoomsForm != null)
            {
                _currentRoomsForm.SearchRooms(searchText);
            }
            else if (lblTitle.Text == "BOOKINGS" && _currentBookingsForm != null)
            {
                _currentBookingsForm.SearchBookings(searchText);
            }
            else if (lblTitle.Text == "GUESTS" && _currentGuestsForm != null)
            {
                _currentGuestsForm.SearchGuests(searchText);
            } else if (lblTitle.Text == "EMPLOYEES" && _currentGuestsForm != null)
            {
                _currentEmployeeForm.SearchEmployees(searchText);
            }
        }

        private void CompanyLogo_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}