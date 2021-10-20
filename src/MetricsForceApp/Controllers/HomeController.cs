using MetricsForceApp.Data;
using MetricsForceApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ValorTotal();
            MetaGerente();
            PorcentagemAtingida();
            return View();
        }


        public IActionResult Sobre()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult ValorTotal()
        {
            var consulta = _context.RegistroVendas.Select(c => c.ValorVenda).Sum();
            ViewBag.ValorTotal = consulta;

            return View();
        }

        public ActionResult MetaGerente()
        {
            var consulta = _context.MetasGerentes.Select(c => c.MetaMes).Sum();
            ViewBag.MetaMes = consulta;

            return View();
        }

        public ActionResult PorcentagemAtingida()
        {
            var consultaGerente = _context.MetasGerentes.Select(c => c.MetaMes).Sum();
            var consultaVendas = _context.RegistroVendas.Select(r => r.ValorVenda).Sum();
            var resultado = (consultaGerente / consultaVendas).ToString("N2");
            ViewBag.Porcentagem = resultado;

            return View();
        }
    }
}
