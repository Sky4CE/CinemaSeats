using CinemaSeats.Application.BookSeats.Queries.GetSeats;
using CinemaSeats.Application.Common.Exceptions;
using CinemaSeats.Application.Common.Interfaces;
using CinemaSeats.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaSeats.Application.BookSeats.Commands.BookSeats
{
    public partial class BookSeatsCommand : IRequest<int>
    {
        public SeatsMapDto SeatsMap { get; set; }
    }

    public class BookSeatsCommandHandler : IRequestHandler<BookSeatsCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public BookSeatsCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(BookSeatsCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.SeatsMaps
                .Include(s => s.Rows)
                .ThenInclude(r => r.Seats)
                .FirstOrDefaultAsync(s => s.Id == request.SeatsMap.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(SeatsMap), request.SeatsMap.Id);
            }

            foreach (var row in entity.Rows)
            {
                foreach (var seat in row.Seats)
                {
                    var requestRow = request.SeatsMap.Rows.First(r => r.Id == row.Id);
                    var requestSeat = requestRow.Seats.First(s => s.Id == seat.Id);

                    if (requestSeat.Booked && requestSeat.BookConfirmed)
                        seat.Booked = true;
                }

            }

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
