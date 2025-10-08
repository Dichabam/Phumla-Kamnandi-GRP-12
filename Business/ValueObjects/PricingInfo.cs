/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
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