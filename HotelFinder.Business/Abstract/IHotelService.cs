using System;
using HotelFinder.Entities;
namespace HotelFinder.Business.Abstract
{
	public interface IHotelService
	{
		Task<List<Hotel>> GetAllHotels();

		Hotel GetHotelById(int id);

		Hotel AddHotel(Hotel hotel);

		Hotel UpdateHotel(Hotel hotel);

		void DeleteHotel(int id);

	}
}

