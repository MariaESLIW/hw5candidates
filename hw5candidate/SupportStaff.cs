namespace hw5candidate
{
    public class SupportStaff : UniversityEmployee
    {
        public string Duties { get; set; }
        public SupportStaff(String taxId, Person person, String duties) : base(taxId, person)
        {
            Duties = duties;
        }
        public override string getOfficialDuties()
        {
            return Duties;
        }
    }
}

