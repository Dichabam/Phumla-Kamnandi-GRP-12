using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;
using System.Collections.Generic;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface BookingRepositoryInterface
    {
        Booking GetByReference(string reference);
        List<Booking> GetByGuestId(string guestId);
        List<Booking> GetByDateRange(DateTime startDate, DateTime endDate);
        List<Booking> GetActiveBookingsForDate(DateTime date);
        void Add(Booking booking);
        void Update(Booking booking);
        void Delete(string reference);
        bool RoomAvailableForDates(int roomNumber, DateTime checkIn, DateTime checkOut, string excludeBookingRef = null);
    }
}