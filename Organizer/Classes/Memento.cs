using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Classes
{
    public class Memento
    {
        private Contact.Business_Contact bcontact = null;
        public Contact.Business_Contact Bcontact
        {
            get
            {
                return bcontact;
            }           
        }

        private Contact.Social_Contact scontact = null;
        public Contact.Social_Contact Scontact
        {
            get
            {
                return scontact;
            }
        }

        public Memento(Contact.Social_Contact sc)
        {
            scontact = sc;
        }
        public Memento(Contact.Business_Contact bc)
        {
            bcontact = bc;
        }
    }
}
