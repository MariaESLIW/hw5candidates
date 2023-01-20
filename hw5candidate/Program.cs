using hw5candidate;
internal class Program
{
    private static void Main(string[] args)
    {
        // Create array of candidates (task 0.5)
        Candidate[] candidates = InputData.CreateCandidates();

        // Print streets (task 1.6)
        PrintStreets(candidates);

        // Print maxSubjectScore (task 1.7)
        PrintMaxSubjectScore(candidates);

        // task 2.8 create array of university employees
        UniversityEmployee[] employees = InputData.CreateUniversityEmployees();

        // task 2.9 - all employees with duties
        PrintEmployeesDuties(employees);

        // task 2.10 - only teachers with courses
        PrintTeaches(employees);

        // task 3.3 - create and initialize university
        University PIG = InputData.CreateUniversity();
    }

    // Print streets (task 1.6)
    public static void PrintStreets(Candidate[] candidates)
    {
        // Print streets (task 1.6)
        for (int i = 0; i < candidates.Length; i++)
        {
            string street = candidates[i].Person.Address.Street;
            Console.WriteLine(street);
        }
    }

    // Print maxSubjectScore (task 1.7)
    public static void PrintMaxSubjectScore(Candidate[] candidates)
    {
        
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
    }

    // task 2.9 - all employees with duties
    public static void PrintEmployeesDuties(UniversityEmployee[] employees)
    {
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"{employees[i].Person.getName()}: {employees[i].getOfficialDuties()}");
        }
    }

    // task 2.10 - only teachers with courses
    public static void PrintTeaches(UniversityEmployee[] employees)
    {
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i] is Teacher)
            {
                Console.WriteLine($"{employees[i].Person.getName()}: {employees[i].getOfficialDuties()}");
            }
        }
    }
}