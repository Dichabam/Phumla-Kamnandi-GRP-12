/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using System.Collections.Generic;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface EmployeeServiceInterface
    {
        Employee RegisterEmployee(string firstName, string lastName, string email,
                                 string phone, string password, EmployeeRole role,
                                 string createdByEmployeeId);
        Employee AuthenticateEmployee(string email, string password);
        Employee GetEmployeeById(string employeeId);
        Employee GetEmployeeByEmail(string email);
        List<Employee> GetAllEmployees();
        bool UpdateEmployeePassword(string employeeId, string oldPassword, string newPassword);
        bool ValidateAdminCode(string adminCode);
        bool UpdateEmployeeRole(string employeeId, EmployeeRole newRole, string updatedByEmployeeId);
        bool DeactivateEmployee(string employeeId, string deactivatedByEmployeeId);
    }
}