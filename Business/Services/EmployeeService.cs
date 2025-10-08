/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Phumla_Kamnandi_GRP_12.Business.Services
{
    public class EmployeeService : EmployeeServiceInterface
    {
        private readonly EmployeeRepositoryInterface _employeeRepository;
        private const string ADMIN_CODE = "DIRK"; 

        public EmployeeService(EmployeeRepositoryInterface employeeRepo)
        {
            _employeeRepository = employeeRepo;
        }

        public Employee RegisterEmployee(string firstName, string lastName, string email,
                                        string phone, string password, EmployeeRole role,
                                        string createdByEmployeeId)
        {
            // Check if email already exists
            if (_employeeRepository.EmailExists(email))
            {
                return null;
            }

            // Hash password
            string passwordHash = HashPassword(password);

            // Create new employee
            var employee = new Employee(firstName, lastName, email, phone,
                                       passwordHash, role, createdByEmployeeId);

            // Save to repository
            _employeeRepository.Add(employee);

            return employee;
        }

        public Employee AuthenticateEmployee(string email, string password)
        {
            var employee = _employeeRepository.GetByEmail(email);

            if (employee == null || !employee.IsActive)
            {
                return null;
            }

            // Verify password
            string passwordHash = HashPassword(password);
            if (employee.PasswordHash == passwordHash)
            {
                return employee;
            }

            return null;
        }

        public Employee GetEmployeeById(string employeeId)
        {
            return _employeeRepository.GetById(employeeId);
        }

        public Employee GetEmployeeByEmail(string email)
        {
            return _employeeRepository.GetByEmail(email);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public bool UpdateEmployeePassword(string employeeId, string oldPassword, string newPassword)
        {
            var employee = _employeeRepository.GetById(employeeId);
            if (employee == null)
            {
                return false;
            }

            // Verify old password
            string oldPasswordHash = HashPassword(oldPassword);
            if (employee.PasswordHash != oldPasswordHash)
            {
                return false;
            }

            // Update to new password
            string newPasswordHash = HashPassword(newPassword);
            employee.UpdatePassword(newPasswordHash);
            _employeeRepository.Update(employee);

            return true;
        }

        public bool ValidateAdminCode(string adminCode)
        {
            return adminCode == ADMIN_CODE;
        }

        public bool UpdateEmployeeRole(string employeeId, EmployeeRole newRole, string updatedByEmployeeId)
        {
            var employee = _employeeRepository.GetById(employeeId);
            var updatedBy = _employeeRepository.GetById(updatedByEmployeeId);

            // Only admins can update roles
            if (employee == null || updatedBy == null || !updatedBy.IsAdmin())
            {
                return false;
            }

            employee.UpdateRole(newRole);
            _employeeRepository.Update(employee);

            return true;
        }

        public bool DeactivateEmployee(string employeeId, string deactivatedByEmployeeId)
        {
            var employee = _employeeRepository.GetById(employeeId);
            var deactivatedBy = _employeeRepository.GetById(deactivatedByEmployeeId);

            // Only admins can deactivate employees
            if (employee == null || deactivatedBy == null || !deactivatedBy.IsAdmin())
            {
                return false;
            }

            employee.IsActive = false;
            _employeeRepository.Update(employee);

            return true;
        }

        // Simple password hashing 
       
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}