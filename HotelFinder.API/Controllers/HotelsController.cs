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

        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        public async Task<IActionResult> Hotels()
        {
            var hotels = await _hotelService.GetAllHotels();
            return Ok(hotels); // 200 + data
        }

        [HttpGet]
        [Route("hotelById/{id}")]
        public IActionResult Hotel(int id)
        {
            var hotel = _hotelService.GetHotelById(id);
            if (hotel == null)
                return NotFound(); // 404

            return Ok(hotel); // 200 + data
        }

        [HttpGet]
        [Route("[action]/{name}")]
        public IActionResult HotelByName(string name)
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult HotelByIdAndName(int id, string name)
        {
            return Ok();
        }



        [HttpPost]
        public IActionResult AddHotel([FromBody] Hotel hotel)
        {
            if (string.IsNullOrEmpty(hotel.Name)
                || string.IsNullOrEmpty(hotel.City))
                return BadRequest("Empty Name or City"); // 400

            return CreatedAtAction("Post", hotel); // 201 + data
        }

        [HttpPut]
        public IActionResult UpdateHotel([FromBody] Hotel hotel)
        {
            var hotelFound = _hotelService.GetHotelById(hotel.Id);
            if (hotelFound == null)
                return NotFound(); //404

            return Ok(_hotelService.UpdateHotel(hotel)); // 200 + data
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            var hotelFound = _hotelService.GetHotelById(id);
            if (hotelFound == null)
                return NotFound(); //404

            _hotelService.DeleteHotel(id);
            return Ok(); // 200
        }


    }
}