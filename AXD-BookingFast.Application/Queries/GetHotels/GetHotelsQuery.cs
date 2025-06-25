using AXD_BookingFast.Application.DTOs;
using MediatR;

namespace AXD_BookingFast.Application.Queries.GetHotels
{
    public class GetHotelsQuery : IRequest<IEnumerable<HotelDto>> { }
}
