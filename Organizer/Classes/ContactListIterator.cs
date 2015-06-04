using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList {
	public class ContactListIterator : Iterator  {
		//private List<Contact.Contact> _list;
		private int _current = 0;
        public ContactList _list;

        // public ContactListIterator(List<Contact.Contact> list)
		public ContactListIterator() {
            _list = ContactList.GetInstance();
            //_list = list;
            _current = 0;
		}
		public override void First() {
            _current = 0;
		}
		public override void Next() {
            _current++;
		}
		public override Contact.Contact CurrentItem() {
            if (IsDone()) {
                // wywala okno z b³êdem
                return null;
            }
            return _list.Get(_current);
		}
		public override bool IsDone() {
            if (_current >= _list.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
		}

		private ContactList contactList;

	}

}
