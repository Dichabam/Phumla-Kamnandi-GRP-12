using Phumla_Kamnandi_GRP_12.Business.Entities;
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
    public partial class NewAccount : Form
    {
        private ServiceLocator _services;
        public NewAccount()
        {
            InitializeComponent();
            _services = ServiceLocator.Instance;
        }

        private void EmailTextboxCA_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButtonCA_Click(object sender, EventArgs e)
        {

        }

        private void SidePanelFP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateNewAccountLabel_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButtonCAEMP_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void CellLabelCAEMP_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabelCAEMP_Click(object sender, EventArgs e)
        {

        }

        private void NextButtonCAEMP_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            // Store the details temporarily and move to password form
            var passwordForm = new PasswordForm(
                NameTextboxCA.Text.Trim(),
                SurnameTextboxCA.Text.Trim(),
                CellTextboxCAEMP.Text.Trim(),
                EmailTextboxCAEMP.Text.Trim(),
                false // isPasswordReset = false
            );
            passwordForm.FormClosed += (s, args) => this.Close();
            passwordForm.Show();
            this.Hide();
        }
        

        private bool ValidateInputs()
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(NameTextboxCA.Text))
            {
                MessageBox.Show("Please enter your name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NameTextboxCA.Focus();
                return false;
            }

            // Validate Surname
            if (string.IsNullOrWhiteSpace(SurnameTextboxCA.Text))
            {
                MessageBox.Show("Please enter your surname", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SurnameTextboxCA.Focus();
                return false;
            }

            // Validate Phone
            if (string.IsNullOrWhiteSpace(CellTextboxCAEMP.Text))
            {
                MessageBox.Show("Please enter your phone number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CellTextboxCAEMP.Focus();
                return false;
            }

            // Validate phone format (South African format)
            string phone = CellTextboxCAEMP.Text.Trim();
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Please enter a valid phone number (10 digits)",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CellTextboxCAEMP.Focus();
                return false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(EmailTextboxCAEMP.Text))
            {
                MessageBox.Show("Please enter your email address", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTextboxCAEMP.Focus();
                return false;
            }

            if (!IsValidEmail(EmailTextboxCAEMP.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailTextboxCAEMP.Focus();
                return false;
            }

            // Check if email already exists
            Guest existingGuest = _services.GuestService.GetGuestByEmail(EmailTextboxCAEMP.Text.Trim());
            if (existingGuest != null)
            {
                MessageBox.Show("An account with this email already exists. Please login instead.",
                    "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool IsValidPhoneNumber(string phone)
        {
            // Remove spaces and special characters
            string cleanPhone = phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");

            // Check if it's 10 digits (South African format)
            if (cleanPhone.Length == 10 && cleanPhone.All(char.IsDigit))
            {
                return true;
            }

            // accept international format with +27
            if (cleanPhone.StartsWith("+27") && cleanPhone.Length == 12 &&
                cleanPhone.Substring(1).All(char.IsDigit))
            {
                return true;
            }

            return false;
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

        private string GenerateDefaultAddress()
        {
            // Generate a default address - can be updated later by the guest
            return "Address to be provided";
        }

        
    }
}
