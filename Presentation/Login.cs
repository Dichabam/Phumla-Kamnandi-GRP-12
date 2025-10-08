using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    public partial class Login : Form
    {
        private ServiceLocator _services;

        public Login()
        {
            InitializeComponent();
            ErrorLoginLabel.Visible = false;
            _services = ServiceLocator.Instance;
            PasswordTextbox.PasswordChar = '•';
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            ErrorLoginLabel.Visible = false;
        }

        private void forgotpasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.FormClosed += ForgotPassword_FormClosed;
            this.Hide();
            forgotPasswordForm.Show();
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void NewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void CloseButtonLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            NewAccount newAccountForm = new NewAccount();
            newAccountForm.FormClosed += NewAccount_FormClosed;
            this.Hide();
            newAccountForm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextbox.Text.Trim();
            string password = PasswordTextbox.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ErrorLoginLabel.Text = "Please enter both email and password";
                ErrorLoginLabel.Visible = true;
                return;
            }

            if (!IsValidEmail(email))
            {
                ErrorLoginLabel.Text = "Please enter a valid email address";
                ErrorLoginLabel.Visible = true;
                return;
            }

            // Check if it's a work email (employee login)
            if (email.EndsWith("@pkhotel.com"))
            {
                Employee employee = _services.EmployeeService.AuthenticateEmployee(email, password);

                if (employee != null)
                {
                    // Set employee session
                    _services.SetEmployeeSession(employee);

                    // Open Dashboard
                    this.Hide();
                    Dashbaord dashboard = new Dashbaord();
                    dashboard.FormClosed += (s, args) => this.Close();
                    dashboard.Show();
                    return;
                }
            }
            else
            {
                // Not a work email - inform user
                ErrorLoginLabel.Text = "Please use your work email (@pkhotel.com)";
                ErrorLoginLabel.Visible = true;
                return;
            }

            // Login failed
            ErrorLoginLabel.Text = "Email/Password is incorrect. Try again";
            ErrorLoginLabel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void ErrorLoginLabel_Click(object sender, EventArgs e) { }
    }
}