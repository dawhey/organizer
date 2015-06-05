using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList {
	public class ContactList {

		private int size = 0;
        private List<Contact.Contact> list;
        private static ContactList listInstance = null;
        
		private ContactList() 
        {
            list = new List<Contact.Contact>();
        }

		public void Add(Contact.Contact contact) 
        {
            list.Add(contact);
            size++;
        }

		public void Remove( int id) 
        {
            list.RemoveAt(id);
            size--;
        }

		public void EditContact(Contact.Contact new_contact, Contact.Contact old_contact)
        {
            int old_position = list.IndexOf(old_contact);
            list.Remove(old_contact);
            list.Insert(old_position, new_contact);
        }

		public List<Contact.Contact> GetAllContacts() 
        {
            return list;
   		}

		public int Count() 
        {
            return size;
        }
        
		public Contact.Contact Get(int id) 
        {
            return list.ElementAt(id);
		}

		public bool IsEmpty() 
        {
            if (list.Count == 0)
                return true;
            else
                return false;
		}

		public ContactListIterator CreateIterator() {
            ContactListIterator iterator = new ContactListIterator();
            return iterator;
		}

		public static ContactList GetInstance() {
            if (listInstance == null)
            {
                listInstance = new ContactList();
            }
                return listInstance;
        }
 	}
}
