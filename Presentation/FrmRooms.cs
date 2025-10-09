using Guna.UI2.WinForms;
using Phumla_Kamnandi_GRP_12.Business.Entities;
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
            LoadAllRooms(); // Load all rooms by default
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
                Width = 150
            });

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaxOccupancy",
                HeaderText = "Max Occupancy",
                DataPropertyName = "MaxOccupancy",
                Width = 150
            });

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IsAvailable",
                HeaderText = "Available",
                DataPropertyName = "IsAvailable",
                Width = 150
            });

            roomsDateview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 150
            });
        }

        private void LoadAllRooms()
        {
            var rooms = _services.RoomRepository.GetAll();
            _allRoomsData = ConvertRoomsToDataTable(rooms);
            roomsDateview.DataSource = _allRoomsData;

            // Color code rows
            foreach (DataGridViewRow row in roomsDateview.Rows)
            {
                bool isAvailable = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                row.DefaultCellStyle.BackColor = isAvailable ?
                    System.Drawing.Color.LightGreen :
                    System.Drawing.Color.LightCoral;
            }
        }

        private DataTable ConvertRoomsToDataTable(System.Collections.Generic.List<Room> rooms)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomNumber", typeof(int));
            dt.Columns.Add("MaxOccupancy", typeof(int));
            dt.Columns.Add("IsAvailable", typeof(bool));
            dt.Columns.Add("Status", typeof(string));

            foreach (var room in rooms)
            {
                dt.Rows.Add(
                    room.RoomNumber,
                    room.MaxOccupancy,
                    room.IsAvailable,
                    room.IsAvailable ? "Available" : "Occupied"
                );
            }

            return dt;
        }

        private void showAvailableRoomsButton_Click(object sender, EventArgs e)
        {
            // Change Button to Guna2Button for all comparisons
            var clickedButton = sender as Guna2Button;

            if (clickedButton == showAvailableRoomsButton)
            {
                // Show only available rooms
                var availableRooms = _services.RoomRepository.GetAll()
                    .Where(r => r.IsAvailable).ToList();
                roomsDateview.DataSource = ConvertRoomsToDataTable(availableRooms);
            }
            else if (clickedButton == ShowUnavailableRoomsButton)
            {
                // Show only unavailable rooms
                var unavailableRooms = _services.RoomRepository.GetAll()
                    .Where(r => !r.IsAvailable).ToList();
                roomsDateview.DataSource = ConvertRoomsToDataTable(unavailableRooms);
            }
            else if (clickedButton == ShowAllRoomsButton)
            {
                // Show all rooms
                LoadAllRooms();
            }

            // Color code the filtered results
            foreach (DataGridViewRow row in roomsDateview.Rows)
            {
                bool isAvailable = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                row.DefaultCellStyle.BackColor = isAvailable ?
                    System.Drawing.Color.LightGreen :
                    System.Drawing.Color.LightCoral;
            }
        }

        // Method to be called from Dashboard for search functionality
        public void SearchRooms(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadAllRooms();
                return;
            }

            var filteredView = _allRoomsData.DefaultView;
            filteredView.RowFilter = string.Format(
                "Convert(RoomNumber, 'System.String') LIKE '%{0}%' OR Status LIKE '%{0}%'",
                searchText.Replace("'", "''"));

            // Highlight matching rows
            foreach (DataGridViewRow row in roomsDateview.Rows)
            {
                bool matches = row.Cells["RoomNumber"].Value.ToString().Contains(searchText) ||
                              row.Cells["Status"].Value.ToString().ToLower().Contains(searchText.ToLower());

                if (matches)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    bool isAvailable = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                    row.DefaultCellStyle.BackColor = isAvailable ?
                        System.Drawing.Color.LightGreen :
                        System.Drawing.Color.LightCoral;
                }
            }
        }
    }
}