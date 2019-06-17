using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Ingrese Usuario")]
        [Display(Name = "Usuario")]
        public string username { get; set; }

        [Required(ErrorMessage = "Ingrese Password")]
        [Display(Name = "Password")]
        public string password { get; set; }

        public string mensaje { get; set; }
    }
}