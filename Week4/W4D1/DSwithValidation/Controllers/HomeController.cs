using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DSwithValidation.Models;

namespace DSwithValidation.Controllers;

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

    [HttpPost("process")]
    public IActionResult Create(Survey newSurvey)
    { 
        if (ModelState.IsValid)
        {
            System.Console.WriteLine($"{newSurvey.Name}");
            return View("Result", newSurvey);
        }
        return View("Index");
    }

    [HttpGet("result")]
    public IActionResult Result()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
