using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_GRP_12.Business.Enums;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmHome : Form
    {
        private ServiceLocator _services;

        public FrmHome()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;

          
            LoadDashboardStatistics();
        }

        private void LoadDashboardStatistics()
        {
            try
            {
              
                LoadTotalBookings();

                LoadCurrentOccupancy();

             
                LoadRoomsAvailableToday();

              
                LoadArrivalsToday();

             
                LoadDeparturesToday();

             
                LoadDepositsOverdue();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard statistics: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalBookings()
        {
            try
            {
            
                var allBookings = _services.BookingRepository.GetByDateRange(
                    new DateTime(2000, 1, 1),
                    DateTime.Now.AddYears(10)
                );

                int totalCount = allBookings.Count;
                AmountBookings.Text = totalCount.ToString();
            }
            catch (Exception ex)
            {
                AmountBookings.Text = "N/A";
                Console.WriteLine($"Error loading total bookings: {ex.Message}");
            }
        }

        private void LoadCurrentOccupancy()
        {
            try
            {
                DateTime today = DateTime.Today;

          
                var allRooms = _services.RoomRepository.GetAll();
                int totalRooms = allRooms.Count;

                if (totalRooms == 0)
                {
                    currentOccupancy.Text = "0%";
                    return;
                }

             
                var activeBookings = _services.BookingRepository.GetActiveBookingsForDate(today);
                int occupiedRooms = activeBookings.Count;

              
                decimal occupancyRate = ((decimal)occupiedRooms / totalRooms) * 100;
                currentOccupancy.Text = $"{occupancyRate:F1}%";
            }
            catch (Exception ex)
            {
                currentOccupancy.Text = "N/A";
                Console.WriteLine($"Error loading current occupancy: {ex.Message}");
            }
        }

        private void LoadRoomsAvailableToday()
        {
            try
            {
                DateTime today = DateTime.Today;

                var allRooms = _services.RoomRepository.GetAll();
                int totalRooms = allRooms.Count;

       
                var activeBookings = _services.BookingRepository.GetActiveBookingsForDate(today);
                int occupiedRooms = activeBookings.Count;

            
                int availableRooms = totalRooms - occupiedRooms;
                roomsAvailableLabel.Text = availableRooms.ToString();
            }
            catch (Exception ex)
            {
                roomsAvailableLabel.Text = "N/A";
                Console.WriteLine($"Error loading rooms available: {ex.Message}");
            }
        }

        private void LoadArrivalsToday()
        {
            try
            {
                DateTime today = DateTime.Today;

              
                var allBookings = _services.BookingRepository.GetByDateRange(
                    today,
                    today.AddDays(1)
                );

             
                var arrivalsToday = allBookings.Where(b =>
                    b.CheckInDate.Date == today &&
                    (b.Status == BookingStatus.Confirmed || b.Status == BookingStatus.Unconfirmed)
                ).ToList();

                ArrivalsTopday.Text = arrivalsToday.Count.ToString();
            }
            catch (Exception ex)
            {
                ArrivalsTopday.Text = "N/A";
                Console.WriteLine($"Error loading arrivals: {ex.Message}");
            }
        }

        private void LoadDeparturesToday()
        {
            try
            {
                DateTime today = DateTime.Today;

           
                var allBookings = _services.BookingRepository.GetByDateRange(
                    today,
                    today.AddDays(1)
                );

                var departuresToday = allBookings.Where(b =>
                    b.CheckOutDate.Date == today &&
                    b.Status != BookingStatus.Cancelled
                ).ToList();

                deplabel.Text = departuresToday.Count.ToString();
            }
            catch (Exception ex)
            {
                deplabel.Text = "N/A";
                Console.WriteLine($"Error loading departures: {ex.Message}");
            }
        }

        private void LoadDepositsOverdue()
        {
            try
            {
                DateTime today = DateTime.Today;

             
                var allBookings = _services.BookingRepository.GetByDateRange(
                    today.AddMonths(-6),
                    today.AddYears(1)
                );

               
                var overdueDeposits = allBookings.Where(b =>
                    b.Status == BookingStatus.Unconfirmed &&
                    b.DepositDueDate.HasValue &&
                    b.DepositDueDate.Value < today &&
                    b.PaymentStatus == PaymentStatus.Pending
                ).ToList();

                depoOver.Text = overdueDeposits.Count.ToString();

              
                if (overdueDeposits.Count > 0)
                {
                    depoOver.ForeColor = Color.Red;
                }
                else
                {
                    depoOver.ForeColor = Color.FromArgb(0, 126, 249);
                }
            }
            catch (Exception ex)
            {
                depoOver.Text = "N/A";
                Console.WriteLine($"Error loading deposits overdue: {ex.Message}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.NavigateToBookings();
            }
        }

        private void ViewGuestButton_Click(object sender, EventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.NavigateToGuest();
            }
        }

        private void EnquiryButton_Click(object sender, EventArgs e)
        {
            string pricingSummary =
                    "🌤️ Seasonal Pricing Summary:\n\n" +
                    "🔹 Low Season (R550/night):\n" +
                    "   - December 1–7\n" +
                    "   - February, March, May, September, October, November\n\n" +
                    "🔸 Mid Season (R750/night):\n" +
                    "   - December 8–15\n" +
                    "   - January\n" +
                    "   - April (Easter period)\n\n" +
                    "🔺 High Season (R995/night):\n" +
                    "   - December 16–31\n" +
                    "   - June, July, August (Winter holidays)\n\n" +
                    "💡 Single occupancy adds 50% to the nightly rate.\n" +
                    "💡 Children under 5 stay free.\n" +
                    "💡 Children over 5 pay 50% of adult rate.\n" +
                    "💡 10% deposit required to confirm booking.";

            MessageBox.Show(pricingSummary, "Seasonal Pricing Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
        public void RefreshStatistics()
        {
            LoadDashboardStatistics();
        }
    }
}