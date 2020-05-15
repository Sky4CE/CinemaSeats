using CinemaSeats.Domain.Common;
using System.Collections.Generic;

namespace CinemaSeats.Domain.Entities
{
    public class Row : AuditableEntity
    {
        public Row()
        {
            Seats = new List<Seat>();
        }

        public int Id { get; set; }

        public string RowTitle { get; set; }
        public int CinemaHallId { get; set; }

        public IList<Seat> Seats { get; set; }
    }
}
