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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guestId"></param>
        /// <param name="checkIn"></param>
        /// <param name="checkOut"></param>
        /// <param name="adults"></param>
        /// <param name="children"></param>
        /// <param name="singleOccupancy"></param>
        /// <param name="specialRequests"></param>
        /// <returns></returns>
        public BookingResult MakeBooking(string guestId, DateTime checkIn, DateTime checkOut,
            int adults, int children, bool singleOccupancy, string specialRequests = null)
        {
         // IDEA: 
            // 1: Validate guest exists and is in good standing
            var guest = _guestRepository.GetById(guestId);
            if (guest == null)
                return new BookingResult { Success = false, Message = "Guest not found" };

            if (!guest.IsInGoodStanding)
                return new BookingResult { Success = false, Message = "Guest account has outstanding issues" };

            // 2: Validate dates according to business rules
            if (checkIn >= checkOut)
                return new BookingResult { Success = false, Message = "Check-out must be after check-in" };

            if (checkIn < DateTime.Today)
                return new BookingResult { Success = false, Message = "Cannot book dates in the past" };

            // 3: Validate occupancy (max 4 people per room as per regulations)
            int totalGuests = adults + children;
            if (totalGuests > 4)
                return new BookingResult { Success = false, Message = "Maximum 4 guests per room" };

            if (adults == 0)
                return new BookingResult { Success = false, Message = "At least one adult required" };

            // 4: Check room availability and find available room
            var availableRoom = FindAvailableRoom(checkIn, checkOut);
            if (availableRoom == null)
                return new BookingResult { Success = false, Message = "No rooms available for selected dates" };

            // 5: Create booking with generated reference number
            var booking = new Booking(guestId, checkIn, checkOut, adults, children, singleOccupancy);
            booking.RoomNumber = availableRoom.RoomNumber;
            booking.SpecialRequests = specialRequests;

            // 6: Calculate total amount based on pricing rules
            decimal totalAmount = _pricingService.CalculateTotalAmount(checkIn, checkOut,
                adults, 0, children, singleOccupancy);
            booking.SetTotalAmount(totalAmount);

            // 7: Save booking to repository
            _bookingRepository.Add(booking);

            return new BookingResult
            {
                Success = true,
                Message = "Booking created successfully. Deposit must be paid within 14 days of arrival.",
                BookingReference = booking.BookingReference,
                TotalAmount = totalAmount,
                DepositRequired = booking.DepositAmount
            };
        }

        /// <summary>
        /// the idea is when you change booking, the system must try to find try to look for an available room
        /// and check if the room is available for the "changed" dates and 
        /// </summary>
        /// <param name="bookingRef"></param>
        /// <param name="newCheckIn"></param>
        /// <param name="newCheckOut"></param>
        /// <returns></returns>
        public bool ChangeBooking(string bookingRef, DateTime newCheckIn, DateTime newCheckOut)
        {
            var booking = _bookingRepository.GetByReference(bookingRef);
            if (booking == null || booking.Status == BookingStatus.Cancelled)
                return false;

            // Validate new dates
            if (newCheckIn >= newCheckOut || newCheckIn < DateTime.Today)
                return false;

            // Check if current room is available for new dates
            bool currentRoomAvailable = _bookingRepository.RoomAvailableForDates(
                booking.RoomNumber, newCheckIn, newCheckOut, bookingRef);

            if (!currentRoomAvailable)
            {
                // Try to find alternative room for new dates
                var newRoom = FindAvailableRoom(newCheckIn, newCheckOut);
                if (newRoom == null) return false;
                booking.RoomNumber = newRoom.RoomNumber;
            }

            // Update booking with new dates
            booking.UpdateDates(newCheckIn, newCheckOut);

            // Recalculate pricing for new dates
            decimal newAmount = _pricingService.CalculateTotalAmount(newCheckIn, newCheckOut,
                booking.NumberOfAdults, 0, booking.NumberOfChildren, booking.IsSingleOccupancy);
            booking.SetTotalAmount(newAmount);

            // Handle deposit adjustment if amount changed
            if (booking.Status == BookingStatus.Confirmed && newAmount != booking.TotalAmount)
            {
                // May need additional deposit if new amount is higher
                decimal newDepositRequired = newAmount * 0.10m;
                if (newDepositRequired > booking.DepositPaid)
                {
                    booking.Status = BookingStatus.Unconfirmed; // Requires additional payment
                }
            }

            _bookingRepository.Update(booking);
            return true;
        }

        /// <summary>
        /// remove every instance of the booking in the database 
        /// </summary>
        /// <param name="bookingRef"></param>
        /// <returns></returns>
        public bool CancelBooking(string bookingRef)
        {
            var booking = _bookingRepository.GetByReference(bookingRef);
            if (booking == null || booking.Status == BookingStatus.Cancelled)
                return false;

            booking.CancelBooking();
            _bookingRepository.Update(booking);
            return true;
        }

        /// <summary>
        /// for searching purposes 
        /// </summary>
        /// <param name="bookingRef"></param>
        /// <returns></returns>
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

        // Simulate payment verification 

        public bool ConfirmBookingWithDeposit(string bookingRef, decimal depositAmount, string creditCardNumber = null)
        {
            var booking = _bookingRepository.GetByReference(bookingRef);
            if (booking == null)
                return false;

            // Check if deposit is sufficient (minimum 10% of total)
            if (depositAmount < booking.DepositAmount)
                return false;

            // Store credit card details if provided
            if (!string.IsNullOrEmpty(creditCardNumber) && creditCardNumber.Length >= 4)
            {
                var guest = _guestRepository.GetById(booking.GuestId);
                if (guest != null)
                {
                    // Store last 4 digits only for security
                    string lastFourDigits = creditCardNumber.Substring(creditCardNumber.Length - 4);
                    guest.UpdateCreditCard(lastFourDigits);
                    _guestRepository.Update(guest);
                }
            }

            // Simulate payment verification 
            bool paymentVerified = SimulatePaymentVerification(creditCardNumber, depositAmount);

            if (paymentVerified)
            {
                booking.ConfirmBooking(depositAmount);
                _bookingRepository.Update(booking);
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
        /// Assumes all payments are authorised
        /// for deposits whithout credit card, accept if amount is valid
        /// </summary>
        /// <param name="creditCardNumber"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
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