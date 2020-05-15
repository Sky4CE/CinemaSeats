using CinemaSeats.Application.Common.Mappings;
using CinemaSeats.Domain.Entities;
using System.Collections.Generic;

namespace CinemaSeats.Application.BookSeats.Queries.GetSeats
{
    public class SeatDto : IMapFrom<Seat>
    { 
        public int Id { get; set; }

        public string SeatTitle { get; set; }

        public bool Booked { get; set; }
        public bool BookConfirmed { get; set; }
    }
}
