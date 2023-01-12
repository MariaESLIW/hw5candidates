using System;
namespace hw5candidate
{
    public class DegreeTeacher : Teacher
    {
        String degree;
        String title;
        public DegreeTeacher(String taxID, Person person, Course course, String degree, String title) : base(taxID, person, course)
        {
            this.degree = degree;
            this.title = title;
        }
    }
}

