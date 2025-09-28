using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System.Collections.Generic;

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

        public Guest RegisterNewGuest(string firstName, string lastName, string email,
            string phone, string address)
        {
            // Check if guest already exists
            var existingGuest = _guestRepository.GetByEmail(email);
            if (existingGuest != null)
                return existingGuest;

            var newGuest = new Guest(firstName, lastName, email, phone, address);
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

            guest.UpdateCreditCard(lastFourDigits);
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
    }

}