namespace hw5candidate
{
	public class SubjectScore
	{
        public string SubjectName { get; set; }
        public int Score
		{
			get
			{
				return _score;
			}
			set
            {
                if (value > 0)
                {
                    _score = value;
                }
            }
        }
		private int _score;

        public SubjectScore(string subjectName, int score)
		{
			SubjectName = subjectName;
			Score = score;
		}
	}
}

