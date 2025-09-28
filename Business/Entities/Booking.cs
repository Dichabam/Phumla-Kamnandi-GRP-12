using Phumla_Kamnandi_GRP_12.Business.Enums;
using System;

namespace Phumla_Kamnandi_GRP_12.Business.Entities
{
    public class Booking
    {
        public string BookingReference { get; private set; }
        public string GuestId { get; private set; }
        public int RoomNumber { get; set; }
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }
        public int NumberOfAdults { get; private set; }
        public int NumberOfChildren { get; private set; }
        public decimal TotalAmount { get; private set; }
        public decimal DepositAmount { get; private set; }
        public decimal DepositPaid { get; set; }
        public BookingStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime BookingDate { get; private set; }
        public DateTime? DepositDueDate { get; private set; }
        public string SpecialRequests { get; set; }
        public bool IsSingleOccupancy { get; private set; }

        public Booking(string guestId, DateTime checkIn, DateTime checkOut,
                      int adults, int children, bool singleOccupancy = false)
        {
            // Generate reference like PKH-YYYYMMDD-XXXX
            BookingReference = $"PKH-{DateTime.Now:yyyyMMdd}-{Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper()}";
            GuestId = guestId;
            CheckInDate = checkIn;
            CheckOutDate = checkOut;
            NumberOfAdults = adults;
            NumberOfChildren = children;
            IsSingleOccupancy = singleOccupancy;
            BookingDate = DateTime.Now;
            Status = BookingStatus.Unconfirmed;
            PaymentStatus = PaymentStatus.Pending;

            // Deposit due 14 days before arrival
            DepositDueDate = checkIn.AddDays(-14);
        }

        public int TotalGuests => NumberOfAdults + NumberOfChildren;

        public void SetTotalAmount(decimal amount)
        {
            TotalAmount = amount;
            DepositAmount = amount * 0.10m; // 10% deposit
        }

        public void ConfirmBooking(decimal depositPaid)
        {
            if (depositPaid >= DepositAmount)
            {
                DepositPaid = depositPaid;
                PaymentStatus = PaymentStatus.Paid;
                Status = BookingStatus.Confirmed;
            }
        }

        public void CancelBooking()
        {
            Status = BookingStatus.Cancelled;
            // Handle refund logic based on cancellation policy
            if (DateTime.Now < CheckInDate.AddDays(-7))
            {
                // Full refund if cancelled 7+ days before
                PaymentStatus = PaymentStatus.Refunded;
            }
            // Otherwise deposit is forfeited
        }

        public void UpdateDates(DateTime newCheckIn, DateTime newCheckOut)
        {
            CheckInDate = newCheckIn;
            CheckOutDate = newCheckOut;
            DepositDueDate = newCheckIn.AddDays(-14);
        }

        public void UpdateGuestCount(int adults, int children)
        {
            NumberOfAdults = adults;
            NumberOfChildren = children;
        }
    }
}