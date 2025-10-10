using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Properties;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class RoomDB : RoomRepositoryInterface
    {
        private readonly string connectionString = Settings.Default.PhumlaKamnandiDBConnectionString;

        public Room GetByNumber(int roomNumber)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Room WHERE RoomNum = @num", cn);
            cmd.Parameters.AddWithValue("@num", roomNumber);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapRoom(reader) : null;
        }

        public List<Room> GetAll()
        {
            var rooms = new List<Room>();
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Room", cn);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                rooms.Add(MapRoom(reader));
            return rooms;
        }

        public List<Room> GetAvailableRoomsForDate(DateTime date)
        {
            var rooms = new List<Room>();
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(@"
                SELECT r.* FROM Room r
                WHERE r.Availability = 1 AND NOT EXISTS (
                    SELECT 1 FROM Booking b
                    WHERE b.RoomNum = r.RoomNum
                      AND b.Status != 2 -- Exclude cancelled
                      AND @date BETWEEN b.CheckInDate AND b.CheckOutDate
                )", cn);

            cmd.Parameters.AddWithValue("@date", date);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                rooms.Add(MapRoom(reader));
            return rooms;
        }

        public void Update(Room room)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("UPDATE Room SET Availability = @available WHERE RoomNum = @num", cn);
            cmd.Parameters.AddWithValue("@num", room.RoomNumber);
            cmd.Parameters.AddWithValue("@available", room.IsAvailable);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        private Room MapRoom(SqlDataReader reader)
        {
            var room = new Room(Convert.ToInt32(reader["RoomNum"]));
            room.IsAvailable = Convert.ToBoolean(reader["Availability"]);
            return room;
        }
    }
}
