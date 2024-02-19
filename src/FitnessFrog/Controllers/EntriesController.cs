using Microsoft.AspNetCore.Mvc;
using FitnessFrog.Models;
using FitnessFrogDb.Data;
using FitnessFrogDb.Models;

namespace FitnessFrog.Controllers;

public class EntriesController : Controller
{
    private readonly IEntityService<Entry> _entriesRepo;
    private readonly IEntityService<Activity> _activtiesRepo;

    public EntriesController(IEntityService<Entry> entriesRepo, IEntityService<Activity> activitiesRepo)
    {
        _entriesRepo = entriesRepo;
        _activtiesRepo = activitiesRepo;
    }

    public IActionResult Index()
    {
        IList<Entry> entries = _entriesRepo.GetList();
        decimal totalActivity = entries
            .Where(e => e.Exclude == false)
            .Sum(e => e.Duration);

        int numberOfActiveDays = entries
            .Select(e => e.Date)
            .Distinct()
            .Count();

        var viewModel = new EntriesIndexViewModel()
        {
            Entries = entries,
            TotalActivity = totalActivity,
            AverageDailyActivity = numberOfActiveDays != 0 ?
                (totalActivity / numberOfActiveDays) : 0
        };

        return View(viewModel);
    }

    public IActionResult Add()
    {
        var viewmodel = new EntriesAddViewModel();

        viewmodel.Init(_activtiesRepo);

        return View(viewmodel);
    }

    [HttpPost]
    public IActionResult Add(EntriesAddViewModel viewModel)
    {
        ValidateEntry(viewModel.Entry);

        if (ModelState.IsValid)
        {
            _entriesRepo.Add(viewModel.Entry);

            TempData["Message"] = "Your entry was successfully added!";

            return RedirectToAction("Index");
        }

        viewModel.Init(_activtiesRepo);

        return View(viewModel);
    }

    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return new BadRequestResult();
        }

        Entry? entry = _entriesRepo.Get((int) id);

        if (entry is null)
        {
            return NotFound();
        }

        var viewModel = new EntriesEditViewModel()
        {
            Entry = entry
        };

        viewModel.Init(_activtiesRepo);

        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Edit(EntriesEditViewModel viewModel)
    {
        ValidateEntry(viewModel.Entry);

        if (ModelState.IsValid)
            {
                _entriesRepo.Update(viewModel.Entry);

                TempData["Message"] = "Your entry was successfully updated!";

                return RedirectToAction("Index");
            }

            viewModel.Init(_activtiesRepo);

            return View(viewModel);
    }

    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return new BadRequestResult();
        }

        Entry? entry = _entriesRepo.Get((int)id);

        if (entry is null)
        {
            return NotFound();
        }

        return View(entry);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _entriesRepo.Delete(id);

        TempData["Message"] = "Your entry was successfully deleted!";

        return RedirectToAction("Index");
    }

    private void ValidateEntry(Entry entry)
    {
        // If there aren't any "Duration" field validation errors
        // then make sure that the duration is greater than "0".
        if (entry.Duration <= 0)
        {
            ModelState.AddModelError("Duration",
                "The Duration field value must be greater than '0'.");
        }
    }
}