using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Cpe
    {
        public string RUC { get; set; }
        public string Comprobante { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public string FechaEmision { get; set; }
        public string FechaCarga { get; set; }
        public string Estado { get; set; }
        public string CodigoEmpresa { get; set; }
        public string Mensaje { get; set; }

    }
}