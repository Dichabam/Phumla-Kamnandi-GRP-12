/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
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
