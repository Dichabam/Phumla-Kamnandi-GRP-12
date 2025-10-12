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
         
            var guest = _guestRepository.GetById(guestId);
            if (guest == null)
                return new BookingResult { Success = false, Message = "Guest not found" };

            if (!guest.IsInGoodStanding)
                return new BookingResult { Success = false, Message = "Guest account has outstanding issues" };

        
            if (checkIn >= checkOut)
                return new BookingResult { Success = false, Message = "Check-out must be after check-in" };

            if (checkIn < DateTime.Today)
                return new BookingResult { Success = false, Message = "Cannot book dates in the past" };

          
            int totalGuests = adults + children;
            if (totalGuests > 4)
                return new BookingResult { Success = false, Message = "Maximum 4 guests per room" };

            if (adults == 0)
                return new BookingResult { Success = false, Message = "At least one adult required" };


            var availableRoom = FindAvailableRoom(checkIn, checkOut);
            if (availableRoom == null)
                return new BookingResult { Success = false, Message = "No rooms available for selected dates" };

      
            var booking = new Booking(guestId, checkIn, checkOut, adults, children, singleOccupancy);
            booking.RoomNumber = availableRoom.RoomNumber;
            booking.SpecialRequests = specialRequests;


            decimal totalAmount = _pricingService.CalculateTotalAmount(checkIn, checkOut, adults, 0, children, singleOccupancy);
            booking.SetTotalAmount(totalAmount);

   
            _bookingRepository.Add(booking);


            UpdateRoomAvailability(availableRoom.RoomNumber, checkIn, checkOut);

            return new BookingResult
            {
                Success = true,
                Message = "Booking created successfully. Deposit must be paid within 14 days of arrival.",
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

            if (newCheckIn >= newCheckOut || newCheckIn < DateTime.Today)
                return false;

            int oldRoomNumber = booking.RoomNumber;
            DateTime oldCheckIn = booking.CheckInDate;
            DateTime oldCheckOut = booking.CheckOutDate;

          
            bool currentRoomAvailable = _bookingRepository.RoomAvailableForDates(
                booking.RoomNumber, newCheckIn, newCheckOut, bookingRef);

            if (!currentRoomAvailable)
            {
                var newRoom = FindAvailableRoom(newCheckIn, newCheckOut);
                if (newRoom == null) return false;
                booking.RoomNumber = newRoom.RoomNumber;
            }

            booking.UpdateDates(newCheckIn, newCheckOut);

      
            decimal newAmount = _pricingService.CalculateTotalAmount(newCheckIn, newCheckOut,
                booking.NumberOfAdults, 0, booking.NumberOfChildren, booking.IsSingleOccupancy);
            booking.SetTotalAmount(newAmount);

            if (booking.Status == BookingStatus.Confirmed && newAmount != booking.TotalAmount)
            {
                decimal newDepositRequired = newAmount * 0.10m;
                if (newDepositRequired > booking.DepositPaid)
                {
                    booking.Status = BookingStatus.Unconfirmed;
                }
            }

            _bookingRepository.Update(booking);

        
            UpdateRoomAvailability(oldRoomNumber, oldCheckIn, oldCheckOut);
            UpdateRoomAvailability(booking.RoomNumber, newCheckIn, newCheckOut);

            return true;
        }

        public bool CancelBooking(string bookingRef)
        {
            var booking = _bookingRepository.GetByReference(bookingRef);
            if (booking == null || booking.Status == BookingStatus.Cancelled)
                return false;

         
            int roomNumber = booking.RoomNumber;
            DateTime checkIn = booking.CheckInDate;
            DateTime checkOut = booking.CheckOutDate;

            booking.CancelBooking();
            _bookingRepository.Update(booking);

       
            UpdateRoomAvailability(roomNumber, checkIn, checkOut);

            return true;
        }

        public Booking GetBookingDetails(string bookingRef)
        {
            return _bookingRepository.GetByReference(bookingRef);
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

        public bool ConfirmBookingWithDeposit(string bookingRef, decimal depositAmount, string creditCardNumber = null)
        {
            var booking = _bookingRepository.GetByReference(bookingRef);
            if (booking == null)
                return false;

            if (depositAmount < booking.DepositAmount)
                return false;

            if (!string.IsNullOrEmpty(creditCardNumber) && creditCardNumber.Length >= 4)
            {
                var guest = _guestRepository.GetById(booking.GuestId);
                if (guest != null)
                {
                    string lastFourDigits = creditCardNumber.Substring(creditCardNumber.Length - 4);
                    guest.UpdateCreditCard(lastFourDigits);
                    _guestRepository.Update(guest);
                }
            }

            bool paymentVerified = SimulatePaymentVerification(creditCardNumber, depositAmount);

            if (paymentVerified)
            {
                booking.ConfirmBooking(depositAmount);
                _bookingRepository.Update(booking);

         
                UpdateRoomAvailability(booking.RoomNumber, booking.CheckInDate, booking.CheckOutDate);

                return true;
            }

            return false;
        }

        public string GenerateConfirmationLetter(string bookingRef)
        {
            var booking = GetBookingDetails(bookingRef);
            if (booking == null) return "Booking not found";

            var guest = _guestRepository.GetById(booking.GuestId);
            if (guest == null) return "Guest information not found";

            return $@"
            ═════════════════════════════════════════════════════
                PHUMLA KAMNANDI HOTELS - BOOKING CONFIRMATION
            ═════════════════════════════════════════════════════

            Booking Reference: {booking.BookingReference}

            Guest Information:
                Name: {guest.FullName}
                Email: {guest.Email}
                Phone: {guest.Phone}

            Booking Details:
                Check-in Date: {booking.CheckInDate:dd MMM yyyy}
                Check-out Date: {booking.CheckOutDate:dd MMM yyyy}
                Room Number: {booking.RoomNumber}
                Number of Guests: {booking.NumberOfAdults} Adults, {booking.NumberOfChildren} Children

            Financial Summary:
                Total Amount: R{booking.TotalAmount:N2}
                Deposit Paid: R{booking.DepositPaid:N2}
                Balance Due: R{(booking.TotalAmount - booking.DepositPaid):N2}

            Booking Status: {booking.Status}
            Payment Status: {booking.PaymentStatus}

            Deposit Due Date: {booking.DepositDueDate:dd MMM yyyy}

            Special Requests: {(string.IsNullOrEmpty(booking.SpecialRequests) ? "None" : booking.SpecialRequests)}

            ═════════════════════════════════════════════════════
            Thank you for choosing Phumla Kamnandi Hotels!
            ═════════════════════════════════════════════════════
            ";
        }

        /// <summary>
        /// Updates room availability based on current bookings
        /// This method checks if a room should be marked as available or unavailable
        /// based on active bookings for today
        /// </summary>
        private void UpdateRoomAvailability(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            try
            {
                var room = _roomRepository.GetByNumber(roomNumber);
                if (room == null) return;

                DateTime today = DateTime.Today;

           
                var activeBookingsToday = _bookingRepository.GetActiveBookingsForDate(today)
                    .Where(b => b.RoomNumber == roomNumber).ToList();

         
                room.IsAvailable = !activeBookingsToday.Any();

                _roomRepository.Update(room);
            }
            catch (Exception ex)
            {
    
                System.Diagnostics.Debug.WriteLine($"Error updating room availability: {ex.Message}");
            }
        }

        private bool SimulatePaymentVerification(string creditCardNumber, decimal amount)
        {
            if (amount <= 0)
                return false;

            if (!string.IsNullOrEmpty(creditCardNumber))
            {
                if (creditCardNumber.Length < 13)
                    return false;
            }

            return true;
        }
    }
}