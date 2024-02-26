using Microsoft.AspNetCore.Mvc;

namespace Edilizia.Controllers
{
    public class DipendentiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}