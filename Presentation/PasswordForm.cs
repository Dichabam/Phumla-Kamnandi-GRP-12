/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        private string _workEmail; 
      

       
        public PasswordForm(string firstName, string lastName, string phone, string personalEmail, bool isPasswordReset)
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _personalEmail = personalEmail;
            _isPasswordReset = isPasswordReset;

            NewPasswordTextbox.UseSystemPasswordChar = true;
            ConfirmPasswordTextbox.UseSystemPasswordChar = true;

           
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
       
            SucessLabelPass.Text = "Password created successfully";
            SucessLabelPass.Visible = true;
            await Task.Delay(1500);
            SucessLabelPass.Visible = false;

          
            AdminCode adminForm = new AdminCode(_firstName, _lastName, _phone, _personalEmail, password);
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
               
                    string hashedPassword = HashPassword(newPassword);
                    employee.UpdatePassword(hashedPassword);
                    _services.EmployeeRepository.Update(employee);

                  
                    SucessLabelPass.Text = "Password updated successfully";
                    SucessLabelPass.Visible = true;
                    await Task.Delay(2000);
                    SucessLabelPass.Visible = false;

                    foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                    {
                        if (!(form is Login))
                        {
                            this.Close();
                        }
                    }

               
                    var loginForm = Application.OpenForms.OfType<Login>().FirstOrDefault();
                    if (loginForm != null)
                    {
                        loginForm.Show();
                        loginForm.BringToFront();
                    }
                    else
                    {
                        Login newLoginForm = new Login();
                        newLoginForm.Show();
                    }
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

            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";

            if (!Regex.IsMatch(NewPasswordTextbox.Text, pattern))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one number, and one special character.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPasswordTextbox.Focus();
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

        private void viewNewPasswordButton_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextbox.UseSystemPasswordChar)
            {
                NewPasswordTextbox.UseSystemPasswordChar = false;
                viewNewPasswordButton.Image = Properties.Resources.visibility_off_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
            else
            {
                NewPasswordTextbox.UseSystemPasswordChar = true;
                viewNewPasswordButton.Image = Properties.Resources.visibility_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
        }

        private void viewConfirmPasswordButton_Click(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextbox.UseSystemPasswordChar)
            {
                ConfirmPasswordTextbox.UseSystemPasswordChar = false;
                viewConfirmPasswordButton.Image = Properties.Resources.visibility_off_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
            else
            {
                ConfirmPasswordTextbox.UseSystemPasswordChar = true;
                viewConfirmPasswordButton.Image = Properties.Resources.visibility_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
        }


    }
}