using Phumla_Kamnandi_GRP_12.Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
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

        private void Login_Label_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            ErrorLoginLabel.Visible = false;
        }

        private void guna2Button1_ClickAsync(object sender, EventArgs e)
        {
            // TODO: Add actual authentication logic here
            // For now, this is a placeholder that checks if fields are not empty

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

            // TODO: Replace this with actual authentication against database
            // For now, just check if something was entered
            bool loginSuccessful = ValidateLogin(email, password);

            if (loginSuccessful)
            {
                // Hide current form
                this.Hide();

                // Open Dashboard
                Dashbaord dashboard = new Dashbaord();
                
                dashboard.FormClosed += (s, args) => this.Close(); // Close login when dashboard closes
                dashboard.Show();
            }
            else
            {
                ErrorLoginLabel.Text = "Email/Password is incorrect. Try again";
                ErrorLoginLabel.Visible = true;
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void welcome_2_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void forgotpasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check which link was clicked
            if (sender == forgotpasswordLink)
            {
                // Open Forgot Password form
                ForgotPassword forgotPasswordForm = new ForgotPassword();
                forgotPasswordForm.FormClosed += ForgotPassword_FormClosed;
                this.Hide();
                forgotPasswordForm.Show();
            }
            else if (sender == CreateAccountLink)
            {
                // Open Create Account form
                NewAccount newAccountForm = new NewAccount();
                newAccountForm.FormClosed += NewAccount_FormClosed;
                this.Hide();
                newAccountForm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ErrorLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateLogin(string email, string password)
        {
            // TODO: Implement actual authentication logic
            // This should check against database
            // For now, return true if both fields have values (placeholder)
            try
            {
                // Check if guest exists in the system
                Guest guest = _services.GuestService.GetGuestByEmail(email);

                if (guest != null)
                {
                    // For demo purposes, we'll accept any password for existing users
                    // In production, you would hash and compare passwords

                    // Special check for admin/employee accounts
                    if (email.EndsWith("@phumlakamnandi.co.za") && !string.IsNullOrEmpty(password))
                    {
                        // Store session information
                        _services.CurrentUserEmail = guest.Email;
                        _services.CurrentUserName = guest.FullName;
                        _services.CurrentGuestId = guest.GuestId;
                        return true;
                    }

                    // Regular guest login (simplified for demo)
                    // In production, check password hash
                    if (password.Length >= 4) // Simple validation for demo
                    {
                        _services.CurrentUserEmail = guest.Email;
                        _services.CurrentUserName = guest.FullName;
                        _services.CurrentGuestId = guest.GuestId;
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show login form when forgot password form closes
            this.Show();
        }

        private void NewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show login form when new account form closes
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
    }
}
