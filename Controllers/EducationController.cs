using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
