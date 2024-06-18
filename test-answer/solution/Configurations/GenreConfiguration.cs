using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using solution.Models.Domain;

namespace solution.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {

        builder.HasKey(e => e.IdGenre);
        builder.Property(e => e.Name).HasMaxLength(50);

        builder.HasMany(e => e.BookGenres)
            .WithOne(e => e.Genre)
            .HasForeignKey(e => e.IdGenre);
    }
}