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
        private bool _isUpdateMode = false;
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
            GuestDataView.CellClick += GuestDataView_CellContentClick;  
            emailConfirmtextbox.TextChanged += (s, e) => ErrorLableVBH.Visible = false;
            terminateButton.Click += terminateButton_Click;
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

                // Refresh the grid to show updated standing
                LoadAllGuests();

                // Hide controls
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
                enterEmailTextbox.Visible = false;
                emailConfirmtextbox.Visible = false;
                ConfirmButtonVBH.Visible = false;
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

        private void HideBookingHistoryControls()
        {
            enterEmailTextbox.Visible = false;
            emailConfirmtextbox.Visible = false;
            ConfirmButtonVBH.Visible = false;
            ErrorLableVBH.Visible = false;
            emailConfirmtextbox.Clear();
        }

        private void GuestDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void emailConfirmtextbox_TextChanged(object sender, EventArgs e)
        {
            
            ErrorLableVBH.Visible = false;
        }


        private void ShowUpdatePanel(Guest guest)
        {
            // Populate textboxes with current guest data
            NameTxtBox.Text = guest.FirstName;
            SurnameTxtbox.Text = guest.LastName;
            PhoneTxtbox.Text = guest.Phone;
            EmailTxtbox.Text = guest.Email;
            AdressTxtBox.Text = guest.Address;
            CreditcardNumTxtbox.Text = guest.CreditCardLastFourDigits ?? "";

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

            // Validate that at least one field has been modified
            bool hasChanges = false;
            string errorMessage = "";

            try
            {
                // Check and update First Name
                if (!string.IsNullOrWhiteSpace(NameTxtBox.Text) &&
                    NameTxtBox.Text.Trim() != _selectedGuestForUpdate.FirstName)
                {
                    hasChanges = true;
                }

                // Check and update Last Name
                if (!string.IsNullOrWhiteSpace(SurnameTxtbox.Text) &&
                    SurnameTxtbox.Text.Trim() != _selectedGuestForUpdate.LastName)
                {
                    hasChanges = true;
                }

                // Check and update Phone
                if (!string.IsNullOrWhiteSpace(PhoneTxtbox.Text) &&
                    PhoneTxtbox.Text.Trim() != _selectedGuestForUpdate.Phone)
                {
                    hasChanges = true;
                }

                // Check and update Email
                if (!string.IsNullOrWhiteSpace(EmailTxtbox.Text) &&
                    EmailTxtbox.Text.Trim() != _selectedGuestForUpdate.Email)
                {
                    // Validate email format
                    if (!IsValidEmail(EmailTxtbox.Text.Trim()))
                    {
                        errorMessage = "Invalid email format.";
                        throw new Exception(errorMessage);
                    }
                    hasChanges = true;
                }

                // Check and update Address
                if (!string.IsNullOrWhiteSpace(AdressTxtBox.Text) &&
                    AdressTxtBox.Text.Trim() != _selectedGuestForUpdate.Address)
                {
                    hasChanges = true;
                }

                // Check and update Credit Card
                if (!string.IsNullOrWhiteSpace(CreditcardNumTxtbox.Text))
                {
                    string creditCardInput = CreditcardNumTxtbox.Text.Trim();
                    if (creditCardInput != (_selectedGuestForUpdate.CreditCardLastFourDigits ?? ""))
                    {
                        // Validate credit card number (should be at least 4 digits)
                        if (creditCardInput.Length < 4 || !creditCardInput.All(char.IsDigit))
                        {
                            errorMessage = "Credit card number must contain at least 4 digits.";
                            throw new Exception(errorMessage);
                        }
                        hasChanges = true;
                    }
                }

                // Check if any changes were made
                if (!hasChanges)
                {
                    MessageBox.Show("No changes detected. Please modify at least one field.",
                        "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirm update
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to update information for {_selectedGuestForUpdate.FullName}?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Perform updates
                // Update contact information (email, phone, address)
                string updatedEmail = string.IsNullOrWhiteSpace(EmailTxtbox.Text) ?
                    _selectedGuestForUpdate.Email : EmailTxtbox.Text.Trim();
                string updatedPhone = string.IsNullOrWhiteSpace(PhoneTxtbox.Text) ?
                    _selectedGuestForUpdate.Phone : PhoneTxtbox.Text.Trim();
                string updatedAddress = string.IsNullOrWhiteSpace(AdressTxtBox.Text) ?
                    _selectedGuestForUpdate.Address : AdressTxtBox.Text.Trim();

                bool contactUpdateSuccess = _services.GuestService.UpdateGuestContactInfo(
                    _selectedGuestForUpdate.GuestId,
                    updatedEmail,
                    updatedPhone,
                    updatedAddress
                );

                // Update credit card if changed
                if (!string.IsNullOrWhiteSpace(CreditcardNumTxtbox.Text) &&
                    CreditcardNumTxtbox.Text.Trim() != (_selectedGuestForUpdate.CreditCardLastFourDigits ?? ""))
                {
                    string creditCardInput = CreditcardNumTxtbox.Text.Trim();
                    bool creditCardUpdateSuccess = _services.GuestService.UpdateGuestCreditCard(
                        _selectedGuestForUpdate.GuestId,
                        creditCardInput
                    );

                    if (!creditCardUpdateSuccess)
                    {
                        MessageBox.Show("Failed to update credit card information.",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (contactUpdateSuccess)
                {
                    MessageBox.Show("Guest information updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide the panel and clear selection
                    HideUpdatePanel();

                    // Reload guests to show updated information
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

        private void HideUpdatePanel()
        {
            // Clear all textboxes
            NameTxtBox.Clear();
            SurnameTxtbox.Clear();
            PhoneTxtbox.Clear();
            EmailTxtbox.Clear();
            AdressTxtBox.Clear();
            CreditcardNumTxtbox.Clear();

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

        private void GuestDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Highlight the selected row for better user experience
            if (e.RowIndex >= 0)
            {
                GuestDataView.Rows[e.RowIndex].Selected = true;
            }
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
    }
}