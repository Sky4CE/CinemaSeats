using AutoMapper;
using AutoMapper.QueryableExtensions;
using CinemaSeats.Application.Common.Interfaces;
using CinemaSeats.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaSeats.Application.BookSeats.Queries.GetSeats
{
    public class GetSeatsQuery : IRequest<BookSeatsVm>
    {
    }
    public class GetSeatsQueryHandler : IRequestHandler<GetSeatsQuery, BookSeatsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetSeatsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BookSeatsVm> Handle(GetSeatsQuery request, CancellationToken cancellationToken)
        {
            var seatsMap = await _context.SeatsMaps
                .ProjectTo<SeatsMapDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);

            var singleTitleRows = seatsMap.Rows.Where(r => r.RowTitle.Length == 1).OrderBy(r => r.RowTitle).ToList();
            var doubleTitleRows = seatsMap.Rows.Where(r => r.RowTitle.Length == 2).OrderBy(r => r.RowTitle).ToList();
            seatsMap.Rows = singleTitleRows.Concat(doubleTitleRows).ToList();

            // Assume all persisted seat bookings are confirmed
            foreach (var row in seatsMap.Rows)
            {
                row.Seats = row.Seats.OrderBy(s => Int32.Parse(s.SeatTitle)).ToList();
                foreach (var seat in row.Seats)
                {
                    if (seat.Booked)
                        seat.BookConfirmed = true;
                }

            }
            return new BookSeatsVm
            {
                SeatsMap = seatsMap
            };
        }
    }

}
