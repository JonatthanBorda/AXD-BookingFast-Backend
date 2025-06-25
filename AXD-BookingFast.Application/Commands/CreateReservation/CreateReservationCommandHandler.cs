using AutoMapper;
using AXD_BookingFast.Application.DTOs;
using AXD_BookingFast.Domain.Entities;
using AXD_BookingFast.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Application.Commands.CreateReservation
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, ReservationDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateReservationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReservationDto> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var availableRooms = await _unitOfWork.Rooms.GetAvailableRoomsAsync(request.HotelId, request.RoomType, request.CheckIn, request.CheckOut, request.RoomsNeeded, request.PeopleCount);

            if (availableRooms.Count() < request.RoomsNeeded)
                throw new Exception("No hay suficientes habitaciones disponibles.");

            var season = await _unitOfWork.Seasons.GetSeasonForDateAsync(request.CheckIn);
            var roomRate = await _unitOfWork.RoomRates.GetRateAsync(request.HotelId, request.RoomType, season.SeasonType, request.PeopleCount);

            if (roomRate == null)
                throw new Exception("Tarifa de habitación no encontrada para los criterios seleccionados.");

            var nights = (request.CheckOut - request.CheckIn).Days;
            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                RoomId = availableRooms.First().Id, //Asignar la primera habitación disponible para simplificar
                CheckIn = request.CheckIn,
                CheckOut = request.CheckOut,
                PeopleCount = request.PeopleCount,
                TotalPrice = roomRate.PricePerNight * nights
            };

            await _unitOfWork.Reservations.AddAsync(reservation);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return _mapper.Map<ReservationDto>(reservation);
        }
    }
}
