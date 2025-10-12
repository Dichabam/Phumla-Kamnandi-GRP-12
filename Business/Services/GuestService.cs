/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phumla_Kamnandi_GRP_12.Business.Services
{
    public class GuestService : GuestServiceInterface
    {
        private readonly GuestRepositoryInterface _guestRepository;
        private readonly BookingRepositoryInterface _bookingRepository;

        public GuestService(GuestRepositoryInterface guestRepo, BookingRepositoryInterface bookingRepo)
        {
            _guestRepository = guestRepo;
            _bookingRepository = bookingRepo;
        }

        /// <summary>
        /// check if guest exists already(to avoid double booking)
        /// if doe not exist, make booking
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public Guest RegisterNewGuest(string firstName, string lastName, string email,string phone, string address, string idNum)
        {
            // Check if guest already exists
            var existingGuest = _guestRepository.GetByEmail(email);
            if (existingGuest != null)
                return existingGuest;

            var newGuest = new Guest(firstName, lastName, email, phone, address, idNum);
            _guestRepository.Add(newGuest);
            return newGuest;
        }

        public Guest GetGuestById(string guestId)
        {
            return _guestRepository.GetById(guestId);
        }

        public Guest GetGuestByEmail(string email)
        {
            return _guestRepository.GetByEmail(email);
        }

        public bool UpdateGuestCreditCard(string guestId, string lastFourDigits)
        {
            var guest = _guestRepository.GetById(guestId);
            if (guest == null) return false;

            // Validate that we have at least some digits
            if (string.IsNullOrEmpty(lastFourDigits)) return false;

            // If more than 4 digits provided, take the last 4
            string digitsToStore = lastFourDigits.Length > 4
                ? lastFourDigits.Substring(lastFourDigits.Length - 4)
                : lastFourDigits;

            guest.UpdateCreditCard(digitsToStore);
            _guestRepository.Update(guest);
            return true;
        }

        public List<Booking> GetGuestBookings(string guestId)
        {
            return _bookingRepository.GetByGuestId(guestId);
        }

        public bool UpdateGuestContactInfo(string guestId, string email, string phone, string address)
        {
            var guest = _guestRepository.GetById(guestId);
            if (guest == null) return false;

            guest.UpdateContactInfo(email, phone, address);
            _guestRepository.Update(guest);
            return true;
        }

        public bool UpdateGuestStanding(string guestId, bool isInGoodStanding, string reason = null)
        {
            var guest = _guestRepository.GetById(guestId);
            if (guest == null) return false;

            guest.IsInGoodStanding = isInGoodStanding;
            _guestRepository.Update(guest);


            return true;
        }

        public bool CheckAndUpdateGuestStanding(string guestId)
        {
            var guest = _guestRepository.GetById(guestId);
            if (guest == null) return false;

            var bookings = _bookingRepository.GetByGuestId(guestId);

            // Check for overdue deposits
            bool hasOverdueDeposits = bookings.Any(b =>
                b.Status == BookingStatus.Unconfirmed &&
                b.DepositDueDate.HasValue &&
                b.DepositDueDate.Value < DateTime.Today);

            // Update standing if needed
            if (hasOverdueDeposits && guest.IsInGoodStanding)
            {
                guest.IsInGoodStanding = false;
                _guestRepository.Update(guest);
                return false;
            }

            return guest.IsInGoodStanding;
        }

        


    }
}