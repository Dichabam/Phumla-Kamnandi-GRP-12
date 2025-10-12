namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmBookings
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
            this.ShowdataGridView = new System.Windows.Forms.DataGridView();
            this.phumlaKamnandiDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phumlaKamnandiDBDataSet = new Phumla_Kamnandi_GRP_12.PhumlaKamnandiDBDataSet();
            this.phumlaKamnandiDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.SpecialRequestlabel = new System.Windows.Forms.Label();
            this.Childrenlabel = new System.Windows.Forms.Label();
            this.Occupancylabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CreditCardlabel = new System.Windows.Forms.Label();
            this.NoOfAdultsLabel = new System.Windows.Forms.Label();
            this.YesNoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.surnametextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phonetextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addresstextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.adultstextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.childrentextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.specialrequestTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.creditTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.checkoutlabel = new System.Windows.Forms.Label();
            this.checkindp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkoutdp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SubmitButton = new Guna.UI2.WinForms.Guna2Button();
            this.MakeBookingButton = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBookingButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdatebookingButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.IdNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowdataGridView
            // 
            this.ShowdataGridView.AllowDrop = true;
            this.ShowdataGridView.AllowUserToAddRows = false;
            this.ShowdataGridView.AllowUserToDeleteRows = false;
            this.ShowdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowdataGridView.Location = new System.Drawing.Point(53, 6);
            this.ShowdataGridView.Name = "ShowdataGridView";
            this.ShowdataGridView.RowHeadersWidth = 51;
            this.ShowdataGridView.RowTemplate.Height = 24;
            this.ShowdataGridView.Size = new System.Drawing.Size(844, 236);
            this.ShowdataGridView.TabIndex = 27;
            this.ShowdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(532, 436);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(31, 17);
            this.PhoneNumberLabel.TabIndex = 33;
            this.PhoneNumberLabel.Text = "Cell";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLabel.Location = new System.Drawing.Point(38, 336);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 17);
            this.NameLabel.TabIndex = 34;
            this.NameLabel.Text = "Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddressLabel.Location = new System.Drawing.Point(40, 436);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(111, 17);
            this.AddressLabel.TabIndex = 56;
            this.AddressLabel.Text = "Physical Address";
            // 
            // SpecialRequestlabel
            // 
            this.SpecialRequestlabel.AutoSize = true;
            this.SpecialRequestlabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialRequestlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpecialRequestlabel.Location = new System.Drawing.Point(36, 545);
            this.SpecialRequestlabel.Name = "SpecialRequestlabel";
            this.SpecialRequestlabel.Size = new System.Drawing.Size(104, 17);
            this.SpecialRequestlabel.TabIndex = 60;
            this.SpecialRequestlabel.Text = "Special Request";
            // 
            // Childrenlabel
            // 
            this.Childrenlabel.AutoSize = true;
            this.Childrenlabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Childrenlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Childrenlabel.Location = new System.Drawing.Point(327, 488);
            this.Childrenlabel.Name = "Childrenlabel";
            this.Childrenlabel.Size = new System.Drawing.Size(137, 17);
            this.Childrenlabel.TabIndex = 63;
            this.Childrenlabel.Text = "Number Of Children ";
            // 
            // Occupancylabel
            // 
            this.Occupancylabel.AutoSize = true;
            this.Occupancylabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Occupancylabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Occupancylabel.Location = new System.Drawing.Point(629, 488);
            this.Occupancylabel.Name = "Occupancylabel";
            this.Occupancylabel.Size = new System.Drawing.Size(122, 17);
            this.Occupancylabel.TabIndex = 65;
            this.Occupancylabel.Text = "IsSingleOccupancy";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SurnameLabel.Location = new System.Drawing.Point(415, 336);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(62, 17);
            this.SurnameLabel.TabIndex = 34;
            this.SurnameLabel.Text = "Surname";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailLabel.Location = new System.Drawing.Point(40, 388);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 34;
            this.EmailLabel.Text = "Email";
            // 
            // CreditCardlabel
            // 
            this.CreditCardlabel.AutoSize = true;
            this.CreditCardlabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreditCardlabel.Location = new System.Drawing.Point(415, 545);
            this.CreditCardlabel.Name = "CreditCardlabel";
            this.CreditCardlabel.Size = new System.Drawing.Size(125, 17);
            this.CreditCardlabel.TabIndex = 61;
            this.CreditCardlabel.Text = "credit card number";
            // 
            // NoOfAdultsLabel
            // 
            this.NoOfAdultsLabel.AutoSize = true;
            this.NoOfAdultsLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfAdultsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoOfAdultsLabel.Location = new System.Drawing.Point(36, 488);
            this.NoOfAdultsLabel.Name = "NoOfAdultsLabel";
            this.NoOfAdultsLabel.Size = new System.Drawing.Size(125, 17);
            this.NoOfAdultsLabel.TabIndex = 63;
            this.NoOfAdultsLabel.Text = "Number Of Adults ";
            // 
            // YesNoComboBox
            // 
            this.YesNoComboBox.AutoRoundedCorners = true;
            this.YesNoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.YesNoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.YesNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YesNoComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YesNoComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YesNoComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.YesNoComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.YesNoComboBox.ItemHeight = 30;
            this.YesNoComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.YesNoComboBox.Location = new System.Drawing.Point(774, 485);
            this.YesNoComboBox.Name = "YesNoComboBox";
            this.YesNoComboBox.Size = new System.Drawing.Size(140, 36);
            this.YesNoComboBox.TabIndex = 70;
            this.YesNoComboBox.SelectedIndexChanged += new System.EventHandler(this.YesNoComboBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoRoundedCorners = true;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.DefaultText = "";
            this.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTextBox.Location = new System.Drawing.Point(97, 327);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(277, 33);
            this.NameTextBox.TabIndex = 71;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // emailtextbox
            // 
            this.emailtextbox.AutoRoundedCorners = true;
            this.emailtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtextbox.DefaultText = "";
            this.emailtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtextbox.Location = new System.Drawing.Point(97, 377);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.PlaceholderText = "";
            this.emailtextbox.SelectedText = "";
            this.emailtextbox.Size = new System.Drawing.Size(426, 33);
            this.emailtextbox.TabIndex = 71;
            this.emailtextbox.TextChanged += new System.EventHandler(this.emailtextbox_TextChanged);
            // 
            // surnametextbox
            // 
            this.surnametextbox.AutoRoundedCorners = true;
            this.surnametextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnametextbox.DefaultText = "";
            this.surnametextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surnametextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surnametextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnametextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnametextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnametextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.surnametextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnametextbox.Location = new System.Drawing.Point(504, 327);
            this.surnametextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surnametextbox.Name = "surnametextbox";
            this.surnametextbox.PlaceholderText = "";
            this.surnametextbox.SelectedText = "";
            this.surnametextbox.Size = new System.Drawing.Size(229, 33);
            this.surnametextbox.TabIndex = 71;
            this.surnametextbox.TextChanged += new System.EventHandler(this.surnametextBox_TextChanged);
            // 
            // phonetextbox
            // 
            this.phonetextbox.AutoRoundedCorners = true;
            this.phonetextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonetextbox.DefaultText = "";
            this.phonetextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phonetextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phonetextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phonetextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetextbox.Location = new System.Drawing.Point(582, 436);
            this.phonetextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.PlaceholderText = "";
            this.phonetextbox.SelectedText = "";
            this.phonetextbox.Size = new System.Drawing.Size(229, 33);
            this.phonetextbox.TabIndex = 71;
            this.phonetextbox.TextChanged += new System.EventHandler(this.phoneNumberTextbox_TextChanged);
            // 
            // addresstextbox
            // 
            this.addresstextbox.AutoRoundedCorners = true;
            this.addresstextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addresstextbox.DefaultText = "";
            this.addresstextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addresstextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addresstextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addresstextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstextbox.Location = new System.Drawing.Point(181, 436);
            this.addresstextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.PlaceholderText = "";
            this.addresstextbox.SelectedText = "";
            this.addresstextbox.Size = new System.Drawing.Size(319, 33);
            this.addresstextbox.TabIndex = 71;
            this.addresstextbox.TextChanged += new System.EventHandler(this.addresstextbox_TextChanged);
            // 
            // adultstextbox
            // 
            this.adultstextbox.AutoRoundedCorners = true;
            this.adultstextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adultstextbox.DefaultText = "";
            this.adultstextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adultstextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adultstextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adultstextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adultstextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adultstextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adultstextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adultstextbox.Location = new System.Drawing.Point(181, 488);
            this.adultstextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adultstextbox.Name = "adultstextbox";
            this.adultstextbox.PlaceholderText = "";
            this.adultstextbox.SelectedText = "";
            this.adultstextbox.Size = new System.Drawing.Size(104, 33);
            this.adultstextbox.TabIndex = 71;
            this.adultstextbox.TextChanged += new System.EventHandler(this.adultstextbox_TextChanged);
            // 
            // childrentextbox
            // 
            this.childrentextbox.AutoRoundedCorners = true;
            this.childrentextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.childrentextbox.DefaultText = "";
            this.childrentextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.childrentextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.childrentextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.childrentextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.childrentextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.childrentextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.childrentextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.childrentextbox.Location = new System.Drawing.Point(483, 488);
            this.childrentextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.childrentextbox.Name = "childrentextbox";
            this.childrentextbox.PlaceholderText = "";
            this.childrentextbox.SelectedText = "";
            this.childrentextbox.Size = new System.Drawing.Size(104, 33);
            this.childrentextbox.TabIndex = 71;
            this.childrentextbox.TextChanged += new System.EventHandler(this.childrentextbox_TextChanged);
            // 
            // specialrequestTextbox
            // 
            this.specialrequestTextbox.AutoRoundedCorners = true;
            this.specialrequestTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.specialrequestTextbox.DefaultText = "";
            this.specialrequestTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.specialrequestTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.specialrequestTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialrequestTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialrequestTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialrequestTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.specialrequestTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialrequestTextbox.Location = new System.Drawing.Point(146, 545);
            this.specialrequestTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.specialrequestTextbox.Name = "specialrequestTextbox";
            this.specialrequestTextbox.PlaceholderText = "";
            this.specialrequestTextbox.SelectedText = "";
            this.specialrequestTextbox.Size = new System.Drawing.Size(241, 33);
            this.specialrequestTextbox.TabIndex = 71;
            this.specialrequestTextbox.TextChanged += new System.EventHandler(this.specialrequestTextbox_TextChanged);
            // 
            // creditTextbox
            // 
            this.creditTextbox.AutoRoundedCorners = true;
            this.creditTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.creditTextbox.DefaultText = "";
            this.creditTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.creditTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.creditTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.creditTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.creditTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creditTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.creditTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.creditTextbox.Location = new System.Drawing.Point(569, 545);
            this.creditTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creditTextbox.Name = "creditTextbox";
            this.creditTextbox.PlaceholderText = "";
            this.creditTextbox.SelectedText = "";
            this.creditTextbox.Size = new System.Drawing.Size(362, 33);
            this.creditTextbox.TabIndex = 71;
            this.creditTextbox.TextChanged += new System.EventHandler(this.creditTextbox_TextChanged);
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckInLabel.Location = new System.Drawing.Point(36, 614);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(93, 17);
            this.CheckInLabel.TabIndex = 60;
            this.CheckInLabel.Text = "Check-In Date";
            // 
            // checkoutlabel
            // 
            this.checkoutlabel.AutoSize = true;
            this.checkoutlabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkoutlabel.Location = new System.Drawing.Point(501, 614);
            this.checkoutlabel.Name = "checkoutlabel";
            this.checkoutlabel.Size = new System.Drawing.Size(104, 17);
            this.checkoutlabel.TabIndex = 60;
            this.checkoutlabel.Text = "Check-Out Date";
            // 
            // checkindp
            // 
            this.checkindp.Checked = true;
            this.checkindp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkindp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.checkindp.Location = new System.Drawing.Point(145, 604);
            this.checkindp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkindp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkindp.Name = "checkindp";
            this.checkindp.Size = new System.Drawing.Size(287, 36);
            this.checkindp.TabIndex = 72;
            this.checkindp.Value = new System.DateTime(2025, 10, 9, 21, 14, 16, 831);
            this.checkindp.ValueChanged += new System.EventHandler(this.checkindp_ValueChanged);
            // 
            // checkoutdp
            // 
            this.checkoutdp.Checked = true;
            this.checkoutdp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkoutdp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.checkoutdp.Location = new System.Drawing.Point(632, 604);
            this.checkoutdp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkoutdp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkoutdp.Name = "checkoutdp";
            this.checkoutdp.Size = new System.Drawing.Size(287, 36);
            this.checkoutdp.TabIndex = 72;
            this.checkoutdp.Value = new System.DateTime(2025, 10, 9, 21, 14, 16, 831);
            this.checkoutdp.ValueChanged += new System.EventHandler(this.checkoutdp_ValueChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoRoundedCorners = true;
            this.SubmitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitButton.FillColor = System.Drawing.Color.ForestGreen;
            this.SubmitButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.man_4_50dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.SubmitButton.Location = new System.Drawing.Point(330, 665);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(282, 34);
            this.SubmitButton.TabIndex = 69;
            this.SubmitButton.Text = "Submit Booking";
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MakeBookingButton
            // 
            this.MakeBookingButton.AutoRoundedCorners = true;
            this.MakeBookingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MakeBookingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MakeBookingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MakeBookingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MakeBookingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.MakeBookingButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBookingButton.ForeColor = System.Drawing.Color.White;
            this.MakeBookingButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.add_50dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.MakeBookingButton.Location = new System.Drawing.Point(43, 261);
            this.MakeBookingButton.Name = "MakeBookingButton";
            this.MakeBookingButton.Size = new System.Drawing.Size(230, 45);
            this.MakeBookingButton.TabIndex = 68;
            this.MakeBookingButton.Text = "MAKE BOOKING";
            this.MakeBookingButton.Click += new System.EventHandler(this.MakeBookingButton_Click_1);
            // 
            // CancelBookingButton
            // 
            this.CancelBookingButton.AutoRoundedCorners = true;
            this.CancelBookingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBookingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBookingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBookingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBookingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CancelBookingButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBookingButton.ForeColor = System.Drawing.Color.White;
            this.CancelBookingButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.cancel_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.CancelBookingButton.Location = new System.Drawing.Point(667, 261);
            this.CancelBookingButton.Name = "CancelBookingButton";
            this.CancelBookingButton.Size = new System.Drawing.Size(234, 45);
            this.CancelBookingButton.TabIndex = 67;
            this.CancelBookingButton.Text = "CANCEL";
            this.CancelBookingButton.Click += new System.EventHandler(this.CancelBookingButton_Click_1);
            // 
            // UpdatebookingButton
            // 
            this.UpdatebookingButton.AutoRoundedCorners = true;
            this.UpdatebookingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdatebookingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdatebookingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdatebookingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdatebookingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UpdatebookingButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatebookingButton.ForeColor = System.Drawing.Color.White;
            this.UpdatebookingButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.update_50dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.UpdatebookingButton.Location = new System.Drawing.Point(357, 261);
            this.UpdatebookingButton.Name = "UpdatebookingButton";
            this.UpdatebookingButton.Size = new System.Drawing.Size(230, 45);
            this.UpdatebookingButton.TabIndex = 66;
            this.UpdatebookingButton.Text = "UPDATE BOOKING";
            this.UpdatebookingButton.Click += new System.EventHandler(this.UpdatebookingButton_Click_1);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(648, 377);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(229, 33);
            this.guna2TextBox1.TabIndex = 71;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.phoneNumberTextbox_TextChanged);
            // 
            // IdNumLabel
            // 
            this.IdNumLabel.AutoSize = true;
            this.IdNumLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IdNumLabel.Location = new System.Drawing.Point(566, 388);
            this.IdNumLabel.Name = "IdNumLabel";
            this.IdNumLabel.Size = new System.Drawing.Size(76, 17);
            this.IdNumLabel.TabIndex = 33;
            this.IdNumLabel.Text = "ID Number";
            // 
            // FrmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.checkoutdp);
            this.Controls.Add(this.checkindp);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.phonetextbox);
            this.Controls.Add(this.surnametextbox);
            this.Controls.Add(this.childrentextbox);
            this.Controls.Add(this.adultstextbox);
            this.Controls.Add(this.creditTextbox);
            this.Controls.Add(this.specialrequestTextbox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.YesNoComboBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MakeBookingButton);
            this.Controls.Add(this.CancelBookingButton);
            this.Controls.Add(this.UpdatebookingButton);
            this.Controls.Add(this.Occupancylabel);
            this.Controls.Add(this.NoOfAdultsLabel);
            this.Controls.Add(this.Childrenlabel);
            this.Controls.Add(this.CreditCardlabel);
            this.Controls.Add(this.checkoutlabel);
            this.Controls.Add(this.CheckInLabel);
            this.Controls.Add(this.SpecialRequestlabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdNumLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.ShowdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBookings";
            this.Text = "FrmBookings";
            this.Load += new System.EventHandler(this.FrmBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ShowdataGridView;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label SpecialRequestlabel;
        private System.Windows.Forms.Label Childrenlabel;
        private System.Windows.Forms.Label Occupancylabel;
        private Guna.UI2.WinForms.Guna2Button UpdatebookingButton;
        private Guna.UI2.WinForms.Guna2Button CancelBookingButton;
        private Guna.UI2.WinForms.Guna2Button MakeBookingButton;
        private Guna.UI2.WinForms.Guna2Button SubmitButton;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CreditCardlabel;
        private PhumlaKamnandiDBDataSet phumlaKamnandiDBDataSet;
        private System.Windows.Forms.BindingSource phumlaKamnandiDBDataSetBindingSource;
        private System.Windows.Forms.Label NoOfAdultsLabel;
        private Guna.UI2.WinForms.Guna2ComboBox YesNoComboBox;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox emailtextbox;
        private Guna.UI2.WinForms.Guna2TextBox surnametextbox;
        private Guna.UI2.WinForms.Guna2TextBox phonetextbox;
        private Guna.UI2.WinForms.Guna2TextBox addresstextbox;
        private Guna.UI2.WinForms.Guna2TextBox adultstextbox;
        private Guna.UI2.WinForms.Guna2TextBox childrentextbox;
        private Guna.UI2.WinForms.Guna2TextBox specialrequestTextbox;
        private Guna.UI2.WinForms.Guna2TextBox creditTextbox;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.Label checkoutlabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker checkindp;
        private Guna.UI2.WinForms.Guna2DateTimePicker checkoutdp;
        private System.Windows.Forms.BindingSource phumlaKamnandiDBDataSetBindingSource1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label IdNumLabel;
    }
}