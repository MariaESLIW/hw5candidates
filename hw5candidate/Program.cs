using hw5candidate;
internal class Program
{
    private static void Main(string[] args)
    {
        // Create array of candidates (task 0.5)
        Candidate[] candidates = createCandidates();

        // Print streets (task 1.6)
        for (int i = 0; i < candidates.Length; i++)
        {
            string street = candidates[i].Person.Address.Street;
            Console.WriteLine(street);
        }

        // Print maxSubjectScore (task 1.7)
        int maxScore = 0;
        string subject = "Math";  // subject for which we try to find maxScore
        bool isContained = false; // chech if subject contained subjectScores of candidates

        for (int i = 0; i < candidates.Length; i++)
        {
            SubjectScore[] scores = candidates[i].SubjectScores;
            for (int j = 0; j < scores.Length; j++)
            {
                string subjectName = scores[j].SubjectName;
                if (subject == subjectName)
                {
                    isContained = true;
                    int score = scores[j].Score;
                    if (score > maxScore)
                    {
                        maxScore = score;
                    }
                }
            }
        }

        // Check if there's such a subject in the subjectScores
        if (isContained)
        {
            Console.WriteLine($"\n{subject} subject maxScore: {maxScore}");
        }
        else
        {
            Console.WriteLine($"\nThere's no such subject as a {subject} in subject scores.");
        }

        // task 2.8 create array of university employees
        UniversityEmployee[] employees = createUniversityEmployees();

        // task 2.9 - all employees with duties
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"{employees[i].Person.getName()}: {employees[i].getOfficialDuties()}");
        }


        // task 2.10 - only teachers with courses
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i] is Teacher)
            {
                Console.WriteLine($"{employees[i].Person.getName()}: {employees[i].getOfficialDuties()}");
            }
        }

    }

    public static UniversityEmployee[] createUniversityEmployees()
    {
        // task 2.8 create array of university employees
        UniversityEmployee universityEmployee1 = new Teacher("301011975B072PB1",
            new Person("Vasilii", "Vasiliev", new Address("Minsk", "Chapaeva", 5, 100)),
            new Course("Physics", "About everything"));

        UniversityEmployee universityEmployee2 = new Teacher("301011965B068PB3",
            new Person("Petia", "Petrov", new Address("Wroclaw", "SilverTower", 5, 78)),
            new Course("ComputerScience", "Java"));

        UniversityEmployee universityEmployee3 = new SupportStaff("301011980B072PB7",
            new Person("Sasha", "Sashov", new Address("Minsk", "Gurskogo", 1, 2)), "driver");

        UniversityEmployee universityEmployee4 = new SupportStaff("301011990B072PB5",
            new Person("Taras", "Tarasov", new Address("Lviv", "Kultparkivska", 7, 95)), "security");

        UniversityEmployee universityEmployee5 = new SupportStaff("401011960B072PB9",
            new Person("Gogi", "Gogadze", new Address("Batumi", "Batumadze", 105, 79)), "rector");

        UniversityEmployee[] employees =
            {
            universityEmployee1,
            universityEmployee2,
            universityEmployee3,
            universityEmployee4,
            universityEmployee5
        };

        return employees;
    }

    public static Candidate[] createCandidates()
    {
        // Create array of candidates (task 1.5)
        Candidate[] candidates = new Candidate[5];

        Address address = new Address("Minsk", "Chapaeva", 5, 100);
        Person person = new Person("Vasilii", "Vasiliev", address);
        SubjectScore subjectScore1 = new SubjectScore("Physics", 10);
        SubjectScore subjectScore2 = new SubjectScore("Math", 7);
        SubjectScore subjectScore3 = new SubjectScore("History", 5);
        SubjectScore[] subjectScores0 = { subjectScore1, subjectScore2, subjectScore3 };
        candidates[0] = new Candidate(person, subjectScores0);

        address = new Address("Wroclaw", "SilverTower", 5, 78);
        person = new Person("Petia", "Petrov", address);
        subjectScore1 = new SubjectScore("Physics", 9);
        subjectScore2 = new SubjectScore("Math", 8);
        subjectScore3 = new SubjectScore("History", 6);
        SubjectScore[] subjectScores1 = { subjectScore1, subjectScore2, subjectScore3 };
        candidates[1] = new Candidate(person, subjectScores1);

        address = new Address("Minsk", "Gurskogo", 1, 2);
        person = new Person("Sasha", "Sashov", address);
        subjectScore1 = new SubjectScore("Physics", 6);
        subjectScore2 = new SubjectScore("Math", 8);
        subjectScore3 = new SubjectScore("History", 7);
        SubjectScore[] subjectScores2 = { subjectScore1, subjectScore2, subjectScore3 };
        candidates[2] = new Candidate(person, subjectScores2);

        address = new Address("Lviv", "Kultparkivska", 7, 95);
        person = new Person("Taras Tarasov", "Petrov", address);
        subjectScore1 = new SubjectScore("Physics", 8);
        subjectScore2 = new SubjectScore("Math", 9);
        subjectScore3 = new SubjectScore("History", 6);
        SubjectScore[] subjectScores3 = { subjectScore1, subjectScore2, subjectScore3 };
        candidates[3] = new Candidate(person, subjectScores3);

        address = new Address("Batumi", "Batumadze", 105, 79);
        person = new Person("Gogi", "Gogadze", address);
        subjectScore1 = new SubjectScore("Physics", 3);
        subjectScore2 = new SubjectScore("Math", 5);
        subjectScore3 = new SubjectScore("History", 7);
        SubjectScore[] subjectScores4 = { subjectScore1, subjectScore2, subjectScore3 };
        candidates[4] = new Candidate(person, subjectScores4);

        return candidates;
    }
}