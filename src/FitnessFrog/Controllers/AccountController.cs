using FitnessFrog.Models;
using FitnessFrogDb;
using Microsoft.AspNetCore.Mvc;

namespace FitnessFrog.Controllers;

public class AccountController : Controller
{
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(AccountRegisterViewModel viewModel)
    {
        var user = new User
        {
            UserName = viewModel.Email,
            Email = viewModel.Email,
        };

        return View(viewModel);
    }
}