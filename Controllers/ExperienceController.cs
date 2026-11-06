using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
