using CinemaSeats.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaSeats.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<SeatsMap> SeatsMaps { get; set; }

        DbSet<Row> Rows { get; set; }

        DbSet<Seat> Seats { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
