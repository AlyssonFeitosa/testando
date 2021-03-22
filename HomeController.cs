using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using deliveryfast.Models;

namespace deliveryfast.Controllers
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

        public IActionResult Galeria()
        {
            return View();
        }

        public IActionResult Listagem()
        {
            List<Cadastro> cadastros = BaseDados.Listar();
            return View(cadastros);
        }

        public IActionResult Formulario()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Formulario(Cadastro cadastro)
        {
            BaseDados.Incluir(cadastro);
            return View("Pedido");
        }

         public IActionResult Contato()
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
