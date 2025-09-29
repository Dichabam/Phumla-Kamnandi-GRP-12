using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Phumla_Kamnandi_GRP_12.Business
{
    public class MockRoomRepository : RoomRepositoryInterface
    {
        private List<Room> _rooms = new List<Room>();

        public MockRoomRepository()
        {
            // Initialize with 5 rooms as per requirements
            for (int i = 1; i <= 5; i++)
            {
                _rooms.Add(new Room(i));
            }
        }

        public Room GetByNumber(int roomNumber) => _rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        public List<Room> GetAll() => _rooms;
        public List<Room> GetAvailableRoomsForDate(DateTime date) => _rooms.Where(r => r.IsAvailable).ToList();
        public void Update(Room room) { /* In real implementation would update */ }
    }
}
