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
            if (enterEmailTextbox.Visible || emailConfirmtextbox.Visible || ConfirmButtonVBH.Visible)
            {
                enterEmailTextbox.Visible = false;
                emailConfirmtextbox.Visible = false;
                ConfirmButtonVBH.Visible = false;
            }
            if (!_isUpdateMode)
            {
                // Enable update mode
                _isUpdateMode = true;
                GuestDataView.ReadOnly = false;

                // Make only certain columns editable
                GuestDataView.Columns["GuestId"].ReadOnly = true;
                GuestDataView.Columns["FirstName"].ReadOnly = true;
                GuestDataView.Columns["LastName"].ReadOnly = true;
                GuestDataView.Columns["Email"].ReadOnly = true;
                GuestDataView.Columns["Phone"].ReadOnly = true;
                GuestDataView.Columns["IsInGoodStanding"].ReadOnly = true;

                UpdateGuestButton.Text = "Save Changes";
                UpdateGuestButton.FillColor = Color.Green;

                MessageBox.Show("Update mode enabled. Edit guest details and click 'Save Changes' when done.",
                    "Update Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
            {
                // Save changes
                try
                {
                    foreach (DataGridViewRow row in GuestDataView.Rows)
                    {
                        if (row.DataBoundItem is Guest guest && !row.IsNewRow)
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

                    
                    _isUpdateMode = false;
                    GuestDataView.ReadOnly = true;
                    UpdateGuestButton.Text = "Update Guest";
                    UpdateGuestButton.FillColor = Color.FromArgb(0, 126, 249);

                   
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

        private void GuestDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void emailConfirmtextbox_TextChanged(object sender, EventArgs e)
        {
            
            ErrorLableVBH.Visible = false;
        }
    }
}