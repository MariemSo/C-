using Microsoft.AspNetCore.Mvc;
//must take the same name than the project(folder)
namespace FirstWebApp.controllers;
//must take the same name than the controller file
public class HelloController: Controller
{
    //Routes
    [HttpGet] //type of the request
    [Route("")]//associated route (/)
    public ViewResult Index()
    {   
        return View("Index");
    }
}