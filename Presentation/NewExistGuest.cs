using System;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class NewExistGuest : Form
    {
        private FrmBookings _bookingsForm;

        public NewExistGuest(FrmBookings bookingsForm)
        {
            InitializeComponent();
            _bookingsForm = bookingsForm;

            // Wire up button events
            NewGuestBut.Click += NewGuestBut_Click;
            ExistingguestBut.Click += ExistingguestBut_Click;
        }

        private void NewGuestBut_Click(object sender, EventArgs e)
        {
            // Close this form and start new guest booking
            this.Close();
            _bookingsForm.StartNewGuestBooking();
        }

        private void ExistingguestBut_Click(object sender, EventArgs e)
        {
            // Close this form and open ID confirmation
            this.Close();
            MakeBookingConf idForm = new MakeBookingConf(_bookingsForm);
            idForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}