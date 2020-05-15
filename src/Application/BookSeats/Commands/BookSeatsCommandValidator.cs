using CinemaSeats.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaSeats.Application.BookSeats.Commands.BookSeats
{
    public class BookSeatsCommandValidator : AbstractValidator<BookSeatsCommand>
    {
        private readonly IApplicationDbContext _context;

        public BookSeatsCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.SeatsMap)
                .NotEmpty().WithMessage("Title is required.");
        }

    }
}
