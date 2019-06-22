using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class MenuEnvios
    {
        [Required(ErrorMessage = "Ingrese fecha de inicio")]
        [Display(Name = "Fecha Inicio")]
        public string fechaInicio { get; set; }

        [Required(ErrorMessage = "Ingrese fecha de inicio")]
        [Display(Name = "Fecha Inicio")]
        public string fechaFinal { get; set; }

        [Required(ErrorMessage = "Seleccione Empresa")]
        [Display(Name = "Empresa")]
        public string empresa { get; set; }

        public SelectList empresaList { get; set; }

        public List<Cpe> listaCpe { get; set; }
        public List<Cpe> listaCpeBoletas { get; set; }
        public List<Cpe> listaCpeRetePerce { get; set; }

        public string listaCpeEnviosPorReprocesar { get; set; }
        public string listaCpeBoletasEnviosPorReprocesar { get; set; }
        public string listaCpeRetePerceEnviosPorReprocesar { get; set; }
    }
}