namespace hw5candidate
{
	public class University
	{
		public UniversityEmployee[] UniversityEmployees { get; set; }
		public UniversityEmployee Rector { get; set; }
		public Building[] Buildings { get; set; }
		public University(UniversityEmployee[] universityEmployees, UniversityEmployee rector, Building[] buildings)
		{
			UniversityEmployees = universityEmployees;
			Rector = rector;
			Buildings = buildings;
        }
	}
}

