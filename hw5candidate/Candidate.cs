﻿namespace hw5candidate
{
	public class Candidate
	{
		public Person Person { get; set; }
		public SubjectScore[] SubjectScores { get; set; }

		public Candidate(Person person, SubjectScore[] subjectScores)
		{
			Person = person;
			SubjectScores = subjectScores;
		}
	}
}

