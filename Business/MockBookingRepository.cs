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

}