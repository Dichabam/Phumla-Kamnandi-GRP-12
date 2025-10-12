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
            this.viewBookingHostoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.PhoneTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SurnameTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdatebuttonPanel = new System.Windows.Forms.Panel();
            this.standingcomobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.terminateButton = new Guna.UI2.WinForms.Guna2Button();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.Label();
            this.AddGuestPanel = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Createbutton = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.nummaek = new System.Windows.Forms.Label();
            this.CreateNewGuestLabel = new System.Windows.Forms.Label();
            this.Srunamemake = new System.Windows.Forms.Label();
            this.IDNumberLabel = new System.Windows.Forms.Label();
            this.mailmake = new System.Windows.Forms.Label();
            this.AddressTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Namemake = new System.Windows.Forms.Label();
            this.IDNumTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cell = new Guna.UI2.WinForms.Guna2TextBox();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.surname = new Guna.UI2.WinForms.Guna2TextBox();
            this.Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.GuestStandingButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddGuestButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateGuestButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuestDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource1)).BeginInit();
            this.UpdatebuttonPanel.SuspendLayout();
            this.AddGuestPanel.SuspendLayout();
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
            this.PhoneTxtbox.Location = new System.Drawing.Point(160, 131);
            this.PhoneTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneTxtbox.Name = "PhoneTxtbox";
            this.PhoneTxtbox.PlaceholderText = "";
            this.PhoneTxtbox.SelectedText = "";
            this.PhoneTxtbox.Size = new System.Drawing.Size(210, 32);
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
            this.NameTxtBox.Location = new System.Drawing.Point(160, 73);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.PlaceholderText = "";
            this.NameTxtBox.SelectedText = "";
            this.NameTxtBox.Size = new System.Drawing.Size(210, 32);
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
            this.EmailTxtbox.Location = new System.Drawing.Point(475, 131);
            this.EmailTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTxtbox.Name = "EmailTxtbox";
            this.EmailTxtbox.PlaceholderText = "";
            this.EmailTxtbox.SelectedText = "";
            this.EmailTxtbox.Size = new System.Drawing.Size(393, 32);
            this.EmailTxtbox.TabIndex = 27;
            this.EmailTxtbox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
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
            this.SurnameTxtbox.Location = new System.Drawing.Point(475, 73);
            this.SurnameTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SurnameTxtbox.Name = "SurnameTxtbox";
            this.SurnameTxtbox.PlaceholderText = "";
            this.SurnameTxtbox.SelectedText = "";
            this.SurnameTxtbox.Size = new System.Drawing.Size(233, 32);
            this.SurnameTxtbox.TabIndex = 27;
            this.SurnameTxtbox.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // UpdatebuttonPanel
            // 
            this.UpdatebuttonPanel.Controls.Add(this.standingcomobox);
            this.UpdatebuttonPanel.Controls.Add(this.terminateButton);
            this.UpdatebuttonPanel.Controls.Add(this.SaveButton);
            this.UpdatebuttonPanel.Controls.Add(this.label2);
            this.UpdatebuttonPanel.Controls.Add(this.label6);
            this.UpdatebuttonPanel.Controls.Add(this.label1);
            this.UpdatebuttonPanel.Controls.Add(this.label5);
            this.UpdatebuttonPanel.Controls.Add(this.label3);
            this.UpdatebuttonPanel.Controls.Add(this.NameL);
            this.UpdatebuttonPanel.Controls.Add(this.PhoneTxtbox);
            this.UpdatebuttonPanel.Controls.Add(this.EmailTxtbox);
            this.UpdatebuttonPanel.Controls.Add(this.SurnameTxtbox);
            this.UpdatebuttonPanel.Controls.Add(this.NameTxtBox);
            this.UpdatebuttonPanel.Location = new System.Drawing.Point(46, 409);
            this.UpdatebuttonPanel.Name = "UpdatebuttonPanel";
            this.UpdatebuttonPanel.Size = new System.Drawing.Size(890, 288);
            this.UpdatebuttonPanel.TabIndex = 29;
            // 
            // standingcomobox
            // 
            this.standingcomobox.AutoRoundedCorners = true;
            this.standingcomobox.BackColor = System.Drawing.Color.Transparent;
            this.standingcomobox.BorderColor = System.Drawing.Color.SlateGray;
            this.standingcomobox.BorderThickness = 2;
            this.standingcomobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.standingcomobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.standingcomobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.standingcomobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.standingcomobox.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.standingcomobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.standingcomobox.ItemHeight = 30;
            this.standingcomobox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.standingcomobox.Location = new System.Drawing.Point(160, 183);
            this.standingcomobox.Name = "standingcomobox";
            this.standingcomobox.Size = new System.Drawing.Size(140, 36);
            this.standingcomobox.TabIndex = 31;
            // 
            // terminateButton
            // 
            this.terminateButton.Animated = true;
            this.terminateButton.AutoRoundedCorners = true;
            this.terminateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.terminateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.terminateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.terminateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.terminateButton.FillColor = System.Drawing.Color.Red;
            this.terminateButton.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminateButton.ForeColor = System.Drawing.Color.White;
            this.terminateButton.Location = new System.Drawing.Point(810, 3);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(77, 33);
            this.terminateButton.TabIndex = 29;
            this.terminateButton.Text = "close";
            this.terminateButton.Click += new System.EventHandler(this.terminateButton_Click);
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
            this.SaveButton.Location = new System.Drawing.Point(707, 225);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(180, 45);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save Updates";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(303, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "CHANGE ONE OR MORE ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Standing\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(415, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameL.ForeColor = System.Drawing.Color.White;
            this.NameL.Location = new System.Drawing.Point(3, 79);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(56, 23);
            this.NameL.TabIndex = 28;
            this.NameL.Text = "Name";
            // 
            // AddGuestPanel
            // 
            this.AddGuestPanel.Controls.Add(this.guna2Button1);
            this.AddGuestPanel.Controls.Add(this.Createbutton);
            this.AddGuestPanel.Controls.Add(this.label7);
            this.AddGuestPanel.Controls.Add(this.address);
            this.AddGuestPanel.Controls.Add(this.nummaek);
            this.AddGuestPanel.Controls.Add(this.CreateNewGuestLabel);
            this.AddGuestPanel.Controls.Add(this.Srunamemake);
            this.AddGuestPanel.Controls.Add(this.IDNumberLabel);
            this.AddGuestPanel.Controls.Add(this.mailmake);
            this.AddGuestPanel.Controls.Add(this.AddressTxtbox);
            this.AddGuestPanel.Controls.Add(this.Namemake);
            this.AddGuestPanel.Controls.Add(this.IDNumTxtBox);
            this.AddGuestPanel.Controls.Add(this.cell);
            this.AddGuestPanel.Controls.Add(this.email);
            this.AddGuestPanel.Controls.Add(this.surname);
            this.AddGuestPanel.Controls.Add(this.Name);
            this.AddGuestPanel.Location = new System.Drawing.Point(46, 406);
            this.AddGuestPanel.Name = "AddGuestPanel";
            this.AddGuestPanel.Size = new System.Drawing.Size(890, 288);
            this.AddGuestPanel.TabIndex = 29;
            this.AddGuestPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddGuestPanel_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(810, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(77, 33);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "close";
            this.guna2Button1.Click += new System.EventHandler(this.terminateButton1_Click);
            // 
            // Createbutton
            // 
            this.Createbutton.Animated = true;
            this.Createbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Createbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Createbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Createbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Createbutton.FillColor = System.Drawing.Color.LimeGreen;
            this.Createbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Createbutton.ForeColor = System.Drawing.Color.White;
            this.Createbutton.Location = new System.Drawing.Point(707, 225);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(180, 45);
            this.Createbutton.TabIndex = 29;
            this.Createbutton.Text = "Create Guest";
            this.Createbutton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "cell";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(3, 234);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(70, 23);
            this.address.TabIndex = 28;
            this.address.Text = "Address";
            // 
            // nummaek
            // 
            this.nummaek.AutoSize = true;
            this.nummaek.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummaek.ForeColor = System.Drawing.Color.White;
            this.nummaek.Location = new System.Drawing.Point(3, 161);
            this.nummaek.Name = "nummaek";
            this.nummaek.Size = new System.Drawing.Size(35, 23);
            this.nummaek.TabIndex = 28;
            this.nummaek.Text = "cell";
            // 
            // CreateNewGuestLabel
            // 
            this.CreateNewGuestLabel.AutoSize = true;
            this.CreateNewGuestLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewGuestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CreateNewGuestLabel.Location = new System.Drawing.Point(321, 3);
            this.CreateNewGuestLabel.Name = "CreateNewGuestLabel";
            this.CreateNewGuestLabel.Size = new System.Drawing.Size(205, 28);
            this.CreateNewGuestLabel.TabIndex = 28;
            this.CreateNewGuestLabel.Text = "CREATE NEW GUEST";
            // 
            // Srunamemake
            // 
            this.Srunamemake.AutoSize = true;
            this.Srunamemake.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Srunamemake.ForeColor = System.Drawing.Color.White;
            this.Srunamemake.Location = new System.Drawing.Point(392, 112);
            this.Srunamemake.Name = "Srunamemake";
            this.Srunamemake.Size = new System.Drawing.Size(78, 23);
            this.Srunamemake.TabIndex = 28;
            this.Srunamemake.Text = "Surname";
            // 
            // IDNumberLabel
            // 
            this.IDNumberLabel.AutoSize = true;
            this.IDNumberLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNumberLabel.ForeColor = System.Drawing.Color.White;
            this.IDNumberLabel.Location = new System.Drawing.Point(3, 62);
            this.IDNumberLabel.Name = "IDNumberLabel";
            this.IDNumberLabel.Size = new System.Drawing.Size(95, 23);
            this.IDNumberLabel.TabIndex = 28;
            this.IDNumberLabel.Text = "ID Number";
            // 
            // mailmake
            // 
            this.mailmake.AutoSize = true;
            this.mailmake.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailmake.ForeColor = System.Drawing.Color.White;
            this.mailmake.Location = new System.Drawing.Point(415, 161);
            this.mailmake.Name = "mailmake";
            this.mailmake.Size = new System.Drawing.Size(51, 23);
            this.mailmake.TabIndex = 28;
            this.mailmake.Text = "Email";
            // 
            // AddressTxtbox
            // 
            this.AddressTxtbox.AutoRoundedCorners = true;
            this.AddressTxtbox.BorderColor = System.Drawing.Color.SlateGray;
            this.AddressTxtbox.BorderThickness = 2;
            this.AddressTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTxtbox.DefaultText = "";
            this.AddressTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTxtbox.Location = new System.Drawing.Point(160, 225);
            this.AddressTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressTxtbox.Name = "AddressTxtbox";
            this.AddressTxtbox.PlaceholderText = "";
            this.AddressTxtbox.SelectedText = "";
            this.AddressTxtbox.Size = new System.Drawing.Size(391, 32);
            this.AddressTxtbox.TabIndex = 27;
            this.AddressTxtbox.TextChanged += new System.EventHandler(this.IDNumTxtBox_TextChanged);
            // 
            // Namemake
            // 
            this.Namemake.AutoSize = true;
            this.Namemake.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namemake.ForeColor = System.Drawing.Color.White;
            this.Namemake.Location = new System.Drawing.Point(3, 112);
            this.Namemake.Name = "Namemake";
            this.Namemake.Size = new System.Drawing.Size(56, 23);
            this.Namemake.TabIndex = 28;
            this.Namemake.Text = "Name";
            // 
            // IDNumTxtBox
            // 
            this.IDNumTxtBox.AutoRoundedCorners = true;
            this.IDNumTxtBox.BorderColor = System.Drawing.Color.SlateGray;
            this.IDNumTxtBox.BorderThickness = 2;
            this.IDNumTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDNumTxtBox.DefaultText = "";
            this.IDNumTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDNumTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDNumTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDNumTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDNumTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDNumTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDNumTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDNumTxtBox.Location = new System.Drawing.Point(160, 62);
            this.IDNumTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDNumTxtBox.Name = "IDNumTxtBox";
            this.IDNumTxtBox.PlaceholderText = "";
            this.IDNumTxtBox.SelectedText = "";
            this.IDNumTxtBox.Size = new System.Drawing.Size(391, 32);
            this.IDNumTxtBox.TabIndex = 27;
            this.IDNumTxtBox.TextChanged += new System.EventHandler(this.IDNumTxtBox_TextChanged);
            // 
            // cell
            // 
            this.cell.AutoRoundedCorners = true;
            this.cell.BorderColor = System.Drawing.Color.SlateGray;
            this.cell.BorderThickness = 2;
            this.cell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cell.DefaultText = "";
            this.cell.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cell.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cell.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cell.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cell.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cell.Location = new System.Drawing.Point(160, 161);
            this.cell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cell.Name = "cell";
            this.cell.PlaceholderText = "";
            this.cell.SelectedText = "";
            this.cell.Size = new System.Drawing.Size(210, 32);
            this.cell.TabIndex = 27;
            this.cell.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // email
            // 
            this.email.AutoRoundedCorners = true;
            this.email.BorderColor = System.Drawing.Color.SlateGray;
            this.email.BorderThickness = 2;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Location = new System.Drawing.Point(475, 161);
            this.email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email.Name = "email";
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(393, 32);
            this.email.TabIndex = 27;
            this.email.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // surname
            // 
            this.surname.AutoRoundedCorners = true;
            this.surname.BorderColor = System.Drawing.Color.SlateGray;
            this.surname.BorderThickness = 2;
            this.surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surname.DefaultText = "";
            this.surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surname.Location = new System.Drawing.Point(475, 109);
            this.surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surname.Name = "surname";
            this.surname.PlaceholderText = "";
            this.surname.SelectedText = "";
            this.surname.Size = new System.Drawing.Size(233, 32);
            this.surname.TabIndex = 27;
            this.surname.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoRoundedCorners = true;
            this.Name.BorderColor = System.Drawing.Color.SlateGray;
            this.Name.BorderThickness = 2;
            this.Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name.DefaultText = "";
            this.Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name.Location = new System.Drawing.Point(160, 109);
            this.Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name.Name = "Name";
            this.Name.PlaceholderText = "";
            this.Name.SelectedText = "";
            this.Name.Size = new System.Drawing.Size(210, 32);
            this.Name.TabIndex = 27;
            this.Name.TextChanged += new System.EventHandler(this.emailConfirmtextbox_TextChanged);
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
            // FrmGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.AddGuestPanel);
            this.Controls.Add(this.UpdatebuttonPanel);
            this.Controls.Add(this.GuestStandingButton);
            this.Controls.Add(this.ConfirmButtonVBH);
            this.Controls.Add(this.viewBookingHostoryButton);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.UpdateGuestButton);
            this.Controls.Add(this.GuestDataView);
            this.Controls.Add(this.emailConfirmtextbox);
            this.Controls.Add(this.enterEmailTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            this.Text = "FrmGuests";
            ((System.ComponentModel.ISupportInitialize)(this.GuestDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource1)).EndInit();
            this.UpdatebuttonPanel.ResumeLayout(false);
            this.UpdatebuttonPanel.PerformLayout();
            this.AddGuestPanel.ResumeLayout(false);
            this.AddGuestPanel.PerformLayout();
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
        private BindingSource phumlaKamnandiDBDataSetBindingSource1;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTxtbox;
        private Guna.UI2.WinForms.Guna2TextBox NameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxtbox;
        private Guna.UI2.WinForms.Guna2TextBox SurnameTxtbox;
        private Panel UpdatebuttonPanel;
        private Label label2;
        private Label label1;
        private Label NameL;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button terminateButton;
        private Guna.UI2.WinForms.Guna2ComboBox standingcomobox;
        private Panel AddGuestPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button Createbutton;
        private Label nummaek;
        private Label CreateNewGuestLabel;
        private Label Srunamemake;
        private Label IDNumberLabel;
        private Label mailmake;
        private Label Namemake;
        private Guna.UI2.WinForms.Guna2TextBox cell;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2TextBox surname;
        private Guna.UI2.WinForms.Guna2TextBox Name;
        private Guna.UI2.WinForms.Guna2TextBox IDNumTxtBox;
        private Label label7;
        private Label address;
        private Guna.UI2.WinForms.Guna2TextBox AddressTxtbox;
    }
}