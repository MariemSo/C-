using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;

public class SurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View()   ;
    }

    [HttpPost("result")]
    public IActionResult Result (string Name , string Location, string Language,string Comment)
    {
        System.Console.WriteLine($"{Name}");
        System.Console.WriteLine($"{Location}");
        System.Console.WriteLine($"{Language}");
        System.Console.WriteLine($"{Comment}");
        ViewBag.Name= Name;
        ViewBag.Location= Location;
        ViewBag.Language= Language;
        ViewBag.Comment= Comment;

        return View("Result"); // view that we are redirected to 
    }

    // [HttpGet("result")]
    // public ViewResult Result()
    // {
    //     return View();
    // }
}
