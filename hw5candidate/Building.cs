namespace hw5candidate
{
	public class Building:Asset
	{
		public Room[] Rooms { get; set; }
		public Address Address { get; set;}

        public Building(Room[] rooms, Address address)
		{
			Rooms = rooms;
			Address = address;
		}
	}
}

