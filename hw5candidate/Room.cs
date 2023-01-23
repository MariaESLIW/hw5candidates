namespace hw5candidate
{
	public class Room
	{
		RoomType RoomType { get; set; }
		int RoomNumber
		{
			get
			{
				return _roomNumber;
			}
			set
			{
				if (value>=0)
				{
					_roomNumber = value;
				}
			}
		}
		int _roomNumber;

		public Room(RoomType roomType, int roomNumber)
		{
			RoomType = roomType;
			RoomNumber = roomNumber;
		}
	}
}

