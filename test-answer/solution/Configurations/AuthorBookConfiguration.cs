using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using solution.Models.Domain;

namespace solution.Configurations;

public class AuthorBookConfiguration : IEntityTypeConfiguration<BookAuthor>
{
    public void Configure(EntityTypeBuilder<BookAuthor> builder)
    {

        builder.HasKey(e => new { e.IdAuthor, e.IdBook });


        builder.HasOne(e => e.Author)
            .WithMany(e => e.BookAuthors)
            .HasForeignKey(e => e.IdAuthor);
        
        builder.HasOne(e => e.Book)
            .WithMany(e => e.BookAuthors)
            .HasForeignKey(e => e.IdBook);

    }
    

}