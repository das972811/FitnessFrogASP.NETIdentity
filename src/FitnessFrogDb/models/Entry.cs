namespace FitnessFrogDb.Models;

public class Entry
{
    public enum IntensityLevel
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public Entry() { }

    public int Id { get; set; }

}