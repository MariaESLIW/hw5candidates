﻿namespace hw5candidate
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Address Address { get; set; }

        public Person(string firstname, string lastname, Address address)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
        }

        public string getName()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}

