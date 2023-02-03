namespace hw5candidate
{
    public class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }

        public Teacher(string taxId, Person person, Course course) : base(taxId, person)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return Course.ToString();
        }
    }
}

