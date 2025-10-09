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
        private DataGridView _bookingsGrid;

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
            
            _bookingsGrid = new DataGridView
            {
                Location = new Point(118, 310),
                Size = new Size(740, 320),
                BackgroundColor = Color.FromArgb(46, 51, 73),
                BorderStyle = BorderStyle.None,
                AutoGenerateColumns = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                EnableHeadersVisualStyles = false
            };

            _bookingsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            _bookingsGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            _bookingsGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            _bookingsGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 30, 54);

           
            _bookingsGrid.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            _bookingsGrid.DefaultCellStyle.ForeColor = Color.White;
            _bookingsGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 126, 249);
            _bookingsGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            _bookingsGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 45, 65);

           
            _bookingsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BookingReference",
                HeaderText = "Reference",
                DataPropertyName = "BookingReference",
                Width = 130
            });

            _bookingsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CheckInDate",
                HeaderText = "Check-In",
                DataPropertyName = "CheckInDate",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            _bookingsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CheckOutDate",
                HeaderText = "Check-Out",
                DataPropertyName = "CheckOutDate",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            _bookingsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RoomNumber",
                HeaderText = "Room",
                DataPropertyName = "RoomNumber",
                Width = 60
            });

            _bookingsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "Total",
                DataPropertyName = "TotalAmount",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            _bookingsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 100
            });

            _bookingsGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaymentStatus",
                HeaderText = "Payment",
                DataPropertyName = "PaymentStatus",
                Width = 100
            });

          
            this.Controls.Add(_bookingsGrid);
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
                return;
            }

            // Sort bookings
            var sortedBookings = _bookings.OrderByDescending(b => b.CheckInDate).ToList();

            // Separate current and past bookings
            var currentBookings = sortedBookings
                .Where(b => b.CheckOutDate >= DateTime.Today && b.Status != BookingStatus.Cancelled)
                .ToList();
            var pastBookings = sortedBookings
                .Where(b => b.CheckOutDate < DateTime.Today || b.Status == BookingStatus.Cancelled)
                .ToList();

            // Get the most recent booking
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

                // Payment status
                string paymentStatus = lastBooking.PaymentStatus == PaymentStatus.Paid
                    ? "✓ Fully Paid"
                    : $"Deposit: {lastBooking.DepositPaid:C} / {lastBooking.DepositAmount:C}";
                details.AppendLine($"  Payment: {paymentStatus}");
            }

            DetailsLabel.Text = details.ToString();
            DetailsLabel.Font = new Font("Nirmala UI", 9F, FontStyle.Regular);
            DetailsLabel.ForeColor = Color.White;

            // Display all bookings in grid
            _bookingsGrid.DataSource = sortedBookings;

            // Color code rows
            foreach (DataGridViewRow row in _bookingsGrid.Rows)
            {
                var booking = row.DataBoundItem as Booking;
                if (booking != null)
                {
                    if (booking.Status == BookingStatus.Cancelled)
                    {
                        row.DefaultCellStyle.ForeColor = Color.LightGray;
                        row.DefaultCellStyle.Font = new Font(_bookingsGrid.Font, FontStyle.Strikeout);
                    }
                    else if (booking.CheckInDate <= DateTime.Today && booking.CheckOutDate >= DateTime.Today)
                    {
                        // Current stay
                        row.DefaultCellStyle.BackColor = Color.FromArgb(0, 100, 0);
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (booking.CheckInDate > DateTime.Today)
                    {
                        // Future booking
                        row.DefaultCellStyle.BackColor = Color.FromArgb(0, 70, 140);
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Past booking
                        row.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                        row.DefaultCellStyle.ForeColor = Color.LightGray;
                    }

                    // Highlight unpaid bookings
                    if (booking.PaymentStatus != PaymentStatus.Paid)
                    {
                        row.Cells["PaymentStatus"].Style.BackColor = Color.Yellow;
                        row.Cells["PaymentStatus"].Style.ForeColor = Color.Red;
                    }
                }
            }
        }


    }
}