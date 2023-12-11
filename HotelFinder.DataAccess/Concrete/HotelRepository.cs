using System;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;

namespace HotelFinder.DataAccess.Concrete
{
	public class HotelRepository: IHotelRepository
	{
        private readonly HotelDbContext dbContext = new HotelDbContext();
		public HotelRepository()
		{
		}

        public Hotel AddHotel(Hotel hotel)
        {
            dbContext.hotels.Add(hotel);
            return hotel;
        }

        public void DeleteHotel(int id)
        {
            var hotel = dbContext.hotels.Find(h => h.Id == id);
            if (hotel != null)
                dbContext.hotels.Remove(hotel);
            else
                throw new Exception("Hotel Not Found");
        }

        public List<Hotel> GetAllHotels()
        {
            return dbContext.hotels;
        }

        public Hotel GetHotelById(int id)
        {
            return dbContext.hotels.Find(h => h.Id == id)
                ?? throw new Exception("Hotel Not Found");
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            var index = dbContext.hotels.FindIndex(h => h.Id == hotel.Id);
            if (index == -1)
                throw new Exception("Hotel Not Found");

            dbContext.hotels.RemoveAt(index);
            dbContext.hotels.Insert(index, hotel);
            return hotel;
        }
    }
}
