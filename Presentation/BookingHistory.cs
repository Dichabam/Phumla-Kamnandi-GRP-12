using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class BookingHistory : Form
    {
        private Guest _guest;
        private List<Booking> _bookings;
        private RichTextBox _bookingsRichTextBox;

        public BookingHistory()
        {
            InitializeComponent();
        }

        public BookingHistory(Guest guest, List<Booking> bookings)
        {
            InitializeComponent();
            _guest = guest;
            _bookings = bookings;
            InitializeCustomComponents();
            LoadGuestInfo();
            LoadBookingHistory();
        }

        private void InitializeCustomComponents()
        {
            // Create and configure RichTextBox
            _bookingsRichTextBox = new RichTextBox
            {
                Location = new Point(104, 332),
                Size = new Size(754, 305),
                ReadOnly = true,
                BackColor = Color.White,
                Font = new Font("Consolas", 9F, FontStyle.Regular),
                ScrollBars = RichTextBoxScrollBars.Vertical
            };

            this.Controls.Add(_bookingsRichTextBox);
        }

        private void LoadGuestInfo()
        {
            Namelabel.Text = $"Name: {_guest.FirstName}";
            SurnameLabel.Text = $"Surname: {_guest.LastName}";
            EmailLabel.Text = $"Email: {_guest.Email}";
            PhoneLabel.Text = $"Phone: {_guest.Phone}";

            Font labelFont = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            Namelabel.Font = labelFont;
            SurnameLabel.Font = labelFont;
            EmailLabel.Font = labelFont;
            PhoneLabel.Font = labelFont;

            Namelabel.ForeColor = Color.White;
            SurnameLabel.ForeColor = Color.White;
            EmailLabel.ForeColor = Color.White;
            PhoneLabel.ForeColor = Color.White;
        }

        private void LoadBookingHistory()
        {
            if (_bookings == null || _bookings.Count == 0)
            {
                DetailsLabel.Text = "No bookings found for this guest";
                DetailsLabel.Font = new Font("Nirmala UI", 12, FontStyle.Bold);
                DetailsLabel.ForeColor = Color.Orange;
                _bookingsRichTextBox.Text = "No booking history available.";
                return;
            }

            var sortedBookings = _bookings.OrderByDescending(b => b.CheckInDate).ToList();
            var currentBookings = sortedBookings
                .Where(b => b.CheckOutDate >= DateTime.Today && b.Status != BookingStatus.Cancelled)
                .ToList();
            var pastBookings = sortedBookings
                .Where(b => b.CheckOutDate < DateTime.Today || b.Status == BookingStatus.Cancelled)
                .ToList();

            var lastBooking = sortedBookings.FirstOrDefault();

            // Build details text
            StringBuilder details = new StringBuilder();
            details.AppendLine($"Total Bookings: {_bookings.Count}");
            details.AppendLine($"Current: {currentBookings.Count} | Past: {pastBookings.Count}");

            if (lastBooking != null)
            {
                details.AppendLine();
                details.AppendLine("Last Booking:");
                details.AppendLine($"  Reference: {lastBooking.BookingReference}");
                details.AppendLine($"  Check-in: {lastBooking.CheckInDate:yyyy-MM-dd}");
                details.AppendLine($"  Check-out: {lastBooking.CheckOutDate:yyyy-MM-dd}");
                details.AppendLine($"  Status: {lastBooking.Status}");

                string paymentStatus = lastBooking.PaymentStatus == PaymentStatus.Paid
                    ? "✓ Fully Paid"
                    : $"Deposit: {lastBooking.DepositPaid:C} / {lastBooking.DepositAmount:C}";
                details.AppendLine($"  Payment: {paymentStatus}");
            }

            DetailsLabel.Text = details.ToString();
            DetailsLabel.Font = new Font("Nirmala UI", 9F, FontStyle.Regular);
            DetailsLabel.ForeColor = Color.White;

            // Display all bookings in RichTextBox
            DisplayBookingsInRichTextBox(sortedBookings, currentBookings, pastBookings);
        }

        private void DisplayBookingsInRichTextBox(List<Booking> allBookings, List<Booking> currentBookings, List<Booking> pastBookings)
        {
            _bookingsRichTextBox.Clear();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("═══════════════════════════════════════════════════════════════════════════");
            sb.AppendLine("                           BOOKING HISTORY                                 ");
            sb.AppendLine("═══════════════════════════════════════════════════════════════════════════");
            sb.AppendLine();

            if (currentBookings.Any())
            {
                sb.AppendLine("━━━ CURRENT BOOKINGS ━━━");
                sb.AppendLine();
                foreach (var booking in currentBookings)
                {
                    AppendBookingDetails(sb, booking, "CURRENT");
                }
            }

            if (pastBookings.Any())
            {
                sb.AppendLine("━━━ PAST BOOKINGS ━━━");
                sb.AppendLine();
                foreach (var booking in pastBookings)
                {
                    AppendBookingDetails(sb, booking, "PAST");
                }
            }

            _bookingsRichTextBox.Text = sb.ToString();

            // Color code sections
            ColorCodeBookings(currentBookings, pastBookings);
        }

        private void AppendBookingDetails(StringBuilder sb, Booking booking, string bookingType)
        {
            sb.AppendLine($"Reference: {booking.BookingReference}");
            sb.AppendLine($"Check-in:  {booking.CheckInDate:yyyy-MM-dd}");
            sb.AppendLine($"Check-out: {booking.CheckOutDate:yyyy-MM-dd}");
            sb.AppendLine($"Room:      {booking.RoomNumber}");
            sb.AppendLine($"Guests:    {booking.NumberOfAdults} Adults, {booking.NumberOfChildren} Children");
            sb.AppendLine($"Total:     {booking.TotalAmount:C}");
            sb.AppendLine($"Deposit:   {booking.DepositPaid:C} / {booking.DepositAmount:C}");
            sb.AppendLine($"Status:    {booking.Status}");
            sb.AppendLine($"Payment:   {booking.PaymentStatus}");

            if (!string.IsNullOrEmpty(booking.SpecialRequests))
            {
                sb.AppendLine($"Notes:     {booking.SpecialRequests}");
            }

            sb.AppendLine("─────────────────────────────────────────────────────────────────────────");
            sb.AppendLine();
        }

        private void ColorCodeBookings(List<Booking> currentBookings, List<Booking> pastBookings)
        {
            string text = _bookingsRichTextBox.Text;

            // Find and color current bookings section
            int currentIndex = text.IndexOf("━━━ CURRENT BOOKINGS ━━━");
            if (currentIndex >= 0)
            {
                _bookingsRichTextBox.Select(currentIndex, "━━━ CURRENT BOOKINGS ━━━".Length);
                _bookingsRichTextBox.SelectionColor = Color.Green;
                _bookingsRichTextBox.SelectionFont = new Font(_bookingsRichTextBox.Font, FontStyle.Bold);
            }

            // Find and color past bookings section
            int pastIndex = text.IndexOf("━━━ PAST BOOKINGS ━━━");
            if (pastIndex >= 0)
            {
                _bookingsRichTextBox.Select(pastIndex, "━━━ PAST BOOKINGS ━━━".Length);
                _bookingsRichTextBox.SelectionColor = Color.Gray;
                _bookingsRichTextBox.SelectionFont = new Font(_bookingsRichTextBox.Font, FontStyle.Bold);
            }

            // Reset selection
            _bookingsRichTextBox.Select(0, 0);
        }

        private void CloseButtonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}