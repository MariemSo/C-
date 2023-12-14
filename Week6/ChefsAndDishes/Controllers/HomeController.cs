using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ChefsAndDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;



namespace ChefsAndDishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;
    public HomeController(ILogger<HomeController> logger,MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        
        var chefs = _context.Chefs
            .Include(c => c.DishesBy)
            .ToList();

    	 return View(chefs);
    }
    //*----------------Chefs----------------
    //Form To Add Chef
    [HttpGet("/chefs/new")]
    public IActionResult AddChef()
    {
         
        return View();
    }
    //Submit Form
    [HttpPost("/chefs/create")]
    public IActionResult CreateChef(Chef newChef)
    {
        if (ModelState.IsValid)
        {
            if (newChef.DateOfBirth < DateTime.Now)
        {
            _context.Add(newChef);
            _context.SaveChanges();
            // Redirect to a success page or return a success response
            return RedirectToAction("Index");
        }
        else
        {
            // Date of Birth is in the future, add a ModelState error
            ModelState.AddModelError("DateOfBirth", "Date of Birth must be in the past.");
            return View("AddChef");
        }
        }
        return View ("Index");
    }
    //*-------------Dishes---------------
     public IActionResult AddDish()
     {
         ViewBag.Chefs = _context.Chefs.ToList();
        return View();
  
     }
    [HttpPost("/dish/new")]
    public IActionResult CreateDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
        return RedirectToAction("Dishes");
        }
        ViewBag.Chefs = _context.Chefs.ToList();
        return View("AddDish");
    }

    public IActionResult Dishes()
    {
        var Dishes = _context.Dishes
            .Include(c => c.Cook)
            .ToList();

    	 return View(Dishes);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
