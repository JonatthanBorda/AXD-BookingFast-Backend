using AXD_BookingFast.Application.DTOs;
using AXD_BookingFast.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Application.Queries.GetRoomRate
{
    public class GetRoomRateQueryHandler : IRequestHandler<GetRoomRateQuery, RoomRateDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetRoomRateQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<RoomRateDto> Handle(GetRoomRateQuery request, CancellationToken cancellationToken)
        {
            var season = await _unitOfWork.Seasons.GetSeasonForDateAsync(request.CheckIn);
            var roomRate = await _unitOfWork.RoomRates.GetRateAsync(request.HotelId, request.RoomType, season.SeasonType, request.PeopleCount);
            
            if (roomRate == null)
                throw new Exception("No room rate found for the selected criteria.");

            return new RoomRateDto
            {
                PricePerNight = roomRate.PricePerNight
            };
        }
    }
}
