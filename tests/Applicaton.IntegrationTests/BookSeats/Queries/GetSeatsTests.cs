using CinemaSeats.Application.BookSeats.Queries.GetSeats;
using FluentAssertions;
using NUnit.Framework;
using System.Threading.Tasks;

namespace CinemaSeats.Application.IntegrationTests.BookSeats.Queries
{
    using static Testing;

    public class GetSeatsTests : TestBase
    {
        // TODO: Fix tests
        [Test]
        public async Task ShouldGetSeatsMap()
        {
            var query = new GetSeatsQuery();

            var result = await SendAsync(query);

            result.SeatsMap.Should().NotBeNull();
            result.SeatsMap.Rows.Should().HaveCountGreaterThan(0);
        }
    }
}
