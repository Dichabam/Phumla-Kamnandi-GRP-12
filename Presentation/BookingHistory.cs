/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
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
                richTxtBox.Text = "No booking history available.";
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

           
            

            if (lastBooking != null)
            {
                DetailsLabel.Text = "";
                DetailsLabel.Font = new Font("Nirmala UI", 9F, FontStyle.Regular);
                DetailsLabel.ForeColor = Color.White;
            }

            

           
            DisplayBookingsInRichTextBox(sortedBookings, currentBookings, pastBookings);
        }

        private void DisplayBookingsInRichTextBox(List<Booking> allBookings, List<Booking> currentBookings, List<Booking> pastBookings)
        {
            richTxtBox.Clear();
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

            richTxtBox.Text = sb.ToString();

          
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
            string text = richTxtBox.Text;

    
            int currentIndex = text.IndexOf("━━━ CURRENT BOOKINGS ━━━");
            if (currentIndex >= 0)
            {
                richTxtBox.Select(currentIndex, "━━━ CURRENT BOOKINGS ━━━".Length);
                richTxtBox.SelectionColor = Color.Green;
                richTxtBox.SelectionFont = new Font(richTxtBox.Font, FontStyle.Bold);
            }

            int pastIndex = text.IndexOf("━━━ PAST BOOKINGS ━━━");
            if (pastIndex >= 0)
            {
                richTxtBox.Select(pastIndex, "━━━ PAST BOOKINGS ━━━".Length);
                richTxtBox.SelectionColor = Color.Gray;
                richTxtBox.SelectionFont = new Font(richTxtBox.Font, FontStyle.Bold);
            }

            richTxtBox.Select(0, 0);
        }

        private void CloseButtonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}