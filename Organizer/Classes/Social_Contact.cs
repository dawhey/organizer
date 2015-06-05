using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact {
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
            photo_id = null;
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
		private String photo_id;
		public String Photo_id {
			get {
				return photo_id;
			}
			set {
				photo_id = value;
			}
		}

	}

}
