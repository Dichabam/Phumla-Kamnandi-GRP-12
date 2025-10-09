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

            // Make DataGridView read-only by default
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
            emailConfirmtextbox.TextChanged += (s, e) => ErrorLableVBH.Visible = false;
        }

        private void LoadAllGuests()
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

        private void ViewBookingHistoryButton_Click(object sender, EventArgs e)
        {
            // Show email verification controls
            enterEmailTextbox.Visible = true;
            emailConfirmtextbox.Visible = true;
            ConfirmButtonVBH.Visible = true;
            ErrorLableVBH.Visible = false;

            // Hide other verification controls if visible
            HideGuestStandingControls();
        }

        private void GuestStandingButton_Click(object sender, EventArgs e)
        {
            // Show email verification controls with different label
            enterEmailTextbox.Text = "Enter Guest Email to Check Standing";
            enterEmailTextbox.Visible = true;
            emailConfirmtextbox.Visible = true;
            ConfirmButtonVBH.Visible = true;
            ErrorLableVBH.Visible = false;

            // Hide other verification controls
            HideBookingHistoryControls();
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

        private void ShowGuestStanding(Guest guest)
        {
            // Check and update guest standing
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
        }

        private void ShowBookingHistory(Guest guest)
        {
            var bookings = _services.GuestService.GetGuestBookings(guest.GuestId);

            // Open BookingHistory form
            BookingHistory historyForm = new BookingHistory(guest, bookings);
            historyForm.ShowDialog();

            // Reset controls
            emailConfirmtextbox.Clear();
            HideBookingHistoryControls();
        }
        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            // Navigate to Bookings form within dashboard
            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                var bookingButton = dashboard.Controls.Find("BookingButton", true).FirstOrDefault() as Button;
                bookingButton?.PerformClick();

            }
        }

        private void UpdateGuestButton_Click(object sender, EventArgs e)
        {
            if (!_isUpdateMode)
            {
                // Enable update mode
                _isUpdateMode = true;
                GuestDataView.ReadOnly = false;

                // Make only certain columns editable
                GuestDataView.Columns["GuestId"].ReadOnly = true;
                GuestDataView.Columns["FirstName"].ReadOnly = false;
                GuestDataView.Columns["LastName"].ReadOnly = false;
                GuestDataView.Columns["Email"].ReadOnly = false;
                GuestDataView.Columns["Phone"].ReadOnly = false;
                GuestDataView.Columns["IsInGoodStanding"].ReadOnly = true;

                UpdateGuestButton.Text = "Save Changes";
                UpdateGuestButton.FillColor = Color.Green;

                MessageBox.Show("Update mode enabled. Edit guest details and click 'Save Changes' when done.",
                    "Update Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Save changes
                try
                {
                    foreach (DataGridViewRow row in GuestDataView.Rows)
                    {
                        if (row.DataBoundItem is Guest guest && row.IsNewRow == false)
                        {
                            // Update guest in database
                            _services.GuestService.UpdateGuestContactInfo(
                                guest.GuestId,
                                guest.Email,
                                guest.Phone,
                                guest.Address
                            );
                        }
                    }

                    MessageBox.Show("Guest information updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Exit update mode
                    _isUpdateMode = false;
                    GuestDataView.ReadOnly = true;
                    UpdateGuestButton.Text = "Update Guest";
                    UpdateGuestButton.FillColor = Color.FromArgb(0, 126, 249);

                    // Refresh data
                    LoadAllGuests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating guests: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HideBookingHistoryControls()
        {
            enterEmailTextbox.Visible = false;
            emailConfirmtextbox.Visible = false;
            ConfirmButtonVBH.Visible = false;
            ErrorLableVBH.Visible = false;
            emailConfirmtextbox.Clear();
        }

        private void HideGuestStandingControls()
        {
            // Same as HideBookingHistoryControls in this case
            HideBookingHistoryControls();
        }

        private void GuestDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void emailConfirmtextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}