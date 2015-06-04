﻿using System;
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
      
        public ContactBookForm()
        {
            InitializeComponent();
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
        }

        private void ContactBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            xDoc.Load(path + "\\Address Book\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("Contacts");
           // xNode.RemoveAll();

            ContactList.ContactListIterator iterator = new ContactList.ContactListIterator();
            //iterator = list.CreateIterator();
            
            for(iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                XmlNode xTop = xDoc.CreateElement("Contact");
                XmlNode xId = xDoc.CreateElement("Id");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xSurname = xDoc.CreateElement("Surname");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xPhone_number = xDoc.CreateElement("Phone_number");
                XmlNode xType = xDoc.CreateElement("Type_of_contact");
                xId.InnerText = iterator.CurrentItem().Id.ToString();
                xName.InnerText = iterator.CurrentItem().Name;
                xSurname.InnerText = iterator.CurrentItem().Surname;
                xEmail.InnerText = iterator.CurrentItem().Email;
                xPhone_number.InnerText = iterator.CurrentItem().Phone_number;
                xType.InnerText = iterator.CurrentItem().Type;
                xTop.AppendChild(xId);
                xTop.AppendChild(xName);
                xTop.AppendChild(xSurname);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xPhone_number);
                xTop.AppendChild(xType);
                xDoc.DocumentElement.AppendChild(xTop);
            }
            xDoc.Save(path + "\\Address Book\\settings.xml");

            Application.Exit();
        }

        private void AddContactClick(object sender, EventArgs e)
        {
            AddContactForm ac = new AddContactForm(this);
            ac.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
