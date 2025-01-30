using Microsoft.AspNetCore.Mvc;

namespace CodePluse.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
