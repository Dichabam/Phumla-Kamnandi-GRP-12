/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */

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
