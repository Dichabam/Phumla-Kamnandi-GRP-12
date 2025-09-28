using Phumla_Kamnandi_GRP_12.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
