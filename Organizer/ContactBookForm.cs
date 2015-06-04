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

namespace Organizer
{
    public partial class ContactBookForm : Form
    {
        ContactList.ContactList list;
        ContactList.ContactListIterator iterator = new ContactList.ContactListIterator();

        public ContactBookForm()
        {
            InitializeComponent();
            list = ContactList.ContactList.GetInstance();
        }
        
        private void ContactBook_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if(!Directory.Exists(path + "\\Address Book"))
                Directory.CreateDirectory(path + "\\Address Book");
            if(!File.Exists(path + "\\Address Book\\settings.xml"))
            {
                XmlTextWriter xW = new XmlTextWriter(path + "\\Address Book\\settings.xml", Encoding.UTF8);
                xW.WriteStartElement("Contacts");
                xW.WriteEndElement();
                xW.Close();
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Address Book\\settings.xml");
           

            //wcztytywanie kontaktow z listy
            string type_of_contact;
            foreach( XmlNode xNode in xDoc.SelectNodes("Contacts/Contact"))
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

                    sc.address.Country = xNode.SelectSingleNode("Country").InnerText;
                    sc.address.City = xNode.SelectSingleNode("City").InnerText;
                    sc.address.Street = xNode.SelectSingleNode("Street").InnerText;
                    sc.address.Zip_code = xNode.SelectSingleNode("Zip_code").InnerText;
                    
                    sc.Birthday_date = xNode.SelectSingleNode("Birthday_date").InnerText;
                    sc.Facebook_page = xNode.SelectSingleNode("Facebook_page").InnerText;
                    sc.Photo_id = xNode.SelectSingleNode("Photo_id").InnerText;
                    
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
               
                xId.InnerText = iterator.CurrentItem().Id.ToString();
                xName.InnerText = iterator.CurrentItem().Name;
                xSurname.InnerText = iterator.CurrentItem().Surname;
                xEmail.InnerText = iterator.CurrentItem().Email;
                xPhone_number.InnerText = iterator.CurrentItem().Phone_number;
                xZip_code.InnerText = iterator.CurrentItem().address.Zip_code;
                xCountry.InnerText = iterator.CurrentItem().address.Country;
                xCity.InnerText = iterator.CurrentItem().address.City;
                xStreet.InnerText = iterator.CurrentItem().address.Street;

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
                xDoc.DocumentElement.AppendChild(xTop);


                //zapisywanie socjala
                if (type_of_contact == "social")
                {
                    XmlNode xFacebook_page = xDoc.CreateElement("Facebook_page");
                    XmlNode xPhoto_id = xDoc.CreateElement("Photo_id");
                    XmlNode xBirthday_date = xDoc.CreateElement("Birthday_date");

                    Contact.Social_Contact scontact = (Contact.Social_Contact)list.Get(iterator.getCurrentIndex());
                    xFacebook_page.InnerText = scontact.Facebook_page;
                    xPhoto_id.InnerText = scontact.Photo_id;
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



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonRemoveContact_Click(object sender, EventArgs e)
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

        }


    }
}
