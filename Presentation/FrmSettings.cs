/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */

using Guna.UI2.WinForms;
using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using Phumla_Kamnandi_GRP_12.Business.Services;
using Phumla_Kamnandi_GRP_12.Database;
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
    public partial class FrmSettings : Form
    {
        private ServiceLocator _services;
        private EmployeeServiceInterface _employeeService;
        private Employee _currentEmployee;
        private bool _isEditMode = false;

        public FrmSettings()
        {
            InitializeComponent();

            _services = ServiceLocator.Instance;
            var employeeRepo = new EmployeeDB();
            _employeeService = new EmployeeService(employeeRepo);

        
            this.Load += FrmSettings_Load;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
          
            LoadCurrentUserDetails();

         
            SetTextBoxesReadOnly(true);

          
            if (Errorsuccessmessage != null)
            {
                Errorsuccessmessage.Visible = false;
            }

          
            EditUpdateButton.Text = "Edit";

          
            currentPasswordTextBox.UseSystemPasswordChar = false;
            NewPasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void LoadCurrentUserDetails()
        {
            try
            {
              
                string currentUserId = _services.CurrentUserId;

                if (string.IsNullOrEmpty(currentUserId))
                {
                    ShowMessage("No user is currently logged in.", false);
                    return;
                }

                _currentEmployee = _employeeService.GetEmployeeById(currentUserId);

                if (_currentEmployee != null)
                {
                    NametextEm.Text = _currentEmployee.FirstName;
                    surnameTextBox.Text = _currentEmployee.LastName;
                    PhonetextBoxEm.Text = _currentEmployee.Phone;
                    EmailTxtBoxEm.Text = _currentEmployee.Email;
                }
                else
                {
                    ShowMessage("Failed to load user details.", false);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error loading user details: {ex.Message}", false);
            }
        }

        private void SetTextBoxesReadOnly(bool readOnly)
        {
            NametextEm.ReadOnly = readOnly;
            surnameTextBox.ReadOnly = readOnly;
            PhonetextBoxEm.ReadOnly = readOnly;
            EmailTxtBoxEm.ReadOnly = true;

           
            Color fillColor = readOnly ? Color.FromArgb(240, 240, 240) : Color.White;

            NametextEm.FillColor = fillColor;
            surnameTextBox.FillColor = fillColor;
            PhonetextBoxEm.FillColor = fillColor;
            EmailTxtBoxEm.FillColor = fillColor;
        }

        private void EditUpdateButton_Click(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
               
                _isEditMode = true;
                EditUpdateButton.Text = "Update";
                EditUpdateButton.FillColor = Color.ForestGreen;
                SetTextBoxesReadOnly(false);
                ShowMessage("You can now edit your details.", true);
            }
            else
            {
                EditUpdateButton.FillColor = Color.FromArgb(94, 148, 255);
                UpdateUserDetails();
                SetTextBoxesReadOnly(true);
            }
            

        }

        private void UpdateUserDetails()
        {
            try
            {
              
                if (string.IsNullOrWhiteSpace(NametextEm.Text) ||string.IsNullOrWhiteSpace(surnameTextBox.Text) ||string.IsNullOrWhiteSpace(PhonetextBoxEm.Text) ||string.IsNullOrWhiteSpace(EmailTxtBoxEm.Text))
                {
                    ShowMessage("Please fill in all fields.", false);
                    return;
                }

              
                if (!IsValidEmail(EmailTxtBoxEm.Text.Trim()))
                {
                    ShowMessage("Please enter a valid email address.", false);
                    return;
                }

                if (PhonetextBoxEm.Text.Trim().Length < 10)
                {
                    ShowMessage("Please enter a valid phone number (at least 10 digits).", false);
                    return;
                }

                bool success = _employeeService.GetEmployeeById(_currentEmployee.EmployeeId) != null;

                if (success)
                {

                    _currentEmployee.UpdateContactInfo(
                        EmailTxtBoxEm.Text.Trim(),
                        PhonetextBoxEm.Text.Trim()
                    );


                    var employeeRepo = new EmployeeDB();
                    employeeRepo.Update(_currentEmployee);


                    ShowMessage("Details updated successfully!", true);


                    _isEditMode = false;
                    EditUpdateButton.Text = "Edit";
                    SetTextBoxesReadOnly(true);

                    LoadCurrentUserDetails();
                }
                else
                {
                    ShowMessage("Failed to update details.", false);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error updating details: {ex.Message}", false);
            }
        }

        private void CHnagepasswordButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(currentPasswordTextBox.Text) ||
                    string.IsNullOrWhiteSpace(NewPasswordTextBox.Text) ||
                    string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
                {
                    ShowMessage("Please fill in all password fields.", false);
                    return;
                }


                if (NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                {
                    ShowMessage("New password and confirmation do not match.", false);
                    return;
                }


                if (NewPasswordTextBox.Text.Length < 6)
                {
                    ShowMessage("New password must be at least 8 characters long.", false);
                    return;
                }


                var employee = _employeeService.AuthenticateEmployee(
                    _currentEmployee.Email,
                    currentPasswordTextBox.Text
                );

                if (employee == null)
                {
                    ShowMessage("Current password is incorrect.", false);
                    return;
                }


                bool success = _employeeService.UpdateEmployeePassword( _currentEmployee.EmployeeId,currentPasswordTextBox.Text,NewPasswordTextBox.Text);

                if (success)
                {
                    ShowMessage("Password changed successfully!", true);

                    currentPasswordTextBox.Clear();
                    NewPasswordTextBox.Clear();
                    ConfirmPasswordTextBox.Clear();
                }
                else
                {
                    ShowMessage("Failed to change password. Please try again.", false);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error changing password: {ex.Message}", false);
            }
        }

        private void ShowMessage(string message, bool isSuccess)
        {
            if (Errorsuccessmessage != null)
            {
                string caption = isSuccess ? "Success" : "Error";
                MessageBoxIcon icon = isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error;

                MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
            }
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

        #region irrelevant methods
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextEm_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region view password buttons
        private void viewPasswordButton_Click(object sender, EventArgs e)
        {
            if (currentPasswordTextBox.UseSystemPasswordChar)
            {
                currentPasswordTextBox.UseSystemPasswordChar = false;
                viewPasswordButton.Image = Properties.Resources.visibility_off_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
            else
            {
                currentPasswordTextBox.UseSystemPasswordChar = true;
                viewPasswordButton.Image = Properties.Resources.visibility_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
        }

        private void viewPasswordButton2_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.UseSystemPasswordChar)
            {
                NewPasswordTextBox.UseSystemPasswordChar = false;
                viewPasswordButton2.Image = Properties.Resources.visibility_off_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
            else
            {
                NewPasswordTextBox.UseSystemPasswordChar = true;
                viewPasswordButton2.Image = Properties.Resources.visibility_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
        }

        private void viewPasswordButton3_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.UseSystemPasswordChar)
            {
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
                viewPasswordButton3.Image = Properties.Resources.visibility_off_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
            else
            {
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
                viewPasswordButton3.Image = Properties.Resources.visibility_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            }
        }
        #endregion
    }
}