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
using Phumla_Kamnandi_GRP_12.Business.Services;
using Phumla_Kamnandi_GRP_12.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class FrmEmployees : Form
    {
        private readonly EmployeeServiceInterface _employeeService;
        private Employee _selectedEmployee;
        private bool _isAddingEmployee = false;
        private ServiceLocator _services;

        public FrmEmployees()
        {
            InitializeComponent();

            var employeeRepo = new EmployeeDB();
            _employeeService = new EmployeeService(employeeRepo);
            _services = ServiceLocator.Instance;

            InitializeFormSetup();
        }

        private void InitializeFormSetup()
        {
            HideInputFields();
            panel1.Visible = false;

            EmployeeDataGridViiew.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeDataGridViiew.MultiSelect = false;
            EmployeeDataGridViiew.ReadOnly = true;
            EmployeeDataGridViiew.AllowUserToAddRows = false;

            // Add selection change event
            EmployeeDataGridViiew.SelectionChanged += EmployeeDataGridViiew_SelectionChanged;

            LoadEmployees();
        }

        private void EmployeeDataGridViiew_SelectionChanged(object sender, EventArgs e)
        {
            if (EmployeeDataGridViiew.SelectedRows.Count > 0)
            {
                var row = EmployeeDataGridViiew.SelectedRows[0];
                string employeeId = row.Cells["Employee ID"].Value.ToString();
                _selectedEmployee = _employeeService.GetEmployeeById(employeeId);


                if (_selectedEmployee != null)
                {
                    if (_selectedEmployee.IsActive)
                    {
                        DeactivateEmployeeButton.Text = "Deactivate";
                        DeactivateEmployeeButton.FillColor = Color.Firebrick; 
                    }
                    else
                    {
                        DeactivateEmployeeButton.Text = "Activate";
                        DeactivateEmployeeButton.FillColor = Color.ForestGreen; 
                    }

                    DeactivateEmployeeButton.Enabled = true;
                }
                else
                {
                    DeactivateEmployeeButton.Enabled = false;
                }
            }
            else
            {
                _selectedEmployee = null;
                DeactivateEmployeeButton.Enabled = false;
                DeactivateEmployeeButton.Text = "Deactivate";
                DeactivateEmployeeButton.FillColor = Color.Gray; 
            }
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
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
                AddEmployeeButton.FillColor = Color.ForestGreen;
                ChangeRoleButton.Text = "Cancel";
                ChangeRoleButton.FillColor = Color.Red;
                _isAddingEmployee = true;

              
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
                if (string.IsNullOrWhiteSpace(NametextEm.Text) ||string.IsNullOrWhiteSpace(surnameTxtEm.Text) ||string.IsNullOrWhiteSpace(phonetxtEm.Text) ||string.IsNullOrWhiteSpace(EmailTextEm.Text))
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

                // Generate work email
                string workEmail = $"{NametextEm.Text.Trim().ToLower()}.{surnameTxtEm.Text.Trim().ToLower()}@pkhotel.com";

                // Generate temporary password
                string tempPassword = "TempPass123!";

                // Get current user ID from ServiceLocator
                string currentUserId = _services.CurrentUserId;

                // Register employee
                var newEmployee = _employeeService.RegisterEmployee(
                    NametextEm.Text.Trim(),
                    surnameTxtEm.Text.Trim(),
                    workEmail,
                    phonetxtEm.Text.Trim(),
                    tempPassword,
                    EmployeeRole.Employee,
                    currentUserId
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

                    ResetAddEmployeeMode();
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
            // If in add mode, this acts as cancel button
            if (_isAddingEmployee)
            {
                ResetAddEmployeeMode();
                
                return;
            }

            // Normal change role functionality
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

                string currentUserId = _services.CurrentUserId;

                bool success = _employeeService.UpdateEmployeeRole(
                    _selectedEmployee.EmployeeId,
                    newRole,
                    currentUserId
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

        /// <summary>
        /// you get the current user ID from service locator
        /// you must not deactivate yourself
        /// and you must check if it alreasy inactive
        /// and confirm deactivation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeactivateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee == null)
            {
                MessageBox.Show("Please select an employee from the grid first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentUserId = _services.CurrentUserId;

            if (_selectedEmployee.EmployeeId == currentUserId)
            {
                MessageBox.Show("You cannot change your own activation status.",
                    "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determine whether we are activating or deactivating
           
            bool isCurrentlyActive = _selectedEmployee.IsActive;
            
            string action = isCurrentlyActive ? "deactivate" : "activate";
            string actionPast = isCurrentlyActive ? "deactivated" : "activated";

            var result = MessageBox.Show(
                $"Are you sure you want to {action} this employee?\n\n" +
                $"Employee: {_selectedEmployee.FullName}\n" +
                $"Email: {_selectedEmployee.Email}\n\n" +
                (isCurrentlyActive
                    ? "They will not be able to login after deactivation."
                    : "They will regain login access after activation."),
                $"Confirm {char.ToUpper(action[0]) + action.Substring(1)}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success;

                    if (isCurrentlyActive)
                    {
                        // Deactivate
                        success = _employeeService.DeactivateEmployee(
                            _selectedEmployee.EmployeeId, currentUserId);
                    }
                    else
                    {
                        // Activate
                        success = _employeeService.ActivateEmployee(
                            _selectedEmployee.EmployeeId, currentUserId);
                    }

                    if (success)
                    {
                        MessageBox.Show(
                            $"Employee {actionPast} successfully!\n\n" +
                            $"{_selectedEmployee.FullName} has been {actionPast}.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadEmployees(); 
                        _selectedEmployee = null;
                    }
                    else
                    {
                        MessageBox.Show($"Failed to {action} employee. You may not have permission.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error trying to {action} employee: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        #region Irrelevant methods
        private void EmployeeDataGridViiew_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void EmailTextEm_TextChanged(object sender, EventArgs e) { }
        private void phonetxtEm_TextChanged(object sender, EventArgs e) { }
        private void surnameTxtEm_TextChanged(object sender, EventArgs e) { }
        private void NametextEm_TextChanged(object sender, EventArgs e) { }
        private void FrmEmployees_Load_1(object sender, EventArgs e) { }
        #endregion

        #region Helper methods

        private void ResetAddEmployeeMode()
        {
            HideInputFields();
            ClearInputFields();
            AddEmployeeButton.Text = "Add Employee";
            ChangeRoleButton.Text = "Change Role";
            _isAddingEmployee = false;
            DeactivateEmployeeButton.Enabled = true;
        }
        private void ShowInputFields()
        {
            NametextEm.Visible = true;
            surnameTxtEm.Visible = true;
            phonetxtEm.Visible = true;
            EmailTextEm.Visible = true;
            NameL.Visible = true;
            Surname.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void HideInputFields()
        {
            NametextEm.Visible = false;
            surnameTxtEm.Visible = false;
            phonetxtEm.Visible = false;
            EmailTextEm.Visible = false;
            NameL.Visible = false;
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
        #endregion

        public void SearchEmployees(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadEmployees();
                return;
            }

            try
            {
                var allEmp = _services.EmployeeRepository.GetAll();
                var filteredGuests = allEmp.Where(g =>
                    (g.FirstName?.ToLower().Contains(searchText.ToLower()) ?? false) ||
                    (g.LastName?.ToLower().Contains(searchText.ToLower()) ?? false) ||
                    (g.Email?.ToLower().Contains(searchText.ToLower()) ?? false) ||
                    (g.Phone?.Contains(searchText) ?? false) ||
                    (g.EmployeeId?.ToLower().Contains(searchText.ToLower()) ?? false)
                ).ToList();

                EmployeeDataGridViiew.DataSource = filteredGuests;


                foreach (DataGridViewRow row in EmployeeDataGridViiew.Rows)
                {
                    if (row.DataBoundItem is Guest guest)
                    {
                        bool matchFound = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText.ToLower()))
                            {
                                matchFound = true;
                                break;
                            }
                        }

                        if (matchFound)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                        
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}