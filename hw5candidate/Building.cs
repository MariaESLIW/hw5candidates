﻿namespace hw5candidate
{
	public class Building:Asset
	{
		public List<Room> Rooms { get; set; }
		public Address Address { get; set;}

        public Building(List<Room> rooms, Address address)
		{
			Rooms = rooms;
			Address = address;
		}

        public override bool Equals(object? obj)
        {
            return (obj != null) &&
                obj.GetType == this.GetType &&
                ((Building)obj).Rooms == this.Rooms &&
                ((Building)obj).Address == this.Address;
        }

        public void AddRoom(Room newRoom)
        {
            bool isContained = false;

            foreach(Room room in Rooms)
            {
                if (room.Equals(newRoom))
                {
                    isContained = true;
                }
            }

            if(!isContained)
            {
                Rooms.Add(newRoom);
            }
        }
    }
}

