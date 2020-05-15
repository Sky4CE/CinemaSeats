
using CinemaSeats.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaSeats.Infrastructure.Persistence.Configurations
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.Property(t => t.SeatClassId)
                .IsRequired();

            builder.Property(t => t.SeatTitle)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(t => t.Booked)
                .IsRequired();
        }
    }
}
