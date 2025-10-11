using Guna.UI2.WinForms;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Business.Services;
using Phumla_Kamnandi_GRP_12.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmEmployees : Form
    {
        private readonly EmployeeServiceInterface _employeeService;
        private Employee _currentEmployee; // The logged-in admin
        private Employee _selectedEmployee; // The employee selected in the grid
        private bool _isAddingEmployee = false;

        public FrmEmployees()
        {
            InitializeComponent();

            
            var employeeRepo = new EmployeeDB();
            _employeeService = new EmployeeService(employeeRepo);

           
            InitializeFormSetup();
        }

      
        public FrmEmployees(Employee currentEmployee) : this()
        {
            _currentEmployee = currentEmployee;
            LoadEmployees();
        }

        private void InitializeFormSetup()
        {
    
            HideInputFields();

       
            panel1.Visible = false;

      
            EmployeeDataGridViiew.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeDataGridViiew.MultiSelect = false;
            EmployeeDataGridViiew.ReadOnly = true;
            EmployeeDataGridViiew.AllowUserToAddRows = false;

      
            this.Load += FrmEmployees_Load;
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
       
            if (_currentEmployee == null)
            {
                MessageBox.Show("No logged-in employee found. Please ensure you're logged in.",
                    "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                var employees = _employeeService.GetAllEmployees();

                DataTable dt = new DataTable();
                dt.Columns.Add("Employee ID", typeof(string));
                dt.Columns.Add("First Name", typeof(string));
                dt.Columns.Add("Last Name", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("Role", typeof(string));
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Date Registered", typeof(DateTime));

                foreach (var emp in employees)
                {
                    dt.Rows.Add(
                        emp.EmployeeId,
                        emp.FirstName,
                        emp.LastName,
                        emp.Email,
                        emp.Phone,
                        emp.Role.ToString(),
                        emp.IsActive ? "Active" : "Inactive",
                        emp.DateRegistered
                    );
                }

                EmployeeDataGridViiew.DataSource = dt;

   
                EmployeeDataGridViiew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (!_isAddingEmployee)
            {
    
                ShowInputFields();
                ClearInputFields();
                AddEmployeeButton.Text = "Save";
                _isAddingEmployee = true;

   
                ChangeRoleButton.Enabled = false;
                DeactivateEmployeeButton.Enabled = false;
            }
            else
            {
       
                SaveNewEmployee();
            }
        }

        private void SaveNewEmployee()
        {
            try
            {
       
                if (string.IsNullOrWhiteSpace(NametextEm.Text) ||
                    string.IsNullOrWhiteSpace(surnameTxtEm.Text) ||
                    string.IsNullOrWhiteSpace(phonetxtEm.Text) ||
                    string.IsNullOrWhiteSpace(EmailTextEm.Text))
                {
                    MessageBox.Show("Please fill in all fields.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

     
                if (!IsValidEmail(EmailTextEm.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid email address.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

   
                if (phonetxtEm.Text.Trim().Length < 10)
                {
                    MessageBox.Show("Please enter a valid phone number (at least 10 digits).",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Generate work email: firstname.lastname@phumlakamnandi.co.za
                string workEmail = $"{NametextEm.Text.Trim().ToLower()}.{surnameTxtEm.Text.Trim().ToLower()}@phumlakamnandi.co.za";

                // Generate temporary password (employee must change on first login)
                string tempPassword = "TempPass123!";

                // Register employee
                var newEmployee = _employeeService.RegisterEmployee(
                    NametextEm.Text.Trim(),
                    surnameTxtEm.Text.Trim(),
                    workEmail,
                    phonetxtEm.Text.Trim(),
                    tempPassword,
                    EmployeeRole.Employee,
                    _currentEmployee?.EmployeeId
                );

                if (newEmployee != null)
                {
                    MessageBox.Show(
                        $"Employee added successfully!\n\n" +
                        $"Work Email: {workEmail}\n" +
                        $"Temporary Password: {tempPassword}\n\n" +
                        $"The employee must change their password on first login.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Reset form
                    HideInputFields();
                    ClearInputFields();
                    AddEmployeeButton.Text = "Add Employee";
                    _isAddingEmployee = false;

                    // Re-enable buttons
                    ChangeRoleButton.Enabled = true;
                    DeactivateEmployeeButton.Enabled = true;

                    // Reload grid
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("Failed to add employee. Email may already exist.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving employee: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeRoleButton_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee == null)
            {
                MessageBox.Show("Please select an employee from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            panel1.Visible = true;
            panel1.BringToFront();

            guna2ComboBox1.SelectedIndex = _selectedEmployee.Role == EmployeeRole.Employee ? 0 : 1;
        }

        private void changerolebuttonconfirm_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee == null || guna2ComboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an employee and a role.",
                    "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
             
                EmployeeRole newRole = guna2ComboBox1.SelectedIndex == 0
                    ? EmployeeRole.Employee
                    : EmployeeRole.Manager;

            
                if (_selectedEmployee.Role == newRole)
                {
                    MessageBox.Show("Employee already has this role.",
                        "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                    return;
                }

                bool success = _employeeService.UpdateEmployeeRole(
                    _selectedEmployee.EmployeeId,
                    newRole,
                    _currentEmployee.EmployeeId
                );

                if (success)
                {
                    MessageBox.Show(
                        $"Role updated successfully!\n\n" +
                        $"Employee: {_selectedEmployee.FullName}\n" +
                        $"New Role: {newRole}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

               
                    panel1.Visible = false;
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("Failed to update role. You may not have permission.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating role: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeactivateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee == null)
            {
                MessageBox.Show("Please select an employee from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Don't allow deactivating yourself
            if (_selectedEmployee.EmployeeId == _currentEmployee?.EmployeeId)
            {
                MessageBox.Show("You cannot deactivate your own account.",
                    "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if already inactive
            if (!_selectedEmployee.IsActive)
            {
                MessageBox.Show("This employee is already deactivated.",
                    "Already Inactive", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm deactivation
            var result = MessageBox.Show(
                $"Are you sure you want to deactivate this employee?\n\n" +
                $"Employee: {_selectedEmployee.FullName}\n" +
                $"Email: {_selectedEmployee.Email}\n\n" +
                $"They will not be able to login after deactivation.",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _employeeService.DeactivateEmployee(
                        _selectedEmployee.EmployeeId,
                        _currentEmployee.EmployeeId
                    );

                    if (success)
                    {
                        MessageBox.Show(
                            $"Employee deactivated successfully!\n\n" +
                            $"{_selectedEmployee.FullName} can no longer login.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadEmployees();
                        _selectedEmployee = null;
                    }
                    else
                    {
                        MessageBox.Show("Failed to deactivate employee. You may not have permission.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deactivating employee: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EmployeeDataGridViiew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click if needed - SelectionChanged handles row selection
            if (e.RowIndex >= 0)
            {
                var row = EmployeeDataGridViiew.Rows[e.RowIndex];
                string employeeId = row.Cells["Employee ID"].Value.ToString();
                _selectedEmployee = _employeeService.GetEmployeeById(employeeId);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Handle role selection change if needed
        }

        private void EmailTextEm_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time email validation
        }

        private void phonetxtEm_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time phone validation
        }

        private void surnameTxtEm_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time surname validation
        }

        private void NametextEm_TextChanged(object sender, EventArgs e)
        {
            // Optional: Real-time name validation
        }

        // Helper methods
        private void ShowInputFields()
        {
            NametextEm.Visible = true;
            surnameTxtEm.Visible = true; // Surname
            phonetxtEm.Visible = true; // Phone
            EmailTextEm.Visible = true; // Email
            Name.Visible = true;
            Surname.Visible = true;
            label1.Visible = true; // Cell label
            label2.Visible = true; // Email label
        }

        private void HideInputFields()
        {
            NametextEm.Visible = false;
            surnameTxtEm.Visible = false;
            phonetxtEm.Visible = false;
            EmailTextEm.Visible = false;
            Name.Visible = false;
            Surname.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void ClearInputFields()
        {
            NametextEm.Clear();
            surnameTxtEm.Clear();
            phonetxtEm.Clear();
            EmailTextEm.Clear();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void FrmEmployees_Load_1(object sender, EventArgs e)
        {

        }
    }
}