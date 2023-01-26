namespace hw5candidate
{
	public class University
	{
		public List<UniversityEmployee> UniversityEmployees { get; set; }
		public UniversityEmployee Rector { get; set; }
		public List<Building> Buildings { get; set; }
		public Address Address { get; set; }

		public University(
			List<UniversityEmployee> universityEmployees,
			UniversityEmployee rector,
			List<Building> buildings,
			Address address)
		{
			UniversityEmployees = universityEmployees;
			Rector = rector;
			Buildings = buildings;
			Address = address;
        }
	}
}

