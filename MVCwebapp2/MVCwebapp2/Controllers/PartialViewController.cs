using Microsoft.AspNetCore.Mvc;

namespace MVCwebapp2.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good Friends";
            return View();
        }
    }
}
