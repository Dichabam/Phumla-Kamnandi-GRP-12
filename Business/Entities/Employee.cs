/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using Phumla_Kamnandi_GRP_12.Business.Enums;
using System;

namespace Phumla_Kamnandi_GRP_12.Business.Entities
{
    public class Employee
    {
        public string EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string PasswordHash { get; private set; }
        public EmployeeRole Role { get; private set; }
        public DateTime DateRegistered { get; private set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; private set; } // Admin/manager who created this account

        public Employee(string firstName, string lastName, string email, string phone, string passwordHash, EmployeeRole role = EmployeeRole.Employee,string createdBy = null)
        {
            EmployeeId = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            PasswordHash = passwordHash;
            Role = role;
            DateRegistered = DateTime.Now;
            IsActive = true;
            CreatedBy = createdBy;
        }

        public string FullName => $"{FirstName} {LastName}";

        public void UpdatePassword(string newPasswordHash)
        {
            PasswordHash = newPasswordHash;
        }

        public void UpdateContactInfo(string email, string phone)
        {
            if (!string.IsNullOrEmpty(email)) Email = email;
            if (!string.IsNullOrEmpty(phone)) Phone = phone;
        }

        public void UpdateRole(EmployeeRole newRole)
        {
            Role = newRole;
        }

        public bool IsAdmin()
        {
            return Role == EmployeeRole.Admin || Role == EmployeeRole.Manager;
        }
    }
}