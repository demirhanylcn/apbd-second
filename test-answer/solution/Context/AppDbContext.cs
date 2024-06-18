using Microsoft.EntityFrameworkCore;
using solution.Models.Domain;

namespace solution.Context;

public class AppDbContext : DbContext
{
    
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<BookGenre> BookGenres { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<PublishingHouse> PublishingHouses { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}