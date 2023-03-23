using Microsoft.AspNetCore.Mvc;

namespace csharp_aspnetcore_cleaningcompany_site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
