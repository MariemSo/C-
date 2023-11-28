using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
         List<Dishes> allDishes = _context.Dishes
    	    .OrderByDescending(u => u.CreatedAt)
    	    .Take(5)
    	    .ToList();
        return View(allDishes);
    }
    
    [HttpGet("dishes/new")]
    public IActionResult AddDishes()
    {
        return View();
    }

    [HttpPost("dishes/create")]
    public IActionResult AddDish(Dishes newDish)
    {
        if (ModelState.IsValid)
        {
            System.Console.WriteLine($"New Dish: {newDish.Name}");
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("AddDishes");
        }
    }

    [HttpGet("Dishes/{DishId}")]
    public IActionResult Show(int DishId)
    {
        Dishes oneDish = _context.Dishes
            .FirstOrDefault(d => d.DishId == DishId);
        return View(oneDish);
    }

    [HttpGet("dishes/{DishId}/edit")]
    public IActionResult Edit(int DishId)
    {
        Dishes dishToEdit = _context.Dishes
            .SingleOrDefault(d => d.DishId == DishId);
        return View("Edit", dishToEdit);
    }

    [HttpPost("/dishes/update/{DishId}")]
    public IActionResult UpdateDish(int DishId, Dishes newestDish)
    {
        Dishes oldDish = _context.Dishes.FirstOrDefault(b => b.DishId == DishId);
    if (ModelState.IsValid)
        {
            oldDish.Name = newestDish.Name;
            oldDish.Chef = newestDish.Chef;
            oldDish.Tastiness = newestDish.Tastiness;
            oldDish.Calories = newestDish.Calories;
            oldDish.Description = newestDish.Description;
            oldDish.UpdatedAt = newestDish.UpdatedAt;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        return View("Edit", oldDish);

    }

    
    [HttpGet("delete/{DishId}")]
    public IActionResult DeleteDish(int DishId)
    {
            Dishes toDelete = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);
            if(toDelete == null)
                return RedirectToAction("Index");
            _context.Dishes.Remove(toDelete);
             _context.SaveChanges();
            return RedirectToAction("Index");
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
