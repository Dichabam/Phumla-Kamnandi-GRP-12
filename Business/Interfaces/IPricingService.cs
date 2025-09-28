using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface IPricingService
    {
        Season GetSeasonForDate(DateTime date);
        decimal GetRateForDate(DateTime date);
        decimal CalculateTotalAmount(DateTime checkIn, DateTime checkOut,
            int adults, int childrenUnder5, int childrenOver5, bool singleOccupancy);
        PricingInfo GetPricingInfo(DateTime date);
    }
}
