using Microsoft.AspNetCore.Mvc;
//must take the same name than the project(folder)
namespace FirstWebApp.controllers;
//must take the same name than the controller file
public class PortfolioController: Controller
{
    //Routes
    [HttpGet] //type of the request
    [Route("")]//associated route (/)
    public ViewResult Index()
    {   
        return View("Index");
    }

    [HttpGet("projects")] 
    public string Projects()
    {
        return "These are my Projects";
    }

    [HttpGet("contact")] 
    public string contact()
    {
        return "This is my Contact!";
    }

}