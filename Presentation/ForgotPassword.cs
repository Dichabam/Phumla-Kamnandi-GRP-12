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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += ForgotPassword_KeyDown;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Close form when Escape key is pressed
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void SubmitButtonFP_Click(object sender, EventArgs e)
        {
            // TODO: Implement forgot password logic
            // This should:
            // 1. Validate email format
            // 2. Check if email exists in database
            // 3. Send password reset email
            // 4. Show success message
            // 5. Return to login form

            string email = EmailTextboxFP.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Add email validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Implement password reset logic here
            // For now, just show a message
            MessageBox.Show("Password reset instructions have been sent to your email",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close form and return to login
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            // Basic email validation
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

        private void CloseButtonFP_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
