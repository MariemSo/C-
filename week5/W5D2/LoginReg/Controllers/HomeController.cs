using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginReg.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
               return View();
    }

    [HttpPost("users/create")]
    public IActionResult Register (User newUser)
    {
         if (ModelState.IsValid)
        {
            if (_context.Users.Any(u=> u.Email==newUser.Email))
            {
                ModelState.AddModelError("Email","Email Already exist");
                return View("Index");
            }
            else
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("userId", newUser.UserId);

                return RedirectToAction("Success");

            }
        }
        return View ("Index");
    }
    [HttpPost("users/login")]
    public IActionResult Login (LoginUser loginUser)
    {
        User? userFromDb = _context.Users.FirstOrDefault(u=>u.Email==loginUser.LogEmail);
        if (userFromDb == null)
        {
            ModelState.AddModelError("LogEmail","Wrong Credential");
            return View ("Index");
        }
        else
        {
            var hasher = new PasswordHasher<LoginUser>();
            var result= hasher.VerifyHashedPassword(loginUser, userFromDb.Password, loginUser.LogPassword);
            if(result==0)
            {
                ModelState.AddModelError("LogEmail","Wrong Credential");
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetInt32("userId", userFromDb.UserId);
                return RedirectToAction("Success");
            }
        }
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    public IActionResult Success()
    {
        if(HttpContext.Session.GetInt32("userId")== null)
        {
            return RedirectToAction ("Index");
        }
        int userId=(int)HttpContext.Session.GetInt32("userId");
        User? user = _context.Users.FirstOrDefault(u=>u.UserId == userId);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
