using Cinema.Models.Contratos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class PeliculaController : Controller
    {

        private IPelicula _peli;

        public PeliculaController(IPelicula peli)
        {
                _peli=peli;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PeliculaDetalle(string Titulo)
        {
            var resultado = _peli.ObtenerPelicula(Titulo);
            try
            {
                if (resultado.existe)
                {
                    return View(resultado.pelicula);
                }
                else
                {
                    ViewBag.error = "No se encontro la pelicula, intente con otra";
                    return RedirectToAction("Index", "Home");
                }
               
            }
            catch (Exception ex)
            {
                ViewBag.error = "Ocurrio un error : " + ex.Message;
                return RedirectToAction("Index","Home");
            }

           
        }




    }
}
