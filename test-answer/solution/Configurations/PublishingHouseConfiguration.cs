using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using solution.Models.Domain;

namespace solution.Configurations;

public class PublishingHouseConfiguration : IEntityTypeConfiguration<PublishingHouse>
{
    public void Configure(EntityTypeBuilder<PublishingHouse> builder)
    {
        builder.HasKey(e => e.IdPublishingHouse);
        builder.Property(e => e.Name).HasMaxLength(50);
        builder.Property(e => e.Country).HasMaxLength(50);
        builder.Property(e => e.City).HasMaxLength(50);


        builder.HasMany(e => e.Books)
            .WithOne(e => e.PublishingHouse)
            .HasForeignKey(e => e.IdPublishingHouse);

    }
}