using Microsoft.AspNetCore.Mvc;

namespace HotLapping.Controllers
{
    public class CarroController : Controller
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