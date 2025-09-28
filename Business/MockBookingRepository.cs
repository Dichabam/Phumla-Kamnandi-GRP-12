using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Business.Services;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Phumla_Kamnandi_GRP_12.Business
{

    public class MockBookingRepository : BookingRepositoryInterface
    {
        private List<Booking> _bookings = new List<Booking>();

        public void Add(Booking booking) => _bookings.Add(booking);
        public void Update(Booking booking) { /* In real implementation would update */ }
        public void Delete(string reference) => _bookings.RemoveAll(b => b.BookingReference == reference);
        public Booking GetByReference(string reference) => _bookings.FirstOrDefault(b => b.BookingReference == reference);
        public List<Booking> GetByGuestId(string guestId) => _bookings.Where(b => b.GuestId == guestId).ToList();
        public List<Booking> GetByDateRange(DateTime start, DateTime end) =>
            _bookings.Where(b => b.CheckInDate >= start && b.CheckOutDate <= end).ToList();

        public List<Booking> GetActiveBookingsForDate(DateTime date) =>
            _bookings.Where(b => b.Status != BookingStatus.Cancelled &&
                           date >= b.CheckInDate && date < b.CheckOutDate).ToList();

        public bool RoomAvailableForDates(int roomNumber, DateTime checkIn, DateTime checkOut, string excludeRef = null)
        {
            return !_bookings.Any(b => b.RoomNumber == roomNumber &&
                                      b.Status != BookingStatus.Cancelled &&
                                      b.BookingReference != excludeRef &&
                                      ((checkIn >= b.CheckInDate && checkIn < b.CheckOutDate) ||
                                       (checkOut > b.CheckInDate && checkOut <= b.CheckOutDate) ||
                                       (checkIn <= b.CheckInDate && checkOut >= b.CheckOutDate)));
        }
    }

    public class MockGuestRepository : GuestRepositoryInterface
    {
        private List<Guest> _guests = new List<Guest>();

        public MockGuestRepository()
        {
            // Pre-populate with test data
            _guests.Add(new Guest("John", "Smith", "john@email.com", "0211234567", "7 Main Rd, Rondebosch, 7700"));
            _guests.Add(new Guest("Nkosinathi", "Mthembu", "nkosi@email.com", "0311234567", "14 Lungelo Drive, Mtimkhulu, Durban, 4001"));
        }

        public void Add(Guest guest) => _guests.Add(guest);
        public void Update(Guest guest) { /* In real implementation would update */ }
        public Guest GetById(string guestId) => _guests.FirstOrDefault(g => g.GuestId == guestId);
        public Guest GetByEmail(string email) => _guests.FirstOrDefault(g => g.Email == email);
        public Guest GetByPhone(string phone) => _guests.FirstOrDefault(g => g.Phone == phone);
        public List<Guest> GetAll() => _guests;
        public bool Exists(string guestId) => _guests.Any(g => g.GuestId == guestId);
    }

    public class MockRoomRepository : RoomRepositoryInterface
    {
        private List<Room> _rooms = new List<Room>();

        public MockRoomRepository()
        {
            // Initialize with 5 rooms as per requirements
            for (int i = 1; i <= 5; i++)
            {
                _rooms.Add(new Room(i));
            }
        }

        public Room GetByNumber(int roomNumber) => _rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        public List<Room> GetAll() => _rooms;
        public List<Room> GetAvailableRoomsForDate(DateTime date) => _rooms.Where(r => r.IsAvailable).ToList();
        public void Update(Room room) { /* In real implementation would update */ }
    }

    public class BusinessLayerTests
    {
        private static void RunTests()
        {
            Console.WriteLine("=== Starting Business Layer Tests ===\n");

            TestPricingService();
            TestGuestService();
            TestBookingService();
            TestReportingService();
            TestEdgeCases();

            Console.WriteLine("\n=== All Tests Completed ===");
        }

        private static void TestPricingService()
        {
            Console.WriteLine("Testing PricingService...");
            var pricingService = new PricingService();

            // Test season determination
            AssertEqual(Season.Low, pricingService.GetSeasonForDate(new DateTime(2025, 12, 5)),
                       "December 5 should be Low season");
            AssertEqual(Season.Mid, pricingService.GetSeasonForDate(new DateTime(2025, 12, 10)),
                       "December 10 should be Mid season");
            AssertEqual(Season.High, pricingService.GetSeasonForDate(new DateTime(2025, 12, 25)),
                       "December 25 should be High season");

            // Test pricing rates
            AssertEqual(550m, pricingService.GetRateForDate(new DateTime(2025, 12, 5)),
                       "Low season rate should be R550");
            AssertEqual(750m, pricingService.GetRateForDate(new DateTime(2025, 12, 10)),
                       "Mid season rate should be R750");
            AssertEqual(995m, pricingService.GetRateForDate(new DateTime(2025, 12, 25)),
                       "High season rate should be R995");

            // Test total calculation with single occupancy
            decimal singleOccTotal = pricingService.CalculateTotalAmount(
                new DateTime(2025, 12, 5), new DateTime(2025, 12, 7), 1, 0, 0, true);
            AssertEqual(1650m, singleOccTotal, "Single occupancy for 2 nights should include 50% supplement");

            // Test with children
            decimal familyTotal = pricingService.CalculateTotalAmount(
                new DateTime(2025, 12, 5), new DateTime(2025, 12, 7), 2, 1, 2, false);
            AssertEqual(1650m, familyTotal, "Family booking calculation with children half price");

            Console.WriteLine("✓ PricingService tests passed");
        }

        private static void TestGuestService()
        {
            Console.WriteLine("Testing GuestService...");
            var guestRepo = new MockGuestRepository();
            var bookingRepo = new MockBookingRepository();
            var guestService = new GuestService(guestRepo, bookingRepo);

            // Test guest registration
            var newGuest = guestService.RegisterNewGuest("Jane", "Doe", "jane@email.com",
                                                         "0821234567", "123 Test Street");
            AssertNotNull(newGuest, "New guest should be created");
            AssertEqual("Jane", newGuest.FirstName, "Guest first name should match");

            // Test finding guest by email
            var foundGuest = guestService.GetGuestByEmail("john@email.com");
            AssertNotNull(foundGuest, "Should find existing guest John Smith");
            AssertEqual("John", foundGuest.FirstName, "Found guest should be John");

            // Test updating credit card
            var johnSmith = guestService.GetGuestByEmail("john@email.com");
            bool updated = guestService.UpdateGuestCreditCard(johnSmith.GuestId, "1234");
            AssertTrue(updated, "Credit card update should succeed");

            Console.WriteLine("✓ GuestService tests passed");
        }

        private static void TestBookingService()
        {
            Console.WriteLine("Testing BookingService...");
            var bookingRepo = new MockBookingRepository();
            var guestRepo = new MockGuestRepository();
            var roomRepo = new MockRoomRepository();
            var pricingService = new PricingService();
            var bookingService = new BookingService(bookingRepo, guestRepo, roomRepo, pricingService);

            // Get test guest
            var guest = guestRepo.GetByEmail("john@email.com");

            // Test making a booking for December 25-26 (should succeed as room available)
            var result1 = bookingService.MakeBooking(
                guest.GuestId,
                new DateTime(2025, 12, 24),
                new DateTime(2025, 12, 25),
                2, 1, false, "Late arrival");

            AssertTrue(result1.Success, "First booking should succeed");
            AssertEqual(995m, result1.TotalAmount, "High season rate should apply");
            AssertEqual(99.5m, result1.DepositRequired, "Deposit should be 10%");

            // Test room availability check
            var availableRooms = bookingService.GetAvailableRooms(
                new DateTime(2025, 12, 24),
                new DateTime(2025, 12, 25));
            AssertEqual(4, availableRooms.Count, "Should have 4 rooms available after one booking");

            // Test changing booking dates
            bool changed = bookingService.ChangeBooking(
                result1.BookingReference,
                new DateTime(2025, 12, 27),
                new DateTime(2025, 12, 28));
            AssertTrue(changed, "Booking date change should succeed");

            // Test confirming booking with deposit
            bool confirmed = bookingService.ConfirmBookingWithDeposit(result1.BookingReference, 100m);
            AssertTrue(confirmed, "Booking confirmation should succeed with sufficient deposit");

            // Test booking cancellation
            bool cancelled = bookingService.CancelBooking(result1.BookingReference);
            AssertTrue(cancelled, "Booking cancellation should succeed");

            // Test retrieving booking details
            var booking = bookingService.GetBookingDetails(result1.BookingReference);
            AssertNotNull(booking, "Should retrieve booking details");
            AssertEqual(BookingStatus.Cancelled, booking.Status, "Booking should be cancelled");

            Console.WriteLine("✓ BookingService tests passed");
        }

        private static void TestReportingService()
        {
            Console.WriteLine("Testing ReportingService...");
            var bookingRepo = new MockBookingRepository();
            var roomRepo = new MockRoomRepository();
            var guestRepo = new MockGuestRepository();
            var pricingService = new PricingService();
            var bookingService = new BookingService(bookingRepo, guestRepo, roomRepo, pricingService);
            var reportingService = new ReportingService(bookingRepo, roomRepo);

            // Create test bookings
            var guest = guestRepo.GetByEmail("john@email.com");
            bookingService.MakeBooking(guest.GuestId,
                new DateTime(2025, 12, 25), new DateTime(2025, 12, 27), 2, 0, false);
            bookingService.MakeBooking(guest.GuestId,
                new DateTime(2025, 12, 26), new DateTime(2025, 12, 28), 2, 0, false);

            // Test occupancy report
            var occupancyReport = reportingService.GenerateOccupancyReport(
                new DateTime(2025, 12, 24), new DateTime(2025, 12, 28));

            AssertNotNull(occupancyReport, "Occupancy report should be generated");
            AssertEqual(5, occupancyReport.DailyOccupancies.Count, "Should have 5 days in report");

            var dec25 = occupancyReport.DailyOccupancies.FirstOrDefault(d => d.Date.Day == 25);
            AssertNotNull(dec25, "Should have December 25 data");
            AssertEqual(1, dec25.OccupiedRooms, "One room occupied on Dec 25");
            AssertEqual(20m, dec25.OccupancyPercentage, "20% occupancy with 1 of 5 rooms");

            // Test revenue report
            var revenueReport = reportingService.GenerateRevenueReport(
                new DateTime(2025, 12, 1), new DateTime(2025, 12, 31));

            AssertNotNull(revenueReport, "Revenue report should be generated");
            AssertEqual(2, revenueReport.TotalBookings, "Should have 2 bookings");
            AssertTrue(revenueReport.TotalRevenue > 0, "Should have revenue calculated");

            Console.WriteLine("✓ ReportingService tests passed");
        }

        private static void TestEdgeCases()
        {
            Console.WriteLine("Testing Edge Cases...");
            var bookingRepo = new MockBookingRepository();
            var guestRepo = new MockGuestRepository();
            var roomRepo = new MockRoomRepository();
            var pricingService = new PricingService();
            var bookingService = new BookingService(bookingRepo, guestRepo, roomRepo, pricingService);

            // Test invalid guest ID
            var result = bookingService.MakeBooking(
                "INVALID", new DateTime(2025, 12, 25), new DateTime(2025, 12, 26), 2, 0, false);
            AssertFalse(result.Success, "Booking with invalid guest should fail");
            AssertEqual("Guest not found", result.Message, "Should return appropriate error message");

            // Test past dates
            result = bookingService.MakeBooking(
                guestRepo.GetByEmail("john@email.com").GuestId,
                new DateTime(2024, 1, 1), new DateTime(2024, 1, 2), 2, 0, false);
            AssertFalse(result.Success, "Booking with past dates should fail");

            // Test exceeding max occupancy
            result = bookingService.MakeBooking(
                guestRepo.GetByEmail("john@email.com").GuestId,
                new DateTime(2025, 12, 25), new DateTime(2025, 12, 26), 3, 2, false);
            AssertFalse(result.Success, "Booking exceeding 4 guests should fail");
            AssertEqual("Maximum 4 guests per room", result.Message, "Should indicate occupancy limit");

            // Test check-out before check-in
            result = bookingService.MakeBooking(
                guestRepo.GetByEmail("john@email.com").GuestId,
                new DateTime(2025, 12, 26), new DateTime(2025, 12, 25), 2, 0, false);
            AssertFalse(result.Success, "Invalid date range should fail");

            // Test overbooking scenario - book all 5 rooms
            var guest = guestRepo.GetByEmail("john@email.com");
            for (int i = 0; i < 5; i++)
            {
                bookingService.MakeBooking(guest.GuestId,
                    new DateTime(2025, 12, 30), new DateTime(2025, 12, 31), 2, 0, false);
            }

            // Try to book 6th room - should fail
            result = bookingService.MakeBooking(guest.GuestId,
                new DateTime(2025, 12, 30), new DateTime(2025, 12, 31), 2, 0, false);
            AssertFalse(result.Success, "Should fail when no rooms available");
            AssertEqual("No rooms available for selected dates", result.Message,
                       "Should indicate no availability");

            // Test guest not in good standing
            guest.IsInGoodStanding = false;
            result = bookingService.MakeBooking(guest.GuestId,
                new DateTime(2026, 1, 1), new DateTime(2026, 1, 2), 2, 0, false);
            AssertFalse(result.Success, "Guest not in good standing should be rejected");

            Console.WriteLine("✓ Edge case tests passed");
        }

        // Helper assertion methods
        private static void AssertEqual<T>(T expected, T actual, string message)
        {
            if (!expected.Equals(actual))
            {
                throw new Exception($"FAILED: {message}. Expected: {expected}, Actual: {actual}");
            }
        }

        private static void AssertNotNull(object obj, string message)
        {
            if (obj == null)
            {
                throw new Exception($"FAILED: {message}. Object was null");
            }
        }

        private static void AssertTrue(bool condition, string message)
        {
            if (!condition)
            {
                throw new Exception($"FAILED: {message}");
            }
        }

        private static void AssertFalse(bool condition, string message)
        {
            if (condition)
            {
                throw new Exception($"FAILED: {message}");
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                RunTests();
                Console.WriteLine("\n✓✓✓ ALL TESTS PASSED SUCCESSFULLY ✓✓✓");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n✗✗✗ TEST FAILURE: {ex.Message} ✗✗✗");
            }

            Console.ReadLine();
        }
    }
}