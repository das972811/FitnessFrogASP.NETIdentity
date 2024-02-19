using FitnessFrogDb.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessFrogDb.Data;

public class EntriesRepository : BaseRepository<Entry>
{
    /// <summary>
    /// The repository for entries.
    /// </summary>
    public EntriesRepository(FitnessFrogContext context) : base(context)
    {
    }

    /// <summary>
    /// Returns a single entry for the provided ID.
    /// </summary>
    /// <param name="id">The ID for the entry to return.</param>
    /// <param name="includeRelatedEntities">Indicates whether or not to include related entities.</param>
    /// <returns>An entry.</returns>
    public override Entry? Get(int id, bool includeRelatedEntities = true)
    {
        var entries = Context.Entries.AsQueryable();
        
        if (includeRelatedEntities)
        {
            entries = entries
                .Include(e => e.Activity);
        }

        return entries
            .FirstOrDefault(e => e.Id == id);
    }

    /// <summary>
    /// Returns a collection of entries.
    /// </summary>
    /// <returns>A list of entries.</returns>
    public override IList<Entry> GetList()
    {
        return Context.Entries
            .Include(e => e.Activity)
            .OrderByDescending(e => e.Date)
            .ThenByDescending(e => e.Id)
            .ToList();
    }
}