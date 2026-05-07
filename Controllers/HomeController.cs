using Microsoft.AspNetCore.Mvc;

namespace DotnetMvcDockerApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Dockerized ASP.NET Core MVC App Running 🚀";
            ViewBag.Time = DateTime.Now.ToString();

            return View();
        }
    }
}