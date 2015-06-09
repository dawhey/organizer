using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organizer.Classes;


namespace Contact {
	public class Business_Contact : Contact  {

        public Business_Contact(int id, String type, String name, String surname, String email, String phone) : base(id, type, name, surname, email, phone) {}
        public Business_Contact()
        {
            Id = 0;
            Type = "business";
            Name = null;
            Surname = null;
            Email = null;
            Phone_number = null;
            company_name = null;
            fax = null;
            business_phone = null;
            Photo_path = null;
            address = new Address();
        }
        
		private String company_name;
		public String Company_name {
			get {
				return company_name;
			}
			set {
				company_name = value;
			}
		}
		private String fax;
		public String Fax {
			get {
				return fax;
			}
			set {
				fax = value;
			}
		}
		private String business_phone;
		public String Business_phone {
			get {
				return business_phone;
			}
			set {
				business_phone = value;
			}
		}

        public override Memento CreateMemento()
        {
            return new Memento(this);
        }

        public override void SetMemento(Memento m)
        {
            Name = m.Bcontact.Name;
            Surname = m.Bcontact.Surname;
            Type = m.Bcontact.Type;
            Email = m.Bcontact.Email;
            Phone_number = m.Bcontact.Phone_number;
            Photo_path = m.Bcontact.Photo_path;
            Fax = m.Bcontact.Fax;
            Company_name = m.Bcontact.Company_name;
            Business_phone = m.Bcontact.Business_phone;
        }

	}

}
