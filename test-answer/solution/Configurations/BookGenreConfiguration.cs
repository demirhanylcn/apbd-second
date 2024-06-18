using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using solution.Models.Domain;

namespace solution.Configurations;

public class BookGenreConfiguration : IEntityTypeConfiguration<BookGenre>
{
    public void Configure(EntityTypeBuilder<BookGenre> builder)
    {

        builder.HasKey(e => new { e.IdBook, e.IdGenre });
        builder.HasOne(e => e.Book)
            .WithMany(e => e.BookGenres)
            .HasForeignKey(e => e.IdBook);

        builder.HasOne(e => e.Genre)
            .WithMany(e => e.BookGenres)
            .HasForeignKey(e => e.IdGenre);
        
    }


}