using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;
using WebApplication6.repo;

namespace WebApplication6.Controllers
{
    public class PaisController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Listar()
        {
            var paises=PaisRepo.Listar();
            ViewBag.paises=paises;
            ViewBag.otrodato=1234;
            // ViewData["paises"]=paises;

            return View();
        }

        [HttpGet]
        public IActionResult Formulario()
        {
            var pais=new Pais();
            ViewBag.clientes=ClienteRepo.Listar();

            return View(pais);
        }

        [HttpPost]
        public IActionResult Formulario(Pais pais)
        {
            //todo: guardar en la base de datos
            // Entity framework.
            // using(var contexto=new BaseContexto()) {
            //    contexto.Pais.Add(pais);
            //    contexto.SaveChanges();
            // }
            return Redirect("/Pais/Listar"); // return View(pais);
        }
    }
}
