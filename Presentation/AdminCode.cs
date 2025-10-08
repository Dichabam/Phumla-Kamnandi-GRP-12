using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using System;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class AdminCode : Form
    {
        private ServiceLocator _services;

        // For new account creation
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _personalEmail;
        private string _password;

        // For password reset
        private string _workEmail;
        private bool _isPasswordReset;

        public AdminCode(string firstName, string lastName, string phone, string personalEmail, string password)
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _personalEmail = personalEmail;
            _password = password;
            _isPasswordReset = false;

            InitializeForm();
        }

      
        public AdminCode(string workEmail, bool isPasswordReset)
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            _workEmail = workEmail;
            _isPasswordReset = isPasswordReset;

            InitializeForm();
        }

        private void InitializeForm()
        {
            IncorrectLabel.Visible = false;
            SubmitButtonFP.Click += SubmitButtonFP_Click;
            CloseButtonAdmC.Click += CloseButtonAdmC_Click;
            CodeTextBox.KeyPress += CodeTextBox_KeyPress;
        }

        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SubmitButtonFP_Click(sender, e);
                e.Handled = true;
            }
        }

        private void SubmitButtonFP_Click(object sender, EventArgs e)
        {
            string enteredCode = CodeTextBox.Text.Trim();

            if (string.IsNullOrEmpty(enteredCode))
            {
                IncorrectLabel.Text = "Please enter admin code";
                IncorrectLabel.Visible = true;
                return;
            }

            if (_services.EmployeeService.ValidateAdminCode(enteredCode))
            {
                IncorrectLabel.Visible = false;

                if (_isPasswordReset)
                {
                    HandlePasswordReset();
                }
                else
                {
                    HandleNewAccountCreation();
                }
            }
            else
            {
                IncorrectLabel.Text = "Code is Incorrect";
                IncorrectLabel.Visible = true;
                CodeTextBox.Clear();
                CodeTextBox.Focus();
            }
        }

        private void HandlePasswordReset()
        {
            // Proceed to password reset form
            PasswordForm passwordForm = new PasswordForm(_workEmail);
            passwordForm.FormClosed += (s, args) => this.Close();
            passwordForm.Show();
            this.Hide();
        }

        private void HandleNewAccountCreation()
        {
            try
            {
                // Generate work email
                string workEmail = GenerateWorkEmail(_firstName, _lastName);

                // Create employee 
                Employee newEmployee = _services.EmployeeService.RegisterEmployee(
                    _firstName,
                    _lastName,
                    workEmail,
                    _phone,
                    _password,
                    EmployeeRole.Employee,
                    "SYSTEM"
                );

                if (newEmployee != null)
                {
                    MessageBox.Show($"Account created successfully!\n\n" +
                        $"Employee ID: {newEmployee.EmployeeId}\n" +
                        $"Name: {newEmployee.FullName}\n" +
                        $"Work Email: {newEmployee.Email}\n\n" +
                        $"Use your work email to login.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Auto-login the new employee
                    _services.SetEmployeeSession(newEmployee);

                   
                    Dashbaord dashboard = new Dashbaord();
                    dashboard.Show();

                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create account. Email may already exist.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateWorkEmail(string firstName, string lastName)
        {
            // Generate email in format: firstname.lastname@pkhotel.com
            string baseEmail = $"{firstName.ToLower()}.{lastName.ToLower()}@pkhotel.com";

            // Check if email exists, if so add number suffix
            var existingEmployee = _services.EmployeeService.GetEmployeeByEmail(baseEmail);
            if (existingEmployee != null)
            {
                int counter = 1;
                string newEmail;
                do
                {
                    newEmail = $"{firstName.ToLower()}.{lastName.ToLower()}{counter}@pkhotel.com";
                    existingEmployee = _services.EmployeeService.GetEmployeeByEmail(newEmail);
                    counter++;
                } while (existingEmployee != null);
                return newEmail;
            }

            return baseEmail;
        }

        private void CloseButtonAdmC_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}