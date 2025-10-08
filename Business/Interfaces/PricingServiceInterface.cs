/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
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
