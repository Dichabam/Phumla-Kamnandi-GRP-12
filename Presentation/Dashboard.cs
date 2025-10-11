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
        }

        private void SetupUserInterface()
        {
            // Update welcome label with current user's name
            if (!string.IsNullOrEmpty(_services.CurrentUserName))
            {
                WelcomLabel.Text = $"{_services.CurrentUserName.ToUpper()}";
                WelcomLabel.TextAlign = ContentAlignment.MiddleCenter;

            }
            else
            {
                WelcomLabel.Text = "USER";
            }

            // Hide Employees button if user is not admin
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
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(BookingButton);
            lblTitle.Text = "BOOKINGS";
            LoadForm(new FrmBookings());
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(GuestButton);
            lblTitle.Text = "GUESTS";
            LoadForm(new FrmGuests());
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(ReportsButton);
            lblTitle.Text = "REPORTS";
            LoadForm(new FrmReports());
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(RoomsButton);
            lblTitle.Text = "ROOMS";
            _currentRoomsForm = new FrmRooms();
            LoadForm(_currentRoomsForm);

            // Enable search for rooms
            SearchBox.Visible = true;
            SearchBox.PlaceholderText = "Search rooms...";
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            UpdateNavigationPanel(SettingsButton);
            lblTitle.Text = "SETTINGS";
            LoadForm(new FrmSettings());
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
            LoadForm(new FrmEmployees());
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

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        // Add TextChanged event for SearchBox:
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRoomsForm != null && lblTitle.Text == "ROOMS")
            {
                _currentRoomsForm.SearchRooms(SearchBox.Text);
            }
        }

        
       
    }


}