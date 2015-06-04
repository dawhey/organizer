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

namespace Organizer
{
    public partial class ContactBookForm : Form
    {
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
                File.Create(path + "\\Address Book\\settings.xml");
        }

        private void ContactBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddContactClick(object sender, EventArgs e)
        {
            AddContactForm ac = new AddContactForm();
            ac.Show();
        }
    }
}
