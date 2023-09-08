using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class TagsController : Controller
{
    // GET
    [HttpGet]
    public IActionResult Tags()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult SubmitTags()
    {
        var name = Request.Form["name"];
        var displayName = Request.Form["displayName"];
        
        Console.WriteLine();
        return View("Tags");
    }
}