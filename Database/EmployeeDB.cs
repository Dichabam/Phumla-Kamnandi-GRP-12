using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Properties;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class EmployeeDB : EmployeeRepositoryInterface
    {
        private readonly string connectionString = Settings.Default.PhumlaKamnandiDBConnectionString;

        public Employee GetById(string employeeId)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Employee WHERE EmployeeId = @id", cn);
            cmd.Parameters.AddWithValue("@id", employeeId);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapEmployee(reader) : null;
        }

        public Employee GetByEmail(string email)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Employee WHERE Email = @email", cn);
            cmd.Parameters.AddWithValue("@email", email);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            return reader.Read() ? MapEmployee(reader) : null;
        }

        public List<Employee> GetAll()
        {
            var employees = new List<Employee>();
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Employee", cn);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                employees.Add(MapEmployee(reader));
            return employees;
        }

        public List<Employee> GetAllActive()
        {
            var employees = new List<Employee>();
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM Employee WHERE IsActive = 1", cn);
            cn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                employees.Add(MapEmployee(reader));
            return employees;
        }

        public void Add(Employee employee)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(@"
                INSERT INTO Employee (EmployeeId, FirstName, LastName, Email, Phone, PasswordHash, Role, DateRegistered, IsActive, CreatedBy)
                VALUES (@id, @first, @last, @email, @phone, @hash, @role, @date, @active, @creator)", cn);

            AddParameters(cmd, employee);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(Employee employee)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(@"
                UPDATE Employee SET FirstName = @first, LastName = @last, Email = @email, Phone = @phone, PasswordHash = @hash, Role = @role, IsActive = @active, CreatedBy = @creator
                WHERE EmployeeId = @id", cn);

            AddParameters(cmd, employee);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public bool Exists(string employeeId)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Employee WHERE EmployeeId = @id", cn);
            cmd.Parameters.AddWithValue("@id", employeeId);
            cn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public bool EmailExists(string email)
        {
            using var cn = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT COUNT(*) FROM Employee WHERE Email = @email", cn);
            cmd.Parameters.AddWithValue("@email", email);
            cn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void AddParameters(SqlCommand cmd, Employee e)
        {
            cmd.Parameters.AddWithValue("@id", e.EmployeeId);
            cmd.Parameters.AddWithValue("@first", e.FirstName);
            cmd.Parameters.AddWithValue("@last", e.LastName);
            cmd.Parameters.AddWithValue("@email", e.Email);
            cmd.Parameters.AddWithValue("@phone", e.Phone);
            cmd.Parameters.AddWithValue("@hash", e.PasswordHash);
            cmd.Parameters.AddWithValue("@role", (int)e.Role);
            cmd.Parameters.AddWithValue("@date", e.DateRegistered);
            cmd.Parameters.AddWithValue("@active", e.IsActive);
            cmd.Parameters.AddWithValue("@creator", e.CreatedBy ?? string.Empty);
        }

        private Employee MapEmployee(SqlDataReader reader)
        {
            var emp = new Employee(
                reader["FirstName"].ToString().Trim(),
                reader["LastName"].ToString().Trim(),
                reader["Email"].ToString().Trim(),
                reader["Phone"].ToString().Trim(),
                reader["PasswordHash"].ToString().Trim(),
                (EmployeeRole)Convert.ToInt32(reader["Role"]),
                reader["CreatedBy"]?.ToString()
            );

            emp.GetType().GetProperty("EmployeeId")
                .SetValue(emp, reader["EmployeeId"].ToString().Trim());

            emp.GetType().GetProperty("DateRegistered")
                .SetValue(emp, Convert.ToDateTime(reader["DateRegistered"]));

            emp.IsActive = Convert.ToBoolean(reader["IsActive"]);

            return emp;
        }
    }
}
