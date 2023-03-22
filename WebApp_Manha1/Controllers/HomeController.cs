using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_Manha1.Models;

namespace WebApp_Manha1.Controllers
{
    public class HomeController : Controller
    {
        //Atrivuto da class home contoller
        private readonly ILogger<HomeController> _logger;

        //Construtor da class
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action Result devolve uma tela (HTML)
        public IActionResult Index()
        {
            return View();
        }

        //Mais uma tela no sistema
        public IActionResult BemVindo()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LoginSistema()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}