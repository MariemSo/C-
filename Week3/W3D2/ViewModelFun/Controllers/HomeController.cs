using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    public List<User> GenerateUser()
    {
        return new List<User> ()
        {
            new User(){ FirstName="Moose", LastName="Phillips"},
            new User(){ FirstName="Ricky", LastName="Thames"},
            new User(){ FirstName="Sally", LastName="McSally"},
            new User(){ FirstName="Barb", LastName="Reardan"},
        };
    }

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string text="Here is some Text";
        return View("Index",text);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
        int[] numbers={10,20,30,40};
        return View(numbers);
    }


    [HttpGet("users")]
        public IActionResult Users()
        {
                // List<string> users = new List<string>
                // {
                //     "Moose Philips",
                //     "Riley",
                //     "James",
                //     "Sara"
                // };
                var users= GenerateUser();
            return View(users);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
                var rand = new Random();
                var users = GenerateUser();

                var user = users[rand.Next(users.Count)];
            
            return View(user);
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
