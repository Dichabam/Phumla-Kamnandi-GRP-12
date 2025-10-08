/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using Phumla_Kamnandi_GRP_12.Business.Entities;
using System.Collections.Generic;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface EmployeeRepositoryInterface
    {
        Employee GetById(string employeeId);
        Employee GetByEmail(string email);
        List<Employee> GetAll();
        List<Employee> GetAllActive();
        void Add(Employee employee);
        void Update(Employee employee);
        bool Exists(string employeeId);
        bool EmailExists(string email);
    }
}