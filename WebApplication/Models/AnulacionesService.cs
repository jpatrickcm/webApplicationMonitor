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


    }
}