using System;
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
    public partial class ContactBookForm : Form
    {
        public ContactBookForm()
        {
            InitializeComponent();
        }

        private void ContactBook_Load(object sender, EventArgs e)
        {

        }

        private void ContactBook_FormClosing(object sender, FormClosingEventArgs e)
        {
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
