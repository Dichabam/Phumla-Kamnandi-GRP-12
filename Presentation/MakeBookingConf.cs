using System;
using System.Windows.Forms;
using Phumla_Kamnandi_GRP_12.Business.Entities;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class MakeBookingConf : Form
    {
        private FrmBookings _bookingsForm;
        private ServiceLocator _services;

        public MakeBookingConf(FrmBookings bookingsForm)
        {
            InitializeComponent();
            _bookingsForm = bookingsForm;
            _services = ServiceLocator.Instance;

            // Hide error label by default
            IDNotFoundLabel.Visible = false;

            // Wire up events
            guna2Button1.Click += ConfirmButton_Click;
            IDNumberTextBox.TextChanged += IDNumberTextBox_TextChanged_Handler;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string idNumber = IDNumberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(idNumber))
            {
                IDNotFoundLabel.Text = "Please enter an ID number";
                IDNotFoundLabel.Visible = true;
                return;
            }

            try
            {
                // Search for guest by ID (stored in Address field)
                var allGuests = _services.GuestRepository.GetAll();
                Guest foundGuest = null;

                foreach (var guest in allGuests)
                {
                    if (guest.Address != null && guest.Address.Trim() == idNumber)
                    {
                        foundGuest = guest;
                        break;
                    }
                }

                if (foundGuest == null)
                {
                    IDNotFoundLabel.Text = "ID Number Not Found";
                    IDNotFoundLabel.Visible = true;
                    IDNumberTextBox.Focus();
                    return;
                }

                // Guest found - proceed with booking
                this.Close();
                _bookingsForm.StartExistingGuestBooking(foundGuest);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for guest: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IDNumberTextBox_TextChanged_Handler(object sender, EventArgs e)
        {
            IDNotFoundLabel.Visible = false;
        }

        private void IDLabel_Click(object sender, EventArgs e) { }
        private void guna2GradientPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ConfirmButton_Click(sender, e);
        }
        private void IDNumberTextBox_TextChanged(object sender, EventArgs e) { }
        private void IDNotFoundLabel_Click(object sender, EventArgs e) { }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}