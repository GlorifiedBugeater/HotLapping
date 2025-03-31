using Microsoft.AspNetCore.Mvc;

namespace HotLapping.Controllers
{
    public class CircuitoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
