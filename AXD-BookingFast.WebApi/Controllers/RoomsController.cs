using AXD_BookingFast.Application.DTOs;
using AXD_BookingFast.Application.Queries.GetRoomAvailability;
using AXD_BookingFast.Application.Queries.GetRoomRate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AXD_BookingFast.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Consultar disponibilidad de habitaciones.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("availability")]
        public async Task<ActionResult<RoomAvailabilityDto>> CheckAvailability([FromBody] RoomAvailabilityRequestDto request)
        {
            var query = new GetRoomAvailabilityQuery
            {
                HotelId = request.HotelId,
                RoomType = request.RoomType,
                CheckIn = request.CheckIn,
                CheckOut = request.CheckOut,
                PeopleCount = request.PeopleCount,
                RoomsNeeded = request.RoomsNeeded
            };

            var availability = await _mediator.Send(query);
            return Ok(availability);
        }

        /// <summary>
        /// Consultar tarifa de una habitación.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("rate")]
        public async Task<ActionResult<RoomRateDto>> GetRate([FromBody] RoomAvailabilityRequestDto request)
        {
            var query = new GetRoomRateQuery
            {
                HotelId = request.HotelId,
                RoomType = request.RoomType,
                PeopleCount = request.PeopleCount,
                CheckIn = request.CheckIn
            };

            var rate = await _mediator.Send(query);
            return Ok(rate);
        }
    }
}
