using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Properties;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class BookingDB : BookingRepositoryInterface
    {
        private readonly string connectionString = Settings.Default.PhumlaKamnandiDBConnectionString;

        public Booking GetByReference(string reference)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Booking WHERE BookingReference = @ref", cn);
            cmd.Parameters.AddWithValue("@ref", reference);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapBooking(reader) : null;
        }

        public List<Booking> GetByGuestId(string guestId)
        {
            var bookings = new List<Booking>();
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Booking WHERE GuestId = @guestId", cn);
            cmd.Parameters.AddWithValue("@guestId", guestId);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                bookings.Add(MapBooking(reader));
            return bookings;
        }

        public List<Booking> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            var bookings = new List<Booking>();
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Booking WHERE CheckInDate <= @end AND CheckOutDate >= @start", cn);
            cmd.Parameters.AddWithValue("@start", startDate);
            cmd.Parameters.AddWithValue("@end", endDate);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                bookings.Add(MapBooking(reader));
            return bookings;
        }

        public List<Booking> GetActiveBookingsForDate(DateTime date)
        {
            var bookings = new List<Booking>();
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Booking WHERE CheckInDate <= @date AND CheckOutDate > @date AND Status != @cancelled", cn);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@cancelled", (int)BookingStatus.Cancelled);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                bookings.Add(MapBooking(reader));
            return bookings;
        }

        public void Add(Booking booking)
        {
            // inside Add(Booking booking)
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(@"
            INSERT INTO Booking (
                BookingReference,
                GuestId,
                RoomNumber,
                CheckInDate,
                CheckOutDate,
                NumberOfAdults,
                NumberOfChildren,
                TotalAmount,
                DepositAmount,
                DepositPaid,
                Status,
                PaymentStatus,
                BookingDate,
                DepositDueDate,
                SpecialRequests,
                IsSingleOccupancy,
                CreditCardLastFour
            )
            VALUES (
                @ref,
                @guestId,
                @room,
                @checkIn,
                @checkOut,
                @adults,
                @children,
                @total,
                @deposit,
                @paid,
                @status,
                @payment,
                @bookDate,
                @dueDate,
                @requests,
                @single,
                @card
            )", cn);

            AddParameters(cmd, booking);
            cn.Open();
            cmd.ExecuteNonQuery();

        }

        public void Update(Booking booking)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(@"
                UPDATE Booking SET RoomNumber = @room, CheckInDate = @checkIn, CheckOutDate = @checkOut, NumberOfAdults = @adults, NumberOfChildren = @children, TotalAmount = @total, DepositAmount = @deposit, DepositPaid = @paid, Status = @status, PaymentStatus = @payment, DepositDueDate = @dueDate, SpecialRequests = @requests, IsSingleOccupancy = @single, CreditCardLastFour = @card
                WHERE BookingReference = @ref", cn);

            AddParameters(cmd, booking);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(string reference)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("DELETE FROM Booking WHERE BookingReference = @ref", cn);
            cmd.Parameters.AddWithValue("@ref", reference);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public bool RoomAvailableForDates(int roomNumber, DateTime checkIn, DateTime checkOut, string excludeBookingRef = null)
        {
            using var cn = new SqlConnection(connectionString);
            var query = @"
                SELECT COUNT(*) FROM Booking 
                WHERE RoomNumber = @room AND Status != @cancelled AND 
                      CheckInDate < @checkOut AND CheckOutDate > @checkIn";

            if (!string.IsNullOrEmpty(excludeBookingRef))
                query += " AND BookingReference != @exclude";

            var cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@room", roomNumber);
            cmd.Parameters.AddWithValue("@cancelled", (int)BookingStatus.Cancelled);
            cmd.Parameters.AddWithValue("@checkIn", checkIn);
            cmd.Parameters.AddWithValue("@checkOut", checkOut);
            if (!string.IsNullOrEmpty(excludeBookingRef))
                cmd.Parameters.AddWithValue("@exclude", excludeBookingRef);

            cn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count == 0;
        }

        private void AddParameters(SqlCommand cmd, Booking b)
        {
            cmd.Parameters.AddWithValue("@ref", b.BookingReference);
            cmd.Parameters.AddWithValue("@guestId", b.GuestId);
            cmd.Parameters.AddWithValue("@room", b.RoomNumber);
            cmd.Parameters.AddWithValue("@checkIn", b.CheckInDate);
            cmd.Parameters.AddWithValue("@checkOut", b.CheckOutDate);
            cmd.Parameters.AddWithValue("@adults", b.NumberOfAdults);
            cmd.Parameters.AddWithValue("@children", b.NumberOfChildren);
            cmd.Parameters.AddWithValue("@total", b.TotalAmount);
            cmd.Parameters.AddWithValue("@deposit", b.DepositAmount);
            cmd.Parameters.AddWithValue("@paid", b.DepositPaid);
            cmd.Parameters.AddWithValue("@status", (int)b.Status);
            cmd.Parameters.AddWithValue("@payment", (int)b.PaymentStatus);
            cmd.Parameters.AddWithValue("@bookDate", b.BookingDate);
            cmd.Parameters.AddWithValue("@dueDate", b.DepositDueDate ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@requests", b.SpecialRequests ?? string.Empty);
            cmd.Parameters.AddWithValue("@single", b.IsSingleOccupancy);
            cmd.Parameters.AddWithValue("@card", b.CreditCardLastFour ?? string.Empty);
        }

        private Booking MapBooking(SqlDataReader reader)
        {
            var booking = new Booking(
                reader["GuestId"].ToString().Trim(),
                Convert.ToDateTime(reader["CheckInDate"]),
                Convert.ToDateTime(reader["CheckOutDate"]),
                Convert.ToInt32(reader["NumberOfAdults"]),
                Convert.ToInt32(reader["NumberOfChildren"]),
                Convert.ToBoolean(reader["IsSingleOccupancy"])
            );

            booking.GetType().GetProperty("BookingReference")
                .SetValue(booking, reader["BookingReference"].ToString().Trim());

            booking.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
            booking.SetTotalAmount(Convert.ToDecimal(reader["TotalAmount"]));
            booking.DepositPaid = Convert.ToDecimal(reader["DepositPaid"]);
            booking.Status = (BookingStatus)Convert.ToInt32(reader["Status"]);
            booking.PaymentStatus = (PaymentStatus)Convert.ToInt32(reader["PaymentStatus"]);
            booking.GetType().GetProperty("BookingDate")
                .SetValue(booking, Convert.ToDateTime(reader["BookingDate"]));

            if (reader["DepositDueDate"] != DBNull.Value)
                booking.GetType().GetProperty("DepositDueDate")
                    .SetValue(booking, Convert.ToDateTime(reader["DepositDueDate"]));

            booking.SpecialRequests = reader["SpecialRequests"].ToString();
            booking.CreditCardLastFour = reader["CreditCardLastFour"].ToString();

            return booking;
        }
    }
}
