using hw5candidate;
internal class Program
{
    private static void Main(string[] args)
    {
        // Create array of candidates (task 0.5)
        List<Candidate> candidates = InputData.CreateCandidates();

        // Print streets (task 1.6)
        PrintStreets(candidates);

        // Print maxSubjectScore (task 1.7)
        PrintMaxSubjectScore(candidates);

        // task 2.8 create array of university employees
        List<UniversityEmployee> employees = InputData.CreateUniversityEmployees();

        // task 2.9 - all employees with duties
        PrintEmployeesDuties(employees);

        // task 2.10 - only teachers with courses
        PrintTeaches(employees);

        // task 3.3 - create and initialize university
        University PIG = InputData.CreateUniversity();

        // task 5.1 - print employees with last names begin with given letter
        var letter = 'P';
        PrintSortedEmployees(letter, PIG);

        // task 5.2 - print employees with course
        var courseName = "ComputerScience";
        PrintEmployeeWithSelectedCourse(courseName, PIG);

        // task 5.3 - print TaxId and Duties
        PrintTaxIdAndDuties(PIG);

        // task 5.4 - print Addresses of Buildings with Selected Room
        PrintAddressesBuildingRoom(PIG, 77);

        // task 5.5 - print Address of Building with Maximum Room Number
        PrintAdressMaxRoom(PIG);

        // task 5.6 - print Most Common Lastname
        PrintMostCommonLastname(PIG);

    }

    // Print streets (task 1.6)
    public static void PrintStreets(List<Candidate> candidates)
    {
        // Print streets (task 1.6)
        for (int i = 0; i < candidates.Count; i++)
        {
            string street = candidates[i].Person.Address.Street;
            Console.WriteLine(street);
        }
    }

    // Print maxSubjectScore (task 1.7)
    public static void PrintMaxSubjectScore(List<Candidate> candidates)
    {
        
        int maxScore = 0;
        string subject = "Math";  // subject for which we try to find maxScore
        bool isContained = false; // chech if subject contained subjectScores of candidates

        for (int i = 0; i < candidates.Count; i++)
        {
            List<SubjectScore> scores = candidates[i].SubjectScores;
            for (int j = 0; j < scores.Count; j++)
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
    public static void PrintEmployeesDuties(List<UniversityEmployee> employees)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine($"{employees[i].Person.getName()}: {employees[i].GetOfficialDuties()}");
        }
    }

    // task 2.10 - only teachers with courses
    public static void PrintTeaches(List<UniversityEmployee> employees)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            if (employees[i] is Teacher)
            {
                Console.WriteLine($"{employees[i].Person.getName()}: {employees[i].GetOfficialDuties()}");
            }
        }
    }

    // task 5.1
    public static void PrintSortedEmployees(char letter, University university)
    {
        var selectedEmployees = university.UniversityEmployees
            .Where(empl => empl.Person.Lastname.StartsWith(letter))
            .OrderBy(lastName => lastName.TaxId)
            .ToList();

        foreach (UniversityEmployee universityEmployee in selectedEmployees)
        {
            Console.WriteLine(universityEmployee.Person.Lastname + universityEmployee.TaxId);
        }
    }

    // task 5.2 - print employees with course
    public static void PrintEmployeeWithSelectedCourse(string courseName, University university)
    {
        var selectedEmployees = university.UniversityEmployees.OfType<Teacher>()
            .Where(empl => empl.Course.Name.Equals(courseName))
            .ToList();

        foreach (UniversityEmployee universityEmployee in selectedEmployees)
        {
            Console.WriteLine(universityEmployee.Person.Lastname + universityEmployee.GetOfficialDuties());
        }

    }

    // task 5.3 - print TaxId and Duties
    public static void PrintTaxIdAndDuties(University university)
    {
        var listOfTaxIdAndDuties = university
            .UniversityEmployees
            .Select(empl => (empl.TaxId, empl.GetOfficialDuties()))
            .ToList();

        foreach(var item in listOfTaxIdAndDuties)
        {
            Console.WriteLine(item);
        }
    }

    // task 5.4 - print Addresses of Buildings with Selected Room
    public static void PrintAddressesBuildingRoom(University university, int roomNumber)
    {
        var listOfAddresses = university
            .Buildings
            .Where(building => building.Rooms.Any(room => room.RoomNumber == roomNumber))
            .Select(building => (building.Address.City, building.Address.Street, building.Address.HouseNumber))
            .ToList();

        foreach(var item in listOfAddresses)
        {
            Console.WriteLine(item);
        }

    }

    // task 5.5 - print Address of Building with Maximum Room Number
    public static void PrintAdressMaxRoom(University university)
    {
        var listOfBuildings = university
            .Buildings
            .MaxBy(building => building.Rooms.Count());

        Console.WriteLine(listOfBuildings.Address.City+
                          listOfBuildings.Address.Street+
                          listOfBuildings.Address.HouseNumber);
    }

    // task 5.6 - print Most Common Lastname
    public static void PrintMostCommonLastname(University university)
    {
        var mostCommonLastname = university
            .UniversityEmployees
            .GroupBy(employee => employee.Person.Lastname)
            .MaxBy(lastname => lastname.Count());

        Console.WriteLine(mostCommonLastname.Key + mostCommonLastname.Count());
    }

}