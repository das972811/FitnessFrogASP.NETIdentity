using Microsoft.EntityFrameworkCore;
using FitnessFrogDb.Models;

namespace FitnessFrogDb.ModelBuilderExtensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>().HasData(
            new Activity { Id = 1, Name = "Basketball" },
            new Activity { Id = 2, Name = "Biking" },
            new Activity { Id = 3, Name = "Hiking" },
            new Activity { Id = 4, Name = "Kayaking" },
            new Activity { Id = 5, Name = "Pokemon Go" },
            new Activity { Id = 6, Name = "Running" },
            new Activity { Id = 7, Name = "Skiing" },
            new Activity { Id = 8, Name = "Swimming" },
            new Activity { Id = 9, Name = "Walking" },
            new Activity { Id = 10, Name = "Weight Lifting" }
        );

        modelBuilder.Entity<Entry>().HasData(
            new Entry { Id = 1, Date = new DateTime(2024, 2, 9), ActivityId = 2, Duration = 12.2m },
            new Entry { Id = 2, Date = new DateTime(2024, 2, 10), ActivityId = 3, Duration = 123.0m },
            new Entry { Id = 3, Date = new DateTime(2024, 2, 12), ActivityId = 2, Duration = 32.2m },
            new Entry { Id = 4, Date = new DateTime(2024, 2, 13), ActivityId = 9, Duration = 13.6m },
            new Entry { Id = 5, Date = new DateTime(2024, 2, 13), ActivityId = 2, Duration = 10.2m },
            new Entry { Id = 6, Date = new DateTime(2024, 2, 14), ActivityId = 2, Duration = 5.2m },
            new Entry { Id = 7, Date = new DateTime(2024, 2, 15), ActivityId = 9, Duration = 22.2m },
            new Entry { Id = 8, Date = new DateTime(2024, 2, 16), ActivityId = 2, Duration = 17.0m },
            new Entry { Id = 9, Date = new DateTime(2024, 2, 16), ActivityId = 5, Duration = 7.2m }
        );
    }
}