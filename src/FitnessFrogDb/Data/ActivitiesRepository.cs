using FitnessFrogDb.Models;

namespace FitnessFrogDb.Data;

public class ActivitiesRepository : BaseRepository<Activity>
{
    /// <summary>
    /// Repository for activities.
    /// </summary>
    public ActivitiesRepository(FitnessFrogContext context) : base(context)
    {
    }

    public override Activity? Get(int id, bool includeRelatedEntities = true)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns a collection of activities.
    /// </summary>
    /// <returns>A list of activities.</returns>
    public override IList<Activity> GetList()
    {
        throw new NotImplementedException();
    }
}