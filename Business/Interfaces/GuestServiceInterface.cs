using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;
using System.Collections.Generic;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface GuestServiceInterface
    {
        Guest RegisterNewGuest(string firstName, string lastName, string email, string phone, string address);
        Guest GetGuestById(string guestId);
        Guest GetGuestByEmail(string email);
        bool UpdateGuestCreditCard(string guestId, string lastFourDigits);
        List<Booking> GetGuestBookings(string guestId);
        bool UpdateGuestContactInfo(string guestId, string email, string phone, string address);
    }
}
