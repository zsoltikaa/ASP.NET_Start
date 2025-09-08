using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers;

public class HelloWorldController : Controller
{
    //GET: HelloWorld/Index
    public IActionResult Index()
    {
        return View();
    }

    // GET: HelloWorld/Welcome
    public IActionResult Welcome(string name, int number = 1)
    {

        ViewData["Message"] = $"Hello {name}!";
        ViewData["Number"] = number;

        return View();

        //return HtmlEncoder.Default.Encode($"Hello {name}, age is: {age}");
    }

    /* Custom URL routing example:
     * https://localhost:7256/HelloWorld/Welcome/?name=Zsoltika&age=19
     *                                           query string (modal binding)
     */
        
}
