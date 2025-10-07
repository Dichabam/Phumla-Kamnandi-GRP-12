using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class MockRoomRepository : RoomRepositoryInterface
    {
        private static List<Room> _rooms;

        public MockRoomRepository()
        {
            // Initialize with 5 rooms as per test data specification
            if (_rooms == null)
            {
                _rooms = new List<Room>();
                for (int i = 1; i <= 5; i++)
                {
                    _rooms.Add(new Room(i));
                }
            }
        }

        public Room GetByNumber(int roomNumber)
        {
            return _rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }

        public List<Room> GetAll()
        {
            return _rooms.ToList();
        }

        public List<Room> GetAvailableRoomsForDate(DateTime date)
        {
            // This is simplified - actual availability would need to check bookings
            return _rooms.Where(r => r.IsAvailable).ToList();
        }

        public void Update(Room room)
        {
            var existing = GetByNumber(room.RoomNumber);
            if (existing != null)
            {
                _rooms.Remove(existing);
                _rooms.Add(room);
            }
        }
    }
}
