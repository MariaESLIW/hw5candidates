namespace hw5candidate
{
	public class University
	{
		public UniversityEmployee[] UniversityEmployees { get; set; }
		public UniversityEmployee Rector { get; set; }
		public Building[] Buildings { get; set; }
		public Address Address { get; set; }

		public University(UniversityEmployee[] universityEmployees, UniversityEmployee rector, Building[] buildings, Address address)
		{
			UniversityEmployees = universityEmployees;
			Rector = rector;
			Buildings = buildings;
			Address = address;
        }
	}
}

