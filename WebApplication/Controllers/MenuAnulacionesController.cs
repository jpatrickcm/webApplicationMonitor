using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MenuAnulacionesController : Controller
    {
        // GET: MenuAnulaciones
        public ActionResult Index()
        {
            listadoEmpresa();
            return View();
        }

        [HttpPost]
        public ActionResult Index(MenuAnulaciones menuAnulaciones)
        {
            listadoEmpresa();
            if ( menuAnulaciones.fechaInicio != null && menuAnulaciones.fechaFinal != null && menuAnulaciones.empresa != null)
            {
                if (Request.Form["reprocesar"]!= null)
                {
                    var lista = JsonConvert.DeserializeObject<List<Cpe>>(menuAnulaciones.listaCpePorReprocesar);
                    AnulacionesService.reprocesarPorCpe(menuAnulaciones.fechaInicio, menuAnulaciones.fechaFinal, menuAnulaciones.empresa, lista);
                }
                else
                {                
                menuAnulaciones.listaCpe = AnulacionesService.reporteAnulaciones(menuAnulaciones.fechaInicio, menuAnulaciones.fechaFinal, menuAnulaciones.empresa);
                menuAnulaciones.listaCpeBoletas = AnulacionesService.consultaBoletasAnulaciones(menuAnulaciones.fechaInicio, menuAnulaciones.fechaFinal, menuAnulaciones.empresa);
                menuAnulaciones.listaCpeRetePerce = AnulacionesService.consultaRetePerceAnulaciones(menuAnulaciones.fechaInicio, menuAnulaciones.fechaFinal, menuAnulaciones.empresa);
                }
            }
            return View("Index", menuAnulaciones);
        }

        private void listadoEmpresa() {
            ViewBag.listadoEmpresa = AnulacionesService.ListadoEmpresas();
        }

    }
}