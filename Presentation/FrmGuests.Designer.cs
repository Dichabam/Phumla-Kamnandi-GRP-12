using System;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmGuests
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GuestDataView = new System.Windows.Forms.DataGridView();
            this.phumlaKamnandiDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phumlaKamnandiDBDataSet = new Phumla_Kamnandi_GRP_12.PhumlaKamnandiDBDataSet();
            this.phumlaKamnandiDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emailConfirmtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.enterEmailTextbox = new System.Windows.Forms.Label();
            this.ConfirmButtonVBH = new Guna.UI2.WinForms.Guna2Button();
            this.ErrorLableVBH = new System.Windows.Forms.Label();
            this.viewBookingHostoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.GuestStandingButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddGuestButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateGuestButton = new Guna.UI2.WinForms.Guna2Button();
            this.PhoneTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AdressTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SurnameTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreditcardNumTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdatebuttonPanel = new System.Windows.Forms.Panel();
            this.NameL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GuestDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource1)).BeginInit();
            this.UpdatebuttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuestDataView
            // 
            this.GuestDataView.AllowUserToAddRows = false;
            this.GuestDataView.AllowUserToDeleteRows = false;
            this.GuestDataView.AutoGenerateColumns = false;
            this.GuestDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestDataView.DataSource = this.phumlaKamnandiDBDataSetBindingSource;
            this.GuestDataView.Location = new System.Drawing.Point(63, 12);
            this.GuestDataView.Name = "GuestDataView";
            this.GuestDataView.ReadOnly = true;
            this.GuestDataView.RowHeadersWidth = 51;
            this.GuestDataView.RowTemplate.Height = 24;
            this.GuestDataView.Size = new System.Drawing.Size(830, 312);
            this.GuestDataView.TabIndex = 25;
            this.GuestDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GuestDataView_CellContentClick);
            // 
            // phumlaKamnandiDBDataSetBindingSource
            // 
            this.phumlaKamnandiDBDataSetBindingSource.DataSource = this.phumlaKamnandiDBDataSet;
            this.phumlaKamnandiDBDataSetBindingSource.Position = 0;
            // 
            // phumlaKamnandiDBDataSet
            // 
            this.phumlaKamnandiDBDataSet.DataSetName = "PhumlaKamnandiDBDataSet";
            this.phumlaKamnandiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phumlaKamnandiDBDataSetBindingSource1
            // 
            this.phumlaKamnandiDBDataSetBindingSource1.DataSource = this.phumlaKamnandiDBDataSet;
            this.phumlaKamnandiDBDataSetBindingSource1.Position = 0;
            // 
            // emailConfirmtextbox
            // 
            this.emailConfirmtextbox.AutoRoundedCorners = true;
            this.emailConfirmtextbox.BorderColor = System.Drawing.Color.SlateGray;
            this.emailConfirmtextbox.BorderThickness = 2;
            this.emailConfirmtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailConfirmtextbox.DefaultText = "";
            this.emailConfirmtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailConfirmtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailConfirmtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailConfirmtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailConfirmtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailConfirmtextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailConfirmtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailConfirmtextbox.Location = new System.Drawing.Point(236, 454);
            this.emailConfirmtextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailConfirmtextbox.Name = "emailConfirmtextbox";
            this.emailConfirmtextbox.PlaceholderText = "";
            this.emailConfirmtextbox.SelectedText = "";
            this.emailConfirmtextbox.Size = new System.Drawing.Size(422, 48);
            this.emailConfirmtextbox.TabIndex = 27;
            this.emailConfirmtextbox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // enterEmailTextbox
            // 
            this.enterEmailTextbox.AutoSize = true;
            this.enterEmailTextbox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEmailTextbox.ForeColor = System.Drawing.Color.White;
            this.enterEmailTextbox.Location = new System.Drawing.Point(59, 470);
            this.enterEmailTextbox.Name = "enterEmailTextbox";
            this.enterEmailTextbox.Size = new System.Drawing.Size(151, 23);
            this.enterEmailTextbox.TabIndex = 28;
            this.enterEmailTextbox.Text = "Enter Guest Email";
            // 
            // ConfirmButtonVBH
            // 
            this.ConfirmButtonVBH.AutoRoundedCorners = true;
            this.ConfirmButtonVBH.BorderColor = System.Drawing.Color.LimeGreen;
            this.ConfirmButtonVBH.BorderThickness = 2;
            this.ConfirmButtonVBH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmButtonVBH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmButtonVBH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmButtonVBH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmButtonVBH.FillColor = System.Drawing.Color.LimeGreen;
            this.ConfirmButtonVBH.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.ConfirmButtonVBH.ForeColor = System.Drawing.Color.White;
            this.ConfirmButtonVBH.Location = new System.Drawing.Point(713, 454);
            this.ConfirmButtonVBH.Name = "ConfirmButtonVBH";
            this.ConfirmButtonVBH.Size = new System.Drawing.Size(180, 45);
            this.ConfirmButtonVBH.TabIndex = 26;
            this.ConfirmButtonVBH.Text = "Confirm";
            this.ConfirmButtonVBH.Click += new System.EventHandler(this.ConfirmButtonVBH_Click);
            // 
            // ErrorLableVBH
            // 
            this.ErrorLableVBH.AutoSize = true;
            this.ErrorLableVBH.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLableVBH.ForeColor = System.Drawing.Color.Red;
            this.ErrorLableVBH.Location = new System.Drawing.Point(241, 518);
            this.ErrorLableVBH.Name = "ErrorLableVBH";
            this.ErrorLableVBH.Size = new System.Drawing.Size(140, 23);
            this.ErrorLableVBH.TabIndex = 28;
            this.ErrorLableVBH.Text = "Guest not found";
            // 
            // viewBookingHostoryButton
            // 
            this.viewBookingHostoryButton.AutoRoundedCorners = true;
            this.viewBookingHostoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewBookingHostoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewBookingHostoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewBookingHostoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewBookingHostoryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.viewBookingHostoryButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookingHostoryButton.ForeColor = System.Drawing.Color.White;
            this.viewBookingHostoryButton.Location = new System.Drawing.Point(499, 349);
            this.viewBookingHostoryButton.Name = "viewBookingHostoryButton";
            this.viewBookingHostoryButton.Size = new System.Drawing.Size(180, 45);
            this.viewBookingHostoryButton.TabIndex = 26;
            this.viewBookingHostoryButton.Text = "View Booking History";
            this.viewBookingHostoryButton.Click += new System.EventHandler(this.ViewBookingHistoryButton_Click);
            // 
            // GuestStandingButton
            // 
            this.GuestStandingButton.AutoRoundedCorners = true;
            this.GuestStandingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GuestStandingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GuestStandingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GuestStandingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GuestStandingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GuestStandingButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestStandingButton.ForeColor = System.Drawing.Color.White;
            this.GuestStandingButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.man_4_50dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.GuestStandingButton.Location = new System.Drawing.Point(713, 349);
            this.GuestStandingButton.Name = "GuestStandingButton";
            this.GuestStandingButton.Size = new System.Drawing.Size(180, 45);
            this.GuestStandingButton.TabIndex = 26;
            this.GuestStandingButton.Text = "Guest standing";
            this.GuestStandingButton.Click += new System.EventHandler(this.GuestStandingButton_Click);
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.AutoRoundedCorners = true;
            this.AddGuestButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddGuestButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddGuestButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddGuestButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddGuestButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AddGuestButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuestButton.ForeColor = System.Drawing.Color.White;
            this.AddGuestButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.add_50dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.AddGuestButton.Location = new System.Drawing.Point(285, 349);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(180, 45);
            this.AddGuestButton.TabIndex = 26;
            this.AddGuestButton.Text = "Add Guest";
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // UpdateGuestButton
            // 
            this.UpdateGuestButton.AutoRoundedCorners = true;
            this.UpdateGuestButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateGuestButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateGuestButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateGuestButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateGuestButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UpdateGuestButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateGuestButton.ForeColor = System.Drawing.Color.White;
            this.UpdateGuestButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.update_50dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.UpdateGuestButton.Location = new System.Drawing.Point(63, 349);
            this.UpdateGuestButton.Name = "UpdateGuestButton";
            this.UpdateGuestButton.Size = new System.Drawing.Size(180, 45);
            this.UpdateGuestButton.TabIndex = 26;
            this.UpdateGuestButton.Text = "Update Guest";
            this.UpdateGuestButton.Click += new System.EventHandler(this.UpdateGuestButton_Click);
            // 
            // PhoneTxtbox
            // 
            this.PhoneTxtbox.AutoRoundedCorners = true;
            this.PhoneTxtbox.BorderColor = System.Drawing.Color.SlateGray;
            this.PhoneTxtbox.BorderThickness = 2;
            this.PhoneTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTxtbox.DefaultText = "";
            this.PhoneTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTxtbox.Location = new System.Drawing.Point(139, 104);
            this.PhoneTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneTxtbox.Name = "PhoneTxtbox";
            this.PhoneTxtbox.PlaceholderText = "";
            this.PhoneTxtbox.SelectedText = "";
            this.PhoneTxtbox.Size = new System.Drawing.Size(233, 32);
            this.PhoneTxtbox.TabIndex = 27;
            this.PhoneTxtbox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.AutoRoundedCorners = true;
            this.NameTxtBox.BorderColor = System.Drawing.Color.SlateGray;
            this.NameTxtBox.BorderThickness = 2;
            this.NameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxtBox.DefaultText = "";
            this.NameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxtBox.Location = new System.Drawing.Point(85, 53);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.PlaceholderText = "";
            this.NameTxtBox.SelectedText = "";
            this.NameTxtBox.Size = new System.Drawing.Size(233, 32);
            this.NameTxtBox.TabIndex = 27;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // EmailTxtbox
            // 
            this.EmailTxtbox.AutoRoundedCorners = true;
            this.EmailTxtbox.BorderColor = System.Drawing.Color.SlateGray;
            this.EmailTxtbox.BorderThickness = 2;
            this.EmailTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtbox.DefaultText = "";
            this.EmailTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtbox.Location = new System.Drawing.Point(458, 104);
            this.EmailTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTxtbox.Name = "EmailTxtbox";
            this.EmailTxtbox.PlaceholderText = "";
            this.EmailTxtbox.SelectedText = "";
            this.EmailTxtbox.Size = new System.Drawing.Size(393, 32);
            this.EmailTxtbox.TabIndex = 27;
            this.EmailTxtbox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // AdressTxtBox
            // 
            this.AdressTxtBox.AutoRoundedCorners = true;
            this.AdressTxtBox.BorderColor = System.Drawing.Color.SlateGray;
            this.AdressTxtBox.BorderThickness = 2;
            this.AdressTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdressTxtBox.DefaultText = "";
            this.AdressTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdressTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdressTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdressTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdressTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdressTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AdressTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdressTxtBox.Location = new System.Drawing.Point(151, 158);
            this.AdressTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdressTxtBox.Name = "AdressTxtBox";
            this.AdressTxtBox.PlaceholderText = "";
            this.AdressTxtBox.SelectedText = "";
            this.AdressTxtBox.Size = new System.Drawing.Size(700, 32);
            this.AdressTxtBox.TabIndex = 27;
            this.AdressTxtBox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // SurnameTxtbox
            // 
            this.SurnameTxtbox.AutoRoundedCorners = true;
            this.SurnameTxtbox.BorderColor = System.Drawing.Color.SlateGray;
            this.SurnameTxtbox.BorderThickness = 2;
            this.SurnameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SurnameTxtbox.DefaultText = "";
            this.SurnameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SurnameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SurnameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SurnameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SurnameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SurnameTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SurnameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SurnameTxtbox.Location = new System.Drawing.Point(475, 53);
            this.SurnameTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SurnameTxtbox.Name = "SurnameTxtbox";
            this.SurnameTxtbox.PlaceholderText = "";
            this.SurnameTxtbox.SelectedText = "";
            this.SurnameTxtbox.Size = new System.Drawing.Size(233, 32);
            this.SurnameTxtbox.TabIndex = 27;
            this.SurnameTxtbox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // CreditcardNumTxtbox
            // 
            this.CreditcardNumTxtbox.AutoRoundedCorners = true;
            this.CreditcardNumTxtbox.BorderColor = System.Drawing.Color.SlateGray;
            this.CreditcardNumTxtbox.BorderThickness = 2;
            this.CreditcardNumTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreditcardNumTxtbox.DefaultText = "";
            this.CreditcardNumTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CreditcardNumTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CreditcardNumTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreditcardNumTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CreditcardNumTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreditcardNumTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreditcardNumTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreditcardNumTxtbox.Location = new System.Drawing.Point(182, 215);
            this.CreditcardNumTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreditcardNumTxtbox.Name = "CreditcardNumTxtbox";
            this.CreditcardNumTxtbox.PlaceholderText = "";
            this.CreditcardNumTxtbox.SelectedText = "";
            this.CreditcardNumTxtbox.Size = new System.Drawing.Size(392, 32);
            this.CreditcardNumTxtbox.TabIndex = 27;
            this.CreditcardNumTxtbox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // UpdatebuttonPanel
            // 
            this.UpdatebuttonPanel.Controls.Add(this.SaveButton);
            this.UpdatebuttonPanel.Controls.Add(this.label2);
            this.UpdatebuttonPanel.Controls.Add(this.label6);
            this.UpdatebuttonPanel.Controls.Add(this.label1);
            this.UpdatebuttonPanel.Controls.Add(this.label4);
            this.UpdatebuttonPanel.Controls.Add(this.label5);
            this.UpdatebuttonPanel.Controls.Add(this.label3);
            this.UpdatebuttonPanel.Controls.Add(this.NameL);
            this.UpdatebuttonPanel.Controls.Add(this.CreditcardNumTxtbox);
            this.UpdatebuttonPanel.Controls.Add(this.PhoneTxtbox);
            this.UpdatebuttonPanel.Controls.Add(this.EmailTxtbox);
            this.UpdatebuttonPanel.Controls.Add(this.AdressTxtBox);
            this.UpdatebuttonPanel.Controls.Add(this.SurnameTxtbox);
            this.UpdatebuttonPanel.Controls.Add(this.NameTxtBox);
            this.UpdatebuttonPanel.Location = new System.Drawing.Point(49, 414);
            this.UpdatebuttonPanel.Name = "UpdatebuttonPanel";
            this.UpdatebuttonPanel.Size = new System.Drawing.Size(876, 273);
            this.UpdatebuttonPanel.TabIndex = 29;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameL.ForeColor = System.Drawing.Color.White;
            this.NameL.Location = new System.Drawing.Point(6, 56);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(57, 23);
            this.NameL.TabIndex = 28;
            this.NameL.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(398, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Physical Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Credit Card Number";
            // 
            // SaveButton
            // 
            this.SaveButton.Animated = true;
            this.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveButton.FillColor = System.Drawing.Color.LimeGreen;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(650, 211);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(180, 45);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save Updates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(315, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "CHANGE ONE OR MORE ";
            // 
            // FrmGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.UpdatebuttonPanel);
            this.Controls.Add(this.GuestStandingButton);
            this.Controls.Add(this.ConfirmButtonVBH);
            this.Controls.Add(this.viewBookingHostoryButton);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.UpdateGuestButton);
            this.Controls.Add(this.GuestDataView);
            this.Controls.Add(this.emailConfirmtextbox);
            this.Controls.Add(this.enterEmailTextbox);
            this.Controls.Add(this.ErrorLableVBH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGuests";
            this.Text = "FrmGuests";
            ((System.ComponentModel.ISupportInitialize)(this.GuestDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource1)).EndInit();
            this.UpdatebuttonPanel.ResumeLayout(false);
            this.UpdatebuttonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        #endregion
        private System.Windows.Forms.DataGridView GuestDataView;
        private System.Windows.Forms.BindingSource phumlaKamnandiDBDataSetBindingSource;
        private PhumlaKamnandiDBDataSet phumlaKamnandiDBDataSet;
        private Guna.UI2.WinForms.Guna2Button UpdateGuestButton;
        private Guna.UI2.WinForms.Guna2Button AddGuestButton;
        private Guna.UI2.WinForms.Guna2Button viewBookingHostoryButton;
        private Guna.UI2.WinForms.Guna2Button GuestStandingButton;
        private Guna.UI2.WinForms.Guna2TextBox emailConfirmtextbox;
        private System.Windows.Forms.Label enterEmailTextbox;
        private Guna.UI2.WinForms.Guna2Button ConfirmButtonVBH;
        private System.Windows.Forms.Label ErrorLableVBH;
        private BindingSource phumlaKamnandiDBDataSetBindingSource1;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTxtbox;
        private Guna.UI2.WinForms.Guna2TextBox NameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxtbox;
        private Guna.UI2.WinForms.Guna2TextBox AdressTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox SurnameTxtbox;
        private Guna.UI2.WinForms.Guna2TextBox CreditcardNumTxtbox;
        private Panel UpdatebuttonPanel;
        private Label label2;
        private Label label1;
        private Label NameL;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Label label5;
        private Label label6;
    }
}