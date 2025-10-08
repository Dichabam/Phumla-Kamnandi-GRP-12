using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class BookingDB : DB
    {
        #region Data Members
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";
        private Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings => bookings;
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table);
            AddToCollection();
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet() => dsMain;

        private void AddToCollection()
        {
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    var booking = new Booking(
                        row["GuestId"].ToString().Trim(),
                        Convert.ToDateTime(row["CheckInDate"]),
                        Convert.ToDateTime(row["CheckOutDate"]),
                        Convert.ToInt32(row["NumberOfAdults"]),
                        Convert.ToInt32(row["NumberOfChildren"]),
                        Convert.ToBoolean(row["IsSingleOccupancy"])
                    );

                    booking.GetType().GetProperty("BookingReference")
                        .SetValue(booking, row["BookingReference"].ToString().Trim());

                    booking.RoomNumber = Convert.ToInt32(row["RoomNumber"]);
                    booking.SetTotalAmount(Convert.ToDecimal(row["TotalAmount"]));
                    booking.DepositPaid = Convert.ToDecimal(row["DepositPaid"]);
                    booking.Status = (BookingStatus)Convert.ToInt32(row["Status"]);
                    booking.PaymentStatus = (PaymentStatus)Convert.ToInt32(row["PaymentStatus"]);
                    booking.GetType().GetProperty("BookingDate")
                        .SetValue(booking, Convert.ToDateTime(row["BookingDate"]));

                    if (row["DepositDueDate"] != DBNull.Value)
                        booking.GetType().GetProperty("DepositDueDate")
                            .SetValue(booking, Convert.ToDateTime(row["DepositDueDate"]));

                    booking.SpecialRequests = row["SpecialRequests"].ToString();
                    booking.CreditCardLastFour = row["CreditCardLastFour"].ToString();

                    bookings.Add(booking);
                }
            }
        }

        private void FillRow(DataRow row, Booking booking)
        {
            row["BookingReference"] = booking.BookingReference;
            row["GuestId"] = booking.GuestId;
            row["RoomNumber"] = booking.RoomNumber;
            row["CheckInDate"] = booking.CheckInDate;
            row["CheckOutDate"] = booking.CheckOutDate;
            row["NumberOfAdults"] = booking.NumberOfAdults;
            row["NumberOfChildren"] = booking.NumberOfChildren;
            row["TotalAmount"] = booking.TotalAmount;
            row["DepositAmount"] = booking.DepositAmount;
            row["DepositPaid"] = booking.DepositPaid;
            row["Status"] = (int)booking.Status;
            row["PaymentStatus"] = (int)booking.PaymentStatus;
            row["BookingDate"] = booking.BookingDate;
            row["DepositDueDate"] = booking.DepositDueDate.HasValue ? (object)booking.DepositDueDate.Value : DBNull.Value;
            row["SpecialRequests"] = booking.SpecialRequests ?? string.Empty;
            row["IsSingleOccupancy"] = booking.IsSingleOccupancy;
            row["CreditCardLastFour"] = booking.CreditCardLastFour ?? string.Empty;
        }
        #endregion

        #region CRUD Operations
        public void DataSetChange(Booking booking)
        {
            DataRow row = dsMain.Tables[table].NewRow();
            FillRow(row, booking);
            dsMain.Tables[table].Rows.Add(row);
        }
        #endregion

        #region SQL Command Construction
        private void BuildInsertParameters()
        {
            SqlParameter param;

            param = new SqlParameter("@BookingReference", SqlDbType.NVarChar, 50, "BookingReference");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestId", SqlDbType.NVarChar, 50, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 4, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 8, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 8, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfAdults", SqlDbType.Int, 4, "NumberOfAdults");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfChildren", SqlDbType.Int, 4, "NumberOfChildren");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalAmount", SqlDbType.Decimal, 10, "TotalAmount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositAmount", SqlDbType.Decimal, 10, "DepositAmount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.Decimal, 10, "DepositPaid");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.Int, 4, "Status");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PaymentStatus", SqlDbType.Int, 4, "PaymentStatus");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingDate", SqlDbType.DateTime, 8, "BookingDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositDueDate", SqlDbType.DateTime, 8, "DepositDueDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SpecialRequests", SqlDbType.NVarChar, -1, "SpecialRequests");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@IsSingleOccupancy", SqlDbType.Bit, 1, "IsSingleOccupancy");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditCardLastFour", SqlDbType.NVarChar, 4, "CreditCardLastFour");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void CreateInsertCommand()
        {
            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO Booking (BookingReference, GuestId, RoomNumber, CheckInDate, CheckOutDate, NumberOfAdults, NumberOfChildren, TotalAmount, DepositAmount, DepositPaid, Status, PaymentStatus, BookingDate, DepositDueDate, SpecialRequests, IsSingleOccupancy, CreditCardLastFour) " +
                "VALUES (@BookingReference, @GuestId, @RoomNumber, @CheckInDate, @CheckOutDate, @NumberOfAdults, @NumberOfChildren, @TotalAmount, @DepositAmount, @DepositPaid, @Status, @PaymentStatus, @BookingDate, @DepositDueDate, @SpecialRequests, @IsSingleOccupancy, @CreditCardLastFour)",
                cnMain);
            BuildInsertParameters();
        }

        public bool UpdateDataSource(Booking booking)
        {
            CreateInsertCommand();
            return UpdateDataSource(sqlLocal, table);
        }
        #endregion
    }
}
