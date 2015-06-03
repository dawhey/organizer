using System;
namespace Contact {
	public class Address {
		
        public Address(String _country, String _city, String _street, String _zip_code)
        {
            Country = _country;
            City = _city;
            Street = _street;
            Zip_code = _zip_code;
        }

        private String country;
		public String Country {
			get {
				return country;
			}
			set {
				country = value;
			}
		}
		private String city;
		public String City {
			get {
				return city;
			}
			set {
				city = value;
			}
		}
		private String street;
		public String Street {
			get {
				return street;
			}
			set {
				street = value;
			}
		}
		private String zip_code;
		public String Zip_code {
			get {
				return zip_code;
			}
			set {
				zip_code = value;
			}
		}

		private Contact contact;

	}

}
