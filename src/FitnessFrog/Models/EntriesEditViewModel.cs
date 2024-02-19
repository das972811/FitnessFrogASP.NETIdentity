namespace FitnessFrog.Models;

public class EntriesEditViewModel : EntriesBaseViewModel
{
    /// <summary>
    /// This property enables model binding to be able to bind the "id"
    /// route parameter value to the "Entry.Id" model property.
    /// </summary>
    public int Id
    {
        get { return Entry.Id; }
        set { Entry.Id = value; }
    }
}