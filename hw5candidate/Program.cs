using hw5candidate;
// Create array of candidates (task 5)
hw5candidate.Candidate[] candidates = new hw5candidate.Candidate[5];

hw5candidate.Address address = new hw5candidate.Address("Minsk", "Chapaeva", 5, 100);
hw5candidate.Person person = new hw5candidate.Person("Vasilii", "Vasiliev", address);
hw5candidate.SubjectScore subjectScore1 = new hw5candidate.SubjectScore("Physics", 10);
hw5candidate.SubjectScore subjectScore2 = new hw5candidate.SubjectScore("Math", 7);
hw5candidate.SubjectScore subjectScore3 = new hw5candidate.SubjectScore("History", 5);
hw5candidate.SubjectScore[] subjectScores0 = {subjectScore1, subjectScore2, subjectScore3 };
candidates[0] = new hw5candidate.Candidate(person, subjectScores0);

address = new hw5candidate.Address("Wroclaw", "SilverTower", 5, 78);
person = new hw5candidate.Person("Petia", "Petrov", address);
subjectScore1 = new hw5candidate.SubjectScore("Physics", 9);
subjectScore2 = new hw5candidate.SubjectScore("Math", 8);
subjectScore3 = new hw5candidate.SubjectScore("History", 6);
hw5candidate.SubjectScore[] subjectScores1 = { subjectScore1, subjectScore2, subjectScore3 };
candidates[1] = new hw5candidate.Candidate(person, subjectScores1);

address = new hw5candidate.Address("Minsk", "Gurskogo", 1, 2);
person = new hw5candidate.Person("Sasha", "Sashov", address);
subjectScore1 = new hw5candidate.SubjectScore("Physics", 6);
subjectScore2 = new hw5candidate.SubjectScore("Math", 8);
subjectScore3 = new hw5candidate.SubjectScore("History", 7);
hw5candidate.SubjectScore[] subjectScores2 = { subjectScore1, subjectScore2, subjectScore3 };
candidates[2] = new hw5candidate.Candidate(person, subjectScores2);

address = new hw5candidate.Address("Lviv", "Kultparkivska", 7, 95);
person = new hw5candidate.Person("Taras Tarasov", "Petrov", address);
subjectScore1 = new hw5candidate.SubjectScore("Physics", 8);
subjectScore2 = new hw5candidate.SubjectScore("Math", 9);
subjectScore3 = new hw5candidate.SubjectScore("History", 6);
hw5candidate.SubjectScore[] subjectScores3 = { subjectScore1, subjectScore2, subjectScore3 };
candidates[3] = new hw5candidate.Candidate(person, subjectScores3);

address = new hw5candidate.Address("Batumi", "Batumadze", 105, 79);
person = new hw5candidate.Person("Gogi", "Gogadze", address);
subjectScore1 = new hw5candidate.SubjectScore("Physics", 3);
subjectScore2 = new hw5candidate.SubjectScore("Math", 5);
subjectScore3 = new hw5candidate.SubjectScore("History", 7);
hw5candidate.SubjectScore[] subjectScores4 = { subjectScore1, subjectScore2, subjectScore3 };
candidates[4] = new hw5candidate.Candidate(person, subjectScores4);

// Print streets (task 6)
for (int i=0; i<candidates.Length; i++)
{
   String street= candidates[i].getPerson().getAddress().getStreet();
    Console.WriteLine(street);
}

// Print maxSubjectScore (task 7)
int maxScore = 0;
String subject = "Math";  // subject for which we try to find maxScore
Boolean isContained = false; // chech if subject contained subjectScores of candidates
 
for (int i = 0; i < candidates.Length; i++)
{
    hw5candidate.SubjectScore[] scores = candidates[i].getSubjectScores();
    for (int j=0; j<scores.Length; j++)
    {
        String subjectName = scores[j].getSubjectName();
        if (subject == subjectName)
        {
            isContained = true;
            int score = scores[j].getScore();
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
    Console.WriteLine("\n" + subject + " subject maxScore: " + maxScore);
} else
{
    Console.WriteLine("\nThere's no such subject as a " + subject + " in subject scores.");
}
