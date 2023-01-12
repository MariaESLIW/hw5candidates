using System;
namespace hw5candidate
{
    public class Course
    {
        String name;
        String description;
        public Course(String name, String description)
        {
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {
            return "Course name: " + this.name + ", Course description: " + this.description;
        }
    }
}

