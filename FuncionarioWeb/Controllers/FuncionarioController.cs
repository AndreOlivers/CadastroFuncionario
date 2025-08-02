using Microsoft.AspNetCore.Mvc;

namespace FuncionarioWeb.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public FuncionarioController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
