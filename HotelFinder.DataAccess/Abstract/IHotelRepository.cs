using System;
using HotelFinder.Entities;

namespace HotelFinder.DataAccess.Abstract
{
	public interface IHotelRepository
	{
        Task<List<Hotel>> GetAllHotels();

        Hotel GetHotelById(int id);

        Hotel AddHotel(Hotel hotel);

        Hotel UpdateHotel(Hotel hotel);

        void DeleteHotel(int id);


    }
}

