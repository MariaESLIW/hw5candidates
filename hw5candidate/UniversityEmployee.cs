namespace hw5candidate
{
    public abstract class UniversityEmployee
    {
        public string TaxId { get; set; }
        public Person Person { get; set; }

        public UniversityEmployee(string taxId, Person person)
        {
            TaxId = taxId;
            Person = person;
        }

        public abstract String getOfficialDuties();
    }
}

