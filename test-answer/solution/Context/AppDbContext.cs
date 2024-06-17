using Microsoft.EntityFrameworkCore;

namespace solution.Context;

public class AppDbContext : DbContext
{
    
    public DbSet<> name { get; set; }
    public DbSet<> name { get; set; }
    public DbSet<> name { get; set; }
    public DbSet<> name { get; set; }
    public DbSet<> name { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}