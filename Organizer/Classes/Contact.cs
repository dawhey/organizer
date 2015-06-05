using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organizer.Classes;

namespace Contact {
	public abstract class Contact {

        public Contact(int id, String type, String name, String surname, String email, String phone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Phone_number = phone;
            Type = type;
            
            address = new Address();
        }
        public Contact()
        {
         
        }

        private String photo_path;
        public String Photo_path
        {
            get
            {
                return photo_path;
            }
            set
            {
                photo_path = value;
            }
        }

        private String type;
        public String Type {
            get {
                return type;
            }
            set {
                type = value;
            }
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
            get{
                return surname;
            }
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

		public Address address;


        public abstract Memento CreateMemento();
        public abstract void SetMemento(Memento m);
	}

}
