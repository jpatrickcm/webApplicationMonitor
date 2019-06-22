
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MenuEnviosController : Controller
    {
        // GET: MenuEnvios
        public ActionResult Index()
        {
            listadoEmpresa();
            return View();
        }


        [HttpPost]
        public ActionResult Index(MenuEnvios menuEnvios)
        {
            listadoEmpresa();
            if (menuEnvios.fechaInicio != null && menuEnvios.fechaFinal != null && menuEnvios.empresa != null)
            {
                menuEnvios.listaCpe = EnviosService.reporteEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa);
                menuEnvios.listaCpeBoletas = EnviosService.consultaBoletasEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa);
                menuEnvios.listaCpeRetePerce = EnviosService.consultaRetePerceEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa);
            }
            return View("Index", menuEnvios);
        }


        private void listadoEmpresa()
        {
            ViewBag.listadoEmpresa = EnviosService.ListadoEmpresas();
        }



    }
}