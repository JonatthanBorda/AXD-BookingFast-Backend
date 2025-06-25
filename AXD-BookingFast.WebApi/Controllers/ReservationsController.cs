using AXD_BookingFast.Application.Commands.CreateReservation;
using AXD_BookingFast.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AXD_BookingFast.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Crear una nueva reserva.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ReservationDto>> CreateReservation([FromBody] CreateReservationRequestDto request)
        {
            var command = new CreateReservationCommand
            {
                HotelId = request.HotelId,
                RoomType = request.RoomType,
                CheckIn = request.CheckIn,
                CheckOut = request.CheckOut,
                PeopleCount = request.PeopleCount,
                RoomsNeeded = request.RoomsNeeded
            };

            var reservation = await _mediator.Send(command);
            return Ok(reservation);
        }
    }
}
