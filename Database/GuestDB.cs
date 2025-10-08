using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Properties;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class GuestDB : GuestRepositoryInterface
    {
        private readonly string connectionString = Settings.Default.PhumlaKamnandiConnectionString;

        public Guest GetById(string guestId)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Guest WHERE GuestId = @id", cn);
            cmd.Parameters.AddWithValue("@id", guestId);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapGuest(reader) : null;
        }

        public Guest GetByEmail(string email)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Guest WHERE Email = @email", cn);
            cmd.Parameters.AddWithValue("@email", email);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapGuest(reader) : null;
        }

        public Guest GetByPhone(string phone)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Guest WHERE Phone = @phone", cn);
            cmd.Parameters.AddWithValue("@phone", phone);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapGuest(reader) : null;
        }

        public List<Guest> GetAll()
        {
            var guests = new List<Guest>();
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Guest", cn);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                guests.Add(MapGuest(reader));
            return guests;
        }

        public void Add(Guest guest)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(@"
                INSERT INTO Guest (GuestId, FirstName, LastName, Email, Phone, Address, CreditCardLastFourDigits, DateRegistered, IsInGoodStanding)
                VALUES (@id, @first, @last, @email, @phone, @address, @card, @date, @status)", cn);

            cmd.Parameters.AddWithValue("@id", guest.GuestId);
            cmd.Parameters.AddWithValue("@first", guest.FirstName);
            cmd.Parameters.AddWithValue("@last", guest.LastName);
            cmd.Parameters.AddWithValue("@email", guest.Email);
            cmd.Parameters.AddWithValue("@phone", guest.Phone);
            cmd.Parameters.AddWithValue("@address", guest.Address);
            cmd.Parameters.AddWithValue("@card", guest.CreditCardLastFourDigits ?? string.Empty);
            cmd.Parameters.AddWithValue("@date", guest.DateRegistered);
            cmd.Parameters.AddWithValue("@status", guest.IsInGoodStanding);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(Guest guest)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(@"
                UPDATE Guest SET FirstName = @first, LastName = @last, Email = @email, Phone = @phone, Address = @address, CreditCardLastFourDigits = @card, IsInGoodStanding = @status
                WHERE GuestId = @id", cn);

            cmd.Parameters.AddWithValue("@id", guest.GuestId);
            cmd.Parameters.AddWithValue("@first", guest.FirstName);
            cmd.Parameters.AddWithValue("@last", guest.LastName);
            cmd.Parameters.AddWithValue("@email", guest.Email);
            cmd.Parameters.AddWithValue("@phone", guest.Phone);
            cmd.Parameters.AddWithValue("@address", guest.Address);
            cmd.Parameters.AddWithValue("@card", guest.CreditCardLastFourDigits ?? string.Empty);
            cmd.Parameters.AddWithValue("@status", guest.IsInGoodStanding);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public bool Exists(string guestId)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Guest WHERE GuestId = @id", cn);
            cmd.Parameters.AddWithValue("@id", guestId);
            cn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private Guest MapGuest(SqlDataReader reader)
        {
            var guest = new Guest(
                reader["FirstName"].ToString().Trim(),
                reader["LastName"].ToString().Trim(),
                reader["Email"].ToString().Trim(),
                reader["Phone"].ToString().Trim(),
                reader["Address"].ToString().Trim()
            );

            guest.GetType().GetProperty("GuestId")
                .SetValue(guest, reader["GuestId"].ToString().Trim());

            guest.GetType().GetProperty("DateRegistered")
                .SetValue(guest, Convert.ToDateTime(reader["DateRegistered"]));

            guest.IsInGoodStanding = Convert.ToBoolean(reader["IsInGoodStanding"]);

            if (reader["CreditCardLastFourDigits"] != DBNull.Value)
            {
                guest.UpdateCreditCard(reader["CreditCardLastFourDigits"].ToString().Trim());
            }

            return guest;
        }
    }
}