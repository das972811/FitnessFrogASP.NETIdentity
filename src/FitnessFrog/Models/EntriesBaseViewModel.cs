using FitnessFrogDb.Data;
using FitnessFrogDb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitnessFrog.Models;

public abstract class EntriesBaseViewModel
{

    public Entry Entry { get; set; } = new Entry();

    public SelectList? ActivitiesSelectListItems { get; set; }

    /// <summary>
    /// Initializes the view model.
    /// </summary>
    public void Init(IEntityService<Activity> activitiesRepository)
    {
        ActivitiesSelectListItems = new SelectList(
            activitiesRepository.GetList(), "Id", "Name");
    }
}