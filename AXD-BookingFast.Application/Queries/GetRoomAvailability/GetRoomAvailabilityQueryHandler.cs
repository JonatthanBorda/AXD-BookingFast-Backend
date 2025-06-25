using AXD_BookingFast.Application.DTOs;
using AXD_BookingFast.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Application.Queries.GetRoomAvailability
{
    public class GetRoomAvailabilityQueryHandler : IRequestHandler<GetRoomAvailabilityQuery, RoomAvailabilityDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetRoomAvailabilityQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<RoomAvailabilityDto> Handle(GetRoomAvailabilityQuery request, CancellationToken cancellationToken)
        {
            var availableRooms = await _unitOfWork.Rooms.GetAvailableRoomsAsync(
                request.HotelId, request.RoomType, request.CheckIn, request.CheckOut, request.RoomsNeeded, request.PeopleCount);

            int count = availableRooms.Count();

            //Regla: Todas las habitaciones del mismo tipo tienen igual capacidad:
            int maxPeople = availableRooms.FirstOrDefault()?.MaxPeople ?? 0;

            return new RoomAvailabilityDto
            {
                HotelId = request.HotelId,
                RoomType = request.RoomType,
                AvailableRooms = count,
                MaxPeoplePerRoom = maxPeople
            };
        }
    }
}
