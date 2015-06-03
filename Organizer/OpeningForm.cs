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
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactBookForm cb = new ContactBookForm();
            cb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shopping list not yet implemented.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calendar not yet implemented.");
        }

        private void Select_module_Load(object sender, EventArgs e)
        {

        }
    }
}
