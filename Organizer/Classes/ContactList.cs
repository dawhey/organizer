using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList {
	public class ContactList {
		private int size = 0;
        private List<Contact.Contact> list;

		private ContactList() 
        {
			throw new System.Exception("Not implemented");
		}

		public void Add(Contact.Contact contact) 
        {
            list.Add(contact);
        }

		public void Remove( int id) 
        {
            list.Remove(list.ElementAt(id));
        }

		public void EditContact(Contact.Contact new_contact, Contact.Contact old_contact)
        {
            list.Insert(list.IndexOf(old_contact), new_contact);
        }

		public List<Contact.Contact> GetAllContacts() 
        {
            return list;
   		}

		public int Count() 
        {
            return list.Count;
        }
		public Contact.Contact Get(int id) 
        {
			throw new System.Exception("Not implemented");
		}

		public bool IsEmpty() 
        {
            if (list.Count == 0)
                return true;
            else
                return false;
		}

		public ContactListIterator CreateIterator() {
			throw new System.Exception("Not implemented");
		}
		public ContactList GetInstance() {
			throw new System.Exception("Not implemented");
		}

		private ContactListIterator contactListIterator;

	}

}
