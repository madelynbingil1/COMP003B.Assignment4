using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;
using System.Text;

namespace Charity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    // GET
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(CharityClass model)
    {
        return View("ThankYou", model);
    }


    // <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Index">Home</a>


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
