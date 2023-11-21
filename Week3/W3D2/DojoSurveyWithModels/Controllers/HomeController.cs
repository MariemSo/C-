using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModels.Models;

namespace DojoSurveyWithModels.Controllers;

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

    [HttpPost("survey")]
    public IActionResult process (Survey yourSurvey)
    {   
        System.Console.WriteLine($"{yourSurvey.Name}");
        return View("Submission",yourSurvey); // view that we are redirected to 
    }

    [HttpGet("survey")]
    public IActionResult Submission ()
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
