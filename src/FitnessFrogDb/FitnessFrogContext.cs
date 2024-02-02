using Microsoft.EntityFrameworkCore;

using FitnessFrogDb.Models;

namespace FitnessFrogDb;

public class FitnessFrogContext : DbContext
{
    public FitnessFrogContext(DbContextOptions<FitnessFrogContext> options) : base(options)
    {

    }

    public DbSet<Activity> Activities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>().ToTable("Activity");
    }
}