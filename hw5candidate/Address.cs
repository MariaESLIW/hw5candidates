﻿namespace hw5candidate
{
	public class Address
	{

		public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber
		{
			get
			{
				return _houseNumber;
			}
			set
			{
				if (value>0)
				{
					_houseNumber = value;
				}
			}
		}
		private int _houseNumber;

        public int FlatNumber
		{
			get
			{
				return _flatNumber;
			}
			set
			{
				if (value > 0)
				{
					_flatNumber = value;
				}
			}
		}
		private int _flatNumber;

        public Address(string city, string street, int houseNumber, int flatNumber)
		{
			City = city;
			Street = street;
			HouseNumber = houseNumber;
			FlatNumber = flatNumber;
		}

	}
}

