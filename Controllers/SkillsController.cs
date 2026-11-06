using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            var MySkills = new List<Skills>
            {
                new Skills { SkillName = "SQL", Description = "Back End", Rating = "4",Experience="5"},
                new Skills { SkillName= "Oracle", Description = "Back End", Rating = "3",Experience="6"}
            };
            return View(MySkills);

        }
    }
}
