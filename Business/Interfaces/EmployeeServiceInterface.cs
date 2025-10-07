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