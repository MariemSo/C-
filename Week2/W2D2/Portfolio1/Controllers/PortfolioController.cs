using Microsoft.AspNetCore.Mvc;
//must take the same name than the project(folder)
namespace FirstWebApp.controllers;
//must take the same name than the controller file
public class HelloController: Controller
{
    //Routes
    [HttpGet] //type of the request
    [Route("")]//associated route (/)
    public string Index()
    {
        return "Hello from The Index";
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