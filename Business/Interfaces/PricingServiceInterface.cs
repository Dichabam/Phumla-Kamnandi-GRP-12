using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.ValueObjects;
using System;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface PricingServiceInterface
    {
        Season GetSeasonForDate(DateTime date);
        decimal GetRateForDate(DateTime date);
        decimal CalculateTotalAmount(DateTime checkIn, DateTime checkOut,
            int adults, int childrenUnder5, int childrenOver5, bool singleOccupancy);
        PricingInfo GetPricingInfo(DateTime date);
    }
}
