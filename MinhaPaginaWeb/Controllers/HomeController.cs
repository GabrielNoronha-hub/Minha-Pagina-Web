using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhaPaginaWeb.Models;

namespace MinhaPaginaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projetos()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ObterDados()
        {
            // Exemplo manual enquanto você não configura o banco de dados (_context)
            var listaExemplo = new List<string> { "Item 1", "Item 2", "Item do C#" };
            return Json(listaExemplo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
