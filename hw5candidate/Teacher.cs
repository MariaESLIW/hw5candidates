using System;
namespace hw5candidate
{
    public class Teacher : UniversityEmployee
    {
        Course course;
        public Teacher(String taxID, Person person, Course course) : base(taxID, person)
        {
            this.course = course;
        }
        public override string getOfficialDuties()
        {
            return course.ToString()!;
        }
    }
}

