using CinemaSeats.Application.Common.Mappings;
using CinemaSeats.Domain.Entities;
using System.Collections.Generic;

namespace CinemaSeats.Application.BookSeats.Queries.GetSeats
{
    public class SeatsMapDto : IMapFrom<SeatsMap>
{
    public SeatsMapDto()
    {
        Rows = new List<RowDto>();
    }

    public int Id { get; set; }

    public IList<RowDto> Rows { get; set; }
}
}
