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
            this.ShowdataGridView = new System.Windows.Forms.DataGridView();
            this.FirstNamelabel = new System.Windows.Forms.Label();
            this.MakeBookingButton = new System.Windows.Forms.Button();
            this.CancelBookingButton = new System.Windows.Forms.Button();
            this.UpdateBookingButton = new System.Windows.Forms.Button();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.CardtextBox = new System.Windows.Forms.TextBox();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.Cardlabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Formlabel = new System.Windows.Forms.Label();
            this.DatetextBox = new System.Windows.Forms.TextBox();
            this.FormtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowdataGridView
            // 
            this.ShowdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowdataGridView.Location = new System.Drawing.Point(53, 12);
            this.ShowdataGridView.Name = "ShowdataGridView";
            this.ShowdataGridView.RowHeadersWidth = 51;
            this.ShowdataGridView.RowTemplate.Height = 24;
            this.ShowdataGridView.Size = new System.Drawing.Size(844, 261);
            this.ShowdataGridView.TabIndex = 27;
            this.ShowdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.AutoSize = true;
            this.FirstNamelabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FirstNamelabel.Location = new System.Drawing.Point(75, 358);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(75, 17);
            this.FirstNamelabel.TabIndex = 28;
            this.FirstNamelabel.Text = "First Name";
            // 
            // MakeBookingButton
            // 
            this.MakeBookingButton.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBookingButton.Location = new System.Drawing.Point(53, 299);
            this.MakeBookingButton.Name = "MakeBookingButton";
            this.MakeBookingButton.Size = new System.Drawing.Size(203, 32);
            this.MakeBookingButton.TabIndex = 26;
            this.MakeBookingButton.Text = "MAKE BOOKING";
            this.MakeBookingButton.UseVisualStyleBackColor = false;
            this.MakeBookingButton.Click += new System.EventHandler(this.MakeBookingButton_Click);
            // 
            // CancelBookingButton
            // 
            this.CancelBookingButton.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBookingButton.Location = new System.Drawing.Point(365, 299);
            this.CancelBookingButton.Name = "CancelBookingButton";
            this.CancelBookingButton.Size = new System.Drawing.Size(203, 32);
            this.CancelBookingButton.TabIndex = 30;
            this.CancelBookingButton.Text = "CANCEL BOOKING";
            this.CancelBookingButton.UseVisualStyleBackColor = false;
            this.CancelBookingButton.Click += new System.EventHandler(this.CancelBookingButton_Click);
            // 
            // UpdateBookingButton
            // 
            this.UpdateBookingButton.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBookingButton.Location = new System.Drawing.Point(694, 299);
            this.UpdateBookingButton.Name = "UpdateBookingButton";
            this.UpdateBookingButton.Size = new System.Drawing.Size(203, 32);
            this.UpdateBookingButton.TabIndex = 31;
            this.UpdateBookingButton.Text = "UPDATE BOOKING";
            this.UpdateBookingButton.UseVisualStyleBackColor = false;
            this.UpdateBookingButton.Click += new System.EventHandler(this.UpdateBookingbutton_Click);
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Addresslabel.Location = new System.Drawing.Point(75, 530);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(57, 17);
            this.Addresslabel.TabIndex = 33;
            this.Addresslabel.Text = "Address";
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Phonelabel.Location = new System.Drawing.Point(75, 485);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(47, 17);
            this.Phonelabel.TabIndex = 34;
            this.Phonelabel.Text = "Phone";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Emaillabel.Location = new System.Drawing.Point(75, 447);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(42, 17);
            this.Emaillabel.TabIndex = 35;
            this.Emaillabel.Text = "Email";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LastNamelabel.Location = new System.Drawing.Point(75, 405);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(73, 17);
            this.LastNamelabel.TabIndex = 36;
            this.LastNamelabel.Text = "Last Name";
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNametextBox.Location = new System.Drawing.Point(201, 358);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(177, 22);
            this.FirstNametextBox.TabIndex = 37;
            this.FirstNametextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CardtextBox
            // 
            this.CardtextBox.Location = new System.Drawing.Point(602, 352);
            this.CardtextBox.Name = "CardtextBox";
            this.CardtextBox.Size = new System.Drawing.Size(154, 22);
            this.CardtextBox.TabIndex = 38;
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.AllowDrop = true;
            this.LastNametextBox.Location = new System.Drawing.Point(201, 399);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(177, 22);
            this.LastNametextBox.TabIndex = 39;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(201, 441);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(177, 22);
            this.EmailtextBox.TabIndex = 40;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(201, 484);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(177, 22);
            this.PhonetextBox.TabIndex = 41;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(201, 530);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(177, 22);
            this.AddresstextBox.TabIndex = 42;
            this.AddresstextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Cardlabel
            // 
            this.Cardlabel.AutoSize = true;
            this.Cardlabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cardlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cardlabel.Location = new System.Drawing.Point(437, 358);
            this.Cardlabel.Name = "Cardlabel";
            this.Cardlabel.Size = new System.Drawing.Size(131, 17);
            this.Cardlabel.TabIndex = 43;
            this.Cardlabel.Text = "Credit Card Number";
            this.Cardlabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Datelabel.Location = new System.Drawing.Point(446, 399);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(106, 17);
            this.Datelabel.TabIndex = 43;
            this.Datelabel.Text = "Date Registered";
            // 
            // Formlabel
            // 
            this.Formlabel.AutoSize = true;
            this.Formlabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Formlabel.Location = new System.Drawing.Point(438, 447);
            this.Formlabel.Name = "Formlabel";
            this.Formlabel.Size = new System.Drawing.Size(118, 17);
            this.Formlabel.TabIndex = 44;
            this.Formlabel.Text = "IsInGoodStanding";
            // 
            // DatetextBox
            // 
            this.DatetextBox.Location = new System.Drawing.Point(602, 393);
            this.DatetextBox.Name = "DatetextBox";
            this.DatetextBox.Size = new System.Drawing.Size(154, 22);
            this.DatetextBox.TabIndex = 45;
            this.DatetextBox.TextChanged += new System.EventHandler(this.DatetextBox_TextChanged_1);
            // 
            // FormtextBox
            // 
            this.FormtextBox.Location = new System.Drawing.Point(602, 441);
            this.FormtextBox.Name = "FormtextBox";
            this.FormtextBox.Size = new System.Drawing.Size(154, 22);
            this.FormtextBox.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 32);
            this.button1.TabIndex = 47;
            this.button1.Text = "Submit Booking";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FormtextBox);
            this.Controls.Add(this.DatetextBox);
            this.Controls.Add(this.Formlabel);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Cardlabel);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.PhonetextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.LastNametextBox);
            this.Controls.Add(this.CardtextBox);
            this.Controls.Add(this.FirstNametextBox);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Phonelabel);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.UpdateBookingButton);
            this.Controls.Add(this.CancelBookingButton);
            this.Controls.Add(this.MakeBookingButton);
            this.Controls.Add(this.FirstNamelabel);
            this.Controls.Add(this.ShowdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBookings";
            this.Text = "FrmBookings";
            this.Load += new System.EventHandler(this.FrmBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ShowdataGridView;
        private System.Windows.Forms.Label FirstNamelabel;
        private System.Windows.Forms.Button MakeBookingButton;
        private System.Windows.Forms.Button CancelBookingButton;
        private System.Windows.Forms.Button UpdateBookingButton;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.TextBox CardtextBox;
        private System.Windows.Forms.TextBox LastNametextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label Cardlabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Formlabel;
        private System.Windows.Forms.TextBox DatetextBox;
        private System.Windows.Forms.TextBox FormtextBox;
        private System.Windows.Forms.Button button1;
    }
}