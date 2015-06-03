using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList {
	public class ContactList {
		private int size = 0;
        private List<Contact.Contact> list;

		private ContactList() {
			throw new System.Exception("Not implemented");
		}
		public void Add(Contact.Contact contact) {
			throw new System.Exception("Not implemented");
		}
		public void Remove(ref int id) {
			throw new System.Exception("Not implemented");
		}
		public void EditContact(Contact.Contact new_contact, int old_contact_id) {
			throw new System.Exception("Not implemented");
		}
		public Contact.Contact GetAllContacts() {
			throw new System.Exception("Not implemented");
		}
		public int Count() {
			throw new System.Exception("Not implemented");
		}
		public Contact.Contact Get(int id) {
			throw new System.Exception("Not implemented");
		}
		public bool IsEmpty() {
			throw new System.Exception("Not implemented");
		}
		public int Length() {
			throw new System.Exception("Not implemented");
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
