using CinemaSeats.Domain.Common;
using System.Collections.Generic;

namespace CinemaSeats.Domain.Entities
{
    public class SeatsMap : AuditableEntity
    {
        public SeatsMap()
        {
            Rows = new List<Row>();
        }

        public int Id { get; set; }

        public int MovieSessionId { get; set; }

        public IList<Row> Rows { get; set; }
    }
}
