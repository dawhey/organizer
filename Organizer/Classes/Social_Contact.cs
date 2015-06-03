using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact {
	public class Social_Contact : Contact  {

        public Social_Contact(int id, String name, String surname, String email, String phone) : base(id, name, surname, email, phone)
        {
			throw new System.Exception("Not implemented");
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
