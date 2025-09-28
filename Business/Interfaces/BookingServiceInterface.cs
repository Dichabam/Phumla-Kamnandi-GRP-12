using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;
using System.Collections.Generic;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface BookingServiceInterface
    {
        BookingResult MakeBooking(string guestId, DateTime checkIn, DateTime checkOut,
            int adults, int children, bool singleOccupancy, string specialRequests = null);
        bool ChangeBooking(string bookingRef, DateTime newCheckIn, DateTime newCheckOut);
        bool CancelBooking(string bookingRef);
        Booking GetBookingDetails(string bookingRef);
        bool ConfirmBookingWithDeposit(string bookingRef, decimal depositAmount);
        List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut);
    }
}
