using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact {

	public class Business_Contact : Contact  {

        public Business_Contact(int id, String name, String surname, String email, String phone) : base(id, name, surname, email, phone)
        {
			throw new System.Exception("Not implemented");
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

	}

}
