using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList {
	public class ContactListIterator : Iterator  {
		private List<Contact.Contact> _list;
		private int current = 0;

		public ContactListIterator(List<Contact.Contact> list) {
			throw new System.Exception("Not implemented");
		}
		public override void First() {
			throw new System.Exception("Not implemented");
		}
		public override void Next() {
			throw new System.Exception("Not implemented");
		}
		public override Contact.Contact CurrentItem() {
			throw new System.Exception("Not implemented");
		}
		public override bool IsDone() {
			throw new System.Exception("Not implemented");
		}

		private ContactList contactList;

	}

}
