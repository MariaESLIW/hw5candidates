namespace hw5candidate
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Course(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"Course name: {Name}, Course description: {Description}";
        }
    }
}

