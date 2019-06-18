using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class DBContext
    {

        public static List<Cpe> consultaCpeAnulaciones()
        {
            List<Cpe> lista = new List<Cpe>();
            Cpe cpe = new Cpe();
                cpe.RUC = "20510675411";
                cpe.Comprobante = "00002";
                cpe.Serie = "F001";
                cpe.Correlativo = "2";
                cpe.FechaEmision = "13-06-2019";
                cpe.FechaCarga = "14-06-2019";
                cpe.Estado = "DOK";
                cpe.CodigoEmpresa = "DGF";
                cpe.Mensaje = "Sin observaciones";
            lista.Add(cpe);

            cpe = new Cpe();
                cpe.RUC = "20010675411";
                cpe.Comprobante = "00003";
                cpe.Serie = "F001";
                cpe.Correlativo = "3";
                cpe.FechaEmision = "13-06-2019";
                cpe.FechaCarga = "14-06-2019";
                cpe.Estado = "DOK";
                cpe.CodigoEmpresa = "DGF";
                cpe.Mensaje = "Sin observaciones";
            lista.Add(cpe);
            



            return lista;


        }

    }
}