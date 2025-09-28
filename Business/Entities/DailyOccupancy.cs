using System;

namespace Phumla_Kamnandi_GRP_12.Business.Entities
{
    public class DailyOccupancy
    {
        public DateTime Date { get; set; }
        public int TotalRooms { get; set; }
        public int OccupiedRooms { get; set; }
        public int AvailableRooms { get; set; }
        public decimal OccupancyPercentage { get; set; }
    }
}
