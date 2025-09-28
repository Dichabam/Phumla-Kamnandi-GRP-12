using Phumla_Kamnandi_GRP_12.Business.Enums;
using System;

namespace Phumla_Kamnandi_GRP_12.Business.ValueObjects
{
    public class PricingInfo
    {
        public Season Season { get; }
        public decimal RatePerNight { get; }
        public DateTime Date { get; }

        public PricingInfo(DateTime date, Season season, decimal rate)
        {
            Date = date;
            Season = season;
            RatePerNight = rate;
        }
    }
}