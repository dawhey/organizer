using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact {
	public abstract class Contact {

        public Contact(int id, String name, String surname, String email, String phone)
        {
            throw new System.Exception("Not implemented");
        }

		private int id;
		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}
		private String name;
		public String Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}
		private String surname;
		public String Surname {
			set {
				surname = value;
			}
		}
		private String email;
		public String Email {
			get {
				return email;
			}
			set {
				email = value;
			}
		}
		private String phone_number;
		public String Phone_number {
			get {
				return phone_number;
			}
			set {
				phone_number = value;
			}
		}

		private Address address;

	}

}
