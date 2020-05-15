
using CinemaSeats.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaSeats.Infrastructure.Persistence.Configurations
{
    public class RowConfiguration : IEntityTypeConfiguration<Row>
    {
        public void Configure(EntityTypeBuilder<Row> builder)
        {
            builder.Property(t => t.CinemaHallId)
                .IsRequired();

            builder.Property(t => t.RowTitle)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
