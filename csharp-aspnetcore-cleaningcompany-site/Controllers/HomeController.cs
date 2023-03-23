using Microsoft.AspNetCore.Mvc;

namespace csharp_aspnetcore_cleaningcompany_site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Services() => View();

        public IActionResult Contact() => View();
    }
}