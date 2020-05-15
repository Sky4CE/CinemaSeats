using AutoMapper;
using CinemaSeats.Application.BookSeats.Queries.GetSeats;
using CinemaSeats.Application.Common.Mappings;
using CinemaSeats.Domain.Entities;
using NUnit.Framework;
using System;

namespace CinemaSeats.Application.UnitTests.Common.Mappings
{
    public class MappingTests
    {
        private readonly IConfigurationProvider _configuration;
        private readonly IMapper _mapper;

        public MappingTests()
        {
            _configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = _configuration.CreateMapper();
        }

        [Test]
        public void ShouldHaveValidConfiguration()
        {
            _configuration.AssertConfigurationIsValid();
        }
        
        [Test]
        [TestCase(typeof(SeatsMap), typeof(SeatsMapDto))]
        [TestCase(typeof(Row), typeof(RowDto))]
        [TestCase(typeof(Seat), typeof(SeatDto))]
        public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
        {
            var instance = Activator.CreateInstance(source);

            _mapper.Map(instance, source, destination);
        }
    }
}
