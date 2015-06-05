namespace Organizer
{
    partial class ContactBookForm
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
            this.ButtonAddContact = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ContactListBox = new System.Windows.Forms.GroupBox();
            this.ButtonRemoveContact = new System.Windows.Forms.Button();
            this.ButtonEditContact = new System.Windows.Forms.Button();
            this.ContactListView = new System.Windows.Forms.ListView();
            this.ContactPreviewBox = new System.Windows.Forms.GroupBox();
            this.SelectInfoTextBox = new System.Windows.Forms.TextBox();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.BusinessGroupBox = new System.Windows.Forms.GroupBox();
            this.BusinessPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FaxTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SocialGroupBox = new System.Windows.Forms.GroupBox();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FacebookTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BasicInformationsGoupBox = new System.Windows.Forms.GroupBox();
            this.PhotoTextBox = new System.Windows.Forms.TextBox();
            this.ContactPreviewPhotoBox = new System.Windows.Forms.PictureBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label1_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.ContactListBox.SuspendLayout();
            this.ContactPreviewBox.SuspendLayout();
            this.BusinessGroupBox.SuspendLayout();
            this.SocialGroupBox.SuspendLayout();
            this.AddressGroupBox.SuspendLayout();
            this.BasicInformationsGoupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactPreviewPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddContact
            // 
            this.ButtonAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddContact.Location = new System.Drawing.Point(352, 617);
            this.ButtonAddContact.Name = "ButtonAddContact";
            this.ButtonAddContact.Size = new System.Drawing.Size(257, 43);
            this.ButtonAddContact.TabIndex = 0;
            this.ButtonAddContact.Text = "Add New Contact";
            this.ButtonAddContact.UseVisualStyleBackColor = true;
            this.ButtonAddContact.Click += new System.EventHandler(this.AddContactClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ContactListBox
            // 
            this.ContactListBox.Controls.Add(this.ButtonRemoveContact);
            this.ContactListBox.Controls.Add(this.ButtonEditContact);
            this.ContactListBox.Controls.Add(this.ContactListView);
            this.ContactListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContactListBox.Location = new System.Drawing.Point(12, 12);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(428, 586);
            this.ContactListBox.TabIndex = 1;
            this.ContactListBox.TabStop = false;
            this.ContactListBox.Text = "Contact List";
            // 
            // ButtonRemoveContact
            // 
            this.ButtonRemoveContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRemoveContact.Location = new System.Drawing.Point(207, 518);
            this.ButtonRemoveContact.Name = "ButtonRemoveContact";
            this.ButtonRemoveContact.Size = new System.Drawing.Size(175, 35);
            this.ButtonRemoveContact.TabIndex = 2;
            this.ButtonRemoveContact.Text = "Remove Contact";
            this.ButtonRemoveContact.UseVisualStyleBackColor = true;
            this.ButtonRemoveContact.Click += new System.EventHandler(this.ButtonRemoveContact_Click);
            // 
            // ButtonEditContact
            // 
            this.ButtonEditContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEditContact.Location = new System.Drawing.Point(41, 518);
            this.ButtonEditContact.Name = "ButtonEditContact";
            this.ButtonEditContact.Size = new System.Drawing.Size(136, 35);
            this.ButtonEditContact.TabIndex = 1;
            this.ButtonEditContact.Text = "Edit Contact";
            this.ButtonEditContact.UseVisualStyleBackColor = true;
            this.ButtonEditContact.Click += new System.EventHandler(this.ButtonEditContact_Click);
            // 
            // ContactListView
            // 
            this.ContactListView.Location = new System.Drawing.Point(6, 25);
            this.ContactListView.MultiSelect = false;
            this.ContactListView.Name = "ContactListView";
            this.ContactListView.Size = new System.Drawing.Size(407, 452);
            this.ContactListView.TabIndex = 0;
            this.ContactListView.UseCompatibleStateImageBehavior = false;
            this.ContactListView.View = System.Windows.Forms.View.List;
            this.ContactListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ContactPreviewBox
            // 
            this.ContactPreviewBox.Controls.Add(this.SelectInfoTextBox);
            this.ContactPreviewBox.Controls.Add(this.DiscardButton);
            this.ContactPreviewBox.Controls.Add(this.ApplyButton);
            this.ContactPreviewBox.Controls.Add(this.BusinessGroupBox);
            this.ContactPreviewBox.Controls.Add(this.SocialGroupBox);
            this.ContactPreviewBox.Controls.Add(this.AddressGroupBox);
            this.ContactPreviewBox.Controls.Add(this.BasicInformationsGoupBox);
            this.ContactPreviewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContactPreviewBox.Location = new System.Drawing.Point(446, 12);
            this.ContactPreviewBox.Name = "ContactPreviewBox";
            this.ContactPreviewBox.Size = new System.Drawing.Size(537, 586);
            this.ContactPreviewBox.TabIndex = 2;
            this.ContactPreviewBox.TabStop = false;
            this.ContactPreviewBox.Text = "Contact Preview";
            // 
            // SelectInfoTextBox
            // 
            this.SelectInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectInfoTextBox.Location = new System.Drawing.Point(141, 277);
            this.SelectInfoTextBox.Name = "SelectInfoTextBox";
            this.SelectInfoTextBox.Size = new System.Drawing.Size(254, 25);
            this.SelectInfoTextBox.TabIndex = 28;
            this.SelectInfoTextBox.Text = "<No contact selected>";
            this.SelectInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiscardButton
            // 
            this.DiscardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiscardButton.Location = new System.Drawing.Point(323, 518);
            this.DiscardButton.Name = "DiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(136, 35);
            this.DiscardButton.TabIndex = 15;
            this.DiscardButton.Text = "Discard";
            this.DiscardButton.UseVisualStyleBackColor = true;
            this.DiscardButton.Visible = false;
            this.DiscardButton.Click += new System.EventHandler(this.DiscardButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApplyButton.Location = new System.Drawing.Point(130, 518);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(136, 35);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Visible = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // BusinessGroupBox
            // 
            this.BusinessGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.BusinessGroupBox.Controls.Add(this.BusinessPhoneTextBox);
            this.BusinessGroupBox.Controls.Add(this.label12);
            this.BusinessGroupBox.Controls.Add(this.FaxTextBox);
            this.BusinessGroupBox.Controls.Add(this.label10);
            this.BusinessGroupBox.Controls.Add(this.CompanyNameTextBox);
            this.BusinessGroupBox.Controls.Add(this.label11);
            this.BusinessGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BusinessGroupBox.Location = new System.Drawing.Point(6, 361);
            this.BusinessGroupBox.Name = "BusinessGroupBox";
            this.BusinessGroupBox.Size = new System.Drawing.Size(525, 141);
            this.BusinessGroupBox.TabIndex = 25;
            this.BusinessGroupBox.TabStop = false;
            this.BusinessGroupBox.Text = "Business";
            // 
            // BusinessPhoneTextBox
            // 
            this.BusinessPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BusinessPhoneTextBox.Location = new System.Drawing.Point(161, 94);
            this.BusinessPhoneTextBox.Name = "BusinessPhoneTextBox";
            this.BusinessPhoneTextBox.Size = new System.Drawing.Size(358, 27);
            this.BusinessPhoneTextBox.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(7, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Business phone";
            // 
            // FaxTextBox
            // 
            this.FaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FaxTextBox.Location = new System.Drawing.Point(161, 60);
            this.FaxTextBox.Name = "FaxTextBox";
            this.FaxTextBox.Size = new System.Drawing.Size(358, 27);
            this.FaxTextBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(7, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fax:";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyNameTextBox.Location = new System.Drawing.Point(161, 26);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(358, 27);
            this.CompanyNameTextBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(7, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Company Name:";
            // 
            // SocialGroupBox
            // 
            this.SocialGroupBox.Controls.Add(this.BirthdayTextBox);
            this.SocialGroupBox.Controls.Add(this.label6);
            this.SocialGroupBox.Controls.Add(this.FacebookTextBox);
            this.SocialGroupBox.Controls.Add(this.label5);
            this.SocialGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SocialGroupBox.Location = new System.Drawing.Point(6, 361);
            this.SocialGroupBox.Name = "SocialGroupBox";
            this.SocialGroupBox.Size = new System.Drawing.Size(525, 141);
            this.SocialGroupBox.TabIndex = 21;
            this.SocialGroupBox.TabStop = false;
            this.SocialGroupBox.Text = "Social ";
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayTextBox.Location = new System.Drawing.Point(161, 78);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.Size = new System.Drawing.Size(358, 27);
            this.BirthdayTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(14, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birthday:";
            // 
            // FacebookTextBox
            // 
            this.FacebookTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FacebookTextBox.Location = new System.Drawing.Point(161, 36);
            this.FacebookTextBox.Name = "FacebookTextBox";
            this.FacebookTextBox.Size = new System.Drawing.Size(358, 27);
            this.FacebookTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(14, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Facebook:";
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.Controls.Add(this.ZipCodeTextBox);
            this.AddressGroupBox.Controls.Add(this.StreetTextBox);
            this.AddressGroupBox.Controls.Add(this.label9);
            this.AddressGroupBox.Controls.Add(this.CountryTextBox);
            this.AddressGroupBox.Controls.Add(this.label8);
            this.AddressGroupBox.Controls.Add(this.CityTextBox);
            this.AddressGroupBox.Controls.Add(this.label7);
            this.AddressGroupBox.Controls.Add(this.label4);
            this.AddressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddressGroupBox.Location = new System.Drawing.Point(6, 192);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Size = new System.Drawing.Size(525, 163);
            this.AddressGroupBox.TabIndex = 20;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Address";
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZipCodeTextBox.Location = new System.Drawing.Point(161, 124);
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(358, 27);
            this.ZipCodeTextBox.TabIndex = 9;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Location = new System.Drawing.Point(161, 91);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(358, 27);
            this.StreetTextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Zip code:";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryTextBox.Location = new System.Drawing.Point(161, 25);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(358, 27);
            this.CountryTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(7, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Street:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Location = new System.Drawing.Point(161, 58);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(358, 27);
            this.CityTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "City: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Country:";
            // 
            // BasicInformationsGoupBox
            // 
            this.BasicInformationsGoupBox.Controls.Add(this.PhotoTextBox);
            this.BasicInformationsGoupBox.Controls.Add(this.ContactPreviewPhotoBox);
            this.BasicInformationsGoupBox.Controls.Add(this.SurnameTextBox);
            this.BasicInformationsGoupBox.Controls.Add(this.label1_2);
            this.BasicInformationsGoupBox.Controls.Add(this.label1);
            this.BasicInformationsGoupBox.Controls.Add(this.EmailTextBox);
            this.BasicInformationsGoupBox.Controls.Add(this.NameTextBox);
            this.BasicInformationsGoupBox.Controls.Add(this.label2);
            this.BasicInformationsGoupBox.Controls.Add(this.PhoneNumberTextBox);
            this.BasicInformationsGoupBox.Controls.Add(this.label3);
            this.BasicInformationsGoupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BasicInformationsGoupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BasicInformationsGoupBox.Location = new System.Drawing.Point(6, 25);
            this.BasicInformationsGoupBox.Name = "BasicInformationsGoupBox";
            this.BasicInformationsGoupBox.Size = new System.Drawing.Size(525, 161);
            this.BasicInformationsGoupBox.TabIndex = 3;
            this.BasicInformationsGoupBox.TabStop = false;
            this.BasicInformationsGoupBox.Text = "Basic informations";
            // 
            // PhotoTextBox
            // 
            this.PhotoTextBox.Location = new System.Drawing.Point(410, 125);
            this.PhotoTextBox.Name = "PhotoTextBox";
            this.PhotoTextBox.Size = new System.Drawing.Size(100, 27);
            this.PhotoTextBox.TabIndex = 10;
            this.PhotoTextBox.Visible = false;
            // 
            // ContactPreviewPhotoBox
            // 
            this.ContactPreviewPhotoBox.ErrorImage = null;
            this.ContactPreviewPhotoBox.Image = global::Organizer.Properties.Resources._default;
            this.ContactPreviewPhotoBox.InitialImage = null;
            this.ContactPreviewPhotoBox.Location = new System.Drawing.Point(399, 26);
            this.ContactPreviewPhotoBox.Name = "ContactPreviewPhotoBox";
            this.ContactPreviewPhotoBox.Size = new System.Drawing.Size(120, 126);
            this.ContactPreviewPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ContactPreviewPhotoBox.TabIndex = 9;
            this.ContactPreviewPhotoBox.TabStop = false;
            this.ContactPreviewPhotoBox.Click += new System.EventHandler(this.ContactPreviewPhotoBox_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(167, 60);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(226, 27);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // label1_2
            // 
            this.label1_2.AutoSize = true;
            this.label1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_2.Location = new System.Drawing.Point(7, 67);
            this.label1_2.Name = "label1_2";
            this.label1_2.Size = new System.Drawing.Size(78, 20);
            this.label1_2.TabIndex = 6;
            this.label1_2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(167, 126);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(226, 27);
            this.EmailTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(167, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(226, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(167, 93);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(226, 27);
            this.PhoneNumberTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // ContactBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 682);
            this.Controls.Add(this.ContactPreviewBox);
            this.Controls.Add(this.ContactListBox);
            this.Controls.Add(this.ButtonAddContact);
            this.Name = "ContactBookForm";
            this.Text = "Contact Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactBook_FormClosing);
            this.Load += new System.EventHandler(this.ContactBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ContactListBox.ResumeLayout(false);
            this.ContactPreviewBox.ResumeLayout(false);
            this.ContactPreviewBox.PerformLayout();
            this.BusinessGroupBox.ResumeLayout(false);
            this.BusinessGroupBox.PerformLayout();
            this.SocialGroupBox.ResumeLayout(false);
            this.SocialGroupBox.PerformLayout();
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.BasicInformationsGoupBox.ResumeLayout(false);
            this.BasicInformationsGoupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactPreviewPhotoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddContact;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox ContactListBox;
        public System.Windows.Forms.ListView ContactListView;
        private System.Windows.Forms.Button ButtonRemoveContact;
        private System.Windows.Forms.Button ButtonEditContact;
        private System.Windows.Forms.GroupBox ContactPreviewBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox BasicInformationsGoupBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox AddressGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.GroupBox SocialGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FacebookTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BirthdayTextBox;
        private System.Windows.Forms.Button DiscardButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label1_2;
        private System.Windows.Forms.GroupBox BusinessGroupBox;
        private System.Windows.Forms.TextBox BusinessPhoneTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FaxTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PhotoTextBox;
        private System.Windows.Forms.PictureBox ContactPreviewPhotoBox;
        private System.Windows.Forms.TextBox SelectInfoTextBox;
    }
}