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
            var cmd = new SqlCommand("SELECT * FROM Room WHERE RoomNumber = @num", cn);
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
                WHERE r.IsAvailable = 1 AND NOT EXISTS (
                    SELECT 1 FROM Booking b
                    WHERE b.RoomNumber = r.RoomNumber
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
            var cmd = new SqlCommand("UPDATE Room SET IsAvailable = @available WHERE RoomNumber = @num", cn);
            cmd.Parameters.AddWithValue("@num", room.RoomNumber);
            cmd.Parameters.AddWithValue("@available", room.IsAvailable);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        private Room MapRoom(SqlDataReader reader)
        {
            var room = new Room(Convert.ToInt32(reader["RoomNumber"]));
            room.IsAvailable = Convert.ToBoolean(reader["IsAvailable"]);
            return room;
        }

        public bool Exists(int roomNumber)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Room WHERE RoomNumber = @num", cn);
            cmd.Parameters.AddWithValue("@num", roomNumber);
            cn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public void Add(Room room)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("INSERT INTO Room (RoomNumber, MaxOccupancy, IsAvailable) VALUES (@num, @max, @available)", cn);
            cmd.Parameters.AddWithValue("@num", room.RoomNumber);
            cmd.Parameters.AddWithValue("@max", room.MaxOccupancy);
            cmd.Parameters.AddWithValue("@available", room.IsAvailable);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void SeedFakeRooms()
        {
            var sampleRooms = new List<Room>
    {
        new Room(101),
        new Room(102),
        new Room(103),
        new Room(104),
        new Room(105),
        new Room(106),
        new Room(107),
        new Room(108),
        new Room(109),
        new Room(110)
    };

            foreach (var room in sampleRooms)
            {
                if (!Exists(room.RoomNumber))
                {
                    Add(room);
                }
            }
        }

    }
}
