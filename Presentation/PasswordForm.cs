using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class PasswordForm : Form
    {
        private ServiceLocator _services;
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _personalEmail;
        private bool _isPasswordReset;
        private string _workEmail; // For password reset
      

       
        public PasswordForm(string firstName, string lastName, string phone, string personalEmail, bool isPasswordReset)
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _personalEmail = personalEmail;
            _isPasswordReset = isPasswordReset;

            NewPasswordTextbox.PasswordChar = '•';
            ConfirmPasswordTextbox.PasswordChar = '•';

           
            SucessLabelPass.Visible = false;  

            
            if (_isPasswordReset)
            {
                NextButtonPass.Text = "SUBMIT";
            }
            else
            {
                NextButtonPass.Text = "NEXT";
            }

            CloseButtonPass.Click += CloseButtonPass_Click;
            NextButtonPass.Click += NextButtonPass_Click;
        }

       
        public PasswordForm(string workEmail) : this("", "", "", "", true)
        {
            _workEmail = workEmail;
        }

        private void CloseButtonPass_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private async void NextButtonPass_Click(object sender, EventArgs e)
        {
            if (!ValidatePasswords())
            {
                return;
            }

            string password = NewPasswordTextbox.Text.Trim();

            if (_isPasswordReset)
            {
                
                await HandlePasswordReset(password);
            }
            else
            {
               
                await HandleNewAccountCreation(password);
            }
        }

        private async Task HandleNewAccountCreation(string password)
        {
            // Hash password before storing
            string hashedPassword = HashPassword(password);

            // Show success message
            SucessLabelPass.Text = "Password created successfully";  
            SucessLabelPass.Visible = true;
            await Task.Delay(1500); 
            SucessLabelPass.Visible = false;

            // Move to Admin Code verification
            AdminCode adminForm = new AdminCode(_firstName, _lastName, _phone, _personalEmail, hashedPassword);
            adminForm.FormClosed += (s, args) => this.Close();
            adminForm.Show();
            this.Hide();
        }

        private async Task HandlePasswordReset(string newPassword)
        {
            try
            {
                var employee = _services.EmployeeService.GetEmployeeByEmail(_workEmail);
                if (employee != null)
                {
                    // Hash and update password
                    string hashedPassword = HashPassword(newPassword);
                    employee.UpdatePassword(hashedPassword);
                    _services.EmployeeRepository.Update(employee);

                    // Show success message
                    SucessLabelPass.Text = "Password updated successfully";  // Use SucessLabelPass
                    SucessLabelPass.Visible = true;
                    await Task.Delay(2000); // Show for 2 seconds
                    SucessLabelPass.Visible = false;

                    // Return to login
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Employee not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePasswords()
        {
            if (string.IsNullOrWhiteSpace(NewPasswordTextbox.Text))
            {
                MessageBox.Show("Please enter a password", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPasswordTextbox.Focus();
                return false;
            }

            if (NewPasswordTextbox.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPasswordTextbox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(ConfirmPasswordTextbox.Text))
            {
                MessageBox.Show("Please confirm your password", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmPasswordTextbox.Focus();
                return false;
            }

            if (NewPasswordTextbox.Text != ConfirmPasswordTextbox.Text)
            {
                MessageBox.Show("Passwords do not match", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmPasswordTextbox.Clear();
                ConfirmPasswordTextbox.Focus();
                return false;
            }

            return true;
        }

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

        private void EmailTextboxPass_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}