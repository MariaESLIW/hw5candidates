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

        public override bool Equals(object? obj)
        {
            return (obj != null) &&
                obj.GetType == this.GetType &&
                ((University)obj).Address == this.Address;
        }

		public void AddEmployee(UniversityEmployee newEmployee)
		{
			bool isContained = false;

			foreach(UniversityEmployee employee in UniversityEmployees)
			{
				if(employee.Equals(newEmployee))
				{
					isContained = true;
				}
			}

			if (!isContained)
			{
				UniversityEmployees.Add(newEmployee);
			}
		}

        public void AddBuilding(Building newBuilding)
        {
            bool isContained = false;

            foreach (Building building in Buildings)
            {
                if (building.Equals(newBuilding))
                {
                    isContained = true;
                }
            }

            if (!isContained)
            {
                Buildings.Add(newBuilding);
            }
        }
    }
}

