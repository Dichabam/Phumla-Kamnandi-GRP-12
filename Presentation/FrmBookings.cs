using Phumla_Kamnandi_GRP_12.Properties;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmBookings : Form
    {
        private readonly string connectionString = Settings.Default.PhumlaKamnandiDBConnectionString;
        private ServiceLocator _services;
        private bool isInMakeBookingMode = false;
        private bool isInUpdateMode = false;
        private string selectedBookingRef = null;

        public FrmBookings()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;

            HideAllInputFields();

          
            LoadBookingsGrid();
        }

        private void FrmBookings_Load(object sender, EventArgs e)
        {
            // Set minimum dates for date pickers - need to change 
            checkindp.MinDate = DateTime.Today;
            checkoutdp.MinDate = DateTime.Today.AddDays(1);
        }

        private void LoadBookingsGrid()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT 
                        b.BookingReference,
                        b.GuestId,
                        g.FirstName + ' ' + g.LastName AS GuestName,
                        g.Email AS GuestEmail,
                        b.CheckInDate,
                        b.CheckOutDate,
                        b.RoomNumber,
                        b.NumberOfAdults,
                        b.NumberOfChildren,
                        b.TotalAmount,
                        b.DepositAmount,
                        b.DepositPaid,
                        CASE b.Status 
                            WHEN 0 THEN 'Unconfirmed'
                            WHEN 1 THEN 'Confirmed'
                            WHEN 2 THEN 'Cancelled'
                            WHEN 3 THEN 'Completed'
                            WHEN 4 THEN 'NoShow'
                        END AS Status,
                        CASE b.PaymentStatus
                            WHEN 0 THEN 'Pending'
                            WHEN 1 THEN 'Paid'
                            WHEN 2 THEN 'Refunded'
                            WHEN 3 THEN 'Failed'
                        END AS PaymentStatus,
                        b.BookingDate,
                        b.IsSingleOccupancy,
                        b.SpecialRequests
                    FROM Booking b
                    INNER JOIN Guest g ON b.GuestId = g.Id
                    ORDER BY b.BookingDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    ShowdataGridView.ScrollBars = ScrollBars.Both;
                    

                    ShowdataGridView.DataSource = null;
                    ShowdataGridView.DataSource = dt;
                    ShowdataGridView.Refresh();
                    
                    
                    if (ShowdataGridView.Columns.Contains("GuestId"))
                        ShowdataGridView.Columns["GuestId"].Visible = false;

                   
                    if (ShowdataGridView.Columns.Contains("TotalAmount"))
                        ShowdataGridView.Columns["TotalAmount"].DefaultCellStyle.Format = "C2";
                    if (ShowdataGridView.Columns.Contains("DepositAmount"))
                        ShowdataGridView.Columns["DepositAmount"].DefaultCellStyle.Format = "C2";
                    if (ShowdataGridView.Columns.Contains("DepositPaid"))
                        ShowdataGridView.Columns["DepositPaid"].DefaultCellStyle.Format = "C2";
                    if (ShowdataGridView.Columns.Contains("CheckInDate"))
                        ShowdataGridView.Columns["CheckInDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                    if (ShowdataGridView.Columns.Contains("CheckOutDate"))
                        ShowdataGridView.Columns["CheckOutDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                    if (ShowdataGridView.Columns.Contains("BookingDate"))
                        ShowdataGridView.Columns["BookingDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

                    ShowdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}\n\nDetails: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region showing and hiding of fields
        private void HideAllInputFields()
        {
            NameLabel.Visible = false;
            NameTextBox.Visible = false;
            SurnameLabel.Visible = false;
            surnametextbox.Visible = false;
            EmailLabel.Visible = false;
            emailtextbox.Visible = false;
            PhoneNumberLabel.Visible = false;
            phonetextbox.Visible = false;
            AddressLabel.Visible = false;
            addresstextbox.Visible = false;
            CheckInLabel.Visible = false;
            checkindp.Visible = false;
            checkoutlabel.Visible = false;
            checkoutdp.Visible = false;
            NoOfAdultsLabel.Visible = false;
            adultstextbox.Visible = false;
            Childrenlabel.Visible = false;
            childrentextbox.Visible = false;
            Occupancylabel.Visible = false;
            YesNoComboBox.Visible = false;
            SpecialRequestlabel.Visible = false;
            specialrequestTextbox.Visible = false;
            CreditCardlabel.Visible = false;
            creditTextbox.Visible = false;
            SubmitButton.Visible = false;
            guna2TextBox1.Visible = false;
            IdNumLabel.Visible = false;
        }

        private void ShowAllInputFields()
        {
            NameLabel.Visible = true;
            NameTextBox.Visible = true;
            SurnameLabel.Visible = true;
            surnametextbox.Visible = true;
            EmailLabel.Visible = true;
            emailtextbox.Visible = true;
            PhoneNumberLabel.Visible = true;
            phonetextbox.Visible = true;
            AddressLabel.Visible = true;
            addresstextbox.Visible = true;
            CheckInLabel.Visible = true;
            checkindp.Visible = true;
            checkoutlabel.Visible = true;
            checkoutdp.Visible = true;
            NoOfAdultsLabel.Visible = true;
            adultstextbox.Visible = true;
            Childrenlabel.Visible = true;
            childrentextbox.Visible = true;
            Occupancylabel.Visible = true;
            YesNoComboBox.Visible = true;
            SpecialRequestlabel.Visible = true;
            specialrequestTextbox.Visible = true;
            CreditCardlabel.Visible = true;
            creditTextbox.Visible = true;
            SubmitButton.Visible = true;
            guna2TextBox1.Visible = true;
            IdNumLabel.Visible = true;
        }
        #endregion

        private void ClearAllFields()
        {
            NameTextBox.Clear();
            surnametextbox.Clear();
            emailtextbox.Clear();
            phonetextbox.Clear();
            addresstextbox.Clear();
            checkindp.Value = DateTime.Today;
            checkoutdp.Value = DateTime.Today.AddDays(1);
            adultstextbox.Clear();
            childrentextbox.Clear();
            YesNoComboBox.SelectedIndex = -1;
            specialrequestTextbox.Clear();
            creditTextbox.Clear();
            selectedBookingRef = null;

            NameTextBox.ReadOnly = false;
            surnametextbox.ReadOnly = false;
            emailtextbox.ReadOnly = false;
            phonetextbox.ReadOnly = false;
            addresstextbox.ReadOnly = false;
        }

        private void MakeBookingButton_Click_1(object sender, EventArgs e)
        {
            
            using (NewExistGuest choiceForm = new NewExistGuest(this))
            {
                choiceForm.ShowDialog();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (isInMakeBookingMode)
            {
                HandleMakeBooking();
            }
            else if (isInUpdateMode)
            {
                HandleUpdateBooking();
            }
        }

        private void HandleMakeBooking()
        {
            try
            {
                if (!ValidateInputs()) return;

                bool isExistingGuest = NameTextBox.ReadOnly;
                Guest guest;

                if (isExistingGuest)
                {
                    guest = _services.GuestService.GetGuestByEmail(emailtextbox.Text.Trim());
                    if (guest == null)
                    {
                        MessageBox.Show("Error: Could not find guest information.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {

                    guest = _services.GuestService.GetGuestByEmail(emailtextbox.Text.Trim());

                    if (guest == null)
                    {
                        guest = _services.GuestService.RegisterNewGuest(
                            NameTextBox.Text.Trim(),
                            surnametextbox.Text.Trim(),
                            emailtextbox.Text.Trim(),
                            phonetextbox.Text.Trim(),
                            addresstextbox.Text.Trim()
                        );
                    }
                }

                if (!string.IsNullOrEmpty(creditTextbox.Text.Trim()) && creditTextbox.Text.Trim().Length >= 4)
                {
                    string lastFour = creditTextbox.Text.Trim();
                    if (lastFour.Length > 4)
                        lastFour = lastFour.Substring(lastFour.Length - 4);

                    _services.GuestService.UpdateGuestCreditCard(guest.GuestId, lastFour);
                }

                int adults = int.Parse(adultstextbox.Text.Trim());
                int children = string.IsNullOrEmpty(childrentextbox.Text) ? 0 : int.Parse(childrentextbox.Text.Trim());
                bool singleOccupancy = YesNoComboBox.SelectedItem?.ToString() == "Yes";

                var result = _services.BookingService.MakeBooking(
                    guest.GuestId,
                    checkindp.Value.Date,
                    checkoutdp.Value.Date,
                    adults,
                    children,
                    singleOccupancy,
                    specialrequestTextbox.Text.Trim()
                );

                if (result.Success)
                {
                    if (!string.IsNullOrEmpty(creditTextbox.Text.Trim()) && creditTextbox.Text.Trim().Length >= 4)
                    {
                        bool confirmed = _services.BookingService.ConfirmBookingWithDeposit(
                            result.BookingReference,
                            result.DepositRequired,
                            creditTextbox.Text.Trim()
                        );

                        if (confirmed)
                        {
                            var booking = _services.BookingService.GetBookingDetails(result.BookingReference);
                            if (booking != null)
                            {
                                string lastFour = creditTextbox.Text.Trim();
                                if (lastFour.Length > 4)
                                    lastFour = lastFour.Substring(lastFour.Length - 4);

                                booking.SetCreditCardInfo(lastFour);
                                _services.BookingRepository.Update(booking);
                            }
                        }
                    }

                    string confirmationLetter = _services.BookingService.GenerateConfirmationLetter(result.BookingReference);

                    MessageBox.Show(confirmationLetter, "Booking Confirmed!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBookingsGrid();
                    HideAllInputFields();
                    ClearAllFields();
                    isInMakeBookingMode = false;
                }
                else
                {
                    MessageBox.Show(result.Message, "Booking Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating booking: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Please enter guest first name", "Validation Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(surnametextbox.Text))
            {
                MessageBox.Show("Please enter guest surname", "Validation Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(emailtextbox.Text))
            {
                MessageBox.Show("Please enter email", "Validation Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(phonetextbox.Text))
            {
                MessageBox.Show("Please enter phone number", "Validation Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(addresstextbox.Text))
            {
                MessageBox.Show("Please enter address", "Validation Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(adultstextbox.Text) || !int.TryParse(adultstextbox.Text, out int adults) || adults < 1)
            {
                MessageBox.Show("Please enter valid number of adults (minimum 1)", "Validation Error");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(childrentextbox.Text) && !int.TryParse(childrentextbox.Text, out _))
            {
                MessageBox.Show("Please enter valid number of children", "Validation Error");
                return false;
            }
            if (checkindp.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be in the past", "Validation Error");
                return false;
            }
            if (checkoutdp.Value.Date <= checkindp.Value.Date)
            {
                MessageBox.Show("Check-out date must be after check-in date", "Validation Error");
                return false;
            }
            if (YesNoComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select single occupancy option", "Validation Error");
                return false;
            }

            return true;
        }

        private void HandleUpdateBooking()
        {
            try
            {
                if (string.IsNullOrEmpty(selectedBookingRef))
                {
                    MessageBox.Show("No booking selected for update", "Error");
                    return;
                }

                if (!ValidateInputs()) return;

                var booking = _services.BookingService.GetBookingDetails(selectedBookingRef);
                if (booking == null)
                {
                    MessageBox.Show("Booking not found", "Error");
                    return;
                }

                bool success = _services.BookingService.ChangeBooking(
                    selectedBookingRef,
                    checkindp.Value.Date,
                    checkoutdp.Value.Date
                );

                if (success)
                {
                    MessageBox.Show("Booking updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBookingsGrid();
                    HideAllInputFields();
                    ClearAllFields();
                    isInUpdateMode = false;

                    UpdatebookingButton.Text = "UPDATE BOOKING";
                    UpdatebookingButton.FillColor = Color.FromArgb(0, 126, 249);
                    CancelBookingButton.Text = "CANCEL";
                    CancelBookingButton.FillColor = Color.FromArgb(0, 126, 249);
                }
                else
                {
                    MessageBox.Show("Failed to update booking. Room may not be available for new dates.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating booking: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatebookingButton_Click_1(object sender, EventArgs e)
        {
            if (ShowdataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to update", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow row = ShowdataGridView.SelectedRows[0];
                selectedBookingRef = row.Cells["BookingReference"].Value.ToString();

                var booking = _services.BookingService.GetBookingDetails(selectedBookingRef);
                if (booking == null)
                {
                    MessageBox.Show("Could not load booking details", "Error");
                    return;
                }

                var guest = _services.GuestService.GetGuestById(booking.GuestId);
                if (guest == null)
                {
                    MessageBox.Show("Could not load guest details", "Error");
                    return;
                }

                NameTextBox.Text = guest.FirstName;
                surnametextbox.Text = guest.LastName;
                emailtextbox.Text = guest.Email;
                phonetextbox.Text = guest.Phone;
                addresstextbox.Text = guest.Address;
                checkindp.Value = booking.CheckInDate;
                checkoutdp.Value = booking.CheckOutDate;
                adultstextbox.Text = booking.NumberOfAdults.ToString();
                childrentextbox.Text = booking.NumberOfChildren.ToString();
                YesNoComboBox.SelectedItem = booking.IsSingleOccupancy ? "Yes" : "No";
                specialrequestTextbox.Text = booking.SpecialRequests ?? "";
                creditTextbox.Text = guest.CreditCardLastFourDigits ?? "";

                ShowAllInputFields();
                isInUpdateMode = true;
                isInMakeBookingMode = false;

                SubmitButton.Text = "Save Changes";
                SubmitButton.FillColor = Color.Green;
                UpdatebookingButton.Text = "SAVE";
                UpdatebookingButton.FillColor = Color.Green;
                CancelBookingButton.Text = "CANCEL EDIT";
                CancelBookingButton.FillColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading booking for update: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBookingButton_Click_1(object sender, EventArgs e)
        {
            if (isInUpdateMode || isInMakeBookingMode)
            {
                HideAllInputFields();
                ClearAllFields();
                isInUpdateMode = false;
                isInMakeBookingMode = false;

                UpdatebookingButton.Text = "UPDATE BOOKING";
                UpdatebookingButton.FillColor = Color.FromArgb(0, 126, 249);
                CancelBookingButton.Text = "CANCEL";
                CancelBookingButton.FillColor = Color.FromArgb(0, 126, 249);
                return;
            }

            if (ShowdataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bookingRef = ShowdataGridView.SelectedRows[0].Cells["BookingReference"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to cancel booking {bookingRef}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _services.BookingService.CancelBooking(bookingRef);

                if (success)
                {
                    MessageBox.Show("Booking cancelled successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookingsGrid();
                }
                else
                {
                    MessageBox.Show("Failed to cancel booking", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkindp_ValueChanged(object sender, EventArgs e)
        {
            if (checkoutdp.Value.Date <= checkindp.Value.Date)
            {
                checkoutdp.Value = checkindp.Value.AddDays(1);
            }
            checkoutdp.MinDate = checkindp.Value.AddDays(1);
        }

        private void checkoutdp_ValueChanged(object sender, EventArgs e) { }

        public void SearchBookings(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadBookingsGrid();
                return;
            }

            try
            {
                DataTable dt = (DataTable)ShowdataGridView.DataSource;
                if (dt != null)
                {
                    string filter = $"BookingReference LIKE '%{searchText}%'";

                    if (dt.Columns.Contains("GuestName"))
                        filter += $" OR GuestName LIKE '%{searchText}%'";
                    if (dt.Columns.Contains("GuestEmail"))
                        filter += $" OR GuestEmail LIKE '%{searchText}%'";
                    if (dt.Columns.Contains("Status"))
                        filter += $" OR Status LIKE '%{searchText}%'";
                    if (dt.Columns.Contains("RoomNumber"))
                        filter += $" OR CONVERT(RoomNumber, 'System.String') LIKE '%{searchText}%'";

                    dt.DefaultView.RowFilter = filter;

                    foreach (DataGridViewRow row in ShowdataGridView.Rows)
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
                        row.DefaultCellStyle.BackColor = matchFound ? Color.LightYellow : Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region irrelevant things
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void NameTextBox_TextChanged(object sender, EventArgs e) { }
        private void surnametextBox_TextChanged(object sender, EventArgs e) { }
        private void emailtextbox_TextChanged(object sender, EventArgs e) { }
        private void phoneNumberTextbox_TextChanged(object sender, EventArgs e) { }
        private void addresstextbox_TextChanged(object sender, EventArgs e) { }
        private void adultstextbox_TextChanged(object sender, EventArgs e) { }
        private void childrentextbox_TextChanged(object sender, EventArgs e) { }
        private void specialrequestTextbox_TextChanged(object sender, EventArgs e) { }
        private void creditTextbox_TextChanged(object sender, EventArgs e) { }
        private void YesNoComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        #endregion

        public void StartNewGuestBooking()
        {
            isInMakeBookingMode = true;
            isInUpdateMode = false;
            ClearAllFields();
            ShowAllInputFields();
            SubmitButton.Text = "Submit Booking";
            SubmitButton.FillColor = Color.Lime;
        }

        public void StartExistingGuestBooking(Guest guest)
        {
            isInMakeBookingMode = true;
            isInUpdateMode = false;

            // Pre-fill guest details
            NameTextBox.Text = guest.FirstName;
            surnametextbox.Text = guest.LastName;
            emailtextbox.Text = guest.Email;
            phonetextbox.Text = guest.Phone;
            addresstextbox.Text = guest.Address;

            // Disable guest info fields
            NameTextBox.ReadOnly = true;
            surnametextbox.ReadOnly = true;
            emailtextbox.ReadOnly = true;
            phonetextbox.ReadOnly = true;
            addresstextbox.ReadOnly = true;

            ShowAllInputFields();
            SubmitButton.Text = "Submit Booking";
            SubmitButton.FillColor = Color.Lime;

            // Focus on booking-specific fields
            checkindp.Focus();
        }


    }
}