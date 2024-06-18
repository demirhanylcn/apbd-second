using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using solution.Models.Domain;

namespace solution.Configurations;

public class BookConfiguration: IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {

        builder.HasKey(e => e.IdBook);
        builder.Property(e => e.Name).HasMaxLength(50);


        builder.HasMany(e => e.BookGenres)
            .WithOne(e => e.Book)
            .HasForeignKey(e => e.IdBook);

        builder.HasMany(e => e.BookAuthors)
            .WithOne(e => e.Book)
            .HasForeignKey(e => e.IdBook);

        builder.HasOne(e => e.PublishingHouse)
            .WithMany(e => e.Books)
            .HasForeignKey(e => e.IdPublishingHouse);

    }
}