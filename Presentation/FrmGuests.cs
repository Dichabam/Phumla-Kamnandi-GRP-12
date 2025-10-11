using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Phumla_Kamnandi_GRP_12.Business.Entities;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmGuests : Form
    {
        private ServiceLocator _services;
        private Guest _selectedGuestForUpdate = null;

        public FrmGuests()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            InitializeForm();
            LoadAllGuests();
        }

        private void InitializeForm()
        {
            // Hide email verification controls by default
            enterEmailTextbox.Visible = false;
            emailConfirmtextbox.Visible = false;
            ConfirmButtonVBH.Visible = false;
            ErrorLableVBH.Visible = false;

            // Hide update panel by default
            UpdatebuttonPanel.Visible = false;

            GuestDataView.ReadOnly = true;

            // Configure DataGridView
            GuestDataView.AutoGenerateColumns = false;
            GuestDataView.Columns.Clear();

            GuestDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GuestId",
                HeaderText = "Guest ID",
                DataPropertyName = "GuestId",
                Width = 100
            });

            GuestDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "First Name",
                DataPropertyName = "FirstName",
                Width = 120
            });

            GuestDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Last Name",
                DataPropertyName = "LastName",
                Width = 120
            });

            GuestDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
                Width = 180
            });

            GuestDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "Phone",
                DataPropertyName = "Phone",
                Width = 120
            });

            GuestDataView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IsInGoodStanding",
                HeaderText = "Good Standing",
                DataPropertyName = "IsInGoodStanding",
                Width = 100
            });

            // Wire up events
            viewBookingHostoryButton.Click += ViewBookingHistoryButton_Click;
            GuestStandingButton.Click += GuestStandingButton_Click;
            AddGuestButton.Click += AddGuestButton_Click;
            UpdateGuestButton.Click += UpdateGuestButton_Click;
            ConfirmButtonVBH.Click += ConfirmButtonVBH_Click;
            SaveButton.Click += SaveButton_Click;
            terminateButton.Click += terminateButton_Click;
            GuestDataView.CellClick += GuestDataView_CellClick;
            emailConfirmtextbox.TextChanged += (s, e) => ErrorLableVBH.Visible = false;
        }

        private void LoadAllGuests()
        {
            try
            {
                var guests = _services.GuestRepository.GetAll();
                GuestDataView.DataSource = guests;

                // Highlight guests not in good standing
                foreach (DataGridViewRow row in GuestDataView.Rows)
                {
                    if (row.DataBoundItem is Guest guest)
                    {
                        if (!guest.IsInGoodStanding)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            row.DefaultCellStyle.ForeColor = Color.DarkRed;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guests: {ex.Message}\n\nPlease ensure database is properly configured.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewBookingHistoryButton_Click(object sender, EventArgs e)
        {
            // Show email verification controls
            enterEmailTextbox.Text = "Enter Guest Email";
            enterEmailTextbox.Visible = true;
            emailConfirmtextbox.Visible = true;
            ConfirmButtonVBH.Visible = true;
            ErrorLableVBH.Visible = false;
            emailConfirmtextbox.Clear();
            emailConfirmtextbox.Focus();
        }

        private void GuestStandingButton_Click(object sender, EventArgs e)
        {
            // Show email verification controls with different label
            enterEmailTextbox.Text = "Enter Guest Email";
            enterEmailTextbox.Visible = true;
            emailConfirmtextbox.Visible = true;
            ConfirmButtonVBH.Visible = true;
            ErrorLableVBH.Visible = false;
            emailConfirmtextbox.Clear();
            emailConfirmtextbox.Focus();
        }

        private void ConfirmButtonVBH_Click(object sender, EventArgs e)
        {
            string email = emailConfirmtextbox.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                ErrorLableVBH.Text = "Please enter an email address";
                ErrorLableVBH.Visible = true;
                return;
            }

            try
            {
                var guest = _services.GuestService.GetGuestByEmail(email);

                if (guest == null)
                {
                    ErrorLableVBH.Text = "Guest not found";
                    ErrorLableVBH.Visible = true;
                    return;
                }

                ErrorLableVBH.Visible = false;

                // Determine which button was clicked based on visible controls
                if (enterEmailTextbox.Text.Contains("Standing"))
                {
                    ShowGuestStanding(guest);
                }
                else
                {
                    ShowBookingHistory(guest);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowGuestStanding(Guest guest)
        {
            try
            {
                bool isInGoodStanding = _services.GuestService.CheckAndUpdateGuestStanding(guest.GuestId);

                string status = isInGoodStanding ? "Good Standing" : "Not in Good Standing";
                string message = $"Guest: {guest.FullName}\n" +
                               $"Email: {guest.Email}\n" +
                               $"Status: {status}\n\n";

                if (!isInGoodStanding)
                {
                    var bookings = _services.GuestService.GetGuestBookings(guest.GuestId);
                    var overdueDeposits = bookings.Where(b =>
                        b.Status == Business.Enums.BookingStatus.Unconfirmed &&
                        b.DepositDueDate.HasValue &&
                        b.DepositDueDate.Value < DateTime.Today).ToList();

                    if (overdueDeposits.Any())
                    {
                        message += "Issues:\n";
                        foreach (var booking in overdueDeposits)
                        {
                            message += $"- Overdue deposit for booking {booking.BookingReference}\n";
                        }
                    }
                }

                MessageBox.Show(message, "Guest Standing",
                    MessageBoxButtons.OK,
                    isInGoodStanding ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                LoadAllGuests();
                HideBookingHistoryControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking guest standing: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowBookingHistory(Guest guest)
        {
            try
            {
                var bookings = _services.GuestService.GetGuestBookings(guest.GuestId);
                BookingHistory historyForm = new BookingHistory(guest, bookings);
                historyForm.ShowDialog();
                HideBookingHistoryControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading booking history: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            if (enterEmailTextbox.Visible || emailConfirmtextbox.Visible || ConfirmButtonVBH.Visible)
            {
                HideBookingHistoryControls();
            }

            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.NavigateToBookings();
            }
        }

        private void UpdateGuestButton_Click(object sender, EventArgs e)
        {
            // Hide email verification controls if visible
            if (enterEmailTextbox.Visible || emailConfirmtextbox.Visible || ConfirmButtonVBH.Visible)
            {
                HideBookingHistoryControls();
            }

            // Check if a guest is selected in the DataGridView
            if (GuestDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest from the list to update.",
                    "No Guest Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected guest
            _selectedGuestForUpdate = GuestDataView.SelectedRows[0].DataBoundItem as Guest;

            if (_selectedGuestForUpdate == null)
            {
                MessageBox.Show("Error retrieving guest information.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show the update panel and populate with current data
            ShowUpdatePanel(_selectedGuestForUpdate);
        }

        private void ShowUpdatePanel(Guest guest)
        {
            // Populate textboxes with current guest data
            NameTxtBox.Text = guest.FirstName;
            SurnameTxtbox.Text = guest.LastName;
            PhoneTxtbox.Text = guest.Phone;
            EmailTxtbox.Text = guest.Email;
            

            // Show the panel
            UpdatebuttonPanel.Visible = true;

            // Disable other buttons while updating
            AddGuestButton.Enabled = false;
            viewBookingHostoryButton.Enabled = false;
            GuestStandingButton.Enabled = false;
            UpdateGuestButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_selectedGuestForUpdate == null)
            {
                MessageBox.Show("No guest selected for update.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get the values from textboxes
                string newFirstName = NameTxtBox.Text.Trim();
                string newLastName = SurnameTxtbox.Text.Trim();
                string newPhone = PhoneTxtbox.Text.Trim();
                string newEmail = EmailTxtbox.Text.Trim();
                

                // Track if any changes were made
                bool hasChanges = false;

                // Validate required fields
                if (string.IsNullOrWhiteSpace(newFirstName))
                {
                    MessageBox.Show("First name cannot be empty.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(newLastName))
                {
                    MessageBox.Show("Last name cannot be empty.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(newEmail))
                {
                    MessageBox.Show("Email cannot be empty.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate email format
                if (!IsValidEmail(newEmail))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for changes
                if (newFirstName != _selectedGuestForUpdate.FirstName ||
                    newLastName != _selectedGuestForUpdate.LastName ||
                    newPhone != _selectedGuestForUpdate.Phone ||
                    newEmail != _selectedGuestForUpdate.Email
                    )
                {
                    hasChanges = true;
                }

                if (!hasChanges)
                {
                    MessageBox.Show("No changes detected.", "No Changes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirm update
                DialogResult result = MessageBox.Show(
                    $"Update information for {_selectedGuestForUpdate.FullName}?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Update contact information
                bool updateSuccess = _services.GuestService.UpdateGuestContactInfo(
                    _selectedGuestForUpdate.GuestId,
                    newEmail,
                    newPhone,
                    newFirstName
                    
                );

                

                if (updateSuccess)
                {
                    MessageBox.Show("Guest information updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HideUpdatePanel();
                    LoadAllGuests();
                }
                else
                {
                    MessageBox.Show("Failed to update guest information.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating guest: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void terminateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Cancel editing? All unsaved changes will be lost.",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HideUpdatePanel();
            }
        }

        private void HideUpdatePanel()
        {
            // Clear all textboxes
            NameTxtBox.Clear();
            SurnameTxtbox.Clear();
            PhoneTxtbox.Clear();
            EmailTxtbox.Clear();
            

            // Hide the panel
            UpdatebuttonPanel.Visible = false;

            // Re-enable other buttons
            AddGuestButton.Enabled = true;
            viewBookingHostoryButton.Enabled = true;
            GuestStandingButton.Enabled = true;
            UpdateGuestButton.Enabled = true;

            // Clear selected guest
            _selectedGuestForUpdate = null;
        }

        private void HideBookingHistoryControls()
        {
            enterEmailTextbox.Visible = false;
            emailConfirmtextbox.Visible = false;
            ConfirmButtonVBH.Visible = false;
            ErrorLableVBH.Visible = false;
            emailConfirmtextbox.Clear();
        }

        private void GuestDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GuestDataView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void GuestDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void emailConfirmtextbox_TextChanged(object sender, EventArgs e)
        {
            ErrorLableVBH.Visible = false;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void IDNumTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void terminateButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Cancel adding guest? All unsaved changes will be lost.",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HideUpdatePanel();
            }
        }
    }
}