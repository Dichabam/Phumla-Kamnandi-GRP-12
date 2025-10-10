/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
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
        bool ConfirmBookingWithDeposit(string bookingRef, decimal depositAmount, string creditCardNumber = null);
        List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut);
        string GenerateConfirmationLetter(string bookingRef);
    }
}
