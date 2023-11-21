using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;
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
    public IActionResult Create(User newUser)
    {
        if (ModelState.IsValid)
        {
            System.Console.WriteLine($"{newUser.FirstName}\n{newUser.LastName}\n{newUser.Age}\n{newUser.Email}\n{newUser.Password}");
            return RedirectToAction("Success");
        }
        return View("Index");
    }

    [HttpGet("success")]
    public IActionResult Success()
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
