using System;
using System.Collections.Generic;

namespace Phumla_Kamnandi_GRP_12.Business.Entities
{
    public class OccupancyReport
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DailyOccupancy> DailyOccupancies { get; set; }
        public decimal AverageOccupancy { get; set; }
        public int TotalRoomNights { get; set; }
    }
}
