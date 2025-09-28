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
