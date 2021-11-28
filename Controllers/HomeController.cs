using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP_Padron_Blaser_Garber.Models;

namespace TP_Padron_Blaser_Garber.Controllers
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
        public IActionResult Establecimientos()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ConsultaPadron(int dni)
        {
            ViewBag.YaVoto=false;
            ViewBag.MiPersona=BD.ConsultaPadron(dni);
            
            if(ViewBag.MiPersona!=null)
            {
                ViewBag.MiEstablecimiento=BD.ConsultaEstablecimiento(ViewBag.MiPersona.IdEstablecimiento);
                ViewBag.YaVoto=ViewBag.MiPersona.Voto;
                return View("Votar");
            }else
            {
                ViewBag.DniNoEncontrado="Error! No se encontro su DNI";
                return View("Index");
            }
        }

        [HttpPost]
        public IActionResult Votar(int dni, int numeroTramite)
        {
            ViewBag.MiPersona=BD.ConsultaPadron(dni);
            ViewBag.MiEstablecimiento=BD.ConsultaEstablecimiento(ViewBag.MiPersona.IdEstablecimiento);
            if(ViewBag.MiPersona.NumeroTramite==numeroTramite)
            {
                ViewBag.PudoVotar=BD.Votar(dni, numeroTramite);
                return View("Index");
            }else
            {
                ViewBag.ErrorrAlVotar="Numero de DNI o numero de tramite incorrecto. Vuelva a intentar";
                return View("Votar");
            }
        }

        public IActionResult VXE(int IdEstablecimiento){
            ViewBag.Votante=BD.DevolverPersonasXEstablecimiento(IdEstablecimiento);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

