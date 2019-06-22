using Newtonsoft.Json;
using System.Collections.Generic;
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

                if (Request.Form["buscar"] == null)
                {
                    var lista = JsonConvert.DeserializeObject<List<Cpe>>(menuEnvios.listaCpeEnviosPorReprocesar);
                    foreach (var comprobante in lista)
                    {
                        EnviosService.reprocesarPorCpeEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa, comprobante);
                    }
                    if (!string.Empty.Equals(menuEnvios.listaCpeBoletasEnviosPorReprocesar))
                    {
                        foreach (var comprobante in JsonConvert.DeserializeObject<List<Cpe>>(menuEnvios.listaCpeBoletasEnviosPorReprocesar))
                        {
                            EnviosService.reprocesarPorCpeBoletasEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa, comprobante);
                        }
                    }
                    if (!string.Empty.Equals(menuEnvios.listaCpeRetePerceEnviosPorReprocesar))
                    {
                        foreach (var comprobante in JsonConvert.DeserializeObject<List<Cpe>>(menuEnvios.listaCpeRetePerceEnviosPorReprocesar))
                        {
                            EnviosService.reprocesarPorCpeRetePerceEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa, comprobante);
                        }
                    }
                }
                else
                {
                menuEnvios.listaCpe = EnviosService.reporteEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa);
                menuEnvios.listaCpeBoletas = EnviosService.consultaBoletasEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa);
                menuEnvios.listaCpeRetePerce = EnviosService.consultaRetePerceEnvios(menuEnvios.fechaInicio, menuEnvios.fechaFinal, menuEnvios.empresa);
                }
            }
            return View("Index", menuEnvios);
        }


        private void listadoEmpresa()
        {
            ViewBag.listadoEmpresa = EnviosService.ListadoEmpresas();
        }



    }
}