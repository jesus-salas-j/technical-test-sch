using Microsoft.AspNetCore.Mvc;

namespace technical_test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
