/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */

using Guna.UI2.WinForms;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmRooms : Form
    {
        private ServiceLocator _services;
        private DataTable _allRoomsData;

        public FrmRooms()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            InitializeDataGridView();
            LoadAllRooms();
        }

        private void InitializeDataGridView()
        {
            roomsDateview.AutoGenerateColumns = false;
            roomsDateview.Columns.Clear();

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RoomNumber",
                HeaderText = "Room Number",
                DataPropertyName = "RoomNumber",
                Width = 120
            });

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaxOccupancy",
                HeaderText = "Max Occupancy",
                DataPropertyName = "MaxOccupancy",
                Width = 120
            });

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CurrentGuest",
                HeaderText = "Current Guest",
                DataPropertyName = "CurrentGuest",
                Width = 200
            });

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CheckInDate",
                HeaderText = "Check-In",
                DataPropertyName = "CheckInDate",
                Width = 100
            });

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CheckOutDate",
                HeaderText = "Check-Out",
                DataPropertyName = "CheckOutDate",
                Width = 100
            });

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 120
            });
        }

        private void LoadAllRooms()
        {
            try
            {
                var rooms = _services.RoomRepository.GetAll();
                var roomsWithBookingInfo = GetRoomsWithCurrentBookingInfo(rooms);
                _allRoomsData = ConvertRoomsToDataTable(roomsWithBookingInfo);
                roomsDateview.DataSource = _allRoomsData;

          
                ColorCodeRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rooms: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private System.Collections.Generic.List<RoomWithBookingInfo> GetRoomsWithCurrentBookingInfo( System.Collections.Generic.List<Room> rooms)
        {
            var roomsWithInfo = new System.Collections.Generic.List<RoomWithBookingInfo>();
            DateTime today = DateTime.Today;

            foreach (var room in rooms)
            {
                var roomInfo = new RoomWithBookingInfo
                {
                    RoomNumber = room.RoomNumber,
                    MaxOccupancy = room.MaxOccupancy,
                    IsAvailable = room.IsAvailable
                };

           
                var activeBookings = _services.BookingRepository.GetActiveBookingsForDate(today);
                var currentBooking = activeBookings.FirstOrDefault(b => b.RoomNumber == room.RoomNumber);

                if (currentBooking != null)
                {
                   
                    var guest = _services.GuestRepository.GetById(currentBooking.GuestId);
                    if (guest != null)
                    {
                        roomInfo.CurrentGuest = guest.FullName;
                        roomInfo.CheckInDate = currentBooking.CheckInDate.ToString("yyyy-MM-dd");
                        roomInfo.CheckOutDate = currentBooking.CheckOutDate.ToString("yyyy-MM-dd");
                        roomInfo.Status = "Occupied";
                        roomInfo.IsAvailable = false;
                    }
                }
                else
                {
                  
                    var upcomingBookings = _services.BookingRepository.GetByDateRange(
                        today.AddDays(1),
                        today.AddDays(30)
                    ).Where(b => b.RoomNumber == room.RoomNumber &&
                                b.Status != BookingStatus.Cancelled).ToList();

                    if (upcomingBookings.Any())
                    {
                        var nextBooking = upcomingBookings.OrderBy(b => b.CheckInDate).First();
                        roomInfo.CurrentGuest = "Reserved";
                        roomInfo.CheckInDate = nextBooking.CheckInDate.ToString("yyyy-MM-dd");
                        roomInfo.CheckOutDate = nextBooking.CheckOutDate.ToString("yyyy-MM-dd");
                        roomInfo.Status = "Reserved";
                        roomInfo.IsAvailable = true; 
                    }
                    else
                    {
                        roomInfo.CurrentGuest = "-";
                        roomInfo.CheckInDate = "-";
                        roomInfo.CheckOutDate = "-";
                        roomInfo.Status = "Available";
                        roomInfo.IsAvailable = true;
                    }
                }

                roomsWithInfo.Add(roomInfo);
            }

            return roomsWithInfo;
        }

        private DataTable ConvertRoomsToDataTable(System.Collections.Generic.List<RoomWithBookingInfo> rooms)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNumber", typeof(int));
            dt.Columns.Add("MaxOccupancy", typeof(int));
            dt.Columns.Add("CurrentGuest", typeof(string));
            dt.Columns.Add("CheckInDate", typeof(string));
            dt.Columns.Add("CheckOutDate", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("IsAvailable", typeof(bool));

            foreach (var room in rooms)
            {
                dt.Rows.Add(
                    room.RoomNumber,
                    room.MaxOccupancy,
                    room.CurrentGuest,
                    room.CheckInDate,
                    room.CheckOutDate,
                    room.Status,
                    room.IsAvailable
                );
            }

            return dt;
        }

        private void ColorCodeRows()
        {
            foreach (DataGridViewRow row in roomsDateview.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();

                    switch (status)
                    {
                        case "Available":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                            break;
                        case "Occupied":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                            break;
                        case "Reserved":
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                            break;
                    }
                }
            }
        }

        private void showAvailableRoomsButton_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Guna2Button;

            if (clickedButton == showAvailableRoomsButton)
            {
              
                var rooms = _services.RoomRepository.GetAll();
                var roomsWithInfo = GetRoomsWithCurrentBookingInfo(rooms);
                var availableRooms = roomsWithInfo.Where(r => r.Status == "Available").ToList();
                roomsDateview.DataSource = ConvertRoomsToDataTable(availableRooms);
            }
            else if (clickedButton == ShowUnavailableRoomsButton)
            {
             
                var rooms = _services.RoomRepository.GetAll();
                var roomsWithInfo = GetRoomsWithCurrentBookingInfo(rooms);
                var occupiedRooms = roomsWithInfo.Where(r => r.Status == "Occupied").ToList();
                roomsDateview.DataSource = ConvertRoomsToDataTable(occupiedRooms);
            }
            else if (clickedButton == ShowAllRoomsButton)
            {
       
                LoadAllRooms();
            }

            ColorCodeRows();
        }

        public void SearchRooms(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadAllRooms();
                return;
            }

            try
            {
                var filteredView = _allRoomsData.DefaultView;

              
                string filter = string.Format(
                    "Convert(RoomNumber, 'System.String') LIKE '%{0}%' OR " +
                    "Status LIKE '%{0}%' OR " +
                    "CurrentGuest LIKE '%{0}%'",
                    searchText.Replace("'", "''"));

                filteredView.RowFilter = filter;

          
                foreach (DataGridViewRow row in roomsDateview.Rows)
                {
                    bool matches = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null &&
                            cell.Value.ToString().ToLower().Contains(searchText.ToLower()))
                        {
                            matches = true;
                            break;
                        }
                    }

                    if (matches)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                  
                        string status = row.Cells["Status"].Value?.ToString();
                        switch (status)
                        {
                            case "Available":
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                                break;
                            case "Occupied":
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                                break;
                            case "Reserved":
                                row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                                break;
                        }
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refresh the room view - useful after a booking is made
        /// </summary>
        public void RefreshRooms()
        {
            LoadAllRooms();
        }

        private void FrmRooms_Load(object sender, EventArgs e)
        {
       
            LoadAllRooms();
        }

       
        private class RoomWithBookingInfo
        {
            public int RoomNumber { get; set; }
            public int MaxOccupancy { get; set; }
            public bool IsAvailable { get; set; }
            public string CurrentGuest { get; set; }
            public string CheckInDate { get; set; }
            public string CheckOutDate { get; set; }
            public string Status { get; set; }
        }
    }
}