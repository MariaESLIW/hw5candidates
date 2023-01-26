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

        public abstract string GetOfficialDuties();

        public override bool Equals(object? obj)
        {
            return (obj != null) &&
                obj.GetType == this.GetType &&
                ((UniversityEmployee)obj).TaxId == this.TaxId;
        }
    }
}

