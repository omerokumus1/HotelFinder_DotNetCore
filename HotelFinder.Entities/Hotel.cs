using System;
namespace HotelFinder.Entities
{
	public class Hotel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string City { get; set; }

        public Hotel(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }
    }
}

