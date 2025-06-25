using AutoMapper;
using AXD_BookingFast.Application.DTOs;
using AXD_BookingFast.Domain.Entities;

namespace AXD_BookingFast.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hotel, HotelDto>();
            CreateMap<Room, RoomTypeAvailabilityDto>()
                .ForMember(dest => dest.RoomType, opt => opt.MapFrom(src => src.RoomType))
                .ForMember(dest => dest.MaxPeoplePerRoom, opt => opt.MapFrom(src => src.MaxPeople));
            CreateMap<Reservation, ReservationDto>()
                .ForMember(dest => dest.ReservationId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
