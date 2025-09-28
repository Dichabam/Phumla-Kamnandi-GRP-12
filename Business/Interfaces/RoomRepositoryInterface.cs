using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;
using System.Collections.Generic;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface RoomRepositoryInterface
    {
        Room GetByNumber(int roomNumber);
        List<Room> GetAll();
        List<Room> GetAvailableRoomsForDate(DateTime date);
        void Update(Room room);
    }
}