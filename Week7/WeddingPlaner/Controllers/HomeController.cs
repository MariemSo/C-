using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlaner.Models;

namespace WeddingPlaner.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

     public IActionResult Index()
    {
        return RedirectToAction("WeddingList");
    }
    [HttpGet("weddings/new")]
    public IActionResult PlanWedding()
    {
        //checking if user is logged in
        if (HttpContext.Session.GetInt32("userId")== null)
        {
            return RedirectToAction("LogReg");
        }
        //retrieve username from session
        ViewBag.FirstName = HttpContext.Session.GetString("FirstName");
        return View("PlanWedding");
    }
    //Create
    [HttpPost("weddings/create")]
    public IActionResult CreateWedding(Wedding newWedding)
    {
        if (ModelState.IsValid)
        {
                _context.Add(newWedding);
                _context.SaveChanges();
            return RedirectToAction("LogReg", "Users");
        }
        return View("PlanWedding");
    }
    //ShowAll
    [HttpGet(template: "Weddings")]
    public IActionResult WeddingList()
    { 
        //checking if user is logged in
        if (HttpContext.Session.GetInt32("userId")== null)
        {
            return RedirectToAction("LogReg","Users");
        }
        List<Wedding> AllWeddings = _context.Weddings.Include(w => w.Guests).Include(w => w.Planner).ToList();
        return View(AllWeddings);
    }
    //Delete Wedding
     [HttpPost("Weddings/delete")]
    public IActionResult DeleteWedding (int weddingId)
    {
        Wedding? weddingToDelete = _context.Weddings.SingleOrDefault(w => w.WeddingId == weddingId);

            if (weddingToDelete == null)
            {
                // Handle this case differently, show an error message, or redirect to an error page
                return RedirectToAction("WeddingList");
            }

            // Check if the user deleting is the one logged in
            if (weddingToDelete.UserId != HttpContext.Session.GetInt32("userId"))
            {
                return RedirectToAction("WeddingList");
            }

            _context.Weddings.Remove(weddingToDelete);
            _context.SaveChanges();

            // Redirect to the wedding list or another appropriate action
            return RedirectToAction("WeddingList");
    }

    //----------ShowCraft-----------
    [HttpGet("weddings/{weddingId}")]
    public IActionResult ShowWedding(int weddingId)
    {
        Wedding? oneWedding = _context.Weddings
        .Include(wedding => wedding.Planner)
        .ThenInclude(wedding => wedding.Attending)
        .FirstOrDefault(wedding => wedding.WeddingId == weddingId);
        return View(oneWedding);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
