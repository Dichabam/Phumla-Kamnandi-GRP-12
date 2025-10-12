using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class AdminCode : Form
    {
        private ServiceLocator _services;

      
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _personalEmail;
        private string _password;

    
        private string _workEmail;
        private bool _isPasswordReset;

        #region Constructors
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

        #endregion
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
          
            PasswordForm passwordForm = new PasswordForm(_workEmail);
            passwordForm.FormClosed += (s, args) => this.Close();
            passwordForm.Show();
            this.Hide();
        }

        private void HandleNewAccountCreation()
        {
            try
            {
             
                string workEmail = GenerateWorkEmail(_firstName, _lastName);

                
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

                    

                    // Open dashboard
                    Login login = new Login();
                    login.Show();

                    // Close all previous forms 
                    foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                    {
                        if (form != login)
                        {
                            form.Hide();
                        }
                    }

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

            string baseEmail = $"{firstName.ToLower()}.{lastName.ToLower()}@pkhotel.com";

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

        private void EnterAdminCodeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}