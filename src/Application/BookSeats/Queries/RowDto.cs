using CinemaSeats.Application.Common.Mappings;
using CinemaSeats.Domain.Entities;
using System.Collections.Generic;

namespace CinemaSeats.Application.BookSeats.Queries.GetSeats
{
    public class RowDto : IMapFrom<Row>
{
    public RowDto()
    {
        Seats = new List<SeatDto>();
    }

    public int Id { get; set; }

    public string RowTitle { get; set; }

    public IList<SeatDto> Seats { get; set; }
    }
}
