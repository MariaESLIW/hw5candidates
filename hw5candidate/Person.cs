using System;
namespace hw5candidate
{
	public class Person
	{
		String firstname;
		String lastname;
		hw5candidate.Address address;

		public Person(String firstname, String lastname, hw5candidate.Address address)
		{
			this.firstname = firstname;
			this.lastname = lastname;
			this.address = address;
		}

		public hw5candidate.Address getAddress()
		{
			return this.address;
		}

    }
}

