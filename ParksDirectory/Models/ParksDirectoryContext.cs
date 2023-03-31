using Microsoft.EntityFrameworkCore;

namespace ParksDirectory.Models
{
  public class ParksDirectoryContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksDirectoryContext(DbContextOptions<ParksDirectoryContext>options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park {},
          new Park {},
          new Park {},
          new Park {},
          new Park {},
          new Park {},
          new Park {},
          new Park {},
          new Park {},
          new Park {}
        );
    }
  }
}