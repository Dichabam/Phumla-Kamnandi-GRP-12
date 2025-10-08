/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Business.ValueObjects;
using System;

namespace Phumla_Kamnandi_GRP_12.Business.Services
{
    public class PricingService : PricingServiceInterface
    {
        private const decimal LOW_SEASON_RATE = 550m;
        private const decimal MID_SEASON_RATE = 750m;
        private const decimal HIGH_SEASON_RATE = 995m;
        private const decimal SINGLE_SUPPLEMENT_PERCENT = 0.5m;
        private const decimal CHILD_DISCOUNT_PERCENT = 0.5m;

        public Season GetSeasonForDate(DateTime date)
        {
            // December season rules as specified
            if (date.Month == 12)
            {
                if (date.Day <= 7) return Season.Low;
                if (date.Day <= 15) return Season.Mid;
                return Season.High;
            }

            // Simplified rules for other months
            int month = date.Month;
            if (month >= 6 && month <= 8) return Season.High; // Winter holidays
            if (month == 1 || month == 4) return Season.Mid; // January and Easter
            return Season.Low;
        }

        public decimal GetRateForDate(DateTime date)
        {
            Season season = GetSeasonForDate(date);
            switch (season)
            {
                case Season.Low:
                    return LOW_SEASON_RATE;
                case Season.Mid:
                    return MID_SEASON_RATE;
                case Season.High:
                    return HIGH_SEASON_RATE;
                default:
                    return LOW_SEASON_RATE;
            }
        }

        public decimal CalculateTotalAmount(DateTime checkIn, DateTime checkOut,
            int adults, int childrenUnder5, int childrenOver5, bool singleOccupancy)
        {
            decimal total = 0m;
            int nights = (checkOut - checkIn).Days;

            for (int i = 0; i < nights; i++)
            {
                DateTime currentDate = checkIn.AddDays(i);
                decimal baseRate = GetRateForDate(currentDate);

                // Room base rate
                decimal nightTotal = baseRate;

                // Add single supplement if applicable
                if (singleOccupancy)
                {
                    nightTotal += baseRate * SINGLE_SUPPLEMENT_PERCENT;
                }

                total += nightTotal;
            }

            return total;
        }

        public PricingInfo GetPricingInfo(DateTime date)
        {
            return new PricingInfo(date, GetSeasonForDate(date), GetRateForDate(date));
        }
    }

}