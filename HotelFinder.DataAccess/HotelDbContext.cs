using System;
using HotelFinder.Entities;
namespace HotelFinder.DataAccess
{
	public class HotelDbContext
	{
		public List<Hotel> hotels = new()
		{
			new(1, "Azure Haven", "Honolulu, HI"),
			new(2, "Crescent View Manor", "Yosemite National Park, CA"),
			new(3, "The Midnight Muse", "New Orleans, LA"),
			new(4, "Sapphire Spire", "Chicago, IL"),
			new(5, "The Whispering Pines", "Lake Tahoe, CA"),

		};

		public HotelDbContext()
		{
		}
	}
}
