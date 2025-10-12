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
        private const string ADMIN_CODE = "INF2011S"; 

        public EmployeeService(EmployeeRepositoryInterface employeeRepo)
        {
            _employeeRepository = employeeRepo;
        }

        /// <summary>
        /// 1. check if email exists
        /// 2. hash password
        /// 3. then creat new employee
        /// 4. save to repo
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <param name="createdByEmployeeId"></param>
        /// <returns></returns>
        public Employee RegisterEmployee(string firstName, string lastName, string email,string phone, string password, EmployeeRole role, string createdByEmployeeId)
        {
            // 1
            if (_employeeRepository.EmailExists(email))
            {
                return null;
            }

            // 2
            string passwordHash = HashPassword(password);

            // 3
            var employee = new Employee(firstName, lastName, email, phone, passwordHash, role, createdByEmployeeId);

            // 4
            _employeeRepository.Add(employee);

            return employee;
        }

        /// <summary>
        /// Employee has to enter the email
        /// and password which will be vefiried
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Employee AuthenticateEmployee(string email, string password)
        {
            var employee = _employeeRepository.GetByEmail(email);

            if (employee == null || !employee.IsActive)
            {
                return null;
            }

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
        
        /// <summary>
        /// Only admins can update roles
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="newRole"></param>
        /// <param name="updatedByEmployeeId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Only admins can deactivate employees
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="deactivatedByEmployeeId"></param>
        /// <returns></returns>
        public bool DeactivateEmployee(string employeeId, string deactivatedByEmployeeId)
        {
            var employee = _employeeRepository.GetById(employeeId);
            var deactivatedBy = _employeeRepository.GetById(deactivatedByEmployeeId);

            if (employee == null || deactivatedBy == null || !deactivatedBy.IsAdmin())
            {
                return false;
            }

            employee.IsActive = false;
            _employeeRepository.Update(employee);

            return true;
        }

        public bool ActivateEmployee(string employeeId, string activatedByEmployeeId)
        {
            var employee = _employeeRepository.GetById(employeeId);
            var deactivatedBy = _employeeRepository.GetById(activatedByEmployeeId);
            if (employee == null || deactivatedBy == null || !deactivatedBy.IsAdmin())
            {
                return false;
            }

            employee.IsActive = true;
            _employeeRepository.Update(employee);

            return true;

        }

       /// <summary>
       /// Password hashing
       /// </summary>
       /// <param name="password"></param>
       /// <returns></returns>
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