using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList {
	public abstract class Iterator {
		protected Iterator() {
			throw new System.Exception("Not implemented");
		}
		public abstract void First();
		public abstract void Next();
		public abstract Contact.Contact CurrentItem();
		public abstract bool IsDone();

	}

}
