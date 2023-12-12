using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelFinder.Business;
using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : Controller
    {

        private IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        public List<Hotel> Hotels()
        {
            return _hotelService.GetAllHotels();
        }

        [HttpGet("{id}")]
        public Hotel Hotel(int id)
        {
            return _hotelService.GetHotelById(id);
        }

        [HttpPost]
        public Hotel AddHotel([FromBody] Hotel hotel)
        {
            return _hotelService.AddHotel(hotel);
        }

        [HttpPut]
        public Hotel UpdateHotel([FromBody] Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }

        [HttpDelete("{id}")]
        public void DeleteHotel(int id)
        {
            _hotelService.DeleteHotel(id);
        }


    }
}