using csharp_aspnetcore_cleaningcompany_site.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_aspnetcore_cleaningcompany_site.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext database;

        public HomeController(ApplicationContext context)
        {
            database = context;
        }

        public IActionResult Index() => View();

        public IActionResult About() => View();

        public IActionResult Services() => View();

        public IActionResult Contact() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CustomerRequest customersRequest)
        {
            database.CustomersRequests.Add(customersRequest);
            await database.SaveChangesAsync();
            return RedirectToAction("Contact");
        }
    }
}