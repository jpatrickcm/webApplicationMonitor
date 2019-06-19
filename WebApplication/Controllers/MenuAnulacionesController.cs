using System;
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
            return View();
        }

        [HttpPost]
        public ActionResult Index(MenuAnulaciones menuAnulaciones)
        {
            if ( menuAnulaciones.fechaInicio != null && menuAnulaciones.fechaFinal != null && menuAnulaciones.empresa != null)
            {
                menuAnulaciones.listaCpe = AnulacionesService.reporteAnulaciones(menuAnulaciones.empresa);
                menuAnulaciones.listaCpeBoletas = AnulacionesService.consultaBoletasAnulaciones();
                menuAnulaciones.listaCpeRetePerce = AnulacionesService.consultaRetePerceAnulaciones();
            }
            return View("Index", menuAnulaciones);
        }
    }
}