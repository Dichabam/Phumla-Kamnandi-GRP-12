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
    public class Guest
    {
        public string GuestId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string CreditCardLastFourDigits { get; private set; }
        public DateTime DateRegistered { get; private set; }
        public bool IsInGoodStanding { get; set; }

        public Guest(string firstName, string lastName, string email, string phone, string address)
        {
            // Generate unique ID for new guest
            GuestId = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            DateRegistered = DateTime.Now;
            IsInGoodStanding = true;    
        }

        public string FullName => $"{FirstName} {LastName}";

        public void UpdateCreditCard(string lastFourDigits)
        {
            CreditCardLastFourDigits = lastFourDigits;
        }

        public void UpdateContactInfo(string email, string phone, string address)
        {
            if (!string.IsNullOrEmpty(email)) Email = email;
            if (!string.IsNullOrEmpty(phone)) Phone = phone;
            if (!string.IsNullOrEmpty(address)) Address = address;
        }
    }
}