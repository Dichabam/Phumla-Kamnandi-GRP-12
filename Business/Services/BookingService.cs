using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phumla_Kamnandi_GRP_12.Business.Services
{
    public class BookingService : BookingServiceInterface
    {
        private readonly BookingRepositoryInterface _bookingRepository;
        private readonly GuestRepositoryInterface _guestRepository;
        private readonly RoomRepositoryInterface _roomRepository;
        private readonly PricingServiceInterface _pricingService;

        public BookingService(BookingRepositoryInterface bookingRepo, GuestRepositoryInterface guestRepo,
                            RoomRepositoryInterface roomRepo, PricingServiceInterface pricingService)
        {
            _bookingRepository = bookingRepo;
            _guestRepository = guestRepo;
            _roomRepository = roomRepo;
            _pricingService = pricingService;
        }

        public BookingResult MakeBooking(string guestId, DateTime checkIn, DateTime checkOut,
            int adults, int children, bool singleOccupancy, string specialRequests = null)
        {
            // Validate guest exists
            var guest = _guestRepository.GetById(guestId);
            if (guest == null)
                return new BookingResult { Success = false, Message = "Guest not found" };

            // Check if guest is in good standing
            if (!guest.IsInGoodStanding)
                return new BookingResult { Success = false, Message = "Guest account has outstanding issues" };

            // Validate dates
            if (checkIn >= checkOut)
                return new BookingResult { Success = false, Message = "Check-out must be after check-in" };

            if (checkIn < DateTime.Today)
                return new BookingResult { Success = false, Message = "Cannot book dates in the past" };

            // Validate occupancy
            int totalGuests = adults + children;
            if (totalGuests > 4)
                return new BookingResult { Success = false, Message = "Maximum 4 guests per room" };

            // Find available room
            var availableRoom = FindAvailableRoom(checkIn, checkOut);
            if (availableRoom == null)
                return new BookingResult { Success = false, Message = "No rooms available for selected dates" };

            // Create booking
            var booking = new Booking(guestId, checkIn, checkOut, adults, children, singleOccupancy);
            booking.RoomNumber = availableRoom.RoomNumber;
            booking.SpecialRequests = specialRequests;

            // Calculate pricing (simplified - assuming all children are over 5 for this example)
            decimal totalAmount = _pricingService.CalculateTotalAmount(checkIn, checkOut,
                adults, 0, children, singleOccupancy);
            booking.SetTotalAmount(totalAmount);

            // Save booking
            _bookingRepository.Add(booking);

            return new BookingResult
            {
                Success = true,
                Message = "Booking created successfully",
                BookingReference = booking.BookingReference,
                TotalAmount = totalAmount,
                DepositRequired = booking.DepositAmount
            };
        }

        public bool ChangeBooking(string bookingRef, DateTime newCheckIn, DateTime newCheckOut)
        {
            var booking = _bookingRepository.GetByReference(bookingRef);
            if (booking == null || booking.Status == BookingStatus.Cancelled)
                return false;

            // Check if new dates are available for the same room
            bool available = _bookingRepository.RoomAvailableForDates(
                booking.RoomNumber, newCheckIn, newCheckOut, bookingRef);

            if (!available)
            {
                // Try to find another room
                var newRoom = FindAvailableRoom(newCheckIn, newCheckOut);
                if (newRoom == null) return false;
                booking.RoomNumber = newRoom.RoomNumber;
            }

            booking.UpdateDates(newCheckIn, newCheckOut);

            // Recalculate pricing
            decimal newAmount = _pricingService.CalculateTotalAmount(newCheckIn, newCheckOut,
                booking.NumberOfAdults, 0, booking.NumberOfChildren, booking.IsSingleOccupancy);
            booking.SetTotalAmount(newAmount);

            _bookingRepository.Update(booking);
            return true;
        }

        public bool CancelBooking(string bookingRef)
        {
            var booking = _bookingRepository.GetByReference(bookingRef);
            if (booking == null || booking.Status == BookingStatus.Cancelled)
                return false;

            booking.CancelBooking();
            _bookingRepository.Update(booking);
            return true;
        }

        public Booking GetBookingDetails(string bookingRef)
        {
            return _bookingRepository.GetByReference(bookingRef);
        }

        public bool ConfirmBookingWithDeposit(string bookingRef, decimal depositAmount)
        {
            var booking = _bookingRepository.GetByReference(bookingRef);
            if (booking == null || booking.Status != BookingStatus.Unconfirmed)
                return false;

            booking.ConfirmBooking(depositAmount);
            _bookingRepository.Update(booking);
            return true;
        }

        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            var allRooms = _roomRepository.GetAll();
            var availableRooms = new List<Room>();

            foreach (var room in allRooms)
            {
                if (_bookingRepository.RoomAvailableForDates(room.RoomNumber, checkIn, checkOut))
                {
                    availableRooms.Add(room);
                }
            }

            return availableRooms;
        }

        private Room FindAvailableRoom(DateTime checkIn, DateTime checkOut)
        {
            var availableRooms = GetAvailableRooms(checkIn, checkOut);
            return availableRooms.FirstOrDefault();
        }
    }

}