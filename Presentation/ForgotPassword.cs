/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */

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
        private ServiceLocator _services;
        public ForgotPassword()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
            this.KeyPreview = true;
            this.KeyDown += ForgotPassword_KeyDown;
            ErrorEmailLabel.Visible = false;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // press escape button to close form 
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

         
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Password reset instructions have been sent to your email",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
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

        private void CloseButtonFP_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void ErrorEmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButtonFP_Click_1(object sender, EventArgs e)
        {
            string email = EmailTextboxFP.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                ErrorEmailLabel.Text = "Please enter your work email";
                ErrorEmailLabel.Visible = true;
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                ErrorEmailLabel.Text = "Please enter a valid email address";
                ErrorEmailLabel.Visible = true;
                return;
            }

            // Check if it's a work email
            if (!email.EndsWith("@pkhotel.com"))
            {
                ErrorEmailLabel.Text = "Please use your work email (@pkhotel.com)";
                ErrorEmailLabel.Visible = true;
                return;
            }

            // Check if email exists in system
            var employee = _services.EmployeeService.GetEmployeeByEmail(email);
            if (employee == null)
            {
                ErrorEmailLabel.Text = "Email does not exist in system";
                ErrorEmailLabel.Visible = true;
                return;
            }

            // Email exists, proceed to admin code verification for password reset
            AdminCode adminForm = new AdminCode(email, true); // true indicates password reset
            adminForm.FormClosed += (s, args) => this.Close();
            adminForm.Show();
            this.Hide();
        }

        private void EmailTextboxFP_TextChanged(object sender, EventArgs e)
        {
            ErrorEmailLabel.Visible = false;
        }

        private void SidePanelFP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
