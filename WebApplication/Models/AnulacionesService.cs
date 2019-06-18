using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class AnulacionesService
    {

        public static List<Cpe> reporteAnulaciones()
        {
            List<Cpe> listado = DBContext.consultaCpeAnulaciones();
            return listado;
        }

        public static List<Cpe> consultaBoletasAnulaciones()
        {
            List<Cpe> listado = DBContext.consultaCpeBoletasAnulaciones();
            return listado;
        }
        public static List<Cpe> consultaRetePerceAnulaciones()
        {
            List<Cpe> listado = DBContext.consultaCpeRetePerceAnulaciones();
            return listado;
        }


    }
}