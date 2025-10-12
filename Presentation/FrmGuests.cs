/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */

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
        private bool _isCheckingGuestStanding = false;


        public FrmGuests()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            if (!this.Controls.Contains(AddGuestPanel))
            {
                this.Controls.Add(AddGuestPanel);
            }

           
            AddGuestPanel.Visible = false;
         
            InitializeForm();
            LoadAllGuests();
        }

        private void InitializeForm()   
        {
          
            //enterEmailTextbox.Visible = false;
            emailConfirmtextbox.Visible = false;
            ConfirmButtonVBH.Visible = false;

            AddGuestPanel.Visible = false;

        
            UpdatebuttonPanel.Visible = false;

            GuestDataView.ReadOnly = true;

         
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

          
            viewBookingHostoryButton.Click += ViewBookingHistoryButton_Click;
            GuestStandingButton.Click += GuestStandingButton_Click;
            AddGuestButton.Click += AddGuestButton_Click;
            UpdateGuestButton.Click += UpdateGuestButton_Click;
            ConfirmButtonVBH.Click += ConfirmButtonVBH_Click;
            SaveButton.Click += SaveButton_Click;
            terminateButton.Click += terminateButton_Click;
            GuestDataView.CellClick += GuestDataView_CellClick;
            
        }

        private void LoadAllGuests()
        {
            try
            {
                var guests = _services.GuestRepository.GetAll();
                GuestDataView.DataSource = guests;

             
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
            _isCheckingGuestStanding = false;
            //enterEmailTextbox.Text = "Enter Guest Email";
            //enterEmailTextbox.Visible = true;
            emailConfirmtextbox.Visible = true;
            ConfirmButtonVBH.Visible = true;
         
            emailConfirmtextbox.Clear();
            emailConfirmtextbox.Focus();
        }

        private void ConfirmButtonVBH_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(emailConfirmtextbox.Text.Trim()))
            {
                MessageBox.Show(
                    "Please enter an email address",
                    "Missing Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                
                var guest = _services.GuestService.GetGuestByEmail(emailConfirmtextbox.Text.Trim());

                if (guest == null)
                {
                    MessageBox.Show(
                        "Guest Not Found",
                        "Guest Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    emailConfirmtextbox.Focus();
                    return;
                }

               
             

                if (_isCheckingGuestStanding)
                {
                    ShowGuestStanding(guest);
                   
                }
                else
                {
                    ShowBookingHistory(guest);
                   
                }

               
                HideBookingHistoryControls();
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

               
                HideBookingHistoryControls();

                MessageBox.Show(message, "Guest Standing",
                    MessageBoxButtons.OK,
                    isInGoodStanding ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                LoadAllGuests();
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
                HideBookingHistoryControls();
                var bookings = _services.GuestService.GetGuestBookings(guest.GuestId);
                BookingHistory historyForm = new BookingHistory(guest, bookings);
                historyForm.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading booking history: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
           
            if (/*enterEmailTextbox.Visible ||*/ emailConfirmtextbox.Visible || ConfirmButtonVBH.Visible)
            {
                HideBookingHistoryControls();
            }

     
            if (UpdatebuttonPanel.Visible)
            {
                HideUpdatePanel();
            }

           
            IDNumTxtBox.Clear();
            Name.Clear();
            surname.Clear();
            cell.Clear();
            email.Clear();

           
            AddGuestPanel.Visible = true;
            AddGuestPanel.BringToFront();

       
            UpdateGuestButton.Enabled = false;
            viewBookingHostoryButton.Enabled = false;
            GuestStandingButton.Enabled = false;
            AddGuestButton.Enabled = false;
        }

        private void UpdateGuestButton_Click(object sender, EventArgs e)
        {
      
            if (/*enterEmailTextbox.Visible || */emailConfirmtextbox.Visible || ConfirmButtonVBH.Visible)
            {
                HideBookingHistoryControls();
            }

         
            if (GuestDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest from the list to update.",
                    "No Guest Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

          
            _selectedGuestForUpdate = GuestDataView.SelectedRows[0].DataBoundItem as Guest;

            if (_selectedGuestForUpdate == null)
            {
                MessageBox.Show("Error retrieving guest information.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        
            ShowUpdatePanel(_selectedGuestForUpdate);
        }

        private void ShowUpdatePanel(Guest guest)
        {
            NameTxtBox.Text = guest.FirstName;
            SurnameTxtbox.Text = guest.LastName;
            PhoneTxtbox.Text = guest.Phone;
            EmailTxtbox.Text = guest.Email;

        
            standingcomobox.SelectedItem = guest.IsInGoodStanding ? "Yes" : "No";

            UpdatebuttonPanel.Visible = true;
            UpdatebuttonPanel.BringToFront();

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
                string newFirstName = NameTxtBox.Text.Trim();
                string newLastName = SurnameTxtbox.Text.Trim();
                string newPhone = PhoneTxtbox.Text.Trim();
                string newEmail = EmailTxtbox.Text.Trim();

                bool hasChanges = false;

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

                if (!IsValidEmail(newEmail))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                bool? newStanding = null;
                if (standingcomobox.SelectedItem != null)
                {
                    newStanding = standingcomobox.SelectedItem.ToString() == "Yes";
                }

               
                if (newFirstName != _selectedGuestForUpdate.FirstName ||
                    newLastName != _selectedGuestForUpdate.LastName ||
                    newPhone != _selectedGuestForUpdate.Phone ||
                    newEmail != _selectedGuestForUpdate.Email ||
                    (newStanding.HasValue && newStanding.Value != _selectedGuestForUpdate.IsInGoodStanding))
                {
                    hasChanges = true;
                }

                if (!hasChanges)
                {
                    MessageBox.Show("No changes detected.", "No Changes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Update information for {_selectedGuestForUpdate.FullName}?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

               
                var guest = _services.GuestRepository.GetById(_selectedGuestForUpdate.GuestId);
                if (guest == null)
                {
                    MessageBox.Show("Error retrieving guest information.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                guest.UpdateName(newFirstName, newLastName);
                guest.UpdateContactInfo(newEmail, newPhone, guest.Address);

                if (newStanding.HasValue)
                {
                    guest.IsInGoodStanding = newStanding.Value;
                }

                // Save to database
                _services.GuestRepository.Update(guest);

                MessageBox.Show("Guest information updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HideUpdatePanel();
                LoadAllGuests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating guest: {ex.Message}\n\n{ex.StackTrace}",
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
           
            NameTxtBox.Clear();
            SurnameTxtbox.Clear();
            PhoneTxtbox.Clear();
            EmailTxtbox.Clear();
            

      
            UpdatebuttonPanel.Visible = false;

       
            AddGuestButton.Enabled = true;
            viewBookingHostoryButton.Enabled = true;
            GuestStandingButton.Enabled = true;
            UpdateGuestButton.Enabled = true;

         
            _selectedGuestForUpdate = null;
        }

        private void HideBookingHistoryControls()
        {
            //enterEmailTextbox.Visible = false;
            emailConfirmtextbox.Visible = false;
            
         
            emailConfirmtextbox.Clear();
            ConfirmButtonVBH.Visible = false;
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
            try 
            { 
            
                if (string.IsNullOrWhiteSpace(IDNumTxtBox.Text))
                {
                    MessageBox.Show("ID Number is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IDNumTxtBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(Name.Text))
                {
                    MessageBox.Show("First Name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Name.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(surname.Text))
                {
                    MessageBox.Show("Last Name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    surname.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cell.Text))
                {
                    MessageBox.Show("Phone number is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cell.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(email.Text))
                {
                    MessageBox.Show("Email is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    email.Focus();
                    return;
                }

            
                if (!IsValidEmail(email.Text.Trim()))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    email.Focus();
                    return;
                }

      
                var existingGuest = _services.GuestService.GetGuestByEmail(email.Text.Trim());
                if (existingGuest != null)
                {
                    MessageBox.Show("A guest with this email already exists.", "Duplicate Guest",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    email.Focus();
                    return;
                }

      
                DialogResult result = MessageBox.Show(
                    $"Create new guest:\n\n" +
                    $"Name: {Name.Text.Trim()} {surname.Text.Trim()}\n" +
                    $"ID: {IDNumTxtBox.Text.Trim()}\n" +
                    $"Email: {email.Text.Trim()}\n" +
                    $"Phone: {cell.Text.Trim()}\n\n" +
                    $"Continue?",
                    "Confirm Guest Creation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

     
                var newGuest = _services.GuestService.RegisterNewGuest(
                    Name.Text.Trim(),
                    surname.Text.Trim(),
                    email.Text.Trim(),
                    cell.Text.Trim(),
                    AddressTxtbox.Text.Trim(),
                    IDNumTxtBox.Text.Trim() 
                );

                if (newGuest != null)
                {
                    MessageBox.Show(
                        $"Guest created successfully!\n\n" +
                        $"Guest ID: {newGuest.GuestId}\n" +
                        $"Name: {newGuest.FullName}\n" +
                        $"Email: {newGuest.Email}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

            
                    HideAddGuestPanel();
                    LoadAllGuests();
                }
                else
                {
                    MessageBox.Show("Failed to create guest.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating guest: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IDNumTxtBox_TextChanged(object sender, EventArgs e) { }
        
        private void terminateButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Cancel adding guest? All unsaved changes will be lost.",
        "Confirm Cancel",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HideAddGuestPanel();
            }
        }

        private void HideAddGuestPanel()
        {
           
            IDNumTxtBox.Clear();
            Name.Clear();
            surname.Clear();
            cell.Clear();
            email.Clear();

      
            AddGuestPanel.Visible = false;

          
            UpdateGuestButton.Enabled = true;
            viewBookingHostoryButton.Enabled = true;
            GuestStandingButton.Enabled = true;
            AddGuestButton.Enabled = true;
        }

        public void SearchGuests(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadAllGuests();
                return;
            }

            try
            {
                var allGuests = _services.GuestRepository.GetAll();
                var filteredGuests = allGuests.Where(g =>
                    (g.FirstName?.ToLower().Contains(searchText.ToLower()) ?? false) ||
                    (g.LastName?.ToLower().Contains(searchText.ToLower()) ?? false) ||
                    (g.Email?.ToLower().Contains(searchText.ToLower()) ?? false) ||
                    (g.Phone?.Contains(searchText) ?? false) ||
                    (g.GuestId?.ToLower().Contains(searchText.ToLower()) ?? false)
                ).ToList();

                GuestDataView.DataSource = filteredGuests;

              
                foreach (DataGridViewRow row in GuestDataView.Rows)
                {
                    if (row.DataBoundItem is Guest guest)
                    {
                        bool matchFound = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText.ToLower()))
                            {
                                matchFound = true;
                                break;
                            }
                        }

                        if (matchFound)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                        else if (!guest.IsInGoodStanding)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddGuestPanel_Paint(object sender, PaintEventArgs e) { }

        private void GuestStandingButton_Click(object sender, EventArgs e) {
            _isCheckingGuestStanding = true;

            //enterEmailTextbox.Text = "Enter Guest Email";
            //enterEmailTextbox.Visible = true;
            emailConfirmtextbox.Visible = true;
            ConfirmButtonVBH.Visible = true;
          
            emailConfirmtextbox.Clear();
            emailConfirmtextbox.Focus();
        }
    }
}