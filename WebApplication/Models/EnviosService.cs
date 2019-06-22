using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class EnviosService
    {


        public static List<Cpe> reporteEnvios(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> listado = DBContext.ConsultaCpeEnvios(fechaInicio, fechaFinal, empresa);
            return listado;
        }

        public static List<Cpe> consultaBoletasEnvios(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> listado = DBContext.consultaCpeBoletasEnvios(fechaInicio, fechaFinal, empresa);
            return listado;
        }
        public static List<Cpe> consultaRetePerceEnvios(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> listado = DBContext.consultaCpeRetePerceEnvios(fechaInicio, fechaFinal, empresa);
            return listado;
        }



        public static SelectList ListadoEmpresas()
        {
            List<SelectListItem> listaSelectListItem = new List<SelectListItem>();
            List<Empresa> listaEmpresa = DBContext.consultaEmpresas();
            if (listaEmpresa.Count > 0)
            {
                foreach (Empresa emp in listaEmpresa)
                {
                    listaSelectListItem.Add(new SelectListItem() { Text = emp.nombre, Value = emp.codiEmex });
                }
            }
            else
            {
                listaSelectListItem.Add(new SelectListItem() { Text = "DIGIFLOW", Value = "esuiteDIGIFLOW" });
            }
            SelectList selectList = new SelectList(listaSelectListItem, "Value", "Text");
            return selectList;
        }


    }
}