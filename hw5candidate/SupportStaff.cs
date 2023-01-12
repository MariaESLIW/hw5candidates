using System;
namespace hw5candidate
{
    public class SupportStaff : UniversityEmployee
    {
        String duties;
        public SupportStaff(String taxID, Person person, String duties) : base(taxID, person)
        {
            this.duties = duties;
        }
        public override string getOfficialDuties()
        {
            return duties;
        }
    }
}

