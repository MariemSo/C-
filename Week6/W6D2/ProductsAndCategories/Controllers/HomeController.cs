using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers;

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
        ViewBag.AllProducts =  _context.Products.ToList();
        return View();
    }

    [HttpPost("new/product")]
    public IActionResult AddProduct(Product newProduct)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            ViewBag.AllProducts =  _context.Products.Include(product => product.UnderCategory)
            .ThenInclude(c => c.Category).ToList();
            return View("Index");
        }
    }
    [HttpGet("product/{ProductId}")]
    public IActionResult OneProduct(int ProductId)
    {
        ViewBag.AllProducts =  _context.Products.Include(product => product.UnderCategory).ThenInclude(c => c.Category).ToList();
        ViewBag.AllCategories = _context.Categories.ToList();
        return View();
    }
    //---------------Add Category To Product----------------
    [HttpPost("new/product/{ProductId}/under")]
    public IActionResult AddCategoryToProduct(Association newAssociation)
    {
        
        return View("OneProduct");
    }

    // ------------Categories------------
    [HttpGet("Categories")]
    public IActionResult Categories()
    {
        ViewBag.AllCategories =  _context.Categories.ToList();
        return View();
    }
    [HttpPost("new/category")]
    public IActionResult AddCategory(Category newCategory)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("Categories");
        }
        else
        {
            ViewBag.AllCategories =  _context.Categories.ToList();
            return View("Categories");
        }
    }

    [HttpGet("Category/{CategoryId}")]
    public IActionResult OneCategory(int CategoryId)
    {
        
        Category oneCategory = _context.Categories.FirstOrDefault(p => p.CategoryId == CategoryId);
        return View("OneCategory", oneCategory);
    }


    //---------------------------------------------------------------------
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
