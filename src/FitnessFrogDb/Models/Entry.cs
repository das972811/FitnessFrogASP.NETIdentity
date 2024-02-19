using System.ComponentModel.DataAnnotations;

namespace FitnessFrogDb.Models;

/// <summary>
/// Represents an activity that has been logged in the Fitness Frog app.
/// </summary>
public class Entry
{
    /// <summary>
    /// The intensity level of the activity.
    /// </summary>
    public enum IntensityLevel
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    /// <summary>
    /// Default constructor.
    /// </summary>
    public Entry() { }

    /// <summary>
    /// Constructor for creating entries.
    /// </summary>
    /// <param name="year">The year (1 through 9999) for the entry date.</param>
    /// <param name="month">The month (1 through 12) for the entry month.</param>
    /// <param name="day">The day (1 through the number of days for the month) for the entry day.</param>
    /// <param name="activity">The activity for the entry.</param>
    /// <param name="duration">The duration for the entry (in minutes).</param>
    /// <param name="intensity">The intensity for the entry.</param>
    /// <param name="exclude">Whether or not the entry should be excluded when calculating the total fitness activity.</param>
    /// <param name="notes">The notes for the entry.</param>
    public Entry(int year, int month, int day, Activity activity, 
        decimal duration, IntensityLevel intensity = IntensityLevel.Medium,
        bool exclude = false, string? notes = null)
    {
        Date = new DateTime(year, month, day);
        Activity = activity;
        Duration = duration;
        Intensity = intensity;
        Exclude = exclude;
        Notes = notes;
    }

    /// <summary>
    /// The ID of the entry.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The date of the entry. Should not include a time portion.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The activity ID for the entry. The ID value should map to an ID in the activities collection.
    /// </summary>
    [Display(Name = "Activity")]
    public int ActivityId { get; set; }

    /// <summary>
    /// The activity for the entry.
    /// </summary>
    public Activity? Activity { get; set; }

    /// <summary>
    /// The duration for the entry (in minutes).
    /// </summary>
    public decimal Duration { get; set; }

    /// <summary>
    /// The level of intensity for the entry.
    /// </summary>
    public IntensityLevel Intensity { get; set; } = IntensityLevel.Medium;

    /// <summary>
    /// Whether or not this entry should be excluded when calculating the total fitness activity.
    /// </summary>
    public bool Exclude { get; set; }

    /// <summary>
    /// The notes for the entry.
    /// </summary>
    [MaxLength(200, ErrorMessage = "The Notes field cannot be longer than 200 characters.")]
    public string? Notes { get; set; }

    /// <summary>
    /// The level of intensity for the entry as a string.
    /// </summary>
    public string IntensityName => Intensity.ToString();
}