/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface ReportingServiceInterface
    {
        OccupancyReport GenerateOccupancyReport(DateTime startDate, DateTime endDate);
        RevenueReport GenerateRevenueReport(DateTime startDate, DateTime endDate);
    }
}
