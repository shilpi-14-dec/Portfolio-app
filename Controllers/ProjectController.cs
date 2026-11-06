using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            var projects = new List<Project>
            {
                new Project { Title = "Portfolio Website", Description = "Personal portfolio site", Technologies = "ASP.NET Core MVC"},
                new Project { Title = "E-commerce App", Description = "Shopping platform", Technologies = "C#, SQL Server"}
            };
            return View(projects);
         
        }
        public IActionResult CreateProject(Project projectobj)
        {
            
            return View(projectobj);

        }
    }
}
