using System;
namespace hw5candidate
{
    public class Person
    {
        String firstname;
        String lastname;
        Address address;

        public Person(String firstname, String lastname, Address address)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
        }

        public Address getAddress()
        {
            return this.address;
        }

        public String getName()
        {
            return this.firstname + this.lastname;
        }

    }
}

