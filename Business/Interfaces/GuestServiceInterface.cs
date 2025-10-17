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
    public interface GuestServiceInterface
    {
        Guest RegisterNewGuest(string firstName, string lastName, string email, string phone, string address, string idNum);
        Guest GetGuestById(string guestId);
        Guest GetGuestByEmail(string email);
        bool UpdateGuestCreditCard(string guestId, string lastFourDigits);
        List<Booking> GetGuestBookings(string guestId);
        bool UpdateGuestContactInfo(string guestId, string email, string phone, string address);
        bool CheckAndUpdateGuestStanding(string guestId);

        bool ValidateID(string idnum);

        bool UpdateGuestStanding(string guestId, bool isInGoodStanding, string reason = null);
    }
}
