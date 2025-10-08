using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class MockBookingRepository : BookingRepositoryInterface
    {
        private static List<Booking> _bookings = new List<Booking>();

        public Booking GetByReference(string reference)
        {
            return _bookings.FirstOrDefault(b => b.BookingReference == reference);
        }

        public List<Booking> GetByGuestId(string guestId)
        {
            return _bookings.Where(b => b.GuestId == guestId).ToList();
        }

        public List<Booking> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            return _bookings.Where(b =>
                b.CheckInDate <= endDate && b.CheckOutDate >= startDate
            ).ToList();
        }

        public List<Booking> GetActiveBookingsForDate(DateTime date)
        {
            return _bookings.Where(b =>
                b.CheckInDate <= date &&
                b.CheckOutDate > date &&
                b.Status != BookingStatus.Cancelled
            ).ToList();
        }

        public void Add(Booking booking)
        {
            _bookings.Add(booking);
        }

        public void Update(Booking booking)
        {
            var existing = GetByReference(booking.BookingReference);
            if (existing != null)
            {
                _bookings.Remove(existing);
                _bookings.Add(booking);
            }
        }

        public void Delete(string reference)
        {
            var booking = GetByReference(reference);
            if (booking != null)
            {
                _bookings.Remove(booking);
            }
        }

        public bool RoomAvailableForDates(int roomNumber, DateTime checkIn, DateTime checkOut,
                                         string excludeBookingRef = null)
        {
            var conflictingBookings = _bookings.Where(b =>
                b.RoomNumber == roomNumber &&
                b.Status != BookingStatus.Cancelled &&
                b.CheckInDate < checkOut &&
                b.CheckOutDate > checkIn &&
                (excludeBookingRef == null || b.BookingReference != excludeBookingRef)
            );

            return !conflictingBookings.Any();
        }
    }
}
