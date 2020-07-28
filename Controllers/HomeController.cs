using Microsoft.AspNetCore.Mvc; 

namespace AnimalShelter.Controller
{
public class HomeController : Controller
  {
    [HttpGet("/")]

    public ActionResult Index ()
    {
      return View();
    }
  }
}