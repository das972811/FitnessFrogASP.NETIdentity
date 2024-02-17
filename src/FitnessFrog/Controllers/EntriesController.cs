using Microsoft.AspNetCore.Mvc;

namespace FitnessFrog.Controllers;

public class EntriesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}