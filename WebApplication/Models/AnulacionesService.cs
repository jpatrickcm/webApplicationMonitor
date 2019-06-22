using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class AnulacionesService
    {

        public static void reprocesarPorCpe(string fechaInicio, string fechaFinal, string empresa, Cpe comprobante)
        {
            DBContext.ReprocesarPorCpe(fechaInicio, fechaFinal, empresa, comprobante);
        }

        public static List<Cpe> reporteAnulaciones(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> listado = DBContext.ConsultaCpeAnulaciones(fechaInicio, fechaFinal, empresa);
            return listado;
        }

        public static List<Cpe> consultaBoletasAnulaciones(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> listado = DBContext.consultaCpeBoletasAnulaciones(fechaInicio, fechaFinal, empresa);
            return listado;
        }
        public static List<Cpe> consultaRetePerceAnulaciones(string fechaInicio, string fechaFinal, string empresa)
        {
            List<Cpe> listado = DBContext.consultaCpeRetePerceAnulaciones(fechaInicio, fechaFinal, empresa);
            return listado;
        }

        public static SelectList ListadoEmpresas()
        {
            List<SelectListItem> listaSelectListItem = new List<SelectListItem>();
            List<Empresa> listaEmpresa = DBContext.consultaEmpresas();
            if (listaEmpresa.Count>0)
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