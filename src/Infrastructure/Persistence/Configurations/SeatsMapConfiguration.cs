
using CinemaSeats.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaSeats.Infrastructure.Persistence.Configurations
{
    public class SeatsMapConfiguration : IEntityTypeConfiguration<SeatsMap>
    {
        public void Configure(EntityTypeBuilder<SeatsMap> builder)
        {
            builder.Property(t => t.MovieSessionId)
                .IsRequired();
        }
    }
}
