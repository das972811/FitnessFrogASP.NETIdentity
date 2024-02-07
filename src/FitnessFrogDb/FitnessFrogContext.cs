using Microsoft.EntityFrameworkCore;

using FitnessFrogDb.Models;

namespace FitnessFrogDb;

public class FitnessFrogContext : DbContext
{
    public FitnessFrogContext(DbContextOptions<FitnessFrogContext> options) : base(options)
    {

    }

    public DbSet<Activity> Activities { get; set; }
    public DbSet<Entry> Entries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>().ToTable("Activity");
        modelBuilder.Entity<Entry>().ToTable("Entry");

        modelBuilder.Entity<Activity>()
                    .Property(a => a.Name)
                    .HasMaxLength(100);

        modelBuilder.Entity<Entry>()
                    .Property(e => e.Duration)
                    .HasPrecision(5, 1);
    }
}