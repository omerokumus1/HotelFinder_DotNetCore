using System;
using HotelFinder.Business.Abstract;
using HotelFinder.Entities;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;

namespace HotelFinder.Business.Concrete
{
	public class HotelManager: IHotelService
	{
        private IHotelRepository _hotelRepository;

		public HotelManager(IHotelRepository hotelRepository)
		{
            _hotelRepository = hotelRepository;
		}

        public Hotel AddHotel(Hotel hotel)
        {
            return _hotelRepository.AddHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            return _hotelRepository.GetHotelById(id);
                
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}

