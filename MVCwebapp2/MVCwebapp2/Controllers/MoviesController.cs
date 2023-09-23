using Microsoft.AspNetCore.Mvc;

namespace MVCwebapp2.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}
