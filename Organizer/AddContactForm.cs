﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class AddContactForm : Form
    {
        ContactList.ContactList list;
        ContactBookForm cbf;

        //konstruktor przyjmuje ContactBookForm zeby miec dostep do kontrolki listy(dodanie kontaktu)
        public AddContactForm(ContactBookForm form)
        {
            InitializeComponent();
            SocialGroupBox.Visible = false;
            BusinessGroupBox.Visible = false;

            cbf = form;

            list = ContactList.ContactList.GetInstance();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePhotoBox(String file_path)
        {
            try
            {
                AddPhotoBox.Image = Image.FromFile(file_path);
            }
            catch
            {
                MessageBox.Show("Wrong file selected.", "Error", MessageBoxButtons.OK);
            }
        }

        private void SocialButtonChanged(object sender, EventArgs e)
        {
            //zeby tylko typ mogl byc jednoczesnie dodany (Social albo Business)
            if (SocialButton.Checked == true)
            {
                BusinessButton.Checked = false;
                BusinessGroupBox.Visible = false;
                SocialGroupBox.Visible = true;
            }
        }

        private void BusinessButtonChanged(object sender, EventArgs e)
        {
            if (BusinessButton.Checked == true)
            {
                SocialButton.Checked = false;
                SocialGroupBox.Visible = false;
                BusinessGroupBox.Visible = true;
            }
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            //Aby zapobiec dodawaniu pustych kontaktów
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Fill the 'Name' field first.", "Error",MessageBoxButtons.OK);
                return;
            }


             if (SocialButton.Checked)
             {
                 Contact.Social_Contact newContact;

                 newContact = new Contact.Social_Contact(list.Count(), "social", NameTextBox.Text, SurnameTextBox.Text, EmailTextBox.Text, PhoneTextBox.Text);
                 newContact.Photo_path = FilePathTextBox.Text; 
                 newContact.Birthday_date = Convert.ToString(BirthdayDatePicker.Text);
                 newContact.Facebook_page = FacebookTextBox.Text;

                 newContact.address.City = CityTextBox.Text;
                 newContact.address.Country = CountryTextBox.Text;
                 newContact.address.Street = StreetTextBox.Text;
                 newContact.address.Zip_code = ZipCodeTextBox.Text;
                 
                 
                 list.Add(newContact);
                 cbf.ContactListView.Items.Add(newContact.Name + " " + newContact.Surname);
             }
             else if (BusinessButton.Checked)
             {
                 Contact.Business_Contact newContact;

                 newContact = new Contact.Business_Contact(list.Count(), "business", NameTextBox.Text, SurnameTextBox.Text, EmailTextBox.Text, PhoneTextBox.Text);
                 newContact.Photo_path = PhotoPathTextBox.Text;                 
                 newContact.Business_phone = BusinessPhoneTextBox.Text;
                 newContact.Company_name = CompanyNameTextBox.Text;
                 newContact.Fax = FaxTextBox.Text;

                 newContact.address.City = CityTextBox.Text;
                 newContact.address.Country = CountryTextBox.Text;
                 newContact.address.Street = StreetTextBox.Text;
                 newContact.address.Zip_code = ZipCodeTextBox.Text;

                 list.Add(newContact);
                 cbf.ContactListView.Items.Add(newContact.Name + " " + newContact.Surname);
             }
             //zamykanie forma po dodanie kontaktu
             this.Close();
             cbf.Show();
        }
        
        private void AddPhotoBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = ofd.FileName;
                UpdatePhotoBox(ofd.FileName);
            }
        }
    }
}
