using CinemaSeats.Application.Common.Interfaces;
using System;

namespace CinemaSeats.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
