using System;
using Organizer.Classes;

namespace Contact
{
    public class Social_Contact : Contact  {

        public Social_Contact(int id, String type, String name, String surname, String email, String phone) : base(id, type, name, surname, email, phone) {}
        public Social_Contact()
        {
            Id = 0;
            Type = "social";
            Name = null;
            Surname = null;
            Email = null;
            Phone_number = null;
            facebook_page = null;
            birthday_date = null;
            Photo_path = null;
            address = new Address();
        }
        
		private String facebook_page;
		public String Facebook_page {
			get {
				return facebook_page;
			}
			set {
				facebook_page = value;
			}
		}
		private String birthday_date;
		public String Birthday_date {
			get {
				return birthday_date;
			}
			set {
				birthday_date = value;
			}
		}

        public override Memento CreateMemento()
        {
            return new Memento(this);
        }

        public override void SetMemento(Memento m)
        {
            Name = m.Scontact.Name;
            Surname = m.Scontact.Surname;
            Type = m.Scontact.Type;
            Email = m.Scontact.Email;
            Phone_number = m.Scontact.Phone_number;
            Photo_path = m.Scontact.Photo_path;
            Facebook_page = m.Scontact.Facebook_page;
            Birthday_date = m.Scontact.Birthday_date;
        }
    }

}
