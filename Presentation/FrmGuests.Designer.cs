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
            this.emailConfirmtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.enterEmailTextbox = new System.Windows.Forms.Label();
            this.ConfirmButtonVBH = new Guna.UI2.WinForms.Guna2Button();
            this.ErrorLableVBH = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.GuestStandingButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddGuestButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateGuestButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuestDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestDataView
            // 
            this.GuestDataView.AllowUserToOrderColumns = true;
            this.GuestDataView.AutoGenerateColumns = false;
            this.GuestDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestDataView.DataSource = this.phumlaKamnandiDBDataSetBindingSource;
            this.GuestDataView.Location = new System.Drawing.Point(63, 12);
            this.GuestDataView.Name = "GuestDataView";
            this.GuestDataView.RowHeadersWidth = 51;
            this.GuestDataView.RowTemplate.Height = 24;
            this.GuestDataView.Size = new System.Drawing.Size(830, 312);
            this.GuestDataView.TabIndex = 25;
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
            this.ConfirmButtonVBH.Click += new System.EventHandler(this.UpdateGuestButton_Click);
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
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(502, 349);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 26;
            this.guna2Button2.Text = "View Booking History";
            this.guna2Button2.Click += new System.EventHandler(this.UpdateGuestButton_Click);
            // 
            // GuestStandingButton
            // 
            this.GuestStandingButton.AutoRoundedCorners = true;
            this.GuestStandingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GuestStandingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GuestStandingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GuestStandingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GuestStandingButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestStandingButton.ForeColor = System.Drawing.Color.White;
            this.GuestStandingButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.man_4_50dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.GuestStandingButton.Location = new System.Drawing.Point(713, 349);
            this.GuestStandingButton.Name = "GuestStandingButton";
            this.GuestStandingButton.Size = new System.Drawing.Size(180, 45);
            this.GuestStandingButton.TabIndex = 26;
            this.GuestStandingButton.Text = "Guest standing";
            this.GuestStandingButton.Click += new System.EventHandler(this.UpdateGuestButton_Click);
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.AutoRoundedCorners = true;
            this.AddGuestButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddGuestButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddGuestButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddGuestButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddGuestButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuestButton.ForeColor = System.Drawing.Color.White;
            this.AddGuestButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.add_50dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.AddGuestButton.Location = new System.Drawing.Point(285, 349);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(180, 45);
            this.AddGuestButton.TabIndex = 26;
            this.AddGuestButton.Text = "Add Guest";
            this.AddGuestButton.Click += new System.EventHandler(this.UpdateGuestButton_Click);
            // 
            // UpdateGuestButton
            // 
            this.UpdateGuestButton.AutoRoundedCorners = true;
            this.UpdateGuestButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateGuestButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateGuestButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateGuestButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
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
            this.Controls.Add(this.ErrorLableVBH);
            this.Controls.Add(this.enterEmailTextbox);
            this.Controls.Add(this.emailConfirmtextbox);
            this.Controls.Add(this.GuestStandingButton);
            this.Controls.Add(this.ConfirmButtonVBH);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.UpdateGuestButton);
            this.Controls.Add(this.GuestDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGuests";
            this.Text = "FrmGuests";
            ((System.ComponentModel.ISupportInitialize)(this.GuestDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GuestDataView;
        private System.Windows.Forms.BindingSource phumlaKamnandiDBDataSetBindingSource;
        private PhumlaKamnandiDBDataSet phumlaKamnandiDBDataSet;
        private Guna.UI2.WinForms.Guna2Button UpdateGuestButton;
        private Guna.UI2.WinForms.Guna2Button AddGuestButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button GuestStandingButton;
        private Guna.UI2.WinForms.Guna2TextBox emailConfirmtextbox;
        private System.Windows.Forms.Label enterEmailTextbox;
        private Guna.UI2.WinForms.Guna2Button ConfirmButtonVBH;
        private System.Windows.Forms.Label ErrorLableVBH;
    }
}