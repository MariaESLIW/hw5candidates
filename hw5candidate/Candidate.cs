using System;

namespace hw5candidate
{
	public class Candidate
	{
		Person person;
		SubjectScore[] subjectScores;

		public Candidate(Person person, SubjectScore[] subjectScores)
		{
			this.person = person;
			this.subjectScores = subjectScores;
		}

		public Person getPerson()
		{
			return this.person;
		}

		public SubjectScore[] getSubjectScores()
		{
			return this.subjectScores;
		}
	}
}

