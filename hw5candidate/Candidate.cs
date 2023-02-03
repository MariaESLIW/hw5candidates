namespace hw5candidate
{
	public class Candidate
	{
		public Person Person { get; set; }
		public List<SubjectScore> SubjectScores { get; set; }

		public Candidate(Person person, List<SubjectScore> subjectScores)
		{
			Person = person;
			SubjectScores = subjectScores;
		}

        public override bool Equals(object? obj)
        {
            return (obj != null) &&
                obj.GetType == this.GetType &&
                ((Candidate)obj).Person == this.Person &&
                ((Candidate)obj).SubjectScores == this.SubjectScores;
        }
    }
}

