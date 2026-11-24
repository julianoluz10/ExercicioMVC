using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExerciciosMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExerciciosMVC.Controllers
{

    public class EventosController : Controller
    {
        private static List<Eventos> _Eventos = new()
        {
            new Eventos{Id = 1, Nome = "ConectaPro", Descricao = "Evento para prestadore de serviços em nuvem", Local = "São Caetano do Sul",DataEvento = new DateTime(2026,10,12), QuantidadeVagas = 200, ValorIngresso= 300},
            new Eventos{Id = 2, Nome = "ConectaPremiun", Descricao = "Evento para prestadore de serviços em nuvem", Local = "São Caetano do Sul", QuantidadeVagas = 300, ValorIngresso= 200}
        };


        public IActionResult Index()
        {
            return View(_Eventos);
        }

        //Get /Criar - Listar todos os eventos
        public IActionResult Criar()
        {
            return View();
        }

        //Post /Enviar

        public IActionResult Criar(Eventos eventos)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            eventos.Id = _Eventos.Any()? _Eventos.Max(e => e.Id) +1 :1;
            _Eventos.Add(eventos);

            return RedirectToAction("Index");
            
        }



        
    }
}