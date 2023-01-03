using System;
namespace hw5candidate
{
	public class Address
	{

		String city;
		String street;
		int houseNumber;
		int flatNumber;

		public Address(String city, String street, int houseNumber, int flatNumber)
		{
			this.city = city;
			this.street = street;
			this.houseNumber = houseNumber;
			this.flatNumber = flatNumber;
		}

		public String getStreet()
		{
			return this.street;
		}
	}
}

