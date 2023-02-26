using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Road_Safety.Models;

namespace Road_Safety.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Home()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult RoadSafety()
    {
        return View();
    }

    public IActionResult TrafficSigns()
    {
        return View();
    }

    public IActionResult AccidentDetail()
    {
        return View();
    }


    public IActionResult NoOfCasualities()
    {
        return View();
    }

    public IActionResult CausedDueToVehicles()
    {
        return View();
    }

    public IActionResult AccidentProneArea()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Weather()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Map()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
