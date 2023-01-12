using System;
namespace hw5candidate
{
    public abstract class UniversityEmployee
    {
        String taxID;
        Person person;

        public UniversityEmployee(String taxID, Person person)
        {
            this.taxID = taxID;
            this.person = person;
        }

        public abstract String getOfficialDuties();

        public Person getPerson()
        {
            return this.person;
        }
    }
}

