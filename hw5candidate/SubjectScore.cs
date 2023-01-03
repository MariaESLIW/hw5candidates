using System;
namespace hw5candidate
{
	public class SubjectScore
	{
		String subjectName;
		int score;

		public SubjectScore(String subjectName, int score)
		{
			this.subjectName = subjectName;
			this.score = score;
		}

		public int getScore()
		{
			return this.score;
		}

		public String getSubjectName()
		{
			return this.subjectName;

        }
	}
}

