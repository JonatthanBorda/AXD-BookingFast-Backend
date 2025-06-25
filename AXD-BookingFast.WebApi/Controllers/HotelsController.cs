using AXD_BookingFast.Application.DTOs;
using AXD_BookingFast.Application.Queries.GetHotels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AXD_BookingFast.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HotelsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Consultar todos los hoteles.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelDto>>> GetHotels()
        {
            var query = new GetHotelsQuery();
            var hotels = await _mediator.Send(query);
            return Ok(hotels);
        }

        /// <summary>
        /// Consultar un hotel específico por id.
        /// </summary>
        /// <param name="hotelId"></param>
        /// <returns></returns>
        [HttpGet("{hotelId}")]
        public async Task<ActionResult<HotelDto>> GetHotel(Guid hotelId)
        {
            var query = new GetHotelsQuery();
            var hotel = await _mediator.Send(query);
            return hotel != null ? Ok(hotel) : NotFound();
        }
    }
}
