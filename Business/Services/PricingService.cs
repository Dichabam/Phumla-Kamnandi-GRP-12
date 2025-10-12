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

        /// <summary>
        /// Things to consider
        /// 1. calculate the price per day. prices might differ for different season
        ///    e.g. if someone books a room for a between high and mid season, consider both
        /// 2. add a signle supplement if applicable
        /// 3. ADD CHildren discount - Not yet accounted for 
        /// </summary>
        /// <param name="checkIn"></param>
        /// <param name="checkOut"></param>
        /// <param name="adults"></param>
        /// <param name="childrenUnder5"></param>
        /// <param name="childrenOver5"></param>
        /// <param name="singleOccupancy"></param>
        /// <returns></returns>
        /// 

        /*
         * Note that is the provisional class, the actual calculation will be revised
         * like do we account for the number of children when giving out a discount?
         * and is the price the total amount owed per person for just for the room
         */
        public decimal CalculateTotalAmount(DateTime checkIn, DateTime checkOut, int adults, int childrenUnder5, int childrenOver5, bool singleOccupancy)
        {
            decimal total = 0m;
            int nights = (checkOut - checkIn).Days;

            if (nights <= 0)
            {
                return 0m;
            }

            for (int i = 0; i < nights; i++)
            {
                DateTime currentDate = checkIn.AddDays(i);
                decimal baseRate = GetRateForDate(currentDate);

                // Calculate room rate
                decimal nightTotal = baseRate;

                // Add single supplement if applicable (50% extra)
                if (singleOccupancy)
                {
                    nightTotal += baseRate * SINGLE_SUPPLEMENT_PERCENT;
                }
                // If not single occupancy, children under 5 are free
                // Children over 5 pay half price (but this is per child, not affecting room rate)
                // The base rate already covers 2 adults in a room

                // Add charges for additional adults beyond 2
                if (adults > 2)
                {
                    nightTotal += (adults - 2) * baseRate;
                }

                // Add charges for children over 5 (half price)
                if (childrenOver5 > 0)
                {
                    nightTotal += childrenOver5 * (baseRate * CHILD_DISCOUNT_PERCENT);
                }

                // Children under 5 are free (no additional charge)

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