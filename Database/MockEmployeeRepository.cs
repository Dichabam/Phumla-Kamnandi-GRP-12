using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class MockEmployeeRepository : EmployeeRepositoryInterface
    {
        private static List<Employee> _employees = new List<Employee>();

        public Employee GetById(string employeeId)
        {
            return _employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        }

        public Employee GetByEmail(string email)
        {
            return _employees.FirstOrDefault(e =>
                e.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public List<Employee> GetAll()
        {
            return _employees.ToList();
        }

        public List<Employee> GetAllActive()
        {
            return _employees.Where(e => e.IsActive).ToList();
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            var existing = GetById(employee.EmployeeId);
            if (existing != null)
            {
                _employees.Remove(existing);
                _employees.Add(employee);
            }
        }

        public bool Exists(string employeeId)
        {
            return _employees.Any(e => e.EmployeeId == employeeId);
        }

        public bool EmailExists(string email)
        {
            return _employees.Any(e =>
                e.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}

