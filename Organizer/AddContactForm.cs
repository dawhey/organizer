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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
            SocialGroupBox.Visible = false;
            BusinessGroupBox.Visible = false;
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {

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
    }
}
