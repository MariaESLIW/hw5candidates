using System;
namespace hw5candidate
{
	public class InputData
	{
		public InputData()
		{
		}

        // Create array of candidates (task 1.5)
        public static List<Candidate> CreateCandidates()
        {
            var candidates = new List<Candidate>();

            List<SubjectScore> subjectScores0 = new List<SubjectScore>
            {
                new SubjectScore("Physics", 10),
                new SubjectScore("Math", 7),
                new SubjectScore("History", 5)
            };
            candidates.Add(new Candidate(
                new Person("Vasilii", "Vasiliev",
                new Address("Minsk", "Chapaeva", 5, 100)),
                subjectScores0));

            List<SubjectScore> subjectScores1 = new List<SubjectScore>
                {
                new SubjectScore("Physics", 9),
                new SubjectScore("Math", 8),
                new SubjectScore("History", 6)
            };
            candidates.Add(new Candidate(
                    new Person("Petia", "Petrov",
                    new Address("Wroclaw", "SilverTower", 5, 78)),
                    subjectScores1));

            List<SubjectScore> subjectScores2 = new List<SubjectScore>
                {
                new SubjectScore("Physics", 6),
                new SubjectScore("Math", 8),
                new SubjectScore("History", 7)
            };
            candidates.Add( new Candidate(
                new Person("Sasha", "Sashov",
                new Address("Minsk", "Gurskogo", 1, 2)),
                subjectScores2));

            List<SubjectScore> subjectScores3 = new List<SubjectScore>
                {
                new SubjectScore("Physics", 8),
                new SubjectScore("Math", 9),
                new SubjectScore("History", 6)
            };
            candidates.Add (new Candidate(
                new Person("Taras Tarasov", "Petrov",
                new Address("Lviv", "Kultparkivska", 7, 95)),
                subjectScores3));

            List<SubjectScore> subjectScores4 = new List<SubjectScore>
                {
                new SubjectScore("Physics", 3),
                new SubjectScore("Math", 5),
                new SubjectScore("History", 7)
            };
            candidates.Add( new Candidate(
                new Person("Gogi", "Gogadze",
                new Address("Batumi", "Batumadze", 105, 79)),
                subjectScores4));

            return candidates;
        }

        // task 2.8 create array of university employees
        public static List<UniversityEmployee> CreateUniversityEmployees()
        {
            var universityEmployee1 = new Teacher(
                "301011975B072PB1",
                new Person("Vasilii", "Vasiliev",
                new Address("Minsk", "Chapaeva", 5, 100)),
                new Course("Physics", "About everything"));

            var universityEmployee2 = new Teacher(
                "301011965B068PB3",
                new Person("Petia", "Petrov",
                new Address("Wroclaw", "SilverTower", 5, 78)),
                new Course("ComputerScience", "Java"));

            var universityEmployee3 = new SupportStaff(
                "301011980B072PB7",
                new Person("Sasha", "Sashov",
                new Address("Minsk", "Gurskogo", 1, 2)), "driver");

            var universityEmployee4 = new SupportStaff(
                "301011990B072PB5",
                new Person("Taras", "Tarasov",
                new Address("Lviv", "Kultparkivska", 7, 95)), "security");

            var universityEmployee5 = new SupportStaff(
                "401011960B072PB9",
                new Person("Gogi", "Gogadze",
                new Address("Batumi", "Batumadze", 105, 79)), "dean");

            List<UniversityEmployee> employees = new List<UniversityEmployee>
                {
                universityEmployee1,
                universityEmployee2,
                universityEmployee3,
                universityEmployee4,
                universityEmployee5
            };

            return employees;
        }

        // task 3.3 - create university
        public static University CreateUniversity()
        {
            List<Room> rooms1 = new List<Room>
                {
                new Room(RoomType.Auxiliary, 123),
                new Room(RoomType.Laboratory,55),
                new Room(RoomType.Lecture, 77)
                 };
            List<Room> rooms2 = new List<Room>
                {
                new Room(RoomType.Seminar, 35),
                new Room(RoomType.Lecture,100),
                new Room(RoomType.Lecture, 77)
                };

            List<Building> buildings = new List<Building>
                {
                new Building(rooms1, new Address("Minsk", "Skaryny", 77, 1)),
                new Building(rooms2, new Address("Minsk", "Skaryny", 75, 21))
            };

            var rector = new DegreeTeacher(
                "301015577B072PB1",
                new Person("Vladislav", "Vlasov",
                new Address("Minsk", "Skaryny", 75, 34)),
                new Course("Math", "Linear Algebra"),
                "PhD", "Professor");

            var university = new University(
                CreateUniversityEmployees(),
                rector,
                buildings,
                new Address("Minsk", "Skaryny", 15, 3));

            return university;
        }
    }
}

