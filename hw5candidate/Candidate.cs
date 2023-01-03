using System;
namespace hw5candidate
{
	public class Candidate
	{
		hw5candidate.Person person;
		hw5candidate.SubjectScore[] subjectScores;

		public Candidate(hw5candidate.Person person, hw5candidate.SubjectScore[] subjectScores)
		{
			this.person = person;
			this.subjectScores = subjectScores;
		}

		public hw5candidate.Person getPerson()
		{
			return this.person;
		}

		public hw5candidate.SubjectScore[] getSubjectScores()
		{
			return this.subjectScores;
		}
	}
}

