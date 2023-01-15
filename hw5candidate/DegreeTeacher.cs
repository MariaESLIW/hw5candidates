namespace hw5candidate
{
    public class DegreeTeacher : Teacher
    {
        public string Degree { get; set; }
        public string Title { get; set; }
        public DegreeTeacher(string taxId, Person person, Course course, string degree, string title) :
            base(taxId, person, course)
        {
            Degree = degree;
            Title = title;
        }
    }
}

