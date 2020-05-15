using CinemaSeats.Domain.Common;
using System.Collections.Generic;

namespace CinemaSeats.Domain.Entities
{
    public class Seat : AuditableEntity
    {
        public int Id { get; set; }
        public int SeatClassId { get; set; }
        public string SeatTitle { get; set; }
        public bool Booked { get; set; }
    }
}
