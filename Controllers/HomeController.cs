<<<<<<< HEAD
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
=======
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
>>>>>>> 44c4e9e4678e3b0f2bdba26c40f00d61b16dd595
}