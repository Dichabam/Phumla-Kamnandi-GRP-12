using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;

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

         
            var sortedBookings = _bookings.OrderByDescending(b => b.CheckInDate).ToList();

           
            var currentBookings = sortedBookings
                .Where(b => b.CheckOutDate >= DateTime.Today && b.Status != BookingStatus.Cancelled)
                .ToList();
            var pastBookings = sortedBookings
                .Where(b => b.CheckOutDate < DateTime.Today || b.Status == BookingStatus.Cancelled)
                .ToList();

          
            DetailsLabel.Text = $"Total Bookings: {_bookings.Count} " +
                              $"(Current: {currentBookings.Count}, Past: {pastBookings.Count})";
            DetailsLabel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            DetailsLabel.ForeColor = Color.FromArgb(0, 126, 249);

        
            _bookingsGrid.DataSource = sortedBookings;

            
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
                       
                        row.DefaultCellStyle.BackColor = Color.FromArgb(0, 100, 0);
                    }
                    else if (booking.CheckInDate > DateTime.Today)
                    {
                       
                        row.DefaultCellStyle.BackColor = Color.FromArgb(0, 70, 140);
                    }
                }
            }
        }
    }
}