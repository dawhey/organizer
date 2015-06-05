using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Organizer.Classes;

namespace Organizer
{
    public partial class ContactBookForm : Form
    {
        ContactList.ContactList list;
        ContactList.ContactListIterator iterator = new ContactList.ContactListIterator();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        Memento m;

        public ContactBookForm()
        {
            InitializeComponent();
            list = ContactList.ContactList.GetInstance();
            ContactPreviewBox.Enabled = false; 
            ButtonEditContact.Enabled = false;
            ButtonRemoveContact.Enabled = false;
            BasicInformationsGoupBox.Visible = false;
            AddressGroupBox.Visible = false;
            SocialGroupBox.Visible = false;
            BusinessGroupBox.Visible = false;
            SelectInfoTextBox.Visible = true; 
        }

        private void AddItemsToListViewFromXml()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Address Book\\settings.xml");
            //wcztytywanie kontaktow z listy
            string type_of_contact;
            foreach (XmlNode xNode in xDoc.SelectNodes("Contacts/Contact"))
            {
                type_of_contact = xNode.SelectSingleNode("Type").InnerText;
                if (type_of_contact == "social")
                {
                    Contact.Social_Contact sc = new Contact.Social_Contact();
                    sc.Id = Convert.ToInt16(xNode.SelectSingleNode("Id").InnerText);
                    sc.Name = xNode.SelectSingleNode("Name").InnerText;
                    sc.Surname = xNode.SelectSingleNode("Surname").InnerText;
                    sc.Email = xNode.SelectSingleNode("Email").InnerText;
                    sc.Phone_number = xNode.SelectSingleNode("Phone_number").InnerText;
                    sc.Photo_path = xNode.SelectSingleNode("Photo_path").InnerText;

                    sc.address.Country = xNode.SelectSingleNode("Country").InnerText;
                    sc.address.City = xNode.SelectSingleNode("City").InnerText;
                    sc.address.Street = xNode.SelectSingleNode("Street").InnerText;
                    sc.address.Zip_code = xNode.SelectSingleNode("Zip_code").InnerText;

                    sc.Birthday_date = xNode.SelectSingleNode("Birthday_date").InnerText;
                    sc.Facebook_page = xNode.SelectSingleNode("Facebook_page").InnerText;

                    list.Add(sc);
                    ContactListView.Items.Add(sc.Name + " " + sc.Surname);
                }
                else if (type_of_contact == "business")
                {
                    Contact.Business_Contact bc = new Contact.Business_Contact();
                    bc.Id = Convert.ToInt16(xNode.SelectSingleNode("Id").InnerText);
                    bc.Name = xNode.SelectSingleNode("Name").InnerText;
                    bc.Surname = xNode.SelectSingleNode("Surname").InnerText;
                    bc.Email = xNode.SelectSingleNode("Email").InnerText;
                    bc.Phone_number = xNode.SelectSingleNode("Phone_number").InnerText;
                    bc.Photo_path = xNode.SelectSingleNode("Photo_path").InnerText;

                    bc.address.Country = xNode.SelectSingleNode("Country").InnerText;
                    bc.address.City = xNode.SelectSingleNode("City").InnerText;
                    bc.address.Street = xNode.SelectSingleNode("Street").InnerText;
                    bc.address.Zip_code = xNode.SelectSingleNode("Zip_code").InnerText;

                    bc.Fax = xNode.SelectSingleNode("Fax").InnerText;
                    bc.Business_phone = xNode.SelectSingleNode("Business_phone").InnerText;
                    bc.Company_name = xNode.SelectSingleNode("Company_name").InnerText;

                    list.Add(bc);
                    ContactListView.Items.Add(bc.Name + " " + bc.Surname);
                }
            }
        }

        private void UpdateListViewItems()
        {
            ContactListView.Clear();
            Contact.Contact contact;
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                contact = iterator.CurrentItem();
                ContactListView.Items.Add(contact.Name + " " + contact.Surname);
            }
        }

        private void ContactBook_Load(object sender, EventArgs e)
        {
            
            if(!Directory.Exists(path + "\\Address Book"))
                Directory.CreateDirectory(path + "\\Address Book");
            if(!File.Exists(path + "\\Address Book\\settings.xml"))
            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\Address Book\\settings.xml", Encoding.UTF8);
                xW.WriteStartElement("Contacts");
                xW.WriteEndElement();
                xW.Close();
            }
            AddItemsToListViewFromXml();            
        }
        
        private void ContactBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            xDoc.Load(path + "\\Address Book\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("Contacts");
            xNode.RemoveAll();
            
            //zapisywanie kontaktów do listy
            for(iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                string type_of_contact;
                type_of_contact = iterator.CurrentItem().Type;

                XmlNode xTop = xDoc.CreateElement("Contact");
                XmlNode xType = xDoc.CreateElement("Type");
                XmlNode xId = xDoc.CreateElement("Id");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xSurname = xDoc.CreateElement("Surname");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xPhone_number = xDoc.CreateElement("Phone_number");
                XmlNode xCountry = xDoc.CreateElement("Country");
                XmlNode xCity = xDoc.CreateElement("City");
                XmlNode xStreet = xDoc.CreateElement("Street");
                XmlNode xZip_code = xDoc.CreateElement("Zip_code");
                XmlNode xPhoto_path = xDoc.CreateElement("Photo_path");

                xId.InnerText = iterator.CurrentItem().Id.ToString();
                xName.InnerText = iterator.CurrentItem().Name;
                xSurname.InnerText = iterator.CurrentItem().Surname;
                xEmail.InnerText = iterator.CurrentItem().Email;
                xPhone_number.InnerText = iterator.CurrentItem().Phone_number;
                xZip_code.InnerText = iterator.CurrentItem().address.Zip_code;
                xCountry.InnerText = iterator.CurrentItem().address.Country;
                xCity.InnerText = iterator.CurrentItem().address.City;
                xStreet.InnerText = iterator.CurrentItem().address.Street;
                xPhoto_path.InnerText = iterator.CurrentItem().Photo_path;

                xType.InnerText = iterator.CurrentItem().Type;
                xTop.AppendChild(xId);
                xTop.AppendChild(xName);
                xTop.AppendChild(xSurname);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xPhone_number);
                xTop.AppendChild(xType);
                xTop.AppendChild(xCountry);
                xTop.AppendChild(xCity);
                xTop.AppendChild(xStreet);
                xTop.AppendChild(xZip_code);
                xTop.AppendChild(xPhoto_path);
                xDoc.DocumentElement.AppendChild(xTop);

                //zapisywanie socjala
                if (type_of_contact == "social")
                {
                    XmlNode xFacebook_page = xDoc.CreateElement("Facebook_page");
                    XmlNode xPhoto_id = xDoc.CreateElement("Photo_id");
                    XmlNode xBirthday_date = xDoc.CreateElement("Birthday_date");

                    Contact.Social_Contact scontact = (Contact.Social_Contact)list.Get(iterator.getCurrentIndex());
                    xFacebook_page.InnerText = scontact.Facebook_page;
                    xBirthday_date.InnerText = scontact.Birthday_date;

                    xTop.AppendChild(xFacebook_page);
                    xTop.AppendChild(xPhoto_id);
                    xTop.AppendChild(xBirthday_date);
                    
                }
                //zapisywanie krawata
                else if (type_of_contact == "business")
                {
                    XmlNode xBusiness_phone = xDoc.CreateElement("Business_phone");
                    XmlNode xFax = xDoc.CreateElement("Fax");
                    XmlNode xCompany_name = xDoc.CreateElement("Company_name");

                    Contact.Business_Contact bcontact = (Contact.Business_Contact)list.Get(iterator.getCurrentIndex());
                    xBusiness_phone.InnerText = bcontact.Business_phone;
                    xFax.InnerText = bcontact.Fax;
                    xCompany_name.InnerText = bcontact.Company_name;

                    xTop.AppendChild(xCompany_name);
                    xTop.AppendChild(xBusiness_phone);
                    xTop.AppendChild(xFax);
                }
            }
            xDoc.Save(path + "\\Address Book\\settings.xml");
            Environment.Exit(1);
        }

        private void AddContactClick(object sender, EventArgs e)
        {
            AddContactForm ac = new AddContactForm(this);
            ac.Show();
        }

        private void UpdatePhotoBox(String file_path)
        {
            try
            {
                ContactPreviewPhotoBox.Image = Image.FromFile(file_path);
            }
            catch
            {
                ContactPreviewPhotoBox.Image = Organizer.Properties.Resources._default;
                //ExceptionForm ep = new ExceptionForm();
                //ep.Show();
            }
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sprawdzenie czy ilość zaznaczonych elementów z listy nie wynosi 0
            // Podczas przełączania się zaznaczenia SelectedItems.Count wynosiło 
            // prez pewien okres czasu "0" i następowało odniesienie się do elementu
            // z zaznaczonej listy, który nie istniał
            if (ContactListView.SelectedItems.Count == 0)
            {
                ButtonEditContact.Enabled = false;
                ButtonRemoveContact.Enabled = false;
                BasicInformationsGoupBox.Visible = false;
                AddressGroupBox.Visible = false;
                SocialGroupBox.Visible = false;
                BusinessGroupBox.Visible = false;
                SelectInfoTextBox.Visible = true;
                return;
            }

            BasicInformationsGoupBox.Visible = true;
            AddressGroupBox.Visible = true;           
            ButtonEditContact.Enabled = true;
            ButtonRemoveContact.Enabled = true;
            SelectInfoTextBox.Visible = false; 

            int selected_contact_index = ContactListView.SelectedItems[0].Index;            
            while (selected_contact_index != iterator.getCurrentIndex())
            {
                iterator.Next();
                if (iterator.IsDone())
                    iterator.First();
            }

            UpdatePhotoBox(iterator.CurrentItem().Photo_path);

            if(iterator.CurrentItem().Type == "social")
            {
                SocialGroupBox.Visible = true;
                BusinessGroupBox.Visible = false;
                Contact.Social_Contact scontact = (Contact.Social_Contact)list.Get(iterator.getCurrentIndex());
                NameTextBox.Text = iterator.CurrentItem().Name;
                SurnameTextBox.Text = iterator.CurrentItem().Surname;
                PhoneNumberTextBox.Text = scontact.Phone_number;
                EmailTextBox.Text = scontact.Email;
                CountryTextBox.Text = scontact.address.Country;
                CityTextBox.Text = scontact.address.City;
                StreetTextBox.Text = scontact.address.Street;
                ZipCodeTextBox.Text = scontact.address.Zip_code;
                BirthdayTextBox.Text = scontact.Birthday_date;
                FacebookTextBox.Text = scontact.Facebook_page;
            }
            else
            {
                BusinessGroupBox.Visible = true;
                SocialGroupBox.Visible = false;
                Contact.Business_Contact scontact = (Contact.Business_Contact)list.Get(iterator.getCurrentIndex());
                NameTextBox.Text = iterator.CurrentItem().Name;
                SurnameTextBox.Text = iterator.CurrentItem().Surname;
                PhoneNumberTextBox.Text = scontact.Phone_number;
                EmailTextBox.Text = scontact.Email;
                CountryTextBox.Text = scontact.address.Country;
                CityTextBox.Text = scontact.address.City;
                StreetTextBox.Text = scontact.address.Street;
                ZipCodeTextBox.Text = scontact.address.Zip_code;
                CompanyNameTextBox.Text = scontact.Company_name;
                FaxTextBox.Text = scontact.Fax;
                BusinessPhoneTextBox.Text = scontact.Business_phone;
            }
            ContactPreviewBox.Enabled = false;            
        }

        private void ButtonRemoveContact_Click(object sender, EventArgs e)
        {
            if (ContactListView.SelectedItems.Count == 0)
                return;

            Remove();
        }
        
        void Remove()
        {
            try
            {
                list.Remove(ContactListView.SelectedItems[0].Index);
                ContactListView.Items.Remove(ContactListView.SelectedItems[0]); 
            }
            catch { }
        }

        private void ButtonEditContact_Click(object sender, EventArgs e)
        {
            ContactPreviewBox.Enabled = true;
            DiscardButton.Visible = true;
            ApplyButton.Visible = true;

            if (iterator.CurrentItem().Type == "business")
            {
                Contact.Business_Contact bc = (Contact.Business_Contact)list.Get(iterator.getCurrentIndex());
                m = bc.CreateMemento();
            }
            else if (iterator.CurrentItem().Type == "social")
            {
                Contact.Social_Contact sc = (Contact.Social_Contact)list.Get(iterator.getCurrentIndex());
                m = sc.CreateMemento();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
           if(iterator.CurrentItem().Type == "business")
           {
               Contact.Business_Contact bc;
               bc = new Contact.Business_Contact(list.Count(), "business", NameTextBox.Text, SurnameTextBox.Text, EmailTextBox.Text, PhoneNumberTextBox.Text);
               bc.address.City = CityTextBox.Text;
               bc.address.Country = CountryTextBox.Text;
               bc.address.Street = StreetTextBox.Text;
               bc.address.Zip_code = ZipCodeTextBox.Text;  
               bc.Business_phone = BusinessPhoneTextBox.Text;
               bc.Company_name = CompanyNameTextBox.Text;
               bc.Photo_path = PhotoTextBox.Text;
               bc.Fax = FaxTextBox.Text;
               list.EditContact(bc, iterator.CurrentItem());
           }
           else if (iterator.CurrentItem().Type == "social")
           {
               Contact.Social_Contact sc;
               sc = new Contact.Social_Contact(list.Count(), "social", NameTextBox.Text, SurnameTextBox.Text, EmailTextBox.Text, PhoneNumberTextBox.Text);
               sc.address.City = CityTextBox.Text;
               sc.address.Country = CountryTextBox.Text;
               sc.address.Street = StreetTextBox.Text;
               sc.address.Zip_code = ZipCodeTextBox.Text;
               sc.Facebook_page = FacebookTextBox.Text;
               sc.Birthday_date = BirthdayTextBox.Text;
               sc.Photo_path = PhotoTextBox.Text;
               list.EditContact(sc, iterator.CurrentItem());
           }
           ContactPreviewBox.Enabled = false;
           UpdateListViewItems();
        }

        private void ContactPreviewPhotoBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.ShowDialog();
                PhotoTextBox.Text = ofd.FileName;
                UpdatePhotoBox(ofd.FileName);
            }  
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            if(iterator.CurrentItem().Type == "business")
            {
                NameTextBox.Text = m.Bcontact.Name;
                SurnameTextBox.Text = m.Bcontact.Surname;
                PhoneNumberTextBox.Text = m.Bcontact.Phone_number;
                EmailTextBox.Text = m.Bcontact.Email;
                
                CountryTextBox.Text = m.Bcontact.address.Country;
                CityTextBox.Text = m.Bcontact.address.City;
                StreetTextBox.Text = m.Bcontact.address.Street;
                ZipCodeTextBox.Text = m.Bcontact.address.Zip_code;

                BusinessPhoneTextBox.Text = m.Bcontact.Business_phone;
                FaxTextBox.Text = m.Bcontact.Fax;
                CompanyNameTextBox.Text = m.Bcontact.Company_name;
            }
            else if(iterator.CurrentItem().Type == "social")
            {
                NameTextBox.Text = m.Scontact.Name;
                SurnameTextBox.Text = m.Scontact.Surname;
                PhoneNumberTextBox.Text = m.Scontact.Phone_number;
                EmailTextBox.Text = m.Scontact.Email;

                CountryTextBox.Text = m.Scontact.address.Country;
                CityTextBox.Text = m.Scontact.address.City;
                StreetTextBox.Text = m.Scontact.address.Street;
                ZipCodeTextBox.Text = m.Scontact.address.Zip_code;

                FacebookTextBox.Text = m.Scontact.Facebook_page;
                BirthdayTextBox.Text = m.Scontact.Birthday_date;
            }
            ContactPreviewBox.Enabled = false;
        }
    }
}
