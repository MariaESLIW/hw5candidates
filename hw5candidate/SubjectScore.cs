namespace hw5candidate
{
	public class SubjectScore
	{
        public string SubjectName { get; set; }
        public int Score { get; set; }

        public SubjectScore(string subjectName, int score)
		{
			SubjectName = subjectName;
			Score = score;
		}
	}
}

